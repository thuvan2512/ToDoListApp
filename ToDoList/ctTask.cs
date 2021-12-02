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
    public partial class ctTask : UserControl
    {
        List<Panel> termsPN = new List<Panel>(); // lưu tất cả các panel
        int stt = 0; // xác định số tt của task thêm vào
        int sttFix; // lưu stt của task muốn sửa
        Button btFixTask = new Button();
        Button btCancelFix = new Button();
        public static String pathFileUser = Application.StartupPath + @"/TaskUser/"; 
        String fileName = pathFileUser + FSignIn.codeReadFile.ToString() + "-" + FSignIn.userName + ".txt";// tên file user
        String pathSound = Application.StartupPath + @"/Sounds/";
        WindowsMediaPlayer sound = new WindowsMediaPlayer();
        public void savePN(Panel tam)
        {
            termsPN.Add(tam);
        } // lưu trữ quản lý panel để xử lý sự kiện
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
        public void fixTask(int masoTask) 
        {
            if (File.Exists(fileName))
            {
                btCancelFix.Enabled = false;
                btCancelFix.Hide();
                btFixTask.Enabled = false;
                btFixTask.Hide();
                StreamReader stR = new StreamReader(fileName);
                String userInfo = stR.ReadToEnd();
                stR.Close();
                if (userInfo != ";") // không xử lý khi file user mới được tạo chưa có dữ liệu
                {

                    String[] mangInfo = userInfo.Split(';'); // tách 2 phần của file ra
                    String allTask = mangInfo[1]; // lấy chuỗi tất cả các task
                    String[] mangTask = allTask.Split('$'); // tách ra từng task riêng
                    String[] tpTask = mangTask[masoTask].Split('#');// lấy task muốn sửa và tách ra từng thành phần
                    if (tpTask.Length == 8)
                    {
                        txtTaskName.Text = tpTask[5];
                        txtDescription.Text = tpTask[7];
                        if (tpTask[2] == "1")
                        {
                            chkImportant.Checked = true;
                        }
                        else
                        {
                            chkImportant.Checked = false;
                        }
                        if (tpTask[6] != "")
                        {
                            chkDueDay.Checked = true;
                            dtpDueDay1.Enabled = true;
                            dtpDueDay2.Enabled = true;
                            String[] mangGio = tpTask[6].Split('-');
                            dtpDueDay1.Value = DateTime.Parse(mangGio[1]);
                            dtpDueDay2.Value = DateTime.Parse(mangGio[0]);
                        }
                        else
                        {
                            chkDueDay.Checked = false;
                            dtpDueDay1.Enabled = false;
                            dtpDueDay2.Enabled = false;
                        }
                        btAdd.Enabled = false;
                        btAdd.Hide();
                        btFixTask = new Button();
                        btCancelFix = new Button();
                        btFixTask.Location = new Point(949, 87);
                        btCancelFix.Location = new Point(797, 87);
                        btCancelFix.Size = btFixTask.Size = new Size(135, 41);
                        btFixTask.ForeColor = btCancelFix.ForeColor = Color.FromArgb(8, 64, 82);
                        btCancelFix.BackColor = btFixTask.BackColor = Color.FromArgb(252, 235, 192);
                        btCancelFix.Font = new Font(btCancelFix.Font.FontFamily, 12, FontStyle.Regular);
                        btFixTask.Font = new Font(btFixTask.Font.FontFamily, 12, FontStyle.Regular);
                        btFixTask.FlatStyle = btCancelFix.FlatStyle = FlatStyle.Flat;
                        btCancelFix.Text = "Cancel";
                        btFixTask.Text = "Repair";
                        this.Controls.Add(btCancelFix);
                        this.Controls.Add(btFixTask);
                        btFixTask.Click += BtFixTask_Click;
                        btCancelFix.Click += BtCancelFix_Click;
                        sttFix = masoTask;
                    }
                }
            }
        }

        private void BtCancelFix_Click(object sender, EventArgs e)// button hien ra khi muon sua
        {
            txtTaskName.Text = "";
            txtDescription.Text = "";
            chkDueDay.Checked = false;
            chkImportant.Checked = false;
            dtpDueDay1.Enabled = false;
            dtpDueDay2.Enabled = false;
            btFixTask.Enabled = btCancelFix.Enabled = false;
            btCancelFix.Hide();
            btFixTask.Hide();
            btAdd.Enabled = true;
            btAdd.Show();
        }

        private void BtFixTask_Click(object sender, EventArgs e)// button hien ra khi muon sua
        {
            try
            {
                if (txtTaskName.Text == "")
                {
                    throw new Exception("You can't leave the taskname blank !!!");
                }
                if (txtTaskName.Text.Contains('#') || txtTaskName.Text.Contains('$')
                    || txtTaskName.Text.Contains(';') || txtDescription.Text.Contains('#')
                    || txtDescription.Text.Contains(';') || txtDescription.Text.Contains('$')) // kiểm soát chuỗi copy dán
                {
                    throw new Exception("Do not enter (# ; $) signs");
                }
                if (txtDescription.Text.Length > 100)// kiểm soát chuỗi copy dán
                {
                    throw new Exception("Description exceed 100 characters");
                }
                if (txtTaskName.Text.Length > 40)// kiểm soát chuỗi copy dán
                {
                    throw new Exception("Task name exceed 40 characters");
                }
                StreamReader stR = new StreamReader(fileName);
                String userInfo = stR.ReadToEnd();
                stR.Close();
                if (userInfo != ";") // không xử lý khi file user mới được tạo chưa có dữ liệu
                {

                    String[] mangInfo = userInfo.Split(';'); // tách 2 phần của file ra
                    String allTask = mangInfo[1]; // lấy chuỗi tất cả các task
                    String[] mangTask = allTask.Split('$'); // tách ra từng task riêng
                    String[] tpTask = mangTask[sttFix].Split('#');// lấy task muốn sửa và tách ra từng thành phần
                    String gomNhom = mangInfo[0] + ";"; // biến lưu hỗ trợ ghi file
                    if (tpTask.Length == 8) // khhông sử lý chuối rỗng
                    {
                        if (chkImportant.Checked)
                        {
                            tpTask[2] = "1";
                        }
                        else
                        {
                            tpTask[2] = "0";
                        }
                        if (dtpDueDay1.Enabled == true)
                        {
                            tpTask[6] = dtpDueDay2.Value.ToString("T") + " - " + dtpDueDay1.Value.ToString("D");
                        }
                        else
                        {
                            tpTask[6] = "";
                        }
                        tpTask[4] = "0";
                        tpTask[5] = txtTaskName.Text;
                        tpTask[7] = txtDescription.Text;
                    }
                    for (int i = 0; i < mangTask.Length - 1; i++) // tại vì mảng task sau khi tách sẽ dư 1 chuỗi có giá trị rỗng ở cuối nên lenght - 1 để bỏ qua nó
                    {
                        if (true)
                        {
                            if (i != sttFix) // ghi những task không được sửa
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
                readFileUser();
                txtTaskName.Text = "";
                txtDescription.Text = "";
                chkDueDay.Checked = false;
                chkImportant.Checked = false;
                dtpDueDay1.Enabled = false;
                btFixTask.Enabled = btCancelFix.Enabled = false;
                btCancelFix.Hide();
                btFixTask.Hide();
                btAdd.Enabled = true;
                btAdd.Show();
            }
            catch ( Exception e9)
            {

                MessageBox.Show(e9.Message);
            }
        }

        public void createTask(int isDeleted,int important,int isComple, int belongList, String task, String dueDay, String descrip) // tạo các panel ra màn hình
        {
            Panel pn = new Panel();
            CheckBox lTask = new CheckBox();
            Label lDueDay = new Label();
            Label lDescription = new Label(); 
            pn.Size = new Size(460, 125);
            if (important == 0)
            {
                pn.BackColor = Color.FromArgb(252, 235, 192);
                pn.ForeColor = Color.FromArgb(8, 64, 82);
            }
            else
            {
                pn.BackColor = Color.FromArgb(247, 102, 19);
                pn.ForeColor = Color.FromArgb(8,64,82);
            }
            Button btRemove = new Button();
            Button btFix = new Button();
            pn.Controls.Add(lDueDay);
            pn.Controls.Add(lDescription);
            pn.Controls.Add(btFix);
            pn.Controls.Add(btRemove);
            btRemove.Size = btFix.Size = new Size(40, 40);
            btRemove.Location = new Point(416, 82);
            btFix.Location = new Point(371, 82);
            if (File.Exists(Application.StartupPath + @"/Images/iconEdit.png") && File.Exists(Application.StartupPath + @"/Images/iconCancel.png"))
            {
                btFix.Image = Image.FromFile(Application.StartupPath + @"/Images/iconEdit.png");
                btRemove.Image = Image.FromFile(Application.StartupPath + @"/Images/iconCancel.png");
            }
            btRemove.Text = btFix.Text = "";
            btFix.FlatStyle = btRemove.FlatStyle = FlatStyle.Flat;
            btFix.FlatAppearance.MouseOverBackColor = btRemove.FlatAppearance.MouseOverBackColor = Color.FromArgb(122, 128, 117);
            btFix.FlatAppearance.BorderSize = btRemove.FlatAppearance.BorderSize = 0;
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
            if (isDeleted == 0) // task chưa bị xóa
            {
                if (isComple == 0) // task chưa hoàn thành
                {
                    lTask.Font = new Font(lTask.Font.FontFamily, 10, FontStyle.Bold);
                    flpTask.Controls.Add(pn);
                }
                else
                {
                    lTask.Font = new Font(lTask.Font.FontFamily, 10, FontStyle.Strikeout);
                    lTask.Checked = true;
                    flpCompleted.Controls.Add(pn);
                }
            }
            lTask.CheckedChanged += LTask_CheckedChanged;
            btFix.Click += BtFix_Click;
            btRemove.Click += BtRemove_Click;
            savePN(pn); // lưu lại để xử lý sự kiện
        }

        private void BtRemove_Click(object sender, EventArgs e) //button xóa trên mỗi task
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
            if(dR == DialogResult.OK)
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
                txtTaskName.Text = "";
                txtDescription.Text = "";
                chkDueDay.Checked = false;
                chkImportant.Checked = false;
                dtpDueDay1.Enabled = false;
                dtpDueDay2.Enabled = false;
                if (btAdd.Enabled == false)
                {
                    btFixTask.Enabled = btCancelFix.Enabled = false;
                    btCancelFix.Hide();
                    btFixTask.Hide();
                    btAdd.Enabled = true;
                    btAdd.Show();
                }    
            }    
        }

        private void BtFix_Click(object sender, EventArgs e)//button sửa trên mỗi task
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
            fixTask(count);

        }

        private void LTask_CheckedChanged(object sender, EventArgs e) //sự kiện của mỗi chk trong panel
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
                flpCompleted.Controls.Add(tamm);
                flpTask.Controls.Remove(tamm);
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
                flpCompleted.Controls.Remove(tamm);
                flpTask.Controls.Add(tamm);
                fixComplet(count);
            }

        }

        public void readFileUser() // đọc file và ghi ra màn hình
        {
            if (File.Exists(fileName))
            {
                flpTask.Controls.Clear();
                flpCompleted.Controls.Clear();
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

        public ctTask()
        {
            InitializeComponent();
        }

        private void ctTask_Load(object sender, EventArgs e)
        {
            dtpDueDay1.Enabled = false;
            dtpDueDay2.Enabled = false;
            dtpDueDay2.Format = DateTimePickerFormat.Time;
            dtpDueDay2.ShowUpDown = true;
            txtTaskName.Focus();
            readFileUser();
            chkDueDay.CheckedChanged += ChkDueDay_CheckedChanged;
            txtTaskName.KeyPress += TxtTaskName_KeyPress;
            txtDescription.KeyPress += TxtDescription_KeyPress;
        }

        private void TxtDescription_KeyPress(object sender, KeyPressEventArgs e) //kiểm soát nhập
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length >= 100 && !char.IsControl(e.KeyChar) || e.KeyChar == 35 || e.KeyChar == 36 || e.KeyChar == 59)
            {
                e.Handled = true;
            }
        }

        private void TxtTaskName_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length >= 40 && !char.IsControl(e.KeyChar) || e.KeyChar == 35 || e.KeyChar == 36 || e.KeyChar == 59) // kiểm soát nhập
            {
                e.Handled = true;
            }
        }

        private void ChkDueDay_CheckedChanged(object sender, EventArgs e) // xxử lý ẩn hiện date time picker
        {
            if (chkDueDay.Checked)
            {
                dtpDueDay1.Enabled = true;
                dtpDueDay2.Enabled = true;
            }
            else
            {
                dtpDueDay1.Enabled = false;
                dtpDueDay2.Enabled = false;
            }
        }

        private void btAdd_Click(object sender, EventArgs e) 
        {
            int isImportant = 0; // trạng thái quan  trọng
            int isComple = 0;// trạng thái hoàn tất
            int belongList = 0;// thuuộc về list nào
            int isDeleted = 0;// trạng thái đã bị xóa chưa
            String dueDay = "";
            String taskName;
            String descrip;
            try
            {
                if (txtTaskName.Text == "")
                {
                    throw new Exception("You can't leave the taskname blank !!!");
                }
                if (txtTaskName.Text.Contains('#') || txtTaskName.Text.Contains('$')
                    || txtTaskName.Text.Contains(';') || txtDescription.Text.Contains('#')
                    || txtDescription.Text.Contains(';') || txtDescription.Text.Contains('$')) // kiểm soát chuỗi copy dán
                {
                    throw new Exception("Do not enter (# ; $) signs");
                }
                if (txtDescription.Text.Length > 100)// kiểm soát chuỗi copy dán
                {
                    throw new Exception("Description exceed 100 characters");
                }
                if (txtTaskName.Text.Length > 40)// kiểm soát chuỗi copy dán
                {
                    throw new Exception("Task name exceed 40 characters");
                }
                if (File.Exists(pathSound + @"sound2.mp3"))
                {
                    sound.URL = pathSound + @"sound2.mp3";
                    sound.controls.play();
                }
                taskName = txtTaskName.Text;
                descrip = txtDescription.Text;
                if (chkImportant.Checked)
                {
                    isImportant = 1;
                }
                if (dtpDueDay1.Enabled == true)
                {
                    dueDay = dtpDueDay2.Value.ToString("T") + " - " + dtpDueDay1.Value.ToString("D");  
                }
                createTask(isDeleted,isImportant,isComple,belongList , taskName, dueDay, descrip); // tao task tren manf hinh
                if (File.Exists(fileName))
                {
                    StreamReader stR = new StreamReader(fileName);
                    String userInfo = stR.ReadToEnd();
                    stR.Close();
                    String[] mangInfo = userInfo.Split(';'); // tách bộ phận file
                    String allTask = mangInfo[1];// lấy chuối tất cả các task
                    String[] mangTask = allTask.Split('$'); // tách từng task
                    stt = mangTask.Length;// có bao nhiêu task hiện đang có để đánh stt cho task tiếp theo
                }
                if (File.Exists(fileName)) // ghi task vao file
                {
                    StreamWriter wrTask = File.AppendText(fileName);
                    wrTask.Write(stt.ToString()+"#"+isDeleted.ToString() +"#"+isImportant.ToString() + "#" + isComple.ToString() + "#" + "0" + "#" + txtTaskName.Text + "#" + dueDay + "#" + descrip + "$");
                    wrTask.Close(); 
                }
                txtTaskName.Text = "";
                txtDescription.Text = "";
                chkDueDay.Checked = false;
                chkImportant.Checked = false;
                dtpDueDay1.Enabled = false;
                dtpDueDay2.Enabled = false;
                txtTaskName.Focus();
               
            }
            catch (Exception e5)
            {

                MessageBox.Show(e5.Message);
            }
        }

    }
}
