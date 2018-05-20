using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yu_Gi_Oh
{
    class Winner
    {
        public string GetWinner(string ModePlayer1,int AttackPlayer1, int DeffendPlayer1, string ModePlayer2, int AttackPlayer2, int DeffendPlayer2)
        {
            Console.WriteLine("ModePlayer2="+ ModePlayer2);

            if (ModePlayer1=="defend")
            {
                Console.WriteLine("Cannot Attack");
            }

            if (ModePlayer2 == "defend")
             {
                Console.WriteLine("AttackPlayer1="+ AttackPlayer1);
                Console.WriteLine("AttackPlayer2=" + AttackPlayer2);
                if (AttackPlayer1==DeffendPlayer2)
                 {
                    Console.WriteLine("GetWinner=Draw");
                    return "draw";
                 }



                 if (AttackPlayer1 > DeffendPlayer2)
                 {
                    Console.WriteLine("GetWinner=Card1");
                    return "Card1";
                 }


                 if (AttackPlayer1 < DeffendPlayer2)
                 {
                    Console.WriteLine("GetWinner=Card2");
                    return "Card2";
                 }
             }

             if (ModePlayer2 == "attack")
             {
                 if (AttackPlayer1 == AttackPlayer2)
                 {
                    Console.WriteLine("GetWinner=Draw");
                    return "draw";
                 }



                 if (AttackPlayer1 > AttackPlayer2)
                 {
                    Console.WriteLine("GetWinner=Card1");
                    return "Card1";
                 }
                 
                 if (AttackPlayer1 < AttackPlayer2)
                 {
                    Console.WriteLine("GetWinner=Card2");
                    return "Card2";
                 }

               
             }
            Console.WriteLine("GetWinner=null");
            return null;
        }
    }
}