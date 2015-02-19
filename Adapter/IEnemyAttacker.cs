using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public interface IEnemyAttacker
    {
        void FireWeapon();
        void DriveForward();
        void AssignAttacker(string driverName);
    }
}
