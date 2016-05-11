using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UltraShopBd.Entites;
using UltraShopBd.DataAccess;
namespace WindowsFormsApplication1
{
    public partial class LoginForm : Form
    {

      public  Login login = new Login();
        LoginDA loginDA = new LoginDA();
        Main mainFrom = new Main();
    
        public LoginForm()
        {
            InitializeComponent();
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.MaxLength = 20;
            if(mainFrom.Visible== true)
            {
                mainFrom.Visible = false;

            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            userNameTextBox.MaxLength = 35;
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
           
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            messageLabel.Text = "";

             login.email= userNameTextBox.Text;

             login.password = passwordTextBox.Text;
             

            string message = "";
            int flag = 0;

            if(login.email.Length ==0)
            {
                flag =1;
                message += "Empty User Name \n";
            }

            if(login.password.Length ==0)
            {
                flag =1;
                message +="Empty Password\n";
            }

            if(flag == 1)
            {
               messageLabel.Text = message;
            }
            else
            {

                 login = loginDA.GetUserId(login);


                if(login.userId != -1 )
                {
                  
                    this.Hide();
                    mainFrom.GetUserData(login);
                   

                    mainFrom.Show();

                    userNameTextBox.Text="";

                     passwordTextBox.Text="";
                    
                }
                else
                {
                    messageLabel.Text = "password or email you entered is incorrect";

                }
            }


        }

        

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
