using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            ManageThread.ObjThread.ItemList = new List<int>();
            for (int i = 0; i < 10; i++)
            {                    
                ManageThread.ObjThread.AddItems(0, 1);
                ManageThread.ObjThread.AddNewItems(0, 1);
                ManageThread.ObjThread.CountItems();
            }
            
        }
    }
}
