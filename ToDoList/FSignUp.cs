using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ToDoList
{
    public partial class FSignUp : Form
    {
        #region Bien toan cuc
        String path = Application.StartupPath;
        String newFileTask = "";
        String newFileAvt = "";
        int count; // biến đếm user
        #endregion
        #region Thuoc tinh
        #endregion
        #region Phuong thuc
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
            notifyIcon.ShowBalloonTip(10000);
        }
        public void signUp()
        {
            try
            {
                if (txtPassWord1.Text == "" || txtUserName.Text == "" || txtPassWord2.Text == "")
                {
                    throw new Exception("You can't leave it blank !!!");
                }
                if (txtPassWord1.Text != txtPassWord2.Text)
                {

                    throw new Exception("Confirm password error");
                }
                if (File.Exists(path + @"/User/User.txt")) // kiểm tra đã tồn tại user này chưa
                {
                    StreamReader strR = new StreamReader(path + @"/User/User.txt");
                    String readFile = strR.ReadToEnd();
                    strR.Close();
                    String[] mangUser = readFile.Split(';');
                    count = mangUser.Length;
                    for (int i = 0; i < mangUser.Length; i++)
                    {
                        String[] user = mangUser[i].Split('#');
                        if (txtUserName.Text == user[0])
                        {
                            throw new Exception("Username already exists");
                        }

                    }
                }
                if (File.Exists(path + @"/User/User.txt") && Directory.Exists(path + @"/TaskUser"))
                {
                    newFileTask = path + @"/TaskUser/" + count.ToString() + "-" + txtUserName.Text + ".txt";
                    StreamWriter nFT = new StreamWriter(newFileTask); // tạo file task cho user
                    nFT.Write(";");
                    nFT.Close();
                    StreamWriter strW = File.AppendText(path + @"/User/User.txt");
                    strW.Write(txtUserName.Text + '#' + txtPassWord1.Text + ';');
                    strW.Close();
                    newFileAvt= path + @"/Avatar/" + count.ToString() + "-" + txtUserName.Text + ".txt";
                    StreamWriter nFA = new StreamWriter(newFileAvt);
                    nFA.Write("logo2.png");
                    nFA.Close();
                  
                    if (FSetting.flagOffNofi == 0)
                    {
                        showBalloon("Sign up success", DateTime.Now.ToString("F")); 
                    }
                    else
                    {
                        MessageBox.Show("Sign up success");
                    }    
                }
                else
                {
                    throw new Exception("System error");
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message, "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        public FSignUp()
        {
            InitializeComponent();
        }

        private void FSignUp_Load(object sender, EventArgs e)
        {
            if (File.Exists(path + @"/Images/iconHuman.png") && File.Exists(path + @"/Images/iconLock.png"))
            {
                picUser.Image = Image.FromFile(path + @"/Images/iconHuman.png");
                picPass1.Image = Image.FromFile(path + @"/Images/iconLock.png");
                picPass2.Image = Image.FromFile(path + @"/Images/iconLock.png");
            }
            txtPassWord1.UseSystemPasswordChar = true;
            txtPassWord2.UseSystemPasswordChar = true;
            chkShowPass1.CheckedChanged += ChkShowPass_CheckedChanged;
            chkShowPass2.CheckedChanged += ChkShowPass_CheckedChanged;
            txtUserName.KeyPress += Txt_KeyPress; 
            txtPassWord1.KeyPress += Txt_KeyPress;
            txtPassWord2.KeyPress += Txt_KeyPress;
        }

        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) || tb.Text.Length >= 12 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void ChkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            if (chk == chkShowPass1)
            {
                if (chkShowPass1.Checked)
                {
                    txtPassWord1.UseSystemPasswordChar = false;
                }
                else
                {
                    txtPassWord1.UseSystemPasswordChar = true;
                }
            }
            else 
            {
                if (chkShowPass2.Checked)
                {
                    txtPassWord2.UseSystemPasswordChar = false;
                }
                else
                {
                    txtPassWord2.UseSystemPasswordChar = true;
                }
            }
        }
        private void btQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtUserName.Text.Contains('#') || txtUserName.Text.Contains(';') 
                    || txtPassWord1.Text.Contains('#') || txtPassWord2.Text.Contains('#') || txtPassWord2.Text.Contains(';') 
                    || txtPassWord1.Text.Contains(';'))
                {
                    throw new Exception("Do not enter (# ; $ ) signs");
                }
                if (txtPassWord1.Text.Length > 15 || txtPassWord2.Text.Length > 15 || txtUserName.Text.Length > 15)
                {
                    throw new Exception("Exceed 15 characters");
                }
                signUp();
            }
            catch (Exception e7)
            {
                MessageBox.Show(e7.Message, "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override bool ProcessDialogKey(Keys keyData)
        { 
            switch(keyData)
            {
                case (Keys.Enter):
                    btSignUp.Focus();
                    try
                    {
                        if (txtUserName.Text.Contains('#') || txtUserName.Text.Contains(';')
                            || txtPassWord1.Text.Contains('#') || txtPassWord2.Text.Contains('#') || txtPassWord2.Text.Contains(';')
                            || txtPassWord1.Text.Contains(';'))
                        {
                            throw new Exception("Do not enter (# ; $ ) signs");
                        }
                        if (txtPassWord1.Text.Length > 15 || txtPassWord2.Text.Length > 15 || txtUserName.Text.Length > 15)
                        {
                            throw new Exception("Exceed 15 characters");
                        }
                        signUp();
                    }
                    catch (Exception e7)
                    {

                        MessageBox.Show(e7.Message, "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return true;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}
