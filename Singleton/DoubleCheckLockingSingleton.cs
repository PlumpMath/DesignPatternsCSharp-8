using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class DoubleCheckLockingSingleton
    {
        private static readonly object _lock = new object();
        private static DoubleCheckLockingSingleton instance;

        public static DoubleCheckLockingSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (_lock)
                    {
                        if (instance == null)
                        {
                            instance = new DoubleCheckLockingSingleton();
                        }
                    }
                }

                return instance;
            }
        }
    }
}
