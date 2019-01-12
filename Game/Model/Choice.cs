using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Game
{
    public class Choice
    {
        private int _ChoiceOneRep;
        public int ChoiceOneReputation
        {
            get { return _ChoiceOneRep; }
            set
            {
                _ChoiceOneRep = value;
            }
        }
        private int _ChoiceOneVirus;
        public int ChoiceOneViruses
        {
            get { return _ChoiceOneVirus; }
            set
            {
                _ChoiceOneVirus = value;
            }
        }
        private int _ChoiceTwoRep;
        public int ChoiceTwoReputation
        {
            get { return _ChoiceTwoRep; }
            set
            {
                _ChoiceTwoRep = value;
            }
        }
        private int _ChoiceTwoVirus;
        public int ChoiceTwoViruses
        {
            get { return _ChoiceTwoVirus; }
            set
            {
                _ChoiceTwoVirus = value;
            }
        }
        private int _ReputationStart;
        public int ReputationStart
        {
            get { return _ReputationStart; }
            set
            {
                _ReputationStart = value;
            }
        }
        private int _VirusStart;
        public int VirusStart
        {
            get { return _VirusStart; }
            set
            {
                _VirusStart = value;
            }
        }
        private int _TurnCounter;
        public int TurnCounter { get { return _TurnCounter; } set { _TurnCounter = value; } }

        //Lists
        public List<int> ChoiceId = new List<int>();
        public List<int> EventDifficulty = new List<int>();
        public List<int> ChoiceOneRep = new List<int>();
        public List<int> ChoiceOneVirus = new List<int>();
        public List<int> ChoiceTwoRep = new List<int>();
        public List<int> ChoiceTwoVirus = new List<int>();

        //Connection Variables
        private string _ConnString;
        public string connString
        {
            get { return _ConnString; }
            set
            {
                _ConnString = value;
            }
        }
        private SqlConnection _Con;
        public SqlConnection con
        {
            get { return _Con; }
            set
            {
                _Con = value;
            }
        }
        //Connect to Database
        public void Connection()
        {
            // Create SqlConnection
            connString = "Data Source = tolmount.abertay.ac.uk; Initial Catalog = sql1702389; User ID = sql1702389; Password = I%I+Q%s?";
            con = new SqlConnection(connString);
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }
        public void ConnectionClose()
        {
            con.Close(); //close connection variable
        }
        //Methods
        //Choices Database Count
        public int ChoicesCount()
        {
            Connection();
            SqlCommand sql = new SqlCommand("SELECT COUNT(*) FROM gameChoices", con);
            Int32 count = Convert.ToInt32(sql.ExecuteScalar());
            if (count > 0)
            {
                return count;
            }
            else
            {
                return 0;
            }
        }
        /*
         * Offline Choices, Remove once a database has been connected
         */
         public void OfflineInsertChoices()
        {
            int[] Id = new int[7] { 0,1,2,3,4,5,6};
            int[] Diff = new int[7] { 0, 1, 1, 2, 2, 3, 3 };
            int[] OneR = new int[7] { 0, 5, -5, 10, -10, 15, -15 };
            int[] OneV = new int[7] { 0, -5, 5, -10, 10, -15, 15 };
            int[] TwoR = new int[7] { 0, -5, 5, -10, 10, -15, 15 };
            int[] TwoV = new int[7] { 0, 5, -5, 10, -10, 15, -15 };

            for (int i=0;i<7;i++)
            {
                ChoiceId.Add(Id[i]);
                EventDifficulty.Add(Diff[i]);
                ChoiceOneRep.Add(OneR[i]);
                ChoiceOneVirus.Add(OneV[i]);
                ChoiceTwoRep.Add(TwoR[i]);
                ChoiceTwoVirus.Add(TwoV[i]);
            }
        }
        //Insert Choices
        public void InsertChoices()
        {
            Connection();
            //SQL command
            SqlCommand sql = new SqlCommand("SELECT * FROM gameChoices", con);
            //data reader
            SqlDataReader rdr = sql.ExecuteReader();
            while (rdr.Read())
            {
                ChoiceId.Add(Convert.ToInt32(rdr[0].ToString()));
                EventDifficulty.Add(Convert.ToInt32(rdr[1].ToString()));
                ChoiceOneRep.Add(Convert.ToInt32(rdr[2].ToString()));
                ChoiceOneVirus.Add(Convert.ToInt32(rdr[3].ToString()));
                ChoiceTwoRep.Add(Convert.ToInt32(rdr[4].ToString()));
                ChoiceTwoVirus.Add(Convert.ToInt32(rdr[5].ToString()));
            }
            rdr.Close();
        }
        //TurnCount
        public void TurnCounterIncrement()
        {
            ++TurnCounter;
        }
        public void ResetTurnCount()
        {
            TurnCounter = 0;
        }
        //Attributes Set
        public void ResetReputation()
        {
            ReputationStart = 50;
        }
        public void ResetVirus()
        {
            VirusStart = 50;
            var Events = new Events();
        }
        //Attributes Check
        public int CheckVariables(int optionR, int optionV, int TurnCount, string Username, bool offline)
        {
            if (optionR >= 100 || optionV <= 0)
            {
                //return 2; //Win
                var Score = new Score();
                if (offline == false)
                {
                    if (Score.InsertScores(TurnCount, Username) == true)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
                else
                {
                    if (Score.InsertOfflineScores(TurnCount, Username))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
            else if (optionR <= 0 || optionV >= 100)
            {
                return 1; //Lose
            }
            else
            {
                return 0; //Not Finished
            }
        }
    }
}
