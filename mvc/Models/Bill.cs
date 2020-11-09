using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc.Models
{
    public class Bill
    {
        public string Name { get; set; }
        public float Value { get; set; }
        public DateTime BillDate { get; set; }
        public bool PaymentStatus { get; set; }
        private static Random rnd = new Random();

        public Bill()
        {
            Name = string.Empty;
            Value = 0f;
            BillDate = DateTime.Today;
            PaymentStatus = false;
        }
        public static List<Bill> Examples()
        {
            return Enumerable.Range(0, 100).Select(x => new Bill { Name = $"{RandomName()}'s Bill", Value = RandomValue(), BillDate = RandomDate(), PaymentStatus = RandomBool() }).ToList();
        }


        private static string RandomName()
        {
            List<string> NameList = new List<string> { "Henrietta", "Nicolasa", "Tamala", "Francoise", "Burt", "Darline", "Nieves", "Elden", "Arcelia", "Mitch", "Rosanne", "Norah", "Eustolia", "Lilla" };

            return NameList.OrderBy(x => rnd.Next(0, NameList.Count)).First();
        }

        private static bool RandomBool()
        {
            return rnd.Next() % 2 == 0 ? true : false;
        }

        private static DateTime RandomDate()
        {
            int range = 365;
            DateTime randomDate = DateTime.Today.AddDays(rnd.Next(range));
            return randomDate;
        }
        private static float RandomValue()
        {
            return rnd.Next(0, 1000);
        }

    }
}