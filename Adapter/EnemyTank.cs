using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class EnemyTank : IEnemyAttacker
    {
        private Random generator = new Random();

        public void FireWeapon()
        {
            int attackDamage = generator.Next(10) + 1;

            Console.WriteLine("Enemy Tank Does {0}", attackDamage);
        }

        public void DriveForward()
        {
            int movement = generator.Next(5) + 1;

            Console.WriteLine("Enemy Tank moves {0} spaces", movement);
        }

        public void AssignAttacker(string driverName)
        {
            Console.WriteLine("{0} is driving the tank", driverName);
        }
    }
}
