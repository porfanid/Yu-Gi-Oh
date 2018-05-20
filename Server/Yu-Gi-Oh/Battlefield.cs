using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yu_Gi_Oh
{
    class Battlefield
    {

        int CardsAtPlay = 0;

        Card[] battlefield = new Card[10];

        public Battlefield()
        {

        }


        public bool isFull()
        {
            int AvailablePositions = 10-CardsAtPlay;

            if (AvailablePositions==0)
            {
                return true;
            }
            return false;
        }


        public int getCardsAtPlay()
        {
            return CardsAtPlay;
        }


        public Card GetCard(string name, int position)
        {
            CardType info = new CardType();
            ChooseCard choice = new ChooseCard();
            string mode = null;
            if (info.IsTrap(name))
            {
                return choice.setTrap(name);
            }
            if (info.IsMagic(name))
            {
                return choice.placeMagic(name);
            }
            throw new CardNotFoundException("This Card has not been found in the System. Are you sure it is correct?");
        }


        public Card GetCard(string name, string mode, int position)
        {
            CardType info = new CardType();
            ChooseCard choice = new ChooseCard();
            if (info.IsMonster(name))
            {
                return choice.summonMonster(name,mode);
            }
            throw new CardNotFoundException("This Card has not been found in the System. Are you sure it is correct?");
        }



        public void placeCard(Card card, int position)
        {
            if (isFull())
            {
                return;
            }
            battlefield[position]=card;
        }
    }
}