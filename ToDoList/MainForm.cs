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
using WMPLib;

namespace ToDoList
{
    public partial class MainForm : Form
    {
        #region bien toan cuc
        List<Panel> termsPNofCate = new List<Panel>(); // lưu tất cả các panel
        List<String> termsNameCate = new List<String>();
        String pathCate = Application.StartupPath + @"/Categories/";
        String pathAvatar = Application.StartupPath + @"/Avatar/";
        String fileName = Application.StartupPath + @"/TaskUser/" + FSignIn.codeReadFile.ToString() + "-" + FSignIn.userName + ".txt";
        public static int codeReadCate;
        public static String cateName;
        WindowsMediaPlayer sound = new WindowsMediaPlayer();
        String pathSound = Application.StartupPath + @"/Sounds/";
        #endregion
        #region phuongthuc
        public void addCategory(String nameCate, string isDeleted)
        {
            Button bt = new Button();
            Button bt2 = new Button();
            Panel pn = new Panel();
            pn.Size = new Size(306, 54);
            bt.Text = nameCate;
            bt.Font = new Font(bt.Font.FontFamily, 10, FontStyle.Bold);
            bt.Size = new Size(240, 54);
            bt.BackColor = Color.FromArgb(252, 235, 192);
            bt.ForeColor = Color.FromArgb(8, 64, 82);
            bt.FlatStyle = FlatStyle.Flat;
            bt.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 181, 22);
            bt.Location = new Point(0, 3);
            bt2.Text = "";
            bt2.Size = new Size(54, 54);
            bt2.BackColor = Color.FromArgb(252, 235, 192);
            bt2.FlatStyle = FlatStyle.Flat;
            bt2.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 181, 22);
            bt2.Location = new Point(250, 3);
            if (File.Exists(Application.StartupPath + @"/Images/iconCategory.png") && File.Exists(Application.StartupPath + @"/Images/iconCancel.png"))
            {
                bt.Image = Image.FromFile(Application.StartupPath + @"/Images/iconCategory.png");
                bt.ImageAlign = ContentAlignment.MiddleLeft;
                bt2.Image = Image.FromFile(Application.StartupPath + @"/Images/iconCancel.png");
            }
            pn.Controls.Add(bt);
            pn.Controls.Add(bt2);
            if (isDeleted == "0")
            {
                flpCategory.Controls.Add(pn);
            }
            termsPNofCate.Add(pn);
            termsNameCate.Add(nameCate);
            bt.Click += Bt_Click;
            bt2.Click += Bt2_Click;
        }
        #endregion
        public void readFolderCate()
        {
            termsPNofCate = new List<Panel>();
            termsNameCate = new List<string>();
            flpCategory.Controls.Clear();
            String path = pathCate + FSignIn.codeReadFile.ToString() + "-" + FSignIn.userName;
            if (Directory.Exists(path))
            {

                StreamReader stW2 = new StreamReader(path + "/read.txt");
                String chuoiDoc = stW2.ReadToEnd();
                stW2.Close();
                if (chuoiDoc != "")
                {
                    String[] manTam = chuoiDoc.Split('$');
                    for (int i = 0; i < manTam.Length - 1; i++)
                    {
                        String[] tam = manTam[i].Split('#');
                        if (tam.Length == 2)
                        {
                            addCategory(tam[1], tam[0]);
                        }
                    }
                }
            }
        }
        public void loadAvatar()
        {
            String path = pathAvatar + FSignIn.codeReadFile.ToString() + "-" + FSignIn.userName + ".txt";
            if (File.Exists(path))
            {
                StreamReader stLA = new StreamReader(path);
                String linkPicture = stLA.ReadToEnd();
                stLA.Close();
                if (File.Exists(Application.StartupPath + @"/Images/" + linkPicture))
                {
                    pictureBox1.Image = Image.FromFile(Application.StartupPath + @"/Images/" + linkPicture);
                }
            }
            else
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + @"/Images/logo2.png");
            }
        }
        private void Bt2_Click(object sender, EventArgs e)
        {
            Panel tamm = new Panel();
            Button bt = (Button)sender;
            int count = -1;
            foreach (Panel item in termsPNofCate)
            {
                count++;
                if (item.Contains(bt))
                {
                    tamm = item;
                    break;
                }
            }
            DialogResult dR = MessageBox.Show("Are you sure you want to delete it? You can still recover in deleted folder", "To-Do List", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dR == DialogResult.OK)
            {
                String path = pathCate + FSignIn.codeReadFile.ToString() + "-" + FSignIn.userName;
                StreamReader stW2 = new StreamReader(path + "/read.txt");
                String chuoiDoc = stW2.ReadToEnd();
                stW2.Close();
                String ghiFile = "";
                if (chuoiDoc != "")
                {
                    String[] manTam = chuoiDoc.Split('$');
                    String[] manTam2 = manTam[count].Split('#');
                    for (int i = 0; i < manTam.Length - 1; i++)
                    {
                        if (i != count)
                        {
                            ghiFile += manTam[i] + "$";
                        }
                        else
                        {
                            ghiFile += "1#" + manTam2[1] + "$";

                        }
                    }
                    StreamWriter stW = new StreamWriter(path + "/read.txt");
                    stW.Write(ghiFile);
                    stW.Close();
                }
                if (codeReadCate == count + 1)
                {
                    ctCategoryMain.clearSCR();
                }
                readFolderCate();
                ctDeletedMain.readFileUser();
            }
        }

        private void Bt_Click(object sender, EventArgs e)
        {
            lbMark.Hide();
            Panel tamm = new Panel();
            Button bt = (Button)sender;
            int count = -1;
            foreach (Panel item in termsPNofCate)
            {
                count++;
                if (item.Contains(bt))
                {
                    tamm = item;
                    break;
                }
            }
            String path = pathCate + FSignIn.codeReadFile.ToString() + "-" + FSignIn.userName;
            StreamReader stW2 = new StreamReader(path + "/read.txt");
            String chuoiDoc = stW2.ReadToEnd();
            stW2.Close();
            if (chuoiDoc != "")
            {
                String[] manTam = chuoiDoc.Split('$');
                String[] manTam2 = manTam[count].Split('#');
                cateName = manTam2[1];
                codeReadCate = count + 1;
            }
            ctCategoryMain.readFileUser(codeReadCate, cateName);
            ctCategoryMain.BringToFront();
        }

        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            lbUserName.Text = FSignIn.userName;
            tmSystemTime.Enabled = true;
            tmSystemTime.Start();
            tmSystemTime.Tick += TmSystemTime_Tick;
            lbDate.Text = DateTime.Now.ToString("D");
            lbHour.Text = DateTime.Now.ToString("hh:mm:ss tt");
            ctTaskMain.BringToFront();
            readFolderCate();
            loadAvatar();
            lbMark.Show();
            FSetting f = new FSetting();
            f.Show();
            f.Hide();
        }


        private void TmSystemTime_Tick(object sender, EventArgs e)
        {
            lbDate.Text = DateTime.Now.ToString("D");
            lbHour.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void btQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btHide_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btTaskAndCompleted_Click(object sender, EventArgs e)
        {
            lbMark.Show();
            lbMark.Top = btTaskAndCompleted.Top;
            ctTaskMain.BringToFront();
            ctTaskMain.readFileUser();
        }

        private void btImportant_Click(object sender, EventArgs e)
        {
            lbMark.Show();
            lbMark.Top = btImportant.Top;
            ctImportantMain.BringToFront();
            ctImportantMain.readFileUser();
        }

        private void btNote_Click(object sender, EventArgs e)
        {
            lbMark.Show();
            lbMark.Top = btNote.Top;
            ctNote1.BringToFront();
        }

        private void btDeleted_Click(object sender, EventArgs e)
        {
            lbMark.Show();
            lbMark.Top = btDeleted.Top;
            ctDeletedMain.BringToFront();
            ctDeletedMain.readFileUser();
        }

        private void btLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dR = MessageBox.Show("Are you sure you want to log out of your account?", "To-Do List", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dR == DialogResult.OK)
            {
                FSignIn fSI = new FSignIn();
                fSI.Show();
                Close();
            }
        }

        private void btAddCategory_Click(object sender, EventArgs e)
        {
            FAddCategory FAC = new FAddCategory();
            FAC.ShowDialog();
            if (FAddCategory.flag == 1)
            {
                addCategory(FAddCategory.nameCategory, "0"); // 0 có  nghĩa là category chưa xóa
                FAddCategory.flag = 0;
                String path = pathCate + FSignIn.codeReadFile.ToString() + "-" + FSignIn.userName;
                if (!Directory.Exists(path))
                {
                    DirectoryInfo directory = new DirectoryInfo(path);
                    directory.Create();
                    StreamWriter stW = new StreamWriter(path + "/1-" + FAddCategory.nameCategory + ".txt");
                    stW.Close();
                    StreamWriter stW2 = new StreamWriter(path + "/read.txt");
                    stW2.Write("0#" + FAddCategory.nameCategory + "$");
                    stW2.Close();
                }
                else
                {
                    StreamWriter stW2 = File.AppendText(path + "/read.txt");
                    stW2.Write("0#" + FAddCategory.nameCategory + "$");
                    stW2.Close();
                    int fCount = Directory.GetFiles(path, "*", SearchOption.AllDirectories).Length;
                    StreamWriter stW = new StreamWriter(path + "/" + (fCount).ToString() + "-" + FAddCategory.nameCategory + ".txt");
                    stW.Close();
                }
                if (File.Exists(pathSound + @"sound2.mp3"))
                {
                    sound.URL = pathSound + @"sound2.mp3";
                    sound.controls.play();
                }
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            readFolderCate();
            ctTaskMain.readFileUser();
            ctImportantMain.readFileUser();
            if (ctCategory.numCate >= 0 && ctCategory.nameCate != "")
            {
                ctCategoryMain.readFileUser(ctCategory.numCate, ctCategory.nameCate);

            }
            if (File.Exists(pathSound + @"sound2.mp3"))
            {
                sound.URL = pathSound + @"sound2.mp3";
                sound.controls.play();
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FChargeAvatar FCAVA = new FChargeAvatar();
            FCAVA.ShowDialog();
            if (FChargeAvatar.tokenChange == 1)
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\Images\" + FChargeAvatar.linkPicture + ".png");
                FChargeAvatar.linkPicture = "";
                FChargeAvatar.tokenChange = 0;
            }
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
            notifyIcon.ShowBalloonTip(10000);
        }
        public void fixNofication(int masoTask)
        {
            if (File.Exists(fileName))
            {
                StreamReader stR = new StreamReader(fileName);
                String userInfo = stR.ReadToEnd();
                stR.Close();
                if (userInfo != ";") // không xử lý khi file user mới được tạo chưa có dữ liệu
                {

                    String[] mangInfo = userInfo.Split(';'); // tách 2 phần của file ra
                    String allTask = mangInfo[1]; // lấy chuỗi tất cả các task
                    String[] mangTask = allTask.Split('$'); // tách ra từng task riêng
                    String[] tpTask = mangTask[masoTask].Split('#');// lấy task muốn sửa và tách ra từng thành phần
                    String gomNhom = mangInfo[0] + ";"; // biến lưu hỗ trợ ghi file
                    if (tpTask.Length == 8) // khhông sử lý chuối rỗng
                    {
                        tpTask[4] = "1";
                    }
                    for (int i = 0; i < mangTask.Length - 1; i++) // tại vì mảng task sau khi tách sẽ dư 1 chuỗi có giá trị rỗng ở cuối nên lenght - 1 để bỏ qua nó
                    {
                        if (true)
                        {
                            if (i != masoTask) // ghi những task không được sửa
                            {
                                gomNhom += mangTask[i] + "$";
                            }
                            else // ghi task đã được tách ra để sửa
                            {
                                gomNhom += tpTask[0] + "#" + tpTask[1] + "#" + tpTask[2] + "#" + tpTask[3] + "#" + tpTask[4] + "#" + tpTask[5] + "#" + tpTask[6] + "#" + tpTask[7] + "$";
                            }
                        }
                    }
                    StreamWriter stW = new StreamWriter(fileName);
                    stW.Write(gomNhom);
                    stW.Close();
                }
            }
        }
        public void fixAutoComplete(int masoTask)
        {

            if (File.Exists(fileName))
            {
                StreamReader stR = new StreamReader(fileName);
                String userInfo = stR.ReadToEnd();
                stR.Close();
                if (userInfo != ";") // không xử lý khi file user mới được tạo chưa có dữ liệu
                {

                    String[] mangInfo = userInfo.Split(';'); // tách 2 phần của file ra
                    String allTask = mangInfo[1]; // lấy chuỗi tất cả các task
                    String[] mangTask = allTask.Split('$'); // tách ra từng task riêng
                    String[] tpTask = mangTask[masoTask].Split('#');// lấy task muốn sửa và tách ra từng thành phần
                    String gomNhom = mangInfo[0] + ";"; // biến lưu hỗ trợ ghi file
                    if (tpTask.Length == 8) // khhông sử lý chuối rỗng
                    {
                        tpTask[3] = "1";
                    }
                    for (int i = 0; i < mangTask.Length - 1; i++) // tại vì mảng task sau khi tách sẽ dư 1 chuỗi có giá trị rỗng ở cuối nên lenght - 1 để bỏ qua nó
                    {
                        if (true)
                        {
                            if (i != masoTask) // ghi những task không được sửa
                            {
                                gomNhom += mangTask[i] + "$";
                            }
                            else // ghi task đã được tách ra để sửa
                            {
                                gomNhom += tpTask[0] + "#" + tpTask[1] + "#" + tpTask[2] + "#" + tpTask[3] + "#" + tpTask[4] + "#" + tpTask[5] + "#" + tpTask[6] + "#" + tpTask[7] + "$";
                            }
                        }
                    }
                    StreamWriter stW = new StreamWriter(fileName);
                    stW.Write(gomNhom);
                    stW.Close();
                    if (File.Exists(pathSound + @"sound2.mp3"))
                    {
                        sound.URL = pathSound + @"sound2.mp3";
                        sound.controls.play();
                    }
                    ctTaskMain.readFileUser();
                    ctImportantMain.readFileUser();
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (File.Exists(fileName))
            {
                StreamReader streamR = new StreamReader(fileName);
                String userInfo = streamR.ReadToEnd();
                streamR.Close();
                if (userInfo != ";")
                {
                    String[] mangInfo = userInfo.Split(';');
                    String allTask = mangInfo[1];
                    String[] mangTask = allTask.Split('$');
                    foreach (String item in mangTask)
                    {
                        String[] mangTam = item.Split('#');
                        if (mangTam.Length == 8)
                        {
                            if (mangTam[6] != "" && mangTam[1] != "1" && mangTam[3] != "1" && mangTam[4] != "1")
                            {
                                String[] mangGio = mangTam[6].Split('-');
                                DateTime dt1 = DateTime.Parse(mangGio[1]).Date + DateTime.Parse(mangGio[0]).TimeOfDay;
                                DateTime dt2 = DateTime.Now.Date + DateTime.Now.TimeOfDay;
                                if (dt1 < dt2)
                                {
                                    if (FSetting.flagOffNofi == 0)
                                    {
                                        showBalloon("\"" + mangTam[5] + "\" has expired", "At " + mangGio[0] + "-" + mangGio[1]); 
                                    }
                                    fixNofication(int.Parse(mangTam[0]) - 1);
                                }
                            }
                        }
                    }
                    if (FSetting.flagAutoComplete == 1)
                    {
                        foreach (String item in mangTask)
                        {
                            String[] mangTam = item.Split('#');
                            if (mangTam.Length == 8)
                            {
                                if (mangTam[6] != "" && mangTam[3] != "1")
                                {
                                    String[] mangGio = mangTam[6].Split('-');
                                    DateTime dt1 = DateTime.Parse(mangGio[1]).Date + DateTime.Parse(mangGio[0]).TimeOfDay;
                                    DateTime dt2 = DateTime.Now.Date + DateTime.Now.TimeOfDay;
                                    if (dt1 < dt2)
                                    {
                                        fixAutoComplete(int.Parse(mangTam[0]) - 1);
                                    }
                                }
                            }
                        }
                    }

                }

            } 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FSetting fSetting = new FSetting();
            fSetting.ShowDialog();
        }
    }
}
