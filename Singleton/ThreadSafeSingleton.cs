using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class ThreadSafeSingleton
    {
        private static readonly object _lock = new object();
        private static ThreadSafeSingleton instance;

        public static ThreadSafeSingleton Instance
        {
            get
            {
                lock (_lock)
                {
                    if (instance == null)
                    {
                        instance = new ThreadSafeSingleton();
                    }

                    return instance;
                }
            }
        }
    }
}
