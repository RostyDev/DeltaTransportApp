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
    public partial class aanmeldScreen : UserControl
    {
        private bool UniqueNickname = true;

        InlogAPI AanmeldAPI = new InlogAPI();

        public static AccountData NewAccount = new AccountData();

        public aanmeldScreen()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            CheckNickname();

            if (tb_Nickname.Text == "" || tb_Password1.Text == "" || tb_Password2.Text == "")
            {
                string message = "fill out all fields";
                MessageBox.Show(message);
            }
            else if (!UniqueNickname)
            {
                string message = "Nickname is already taken! Choose an other one.";
                MessageBox.Show(message);

                tb_Nickname.Clear();

                UniqueNickname = true;
            }
            else if (tb_Password1.Text == tb_Password2.Text)
            {
                AanmeldAPI.Password = tb_Password1.Text;
                AanmeldAPI.Hash();

                NewAccount.Nickname = tb_Nickname.Text;
                NewAccount.PassWord = AanmeldAPI.HashedPassword;
                NewAccount.Age = int.Parse(cb_Age.Text);
                AanmeldAPI.NewAccount = NewAccount;
                AanmeldAPI.SignUp();

                tb_Nickname.Clear();
                tb_Password1.Clear();
                tb_Password2.Clear();
                cb_Age.Text = "";

                
            }
            else if (tb_Password1.Text != tb_Password2.Text)
            {
                string message = "Make sure to type the same password in the two boxes!";
                MessageBox.Show(message);

                tb_Password1.Clear();
                tb_Password2.Clear();
            }
        }

        private void cb_Age_TextUpdate(object sender, EventArgs e)
        {
            string message = "Choose an option in this dropdown.";
            MessageBox.Show(message);
            cb_Age.Text = "";
        }

        private void CheckNickname()
        {
            AanmeldAPI.GetAllAccounts();

            foreach (var Account in AanmeldAPI.AllAccounts)
            {
                if (Account.Nickname == tb_Nickname.Text)
                {
                    UniqueNickname = false; break;
                }
            }
        }

        private void aanmeldScreen_Load(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(185, Color.Gray);
        }

        private void lb_AanmeldPage_Click(object sender, EventArgs e)
        {
            nav.LoadSignin();
        }
    }
}
