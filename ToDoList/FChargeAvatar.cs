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

namespace ToDoList
{
    public partial class FChargeAvatar : Form
    {
        public FChargeAvatar()
        {
            InitializeComponent();
        }
        string fileName = Application.StartupPath + @"/Avatar/" + FSignIn.codeReadFile.ToString() + "-" + FSignIn.userName + ".txt";
        public static string linkPicture = "";
        public string temp = "";
        public static int tokenChange = 0;
        
        private void pbA1_Click(object sender, EventArgs e)
        {
            temp = ((PictureBox)sender).Name;
            button1.FlatAppearance.BorderColor = Color.FromArgb(245, 181, 22);
            button1.Location = ((PictureBox)sender).Location;
        }
        public void showBalloon(string title, string body)
        {
            NotifyIcon notifyIcon = new NotifyIcon();
            notifyIcon.Visible = true;
            notifyIcon.Icon = new Icon(Application.StartupPath + @"/Images/logo2.ico");
            if (title != null)
            {
                notifyIcon.BalloonTipTitle = title;
            }
            if (body != null)
            {
                notifyIcon.BalloonTipText = body;
            }
            notifyIcon.ShowBalloonTip(5000);
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                if (temp != "")
                {
                    linkPicture = temp;
                    File.WriteAllText(fileName, linkPicture + ".png");
                    tokenChange = 1;
                }
                if (linkPicture == "")
                {
                    throw new Exception("You must choose 01 item !!!");
                }
                if (FSetting.flagOffNofi == 0)
                {
                    showBalloon("You just changed your profile picture", DateTime.Now.ToString("F")); 
                }
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tokenChange = 0;
            Close();
        }
    }
}
