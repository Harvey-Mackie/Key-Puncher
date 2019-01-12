using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Game
{
    public class Score
    {
        private int _ScoreId;
        public int ScoreId
        {
            get { return _ScoreId; }
            set
            {
                _ScoreId = value;
            }
        }
        private string _ScoreUsername;
        public string ScoreUsername
        {
            get { return _ScoreUsername; }
            set
            {
                if (value.Length >= 5 || value.Length <= 10)
                {
                    _ScoreUsername = value;
                }
                else
                {
                    throw new Exception("The Username must be between 5 - 10 Characters");
                }
            }
        }
        private int _Turns;
        public int ScoreTurns
        {
            get { return _Turns; }
            set
            {
                if (_Turns >= 0)
                {
                    _Turns = value;
                }
                else
                {
                    throw new Exception("Invalid Turns Entry - Must have completed 1 turn");
                }
            }

        }

        //Lists storing the High Score Values
        public List<int> ScoreID = new List<int>();
        public List<string> Username = new List<string>();
        public List<int> Turns = new List<int>();

        Choice Choices = new Choice();
        //Methods
        public void ShowScores()
        {
            //Get connection variables
            Choices.Connection();
            //SQL command
            SqlCommand sql = new SqlCommand("SELECT * FROM gameScores Order By scoreValue ASC;", Choices.con);
            //Data reader
            SqlDataReader rdr = sql.ExecuteReader();
            while (rdr.Read())
            {
                ScoreID.Add(Convert.ToInt32(rdr[0].ToString())); //Fetch ScoreID's from Database and Insert turns to 'ScoreID' List
                Turns.Add(Convert.ToInt32(rdr[1].ToString())); //Fetch Turns from Database and Insert turns to 'Turns' List
                Username.Add(rdr[2].ToString()); //Fetch Username from Database and Insert turns to 'Username' List
            }
            rdr.Close();
        }

        public bool InsertScores(int ScoreValue,string Username)
        {
            ShowScores(); //Populate Lists with Highscores

            if(ScoreValue < Turns[9])
            {
                SqlCommand sql = new SqlCommand("UPDATE gameScores SET scoreValue = @scoreValue, username = @Username WHERE scoreid = @ScoreId;", Choices.con);
                sql.Parameters.AddWithValue("@scoreValue", ScoreValue);
                sql.Parameters.AddWithValue("@Username", Username);
                sql.Parameters.AddWithValue("@ScoreId", ScoreID[9]);
                //Insert
                sql.ExecuteNonQuery();

                return true; 
            }
            else
            {
                return false;
            }

        }

        /*
         * Offline - Delete Once database tables are complete
         */
        int[] Id = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] turns = new int[10] { 10, 11, 12, 13, 16, 18, 19, 20, 21, 22 };
        string[] username = new string[10] { "Hmack001", "JBasn9", "ChampToBe", "AlmostAlmost", "LFoth", "HarveyMackie", "AndrewTravers19", "OpenSourceCoder", "PinballWarrior", "LastBut___Least" };
        public bool InsertOfflineScores(int ScoreValue, string username)
        {
            ShowOfflineScores();
            if(ScoreValue < Turns[9])
            {
                Turns[9] = ScoreValue;
                Username[9] = username;
                return true;
            }
            return false;
            
        }
            public bool ShowOfflineScores()
        {
            for (int i = 0; i < 10; i++)
            {
                ScoreID.Add(Id[i]);
                Turns.Add(turns[i]);
                Username.Add(username[i]);
            }
            return true;
        }
    }
}
