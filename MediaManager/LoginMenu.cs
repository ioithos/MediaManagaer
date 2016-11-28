using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaManager
{
    public partial class LoginMenu : Form
    {
        public LoginMenu()
        {
            InitializeComponent();

            //set colors on login menu
            this.BackColor = Color.SteelBlue;
            GlobalControl.setButtonColor(this, Color.Goldenrod);
            GlobalControl.setTextBoxMaxLength(this, 40);

            //set as enter button
            this.AcceptButton = login1Btn;
        }

        public void startMainMenu()
        {
            //start main menu
            MainMenu MainMenu = new MainMenu(this);
            this.Hide();
            MainMenu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = login1Txt.Text.Trim(' ');
            string password = login2Txt.Text.Trim(' ');

            if (!Check.areValidInputs(username, password))
            {
                Prompt.enterValidInput();
                return;
            }
            try
            {
                if (!UsersTable.hasUser(username, password))
                {
                    MessageBox.Show("Incorrect username and/or password.", "Failed Authentication", MessageBoxButtons.OK);
                    return;
                }
                
                startMainMenu();
            }
            catch
            {
                UsersTable.disposeAdapter();
                Prompt.dbError();
            }
        }

        private void LoginMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
