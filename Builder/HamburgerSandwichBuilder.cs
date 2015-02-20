using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public class HamburgerSandwichBuilder : SandwichBuilder
    {
        public override void PrepareBread() 
        {
            this.sandwitch.BreadType = BreadType.White;
            this.sandwitch.IsToasted = true;
        }

        public override void ApplyMeatAndCheese()
        {
            this.sandwitch.CheeseType = CheeseType.Cheddar;
            this.sandwitch.MeatType = MeatType.Chicken;
        }

        public override void ApplyVegetables()
        {
            this.sandwitch.Vegetables = new List<string> { "Tomato", "Onion" }; 
        }

        public override void AddCondiments()
        {
            this.sandwitch.HasMayo = true;
            this.sandwitch.HasMustard = true;
        }
    }
}
