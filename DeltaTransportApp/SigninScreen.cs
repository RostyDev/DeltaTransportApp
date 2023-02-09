using DeltaTransportDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeltaTransportApp
{
    public partial class SigninScreen : UserControl
    {
        bool SignInSucces = false;

        InlogAPI SigninAPI = new InlogAPI();

        public SigninScreen()
        {
            InitializeComponent();
        }

        private void btn_Signin_Click(object sender, EventArgs e)
        {
            if (tb_Nickname.Text == "" || tb_Password.Text == "")
            {
                string message = "Please fill in all the fields.";
                MessageBox.Show(message);
            }
            else
            {
                try
                {
                    SigninAPI.ActiveAccount.Nickname = tb_Nickname.Text;
                    SigninAPI.Signin();

                    if (SigninAPI.ActiveAccount.PassWord != 0)
                    {
                        SignInSucces = true;
                    }
                }
                catch (Exception)
                {
                    string message = "There is something wrong with the connection, please check your internet connection.";
                    string caption = "Connection error";
                    MessageBox.Show(message, caption);
                    throw;
                }

                SigninAPI.Password = tb_Password.Text;
                SigninAPI.Hash();
            }

            if (SigninAPI.HashedPassword == SigninAPI.ActiveAccount.PassWord && SignInSucces)
            {
                nav.LoadActiveuserPage();
            }
            else if (!SignInSucces)
            {
                string message = "There was no account found with this nickname, pleas check the nickname you entered.";
                MessageBox.Show(message);

                tb_Nickname.Clear();
            }
            else
            {
                string message = "Wrong password!";
                MessageBox.Show(message);

                tb_Password.Clear();
            }
        }

        private void lb_AanmeldPage_Click(object sender, EventArgs e)
        {
            nav.LoadAanmeldScreen();
        }

        private void SigninScreen_Load(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(175, Color.Gray);
        }
    }
}
