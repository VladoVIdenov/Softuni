using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace Orders
{
    public class MainProgram
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            var mapper = new DataMapper();
            var allCategories = mapper.GetAllCategories();
            var allProducts = mapper.GetAllProducts();
            var allOrders = mapper.GetAllOrders();

            // Names of the 5 most expensive products
            IEnumerable<string> firstFiveMostExpensiveProducts = allProducts
                .OrderByDescending(p => p.UnitPrice)
                .Take(5)
                .Select(p => p.Name);
            Console.WriteLine(string.Join(Environment.NewLine, firstFiveMostExpensiveProducts));

            Console.WriteLine(new string('-', 10));

            // Number of products in each category
            var productsCountInCategory = allProducts
                .GroupBy(p => p.CategoryId)
                .Select(grp => new { Category = allCategories.First(c => c.Id == grp.Key).Name, Count = grp.Count() })
                .ToList();
            foreach (var product in productsCountInCategory)
            {
                Console.WriteLine("{0}: {1}", product.Category, product.Count);
            }

            Console.WriteLine(new string('-', 10));

            // The 5 top products (by order quantity)
            var productsOrderedByQuantity = allOrders
                .GroupBy(o => o.ProductId)
                .Select(grp => new { Product = allProducts.First(p => p.Id == grp.Key).Name, Quantities = grp.Sum(grpgrp => grpgrp.Quant) })
                .OrderByDescending(q => q.Quantities)
                .Take(5);
            foreach (var product in productsOrderedByQuantity)
            {
                Console.WriteLine("{0}: {1}", product.Product, product.Quantities);
            }

            Console.WriteLine(new string('-', 10));

            // The most profitable category
            var mostProfitableCategory = allOrders
                .GroupBy(o => o.ProductId)
                .Select(g => new { catId = allProducts.First(p => p.Id == g.Key).CategoryId, price = allProducts.First(p => p.Id == g.Key).UnitPrice, quantity = g.Sum(p => p.Quant) })
                .GroupBy(gg => gg.catId)
                .Select(grp => new { categoryName = allCategories.First(c => c.Id == grp.Key).Name, totalQuantity = grp.Sum(g => g.quantity * g.price) })
                .OrderByDescending(g => g.totalQuantity)
                .First();
            Console.WriteLine("{0}: {1}", mostProfitableCategory.categoryName, mostProfitableCategory.totalQuantity);
        }
    }
}
