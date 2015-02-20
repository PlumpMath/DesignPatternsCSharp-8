using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    public abstract class Manuscript
    {
        protected IFormatter formatter;

        public Manuscript(IFormatter formatter)
        {
            this.formatter = formatter;
        }
         
        public abstract void Print();
    }
}
