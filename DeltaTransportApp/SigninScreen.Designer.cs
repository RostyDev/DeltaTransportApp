namespace DeltaTransportApp
{
    partial class SigninScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SigninScreen));
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_AanmeldPage = new System.Windows.Forms.Label();
            this.btn_Signin = new System.Windows.Forms.Button();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Nickname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.lb_AanmeldPage);
            this.panel3.Controls.Add(this.btn_Signin);
            this.panel3.Controls.Add(this.tb_Password);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.tb_Nickname);
            this.panel3.Controls.Add(this.label1);
            this.panel3.ForeColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(384, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(417, 636);
            this.panel3.TabIndex = 2;
            // 
            // lb_AanmeldPage
            // 
            this.lb_AanmeldPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lb_AanmeldPage.AutoSize = true;
            this.lb_AanmeldPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AanmeldPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_AanmeldPage.Location = new System.Drawing.Point(73, 587);
            this.lb_AanmeldPage.Name = "lb_AanmeldPage";
            this.lb_AanmeldPage.Size = new System.Drawing.Size(270, 17);
            this.lb_AanmeldPage.TabIndex = 5;
            this.lb_AanmeldPage.Text = "You already have an account? Click here!";
            this.lb_AanmeldPage.Click += new System.EventHandler(this.lb_AanmeldPage_Click);
            // 
            // btn_Signin
            // 
            this.btn_Signin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Signin.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_Signin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Signin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Signin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Signin.Location = new System.Drawing.Point(76, 484);
            this.btn_Signin.Name = "btn_Signin";
            this.btn_Signin.Size = new System.Drawing.Size(259, 90);
            this.btn_Signin.TabIndex = 4;
            this.btn_Signin.Text = "Sign in";
            this.btn_Signin.UseVisualStyleBackColor = false;
            this.btn_Signin.Click += new System.EventHandler(this.btn_Signin_Click);
            // 
            // tb_Password
            // 
            this.tb_Password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(25, 199);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(369, 30);
            this.tb_Password.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(132, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // tb_Nickname
            // 
            this.tb_Nickname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_Nickname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_Nickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Nickname.Location = new System.Drawing.Point(25, 65);
            this.tb_Nickname.Name = "tb_Nickname";
            this.tb_Nickname.Size = new System.Drawing.Size(369, 30);
            this.tb_Nickname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(132, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nickname:";
            // 
            // SigninScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel3);
            this.Name = "SigninScreen";
            this.Size = new System.Drawing.Size(1153, 636);
            this.Load += new System.EventHandler(this.SigninScreen_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Nickname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Signin;
        private System.Windows.Forms.Label lb_AanmeldPage;
    }
}
