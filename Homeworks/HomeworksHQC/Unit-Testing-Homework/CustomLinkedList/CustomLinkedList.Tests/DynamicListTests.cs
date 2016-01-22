namespace CustomLinkedList.Tests
{
    using System;
    using System.CodeDom;
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DynamicListTests
    {
        private static DynamicList<int> list;

        private static DynamicList<int> emptyList;

        [TestInitialize]
        public void TestInitialize()
        {
            list = new DynamicList<int>();
            list.Add(5);
            list.Add(10);
            list.Add(2500);
        }
            
        [TestMethod]
        public void Add_EmptyList_ShouldIncrementCount()
        {
            Assert.AreEqual(3, list.Count, "The List count is not incremented");
        }

        [TestMethod]
        public void Add_Element_ShouldBeEqualToAddedElements()
        {
            Assert.AreEqual(10, list[1],"The element doesn't added properly");
            Assert.AreEqual(2500, list[2], "The element doesn't added properly");

        }

        [TestMethod]
        public void RemoveAt_ShouldRemoveCorrectly()
        {
            list.RemoveAt(1);
            Assert.AreEqual(2, list.Count, "The counter dos not decrement when remove an item");
            Assert.AreEqual(2500, list[1], "Removing the element does not resize the list");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RemoveAt_NegativeIndex_ShouldThrowException()
        {
            list.RemoveAt(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RemoveAt_EmptyList_ShouldThrowException()
        {
            emptyList = new DynamicList<int>();
            emptyList.RemoveAt(1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RemoveAt_BiggerIndexThanCount_ShouldThrowException()
        {
            list.RemoveAt(5);
        }

        [TestMethod]
        public void Remove_InvalidElement_ShouldReturnMinusOne()
        {
            int index = list.Remove(268);
            Assert.AreEqual(-1, index, "Removing element does not return the expected value");
        }

        [TestMethod]
        public void Remove_ValidElement_ShouldRemoveItCorrectly()
        {
            int index = list.Remove(5);
            Assert.AreEqual(0, index, "The element is not been removed successfully");
            Assert.AreEqual(2, list.Count, "The count does not decrement when removing element");
        }

        [TestMethod]
        public void IndexOf_SearchNonExistingElement_ShouldReturnMinusOne()
        {
            int index = list.IndexOf(685);
            Assert.AreEqual(-1, index, "Searching the index of  non-existing element does not return the expected value ");
        }

        [TestMethod]
        public void IndexOf_SearchExistingElement_ShouldReturnIndex()
        {
            int index = list.IndexOf(2500);
            Assert.AreEqual(2, index, "Searching the index of existing element does not return the expected value ");
        }

        [TestMethod]
        public void Contains_SearchNonExistingElement_shouldReturnMinusOne()
        {
            bool isContaining = list.Contains(658);
            Assert.IsFalse(isContaining, "The Method does not return proper value of non-existing element");
        }

        [TestMethod]
        public void Contains_SearchExistingElement_shouldReturnTrue()
        {
            bool isContaining = list.Contains(2500);
            Assert.IsTrue(isContaining, "The Method does not return proper value of existing element");
        }
    }
}
