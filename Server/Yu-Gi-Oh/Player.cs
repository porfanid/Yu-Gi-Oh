using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yu_Gi_Oh
{
    class Player
    {
        string name;



        public Player(string name)
        {
            this.name = name;
        }




        LifePoints playerLifePoints = new LifePoints();

        String CardName;

        public Battlefield playerBattlefield = new Battlefield();


        public bool hasEmptyDeck()
        {
            return false;
        }

        public int getPoints()
        {
            return playerLifePoints.getPoints();
        }

        public bool hasLost()
        {
            if(playerLifePoints.getPoints()<0)
            {
                return true;
            }
            if (hasEmptyDeck())
            {
                return true;
            }
            return false;
        }


        public void getLifePointsDownToZero()
        {
            if (getPoints()<0)
            {
                playerLifePoints.removePoints(getPoints());
            }
        }




        public void round()
        {

        }




        public void placeCard()
        {
            bool WantToContinue;

            WantToContinue = true;

            while (WantToContinue)
            {
                
            }
        }










        public void attack(Monster AttackCard,Monster DeffendCard,Player enemy)
        {
            System.Threading.Thread checkLifepoints = new System.Threading.Thread(getLifePointsDownToZero);
            checkLifepoints.Start();
            Console.WriteLine("AttackCard: " + AttackCard.ToString());
            Console.WriteLine("DeffendCard: " + DeffendCard.ToString());

            string mode1 = AttackCard.getmode();

            int attack1 = AttackCard.getAttackPoints();
            Console.WriteLine("attack1: " + attack1);
            int deffend1 = AttackCard.getDefendPoints();
            Console.WriteLine("deffend1: " + deffend1);
            string mode2 = DeffendCard.getmode();

        //    Console.WriteLine("mode2="+mode2);
            int attack2 = DeffendCard.getAttackPoints();
            Console.WriteLine("attack2: " + attack2);
            int deffend2 = DeffendCard.getDefendPoints();
            Console.WriteLine("deffend2: " + deffend2);
            Winner WhoWon = new Winner();

            string whowon= WhoWon.GetWinner(mode1,attack1,deffend1,mode2,attack2,deffend2);
            //    Console.WriteLine("whowon= " + whowon);
            Console.WriteLine("whowon: "+whowon);
            if (whowon=="draw")
            {
                enemy.playerLifePoints.removePoints(50);
            }

            if (whowon == "Card1")
            {
                
                int player1 = attack1;
                int player2;
                if (mode2=="Deffend")
                {
                    player2 = deffend2;
                }
                else
                {
                    player2 = attack2;
                }
                int damage = player1 - player2;
                enemy.playerLifePoints.removePoints(damage);
            }


            if (whowon == "Card2")
            {
                int player1 = attack1;
                int player2;
                if (mode2 == "Deffend")
                {
                    player2 = deffend2;
                }
                else
                {
                    player2 = attack2;
                }
                int damage = player2 - player1;
                playerLifePoints.removePoints(damage);
            }
        }
    }
}