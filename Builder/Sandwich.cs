using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public class Sandwich
    {
        public BreadType BreadType { get; set; }
        public CheeseType CheeseType { get; set; }
        public MeatType MeatType { get; set; }
        public bool HasMayo { get; set; }
        public bool IsToasted { get; set; }
        public bool HasMustard { get; set; }
        public IList<string> Vegetables { get; set; }
        public string Condiments { get; set; }

        public string Display()
        {
            return String.Format("{0} {1} {2}", 
                this.BreadType.ToString(), 
                this.CheeseType.ToString(), 
                this.MeatType.ToString());
        }
    }
}
