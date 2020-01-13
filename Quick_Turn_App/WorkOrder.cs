using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quick_Turn_App
{
    public class WorkOrder
    {
        public string Order_Num { get; set; }
        public string Quantity { get; set; }
        public string Due_Date { get; set; }
        public string Part_Num { get; set; }

        public WorkOrder(string t2, string t3, string t4, string t1)
        {
            string OrderNum = t2;
            string Quantity = t3;
            string dueDate = t4;
            string partNum = t1;
        }
    }
}
