using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Threading;
using ProjectMultiThreading.Interface;

namespace ProjectMultiThreading
{
    public sealed class ManageThread:IAddItems,IAddNewItems,ICountItems
    {
        //This flag will indicate whether the Thread is started or not
        
        private static readonly ManageThread objThread = new ManageThread();
        //configs for thread sleep in seconds
        private int m_Thread1SleepTime = 2;
        private int m_Thread2SleepTime = 2;
        private int m_Thread3SleepTime = 5;
        public List<int> ItemList { get; set; }
        private ManageThread()
        {           
        }
        public static ManageThread ObjThread
        {
            get
            {
                return objThread;
            }
        }
        public void AddItems(int item1,int item2)
        {
            ItemList.Add(item1);
            ItemList.Add(item2);
            Thread.Sleep(new TimeSpan(0, 0, m_Thread1SleepTime));
        }          


        public void AddNewItems(int item1,int item2)
        {
            ItemList.Add(item1);
            ItemList.Add(item2);
            Thread.Sleep(new TimeSpan(0, 0, m_Thread2SleepTime));
        }
        public void CountItems()
        {
            Console.WriteLine("Total Items={0}", ItemList.Count);
            Thread.Sleep(new TimeSpan(0, 0, m_Thread3SleepTime));
        }
    }
}
