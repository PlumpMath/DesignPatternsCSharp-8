using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /// <summary>
    /// Type initializers in C# are only called lazyly when first requested.
    /// </summary>
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
            // Explicit static constructor to tell C# compiler not to mark as beforefieldinit
            static Nested()
            { 
            }

            internal static readonly LazySingleton instance = new LazySingleton();
        }
    }
}
