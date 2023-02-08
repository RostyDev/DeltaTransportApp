using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DeltaTransportApp
{
    public class nav
    {
        static SigninScreen InlogScherm = new SigninScreen();
        static aanmeldScreen AanmeldScreen = new aanmeldScreen();

        private static void Unload()
        {
            MainForm.Form1.Controls.Clear();
        }

        public static void LoadSignin()
        {
            Unload();

            MainForm.Form1.Controls.Add(InlogScherm);
            InlogScherm.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        public static void LoadAanmeldScreen()
        {
            Unload();

            MainForm.Form1.Controls.Add(AanmeldScreen);
            AanmeldScreen.Dock = System.Windows.Forms.DockStyle.Fill;
        }
    }
}
