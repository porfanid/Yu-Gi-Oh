using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yu_Gi_Oh
{
    class ChooseCard
    {
        CardType testCard = new CardType();
        public Monster summonMonster(string name, string mode)
        {
            

            // here I need to set the monster's name
            if (!testCard.IsMonster(name))
            {
                return null;
            }
            if (testCard.isInDB(name))
            {
                return new Monster(name, mode);
            }
            else
            {
                throw new CardNotFoundException("This Card has not been found in the System. Are you sure it is correct?");
            }
        }





        public Magic placeMagic(string name)
        {
            // here I need to set the monster's name
            if (!testCard.IsMagic(name))
            {
                return null;
            }
            if (testCard.isInDB(name))
            {
                return new Magic(name);
            }
            else
            {
                throw new CardNotFoundException("This Card has not been found in the System. Are you sure it is correct?");
            }
        }




        public Trap setTrap(string name)
        {
            if (testCard.IsTrap(name))
            {
                return new Trap(name);
            }
            else
            {
                throw new CardNotFoundException("This Card has not been found in the System. Are you sure it is correct?");
            }
        }
    }
}
