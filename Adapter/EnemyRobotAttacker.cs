using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class EnemyRobotAdapter : IEnemyAttacker
    {
        private EnemyRobot theRobot;

        public EnemyRobotAdapter(EnemyRobot newRobot)
        {
            theRobot = newRobot;
        }

        public void FireWeapon()
        {
            theRobot.SmashWithHands();
        }

        public void DriveForward()
        {
            theRobot.WalkForward();
        }

        public void AssignAttacker(String driverName)
        {
            theRobot.ReactToHuman(driverName);
        }
    }
}
