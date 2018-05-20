using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yu_Gi_Oh
{
    class Card
    {
        string name;

        string description;

        public Card (string name)
        {
            this.name = name;
            //    this.special_ability = special_ability;
            ReadFromDatabase info = new ReadFromDatabase();
            description=info.getCardDescription(name);
            
        }


        public string getDescription()
        {
            return description;
        }


        public string ToString()
        {
            return name;
        }

        
    }
}
