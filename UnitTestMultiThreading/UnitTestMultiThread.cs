using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMultiThreading
{
    [TestClass]
    public class UnitTestMultiThread
    {
        [TestMethod]
        public void TestAddItems()
        {
            ProjectMultiThreading.ManageThread.ObjThread.ItemList = new System.Collections.Generic.List<int>();
            ProjectMultiThreading.ManageThread.ObjThread.AddItems(0,1);
        }
        [TestMethod]
        public void TestAddNewItems()
        {
            ProjectMultiThreading.ManageThread.ObjThread.ItemList = new System.Collections.Generic.List<int>();
            ProjectMultiThreading.ManageThread.ObjThread.AddNewItems(0, 1);
        }
        [TestMethod]
        public void TestCountItems()
        {
            ProjectMultiThreading.ManageThread.ObjThread.ItemList = new System.Collections.Generic.List<int>();
            ProjectMultiThreading.ManageThread.ObjThread.AddNewItems(0, 1);
            ProjectMultiThreading.ManageThread.ObjThread.CountItems();
        }
    }
}
