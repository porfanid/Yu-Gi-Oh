using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;




namespace Yu_Gi_Oh
{
    class ReadFromDatabase
    {
        public string[] getNames()
        {
            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=database.ycd;Version=3;");
            m_dbConnection.Open();

            string sql = "select * from cards";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            string[] Name =new string [5427];
            int i = 0;
            while (reader.Read())
            {
                Name[i]=(string) reader["Name"];
                i++;
            }
            m_dbConnection.Close();
            return Name;
        }








        public string[] getDescription()
        {
            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=database.ycd;Version=3;");
            m_dbConnection.Open();

            string sql = "select * from cards";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            string[] Description = new string[5427];
            int i = 0;
            while (reader.Read())
            {
                Description[i] = (string)reader["Description"];
                i++;
            }
            m_dbConnection.Close();
            return Description;
        }





        public int[] CardType()
        {
            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=database.ycd;Version=3;");
            m_dbConnection.Open();

            string sql = "select * from cards";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            int[] MonsterType = new int[5427];
            int i = 0;
            while (reader.Read())
            {
                MonsterType[i] = Convert.ToInt32(reader["Type_ID"]);
                i++;
            }
            m_dbConnection.Close();
            return MonsterType;
        }




        public int[] getAttackPoints()
        {
            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=database.ycd;Version=3;");
            m_dbConnection.Open();

            string sql = "select * from cards";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            int[] AttackPoints = new int[5427];
            int i = 0;
            while (reader.Read())
            {
                AttackPoints[i] = Convert.ToInt32(reader["ATK"]);
                i++;
            }
            m_dbConnection.Close();
            return AttackPoints;
        }




        public int[] getDeffendPoints()
        {
            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=database.ycd;Version=3;");
            m_dbConnection.Open();

            string sql = "select * from cards";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            int[] DefendPoints = new int[5427];
            int i = 0;
            while (reader.Read())
            {
                DefendPoints[i] = Convert.ToInt32(reader["Def"]);
                i++;
            }
            m_dbConnection.Close();
            return DefendPoints;
        }





        public bool isInDB(string name)
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
                    return true;
                }
                i++;
            }
            return false;
        }






        public bool IsMonster(string name)
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
                if (MonsterType[i] < 5)
                {
                    return true;
                }
                return false;
            }
            return false;
        }







        public int getMonsterAttackPoint(string name)
        {
            string[] Name = getNames();
            int[] attackpoints = getAttackPoints();
            if(IsMonster(name))
            {
                int i = 0;
                foreach (string s in Name)
                {
                    if (s == name)
                    {
                        break;
                    }
                    i++;
                }
                return attackpoints[i];
            }
            return 0;
        }














        public string getCardDescription(string name)
        {
            string[] Name = getNames();
            string[] description= getDescription();
            //Console.WriteLine("Length= " +description.Length);
        //    Console.WriteLine("Is the card in DB? "+isInDB(name));
            if (isInDB(name))
            {
                int i = 0;
                foreach (string s in Name)
                {
                    if (s == name)
                    {
                        if (description[i] != null && description[i] != "")
                        {
                            
                            break;
                        }
                    }
                    i++;
                }
                //Console.WriteLine("i= " + i);
                return description[i];
            }
            //Console.WriteLine("null");
            return null;
        }








        public int getMonsterDeffendPoint(string name)
        {

            string[] Name = getNames();
            int[] deffendpoints = getDeffendPoints();
            if (IsMonster(name))
            {
                int i = 0;
                foreach (string s in Name)
                {
                    if (s == name)
                    {
                        break;
                    }
                    i++;
                }
                return deffendpoints[i];
            }
            return 0;
        }
    }
}