using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class EnemyRobot
    {
        private Random generator = new Random();

        public void SmashWithHands()
        {
		    int attackDamage = generator.Next(10) + 1;
            Console.WriteLine("Enemy Robot Causes {0} Damage", attackDamage);
	    }

        public void WalkForward()
        {
            int movement = generator.Next(5) + 1;
            Console.WriteLine("Enemy Robot Walks Forward {0} Spaces", movement);
	    }

        public void ReactToHuman(String driverName)
        {
                Console.WriteLine("Enemy Robot Tramps on {0}", driverName);
	    }
    }
}
