using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sandwichDirector = new SandwichDirector(new HamburgerSandwichBuilder());
            sandwichDirector.MakeSandwich();
            var sandwich = sandwichDirector.GetSandwich();

            Console.WriteLine(sandwich.Display());
        }
    }
}
