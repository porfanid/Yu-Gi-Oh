using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yu_Gi_Oh
{
    class Program
    {
        const int PORT_NO = 5000;
        const string SERVER_IP = "127.0.0.1";



        static void Main(string[] args)
        {

            Activation hasActivation = new Activation();
            hasActivation.checkIfUserWantsPro();
            hasActivation.exitIfNotPro();

            ReadFromDatabase test = new ReadFromDatabase();
            string[] Name = test.getNames();
            int[] AttackPoints = test.getAttackPoints();
            int[] DeffendPoints = test.getDeffendPoints();

            Connect serverConnect = new Connect();
            Battle newGame = new Battle();
            newGame.startBattle();

            for (int i = 0; i < 5427; i++)
            {
                if (Name[i] == "Blue-Eyes White Dragon")
                {
                    Console.WriteLine(Name[i] + " : " + AttackPoints[i] + " : " + DeffendPoints[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
