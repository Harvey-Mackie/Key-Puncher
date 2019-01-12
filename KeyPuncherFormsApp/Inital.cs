using MaterialSkin.Controls;
using MaterialSkin;
using Game;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyPuncherFormsApp
{
    public partial class Inital : MaterialForm
    {
        public Inital()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            txtInfo.ReadOnly = true;
        }
        User User = new User();

        private void btnOnline_Click(object sender, EventArgs e)
        {
            User.Offline = false;
            //Close Game
            frmLogin Login = new frmLogin();
            Login.Show();
            this.Hide();
        }

        private void btnOffline_Click(object sender, EventArgs e)
        {
            string Username = "Tester";
            string Password = "*****";
            User.OfflineLogin(Username, Password);
            Session();
        }
        public void Session()
        {
            //create session
            this.Hide();
            frmMenu Menu = new frmMenu();
            Menu.MenuUser = User;
            Menu.Show();
        }
        private void txtInfo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
