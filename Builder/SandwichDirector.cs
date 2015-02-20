using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public class SandwichDirector
    {
        private SandwichBuilder builder;

        public SandwichDirector(SandwichBuilder builder)
        {
            this.builder = builder;
        }

        public void MakeSandwich()
        {
            this.builder.CreateNewSandwich();
        }

        public Sandwich GetSandwich()
        {
            return this.builder.GetSandwich();
        }
    }
}
