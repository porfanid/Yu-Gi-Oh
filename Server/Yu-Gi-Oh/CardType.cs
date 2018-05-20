using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yu_Gi_Oh
{
    class CardType
    {
        public bool isInDB(string name)
        {
            ReadFromDatabase test = new ReadFromDatabase();
            string[] Name = test.getNames();
            int[] AttackPoints = test.getAttackPoints();
            int[] DeffendPoints = test.getDeffendPoints();
            int i = 0;
            foreach (string s in Name)
            {
                //Console.WriteLine(s + " : " + name);
                if (s == name)
                {

                    return true;
                }
                i++;
            }
            return false;
        }




        public int[] ATKDEF(string name)
        {
            int ATK = 0;
            int DEF = 0;
            int[] power = new int[2];

            if (isInDB(name))
            {
                ReadFromDatabase test = new ReadFromDatabase();
                string[] Name = test.getNames();
                int[] AttackPoints = test.getAttackPoints();
                int[] DeffendPoints = test.getDeffendPoints();
                int i = 0;
                foreach (string s in Name)
                {
                    if (s == name)
                    {
                        break;
                    }
                    i++;
                }
                ATK = AttackPoints[i];
                DEF = DeffendPoints[i];
            }



            power[0] = ATK;
            power[1] = DEF;
            return power;
        }




        public bool IsMonster(string name)
        {
            //    Console.WriteLine("isInDB: " + isInDB(name));
            if (isInDB(name))
            {
                ReadFromDatabase test = new ReadFromDatabase();
                string[] Name = test.getNames();
                int[] MonsterType = test.CardType();
                int i = 0;
                foreach (string s in Name)
                {
                    if (s == name)
                    {
                        break;
                    }
                    i++;
                }
                if (MonsterType[i] < 5)
                {
                    return true;
                }
                return false;
            }
            return false;
        }





        public bool IsMagic(string name)
        {

            if (isInDB(name))
            {
                ReadFromDatabase test = new ReadFromDatabase();
                string[] Name = test.getNames();
                int[] MonsterType = test.CardType();
                int i = 0;
                foreach (string s in Name)
                {
                    if (s == name)
                    {
                        break;
                    }
                    i++;
                }
                if (MonsterType[i] > 4 && MonsterType[i] < 11)
                {
                    return true;
                }
                return false;
            }
            return false;
        }





        public bool IsTrap(string name)
        {
            if (isInDB(name))
            {
                ReadFromDatabase test = new ReadFromDatabase();
                string[] Name = test.getNames();
                int[] MonsterType = test.CardType();
                int i = 0;
                foreach (string s in Name)
                {
                    if (s == name)
                    {
                        break;
                    }
                    i++;
                }
                if (MonsterType[i] > 11)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}
