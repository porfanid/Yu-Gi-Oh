using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Yu_Gi_Oh
{
    class Monster:Card
    {
 //       string Name;
        int AttackPoints;
        int DefendPoints;
        string mode;
        ReadFromDatabase info = new ReadFromDatabase();

        public Monster(string Name,string mode) : base(Name)
        {
            this.mode = mode;
            AttackPoints = info.getMonsterAttackPoint(Name);
            DefendPoints = info.getMonsterDeffendPoint(Name);
        }
















        public int getAttackPoints()
        {
            return AttackPoints;
        }

        public int getDefendPoints()
        {
            return DefendPoints;
        }

        public string getmode()
        {
            return mode;
        }
    }
}
