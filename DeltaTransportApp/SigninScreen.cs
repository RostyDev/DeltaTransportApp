﻿using DeltaTransportDB;
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
        InlogAPI SigninAPI = new InlogAPI();

        public SigninScreen()
        {
            InitializeComponent();
        }

        private void btn_Signin_Click(object sender, EventArgs e)
        {
            SigninAPI.Password = tb_Password.Text;
            SigninAPI.Hash();

            

            
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
