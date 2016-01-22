using System;
using System.Reflection;

namespace GenericList
{
    class MainProgram
    {
        static void Main()
        {
            GenList<int> listOne = new GenList<int>();
            listOne.Add(5);
            listOne.Add(180);
            listOne.Add(-150);
            for (int i = 0; i < 20; i++)
            {
                listOne.Add(i);
            }

            Console.WriteLine(string.Join(", ", listOne));
            Console.WriteLine(listOne.Max());
            Console.WriteLine(listOne.Min());
            Console.WriteLine(listOne.IndexOf(-150));
            Console.WriteLine(listOne.IndexOf(-250));
            listOne.Remove(180);
            Console.WriteLine();
            Console.WriteLine(string.Join(", ", listOne));
            listOne.RemoveAt(5);
            Console.WriteLine();
            Console.WriteLine(string.Join(", ", listOne));
            listOne.Insert(10, 555555);
            Console.WriteLine();
            Console.WriteLine(string.Join(", ", listOne));
            //listOne.Clear();
            //Console.WriteLine();
            //Console.WriteLine(string.Join(", ", listOne)); uncomment to clear the list
            Console.WriteLine();
            Console.WriteLine(listOne.Contains(800));
            Console.WriteLine();

            Console.WriteLine("listOne[3] = {0}", listOne[3]);

            Console.WriteLine("To String:");
            Console.WriteLine(listOne.ToString());

            
            
        }
        
    }
    
}
