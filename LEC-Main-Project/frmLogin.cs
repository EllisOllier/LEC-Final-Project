using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEC_Main_Project
{

    public partial class frmLogin : Form
    {
        // Change with actual database credentials
        // For time being they are global vars
        static string storedUsername = "Ellis";
        static string storedPassword = "password";

        public frmLogin()
        {
            InitializeComponent();
        }

        // Failed login attempts stored globally as it will reset if in function.
        static int failedLoginAttempts = 0;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Stores the text box info and also runs a boolean comparison.
            string inputUsername = txtUsername.Text;
            string inputPassword = txtPassword.Text;
            bool isLoginValid = (inputUsername == storedUsername && inputPassword == storedPassword);

            if (isLoginValid)
            {
                // Close this form and open new form
                frmMain frmMain = new frmMain();
                this.Hide();
                frmMain.ShowDialog();
                this.Close();
            }
            else
            {
                // Exits application if user login is incorrect 3 times.
                failedLoginAttempts += 1;
                Console.WriteLine(failedLoginAttempts);
                if (failedLoginAttempts == 3)
                {
                    Application.Exit();
                }
                MessageBox.Show("Invalid login!");
            }
        }
    }
}
