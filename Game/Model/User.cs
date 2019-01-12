using System;
using System.Data;
using System.Data.SqlClient;
namespace Game
{
    public class User
    {
        private string _Username;
        public string Username
        {
            get { return _Username; }
            set
            {
                if (value.Length >= 5 || value.Length <= 10)
                {
                    _Username = value;
                }
                else
                {
                    throw new Exception("The Username must be between 5 - 10 Characters");
                }
            }
        }
        private string _Password;
        public string Password
        {
            get { return _Password; }
            set
            {
                if (value.Length >= 5 || value.Length <= 15)
                {
                    _Password = value;
                }
                else
                {
                    throw new Exception("The Password must be between 5 - 15 Characters");
                }
            }
        }

        private bool _Admin;
        public bool Admin
        {
            get { return _Admin; }
            set
            {
                _Admin = value;
            }
        }

        private bool _Offline;
        public bool Offline
        {
            get { return _Offline; }
            set
            {
                _Offline = value;
            }
        }

        Choice Choices = new Choice();

        //Validate Login
        public bool CheckLogin(string Name, string Pass, bool Admin)
        {
            //SQL command
            Choices.Connection();
            SqlCommand sql = new SqlCommand("SELECT * FROM gameUsers WHERE username=@username COLLATE SQL_Latin1_General_CP1_CS_AS and password=@password COLLATE SQL_Latin1_General_CP1_CS_AS and Admin=@Admin", Choices.con);
            sql.Parameters.AddWithValue("@username", Name);
            sql.Parameters.AddWithValue("@password", Pass);
            sql.Parameters.AddWithValue("@Admin", Admin);

            SqlDataAdapter adapt = new SqlDataAdapter(sql);

            DataSet ds = new DataSet();
            adapt.Fill(ds);
            Choices.ConnectionClose();
            int count = ds.Tables[0].Rows.Count;
            //If count is equal to 1, than show frmMain form
            if (count == 1)
            {
                Username = Name;
                Password = Pass;
                Offline = false;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool OfflineLogin(string Name, string Pass)
        {
            Offline = true;
            Username = Name;
            Password = Pass;
            Admin = false;
            return true;
        }
    }
}
