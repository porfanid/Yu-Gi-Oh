using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yu_Gi_Oh
{
    class LifePoints
    {
        private int lifepoints;

        public LifePoints()
        {
            lifepoints = 4000;
        }


        public void addPoints(int points)
        {
            lifepoints += points;
        }


        public void removePoints(int points)
        {
            lifepoints -= points;
        }

        public int getPoints()
        {
            return lifepoints;
        }
    }
}
