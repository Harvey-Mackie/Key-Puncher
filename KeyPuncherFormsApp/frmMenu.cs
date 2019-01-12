using System;
using System.Data.SqlClient;
using Game;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace KeyPuncherFormsApp
{
    public partial class frmMenu : MaterialForm
    {
        public User MenuUser;
        Choice Choice = new Choice();
        public void CheckAdmin()
        {
            if(MenuUser.Admin == true)
            {
                btnAdmin.Visible = true;
            }
            else
            {
                btnAdmin.Visible = false;
                if (MenuUser.Offline == true)
                {
                    lblOffline.Visible = true;
                }
            }
        }
        public frmMenu()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        private void btnMenuPlay_Click(object sender, EventArgs e)
        {
            //Open Game
            if(MenuUser.Offline == true)
            {
                this.Hide();
                frmGame frmGame = new frmGame();
                frmGame.GameUser = MenuUser;
                frmGame.Show();
            }
            else
            {
                try
                {
                    Choice.Connection();
                    this.Hide();
                    frmGame frmGame = new frmGame();
                    frmGame.GameUser = MenuUser;
                    frmGame.Show();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Can't connect to the Database");
                }
            }
        }

        private void btnMenuScores_Click(object sender, EventArgs e)
        {
            if (MenuUser.Offline == true)
            {
                this.Hide();
                frmScores frmScores = new frmScores();
                frmScores.ScoresUser = MenuUser;
                frmScores.Show();
            }
            else
            {
                try
                {
                    Choice.Connection();
                    //Open Scores
                    this.Hide();
                    frmScores frmScores = new frmScores();
                    frmScores.ScoresUser = MenuUser;
                    frmScores.Show();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Can't connect to the Database");
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MenuUser.Offline == false)
            {
                //Close Game
                frmLogin Logout = new frmLogin();
                Logout.Show();
                this.Hide();
            }
            else
            {
                Inital Form = new Inital();
                Form.Show();
                this.Hide();
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            CheckAdmin();
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                Choice.Connection();
                this.Hide();
                frmAdmin Admin = new frmAdmin();
                Admin.AdminUser = MenuUser;
                Admin.Show();
            }
            catch(SqlException)
            {
                MessageBox.Show("Can't connect to the Database");
            }
            
        }
    }
}
