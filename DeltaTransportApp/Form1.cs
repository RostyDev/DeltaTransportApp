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
    public partial class MainForm : Form
    {
        public static MainForm Form1 = null;

        public MainForm()
        {
            InitializeComponent();
            Form1 = this;

            //nav.LoadSignin();
            nav.LoadAanmeldScreen();
        }
    }
}
