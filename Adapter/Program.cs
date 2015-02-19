using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EnemyTank rx7Tank = new EnemyTank();
		
		    EnemyRobot fredTheRobot = new EnemyRobot();
		
		    EnemyRobotAdapter robotAdapter = new EnemyRobotAdapter(fredTheRobot);
		
		    Console.WriteLine("The Robot");
		
		    fredTheRobot.ReactToHuman("Paul");
		    fredTheRobot.WalkForward();
		    fredTheRobot.SmashWithHands();
		
		    Console.WriteLine("The Enemy Tank");
		    rx7Tank.AssignAttacker("Frank");
		    rx7Tank.DriveForward();
		    rx7Tank.FireWeapon();

            Console.WriteLine("The Robot with Adapter");
		    robotAdapter.AssignAttacker("Mark");
		    robotAdapter.DriveForward();
		    robotAdapter.FireWeapon();
        }
    }
}
