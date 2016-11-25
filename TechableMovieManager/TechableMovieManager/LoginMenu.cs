using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaManager
{
    public partial class LoginMenu : Form
    {
        /*
        public void LoadMovies()
        {
            StreamReader fileReader = new StreamReader("C:/Users/ithom2/Documents/Data/dvdParsed.csv");
            string line;
            int lineNum = 0;
            int added = 0;
            while ((line = fileReader.ReadLine()) != null)
            {
                lineNum++;
                string name = "";
                string studio = "";
                string yearStr = "";
                int year = 0;
                string a = "cat";

                string[] elements = line.Split(';');

                name = removeEnds(elements[0]);
                studio = removeEnds(elements[1]);
                yearStr = removeEnds(elements[2]);
                if (Check.isInt32(yearStr))
                    year = Int32.Parse(yearStr);
                else
                    year = 0;
                if ((lineNum % 2500) == 0 && year != 0)
                {
                    if (name.Length > 39 || studio.Length > 39)
                    {
                        int nextPartition2 = 0;
                    }else
                    {
                        added++;
                        MoviesTable.add(name, year, studio);
                    }
                }
                int nextPartition = 0;
            }

            fileReader.Close();
        }
        
        public void LoadCopies()
        {
            for(int i = 5; i <= 58; i++)
            {
                CopiesTable.add(i - 4, i);
                CopiesTable.add(54 + i - 4, i);
            }
        }
        */
        
        public LoginMenu()
        {
            InitializeComponent();
            this.BackColor = Color.SteelBlue;
            GlobalControl.setButtonColor(this, Color.Goldenrod);
            GlobalControl.setTextBoxMaxLength(this, 40);
            this.AcceptButton = loginBtn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = usernameTxt.Text.Trim(' ');
            string password = passwordTxt.Text.Trim(' ');

            if (!Check.areValidInputs(userName, password))
            {
                Prompt.enterValidInput();
                return;
            }
            try
            {
                if (!EmployeesTable.validCredentials(userName, password))
                {
                    MessageBox.Show("Incorrect username and/or password.", "Failed Authentication", MessageBoxButtons.OK);
                    return;
                }

                Object[] i = EmployeesTable.getEmployee(userName, password);
                string firstName = (string)i[0];
                string lastName = (string)i[1];
                bool isAdmin = (bool)i[2];
                string dbPassword = (string)i[4];

                if (!password.Equals(dbPassword.Trim(' ')))
                {
                    MessageBox.Show("Incorrect username and/or password.", "Failed Authentication", MessageBoxButtons.OK);
                    return;
                }

                User user = new User(isAdmin, userName, firstName, lastName);

                startMainMenu(user);
            }catch
            {
                EmployeesTable.adapter.Dispose();
                Prompt.dbError();
            }
        }
        public void startMainMenu(User user)
        {
            //start main menu
            MainMenu MainMenu = new MainMenu(user, this);
            this.Hide();
            MainMenu.Show();
            
        }
        private void LoginMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoginMenu_Load(object sender, EventArgs e)
        {
            setupLoginForm();
        }

        private void LoginMenu_Resize(object sender, EventArgs e)
        {
            setupLoginForm();
        }

        public void setupLoginForm(){
            double endOfText;
            double endOfLabels;

            Reposition.setControlLocation(loginTitleLbl, .3, .2);
            Reposition.setControlLocation(loginPic, .7, .1);

            endOfLabels = Reposition.setLabels(0.4, usernameLbl, passwordLbl);
            endOfText = Reposition.setTextBoxes(0.4, usernameTxt, passwordTxt);

            Reposition.setControlLocation(loginBtn, .4, endOfText);
        }
       
    }
    
}
