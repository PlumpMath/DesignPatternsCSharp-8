using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    public class Faq : Manuscript
    {
        public string Title { get; set; }
        public Dictionary<string, string> Questions { get; set; }

        public Faq(IFormatter formatter)
            : base(formatter)
        {
            this.Questions = new Dictionary<string, string>();
        }

        public override void Print()
        {
            Console.WriteLine(this.formatter.Format("Title", this.Title));
            foreach (var question in this.Questions)
            {
                Console.WriteLine(this.formatter.Format(" Question:", question.Key));
                Console.WriteLine(this.formatter.Format(" Answer:", question.Value));
            }
            Console.WriteLine();
        }
    }
}
