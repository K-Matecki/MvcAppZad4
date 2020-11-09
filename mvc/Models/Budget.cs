using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc.Models
{
    public class Budget
    {
        public static List<Bill> BillList {get; set;}


        public static void Examplse()
        {
            BillList = Bill.Examples();
        }

    }
}