using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Custumer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category CategoryId { get; set; }
        public double SoupDiscount { get; set; }
        public double MealDiscount { get; set; }
        public double LastPay { get; set; }
        public DateTime LastPayDay { get; set; }
        public double Debt { get; set; }
    }
}
