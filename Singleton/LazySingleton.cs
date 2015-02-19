using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class LazySingleton
    {
        public LazySingleton()
        { 
        }

        public static LazySingleton Instance
        {
            get { return Nested.instance; }
        }

        private class Nested
        {
            static Nested()
            { 
            }

            internal static readonly LazySingleton instance = new LazySingleton;
        }
    }
}
