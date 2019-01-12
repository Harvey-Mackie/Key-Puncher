using System.Data.SqlClient;
using System.Windows.Forms;
using Game;
using MaterialSkin;
using MaterialSkin.Controls;

namespace KeyPuncherFormsApp
{
    public partial class frmLogin : MaterialForm
    {
        //Create Instance
        User User = new User();
        Events Event = new Events();
        
        public void Session()
        {
            //create session
            this.Hide();
            frmMenu Menu = new frmMenu();
            Menu.MenuUser = User;
            Menu.Show();
        }
        public void Validation()
        {
            User.Username = txtLoginUsername.Text;
            User.Password = txtLoginPassword.Text;
            User.Admin = false;
            //Admin Check
            try
            {
                bool Valid = User.CheckLogin(User.Username, Eramake.eCryptography.Encrypt(User.Password), User.Admin);
                if (Valid == true)
                {
                    MessageBox.Show("Login Successful!");
                    Session();
                }
                else
                {
                    User.Admin = true;
                    bool AdminLogin = User.CheckLogin(User.Username, Eramake.eCryptography.Encrypt(User.Password), User.Admin);
                    if (AdminLogin == true)
                    {
                        MessageBox.Show("Login Successful! " + User.Username + ", you are an Admin");
                        Session();
                    }
                    else
                    {
                        //display error
                        MessageBox.Show("Invalid Credentials");
                    }
                }
            }
            catch(SqlException)
            {
                MessageBox.Show("Can't connect to the database");
            }
            /*catch(System.IO.FileNotFoundException)
            {
                MessageBox.Show("SQL File not found");
            }*/
            
        }
        public frmLogin()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void btnSubmit_Click(object sender, System.EventArgs e)
        {
            Validation();
        }
    }
}
