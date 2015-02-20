using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public abstract class SandwichBuilder
    {
        protected Sandwich sandwitch;

        public void CreateNewSandwich()
        {
            this.sandwitch = new Sandwich();
        }

        public Sandwich GetSandwich()
        {
            return this.sandwitch;
        }

        public abstract void PrepareBread();
        public abstract void ApplyMeatAndCheese();
        public abstract void ApplyVegetables();
        public abstract void AddCondiments();
    }
}
