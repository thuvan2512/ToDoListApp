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
    public partial class FSignIn : Form
    {
        #region Bien toan cuc
        String path = Application.StartupPath;
        int flag = 0;
        #endregion
        #region Thuoc tinh
        public static String userName = "";
        public static int closeForm = 1;
        public static int codeReadFile;
        #endregion
        #region Phuong thuc
        public void signIn()
        {
            try
            {
                if (txtPassWord.Text == "" || txtUserName.Text == "")
                {
                    throw new Exception("You can't leave it blank !!!");
                }

                if (File.Exists(path + @"/User/User.txt"))
                {
                    StreamReader strR = new StreamReader(path + @"/User/User.txt");
                    String readFile = strR.ReadToEnd(); //Đọc toàn bộ file
                    strR.Close();
                    String[] mangUser = readFile.Split(';'); // Tách từng user
                    for (int i = 0; i < mangUser.Length; i++)
                    {
                        String[] user = mangUser[i].Split('#'); // tách username và password
                        if (txtUserName.Text == user[0] && txtPassWord.Text == user[1])
                        {
                            codeReadFile = i + 1; // cho biết stt của user đó trong file lưu user để xác định file task
                            flag = 1; // trạng thái hợp lệ
                            break;
                        }

                    }
                    if (flag == 1)
                    {
                        userName = txtUserName.Text;
                        MainForm mainF = new MainForm();
                        mainF.Show();
                        flag = 0;
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Login Error", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    throw new Exception("System error");
                }
            }
            catch (Exception e1)
            {

                MessageBox.Show(e1.Message, "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        public FSignIn()
        {
            InitializeComponent();
        }
        private void FSignIn_Load(object sender, EventArgs e)
        {
            if (File.Exists(path + @"/Images/iconHuman.png") && File.Exists(path + @"/Images/iconLock.png"))
            {
                picUser.Image = Image.FromFile(path + @"/Images/iconHuman.png");
                picPass.Image = Image.FromFile(path + @"/Images/iconLock.png");
            }
            txtPassWord.UseSystemPasswordChar = true;
            chkShowPass.CheckedChanged += ChkShowPass_CheckedChanged;
            FormClosing += FSignIn_FormClosing;
            txtUserName.KeyPress += Txt_KeyPress;
            txtPassWord.KeyPress += Txt_KeyPress;
        }

        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ChkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass.Checked)
            {
                txtPassWord.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassWord.UseSystemPasswordChar = true;
            }
        }

        private void btSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text.Contains('"')
                    || txtPassWord.Text.Contains('"'))
                {
                    throw new Exception("Login Error");
                }    
                signIn();
            }
            catch (Exception e8)
            {

                MessageBox.Show(e8.Message, "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FSignIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closeForm == 1) // chỉ gọi khi người dùng chưa muốn đóng
            {

                DialogResult conf = MessageBox.Show("Do you want to exit this app?", "To-Do List", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (conf == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else if (conf == DialogResult.OK)
                {
                    closeForm = 0; // đã được gọi và người dùng muốn đóng nên không cần gọi  lại nữa
                }
            }
        }
        private void btSignUp_Click(object sender, EventArgs e)
        {
            FSignUp fSU = new FSignUp();
            fSU.Show();
            fSU.BringToFront();
        }
        private void btQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    btSignIn.Focus();
                    try
                    {
                        if (txtUserName.Text.Contains('"')
                            || txtPassWord.Text.Contains('"'))
                        {
                            throw new Exception("Login Error");
                        }
                        signIn();
                    }
                    catch (Exception e8)
                    {

                        MessageBox.Show(e8.Message, "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return true;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}
