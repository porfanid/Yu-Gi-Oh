using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yu_Gi_Oh
{
    class Battle
    {
        
        



        public void startBattle()
        {
            Player player1 = new Player("test1");
            Player player2 = new Player("test2");
            while(true)
            {
                if(player1.hasLost())
                {
                    break;
                }
                if (player2.hasLost())
                {
                    break;
                }
                //Console.WriteLine(player1.playerBattlefield.CardsAtPlay);
                Monster myCard1=(Monster) player1.playerBattlefield.GetCard("3-Hump Lacooda", "attack");
                Monster myCard2 = (Monster)player2.playerBattlefield.GetCard("Kuribon", "attack");
                Console.WriteLine("Description: "+myCard2.getDescription());
                if (player1.playerBattlefield.getCardsAtPlay() != 0)
                {
//                    Monster ChosenMonster = AttackMonster;
                    player1.attack(myCard1,myCard2,player2);
                    Console.WriteLine("Player1: "+player1.getPoints());
                    Console.WriteLine("Player2: " + player2.getPoints());
                }
                //Console.WriteLine(player2.playerBattlefield.CardsAtPlay);
                //player2.playerBattlefield.placeCard("Kuribon", "attack");
                if (player2.playerBattlefield.getCardsAtPlay() != 0)
                {
                    player2.attack(myCard2, myCard1, player1);
                    Console.WriteLine("Player1: " + player1.getPoints());
                    Console.WriteLine("Player2: " + player2.getPoints());
                }
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("END OF ROUND");
                Console.WriteLine("------------------------------------------------------");
            }
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}