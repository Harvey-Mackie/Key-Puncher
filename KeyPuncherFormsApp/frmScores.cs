using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using Game;
using System.Collections.Generic;
using MaterialSkin.Controls;
using MaterialSkin;

namespace KeyPuncherFormsApp
{
    public partial class frmScores : MaterialForm
    {
        public User ScoresUser;
        //Instance
        Score Scores = new Score();
        //Display Scores to Label
        public void DisplayScores()
        {
            int ScorePosition = 1; //Holds the users' postion on the leaderboard
            if (ScoresUser.Offline == false)
            {
                Scores.ShowScores(); //Get Score values
            }
            else
            {
                Scores.ShowOfflineScores();
            }
           

            lblScoreId.Text = "Position" + Environment.NewLine; //Heading describing row - Leaderboard postions are located below
            lblScoreUsername.Text = "Username" + Environment.NewLine; //Heading describing row - USernames are located below
            lblScoreValue.Text = "Score" + Environment.NewLine; //Heading describing row - Scores are located below
            for (int i=0;i<=9;++i)
            {
                lblScoreId.Text += ScorePosition + ". " + Environment.NewLine; //Print Score Position
                lblScoreUsername.Text += Scores.Username[i] + Environment.NewLine; //Print Username attached to Score Position
                lblScoreValue.Text += Scores.Turns[i] + Environment.NewLine; // Print Score Value attached to Score Position
                ++ScorePosition; //Increment Score Postion each iteration
            }
        }
        public frmScores()
        {
            InitializeComponent();
            //Design
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }
        private void btnScoresBack_Click(object sender, EventArgs e)
        {
            //Open Menu
            this.Hide();
            frmMenu frmMenu = new frmMenu();
            frmMenu.MenuUser = ScoresUser;
            frmMenu.Show();
        }
        private void frmScores_Load(object sender, EventArgs e)
        {
            try
            {
                DisplayScores();
            }
            catch(SqlException)
            {
                MessageBox.Show("Can't Connect to the database");
            }
        }
    }
}
