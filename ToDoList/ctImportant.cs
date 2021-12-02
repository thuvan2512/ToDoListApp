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
using System.Runtime.InteropServices;

namespace ToDoList
{
    public partial class ctImportant : UserControl
    {
        List<Panel> termsPN = new List<Panel>(); // lưu tất cả các panel
        public static String pathFileUser = Application.StartupPath + @"/TaskUser/";
        String pathSound = Application.StartupPath + @"/Sounds/";
        WindowsMediaPlayer sound = new WindowsMediaPlayer();
        String fileName = pathFileUser + FSignIn.codeReadFile.ToString() + "-" + FSignIn.userName + ".txt";// tên file user
        public void savePN(Panel tam)
        {
            termsPN.Add(tam);
        } // lưu 
        public void fixComplet(int masoTask) // thay đối trạng thái đã hoàn tất của task trong file user
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
                        if (tpTask[3] == "1") // đổi trạng thái
                        {
                            tpTask[3] = "0";
                            tpTask[4] = "0";
                        }
                        else
                        {
                            tpTask[3] = "1";
                        }
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
        //PHẦN IMPORT VÀO ĐỂ TẠO BO GÓC CHO CÁC PANEL
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public void createTask(int isDeleted, int important, int isComple, int belongList, String task, String dueDay, String descrip) // tạo các panel ra màn hình
        {
            Panel pn = new Panel();
            CheckBox lTask = new CheckBox();
            Label lDueDay = new Label();
            Label lDescription = new Label();
            pn.Size = new Size(460, 125);
            pn.BackColor = Color.FromArgb(247, 102, 19);
            pn.ForeColor = Color.FromArgb(8, 64, 82);
            Button btRemove = new Button();
            pn.Controls.Add(lDueDay);
            pn.Controls.Add(lDescription);
            pn.Controls.Add(btRemove);
            btRemove.Size = new Size(40, 40);
            btRemove.Location = new Point(416, 82);
            if (File.Exists(Application.StartupPath + @"/Images/iconCancel.png"))
            {
                btRemove.Image = Image.FromFile(Application.StartupPath + @"/Images/iconCancel.png");
            }
            btRemove.Text = "";
            btRemove.FlatStyle = FlatStyle.Flat;
            btRemove.FlatAppearance.MouseOverBackColor = Color.FromArgb(122, 128, 117);
            btRemove.FlatAppearance.BorderSize = 0;
            pn.Controls.Add(lTask);
            lTask.Text = task;
            lTask.Location = new Point(7, 32);
            lTask.AutoSize = false;
            lTask.Size = new Size(450, 30);
            lDueDay.Text = dueDay;
            lDueDay.Font = new Font(lDueDay.Font.FontFamily, 10, FontStyle.Bold);
            lDueDay.Dock = DockStyle.Right;
            lDueDay.AutoSize = true;
            lDescription.Text = descrip;
            lDescription.Location = new Point(3, 65);
            lDescription.AutoSize = false;
            lDescription.Size = new Size(315, 65);
            lDescription.Font = new Font(lDescription.Font.FontFamily, 8, FontStyle.Regular);
            pn.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pn.Width, pn.Height, 15, 15));
            if (isDeleted == 0 && important == 1) // task chưa bị xóa
            {
                if (isComple == 0) // task chưa hoàn thành
                {
                    lTask.Font = new Font(lTask.Font.FontFamily, 10, FontStyle.Bold);
                    flpTaskImportant.Controls.Add(pn);
                }
                else
                {
                    lTask.Font = new Font(lTask.Font.FontFamily, 10, FontStyle.Strikeout);
                    lTask.Checked = true;
                    flpTaskImpoComple.Controls.Add(pn);
                }
            }
            savePN(pn); // lưu lại để xử lý sự kiện
            lTask.CheckedChanged += LTask_CheckedChanged;
            btRemove.Click += BtRemove_Click;
        }

        private void BtRemove_Click(object sender, EventArgs e)
        {
           Panel tamm = new Panel();
            Button bt = (Button)sender;
            int count = -1;
            foreach (Panel item in termsPN)
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
                StreamReader stR = new StreamReader(fileName);
                String userInfo = stR.ReadToEnd();
                stR.Close();
                if (userInfo != ";") // không xử lý khi file user mới được tạo chưa có dữ liệu
                {

                    String[] mangInfo = userInfo.Split(';'); // tách 2 phần của file ra
                    String allTask = mangInfo[1]; // lấy chuỗi tất cả các task
                    String[] mangTask = allTask.Split('$'); // tách ra từng task riêng
                    String[] tpTask = mangTask[count].Split('#');// lấy task muốn sửa và tách ra từng thành phần
                    String gomNhom = mangInfo[0] + ";"; // biến lưu hỗ trợ ghi file
                    if (tpTask.Length == 8) // khhông sử lý chuối rỗng
                    {
                        tpTask[1] = "1";
                    }
                    for (int i = 0; i < mangTask.Length - 1; i++) // tại vì mảng task sau khi tách sẽ dư 1 chuỗi có giá trị rỗng ở cuối nên lenght - 1 để bỏ qua nó
                    {
                        if (i != count) // ghi những task không được sửa
                        {
                            gomNhom += mangTask[i] + "$";
                        }
                        else // ghi task đã được tách ra để sửa
                        {
                            gomNhom += tpTask[0] + "#" + tpTask[1] + "#" + tpTask[2] + "#" + tpTask[3] + "#" + tpTask[4] + "#" + tpTask[5] + "#" + tpTask[6] + "#" + tpTask[7] + "$";
                        }
                    }
                    StreamWriter stW = new StreamWriter(fileName);
                    stW.Write(gomNhom);
                    stW.Close();
                }
                readFileUser();
            }
        }

        private void LTask_CheckedChanged(object sender, EventArgs e)
        {
            Panel tamm = new Panel();
            CheckBox chk = (CheckBox)sender;
            int count = -1;
            foreach (Panel item in termsPN)
            {
                count++;
                if (item.Contains(chk))
                {
                    tamm = item;
                    break;
                }
            }
            if (chk.Checked)
            {
                if (File.Exists(pathSound + @"sound1.mp3"))
                {
                    sound.URL = pathSound + @"sound1.mp3";
                    sound.controls.play();
                }
                chk.Font = new Font(chk.Font.FontFamily, 10, FontStyle.Strikeout);
                flpTaskImpoComple.Controls.Add(tamm);
                flpTaskImportant.Controls.Remove(tamm);
                fixComplet(count);
            }
            else
            {
                if (File.Exists(pathSound + @"sound2.mp3"))
                {
                    sound.URL = pathSound + @"sound2.mp3";
                    sound.controls.play();
                }
                chk.Font = new Font(chk.Font.FontFamily, 10, FontStyle.Bold);
                flpTaskImpoComple.Controls.Remove(tamm);
                flpTaskImportant.Controls.Add(tamm);
                fixComplet(count);
            }
        }

        public void readFileUser() // đọc file và ghi ra màn hình
        {
            termsPN = new List<Panel>();
            flpTaskImportant.Controls.Clear();
            flpTaskImpoComple.Controls.Clear();
            if (File.Exists(fileName))
            {
                flpTaskImportant.Controls.Clear();
                termsPN = new List<Panel>();
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
                            int isDeleted = int.Parse(mangTam[1]);
                            int isImportant = int.Parse(mangTam[2]);
                            int isComple = int.Parse(mangTam[3]);
                            int belongList = int.Parse(mangTam[4]);
                            String dueDate = mangTam[6];
                            String taskName = mangTam[5];
                            String description = mangTam[7];
                            createTask(isDeleted, isImportant, isComple, belongList, taskName, dueDate, description);
                        }
                    }
                }
            }
        }
        public ctImportant()
        {
            InitializeComponent();
        }

        private void ctImportant_Load(object sender, EventArgs e)
        {
            readFileUser();
        }
    }
}
