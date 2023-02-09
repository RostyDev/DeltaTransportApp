namespace DeltaTransportApp
{
    partial class aanmeldScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aanmeldScreen));
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_AanmeldPage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Age = new System.Windows.Forms.ComboBox();
            this.btn_Register = new System.Windows.Forms.Button();
            this.tb_Password2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Password1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Nickname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel3.Controls.Add(this.lb_AanmeldPage);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.cb_Age);
            this.panel3.Controls.Add(this.btn_Register);
            this.panel3.Controls.Add(this.tb_Password2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tb_Password1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.tb_Nickname);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(368, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(417, 636);
            this.panel3.TabIndex = 3;
            // 
            // lb_AanmeldPage
            // 
            this.lb_AanmeldPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lb_AanmeldPage.AutoSize = true;
            this.lb_AanmeldPage.BackColor = System.Drawing.Color.Transparent;
            this.lb_AanmeldPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AanmeldPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_AanmeldPage.Location = new System.Drawing.Point(65, 572);
            this.lb_AanmeldPage.Name = "lb_AanmeldPage";
            this.lb_AanmeldPage.Size = new System.Drawing.Size(270, 17);
            this.lb_AanmeldPage.TabIndex = 31;
            this.lb_AanmeldPage.Text = "You already have an account? Click here!";
            this.lb_AanmeldPage.Click += new System.EventHandler(this.lb_AanmeldPage_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(174, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Age:";
            // 
            // cb_Age
            // 
            this.cb_Age.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_Age.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_Age.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Age.ForeColor = System.Drawing.Color.DarkBlue;
            this.cb_Age.FormattingEnabled = true;
            this.cb_Age.Items.AddRange(new object[] {
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.cb_Age.Location = new System.Drawing.Point(139, 307);
            this.cb_Age.Name = "cb_Age";
            this.cb_Age.Size = new System.Drawing.Size(121, 28);
            this.cb_Age.TabIndex = 29;
            this.cb_Age.TextUpdate += new System.EventHandler(this.cb_Age_TextUpdate);
            // 
            // btn_Register
            // 
            this.btn_Register.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Register.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_Register.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Register.Location = new System.Drawing.Point(68, 465);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(259, 90);
            this.btn_Register.TabIndex = 6;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = false;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // tb_Password2
            // 
            this.tb_Password2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_Password2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_Password2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password2.Location = new System.Drawing.Point(24, 213);
            this.tb_Password2.Name = "tb_Password2";
            this.tb_Password2.PasswordChar = '*';
            this.tb_Password2.Size = new System.Drawing.Size(366, 30);
            this.tb_Password2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(125, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "confirm password:";
            // 
            // tb_Password1
            // 
            this.tb_Password1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_Password1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_Password1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password1.Location = new System.Drawing.Point(24, 126);
            this.tb_Password1.Name = "tb_Password1";
            this.tb_Password1.PasswordChar = '*';
            this.tb_Password1.Size = new System.Drawing.Size(366, 30);
            this.tb_Password1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(155, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // tb_Nickname
            // 
            this.tb_Nickname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_Nickname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_Nickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Nickname.Location = new System.Drawing.Point(24, 40);
            this.tb_Nickname.Name = "tb_Nickname";
            this.tb_Nickname.Size = new System.Drawing.Size(366, 30);
            this.tb_Nickname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(155, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nickname:";
            // 
            // aanmeldScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel3);
            this.Name = "aanmeldScreen";
            this.Size = new System.Drawing.Size(1153, 636);
            this.Load += new System.EventHandler(this.aanmeldScreen_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Nickname;
        private System.Windows.Forms.TextBox tb_Password2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Password1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.ComboBox cb_Age;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_AanmeldPage;
    }
}
