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
using System.Runtime.InteropServices;
namespace ToDoList
{
    public partial class ctDeleted : UserControl
    {
        List<Panel> termsPN = new List<Panel>(); // lưu tất cả các panel
        List<Panel> termsPNCate = new List<Panel>();
        List<Panel> termsPNTaskInCate = new List<Panel>();
        public static String pathFileUser = Application.StartupPath + @"/TaskUser/";
        String fileName = pathFileUser + FSignIn.codeReadFile.ToString() + "-" + FSignIn.userName + ".txt";// tên file user
        String pathCate = Application.StartupPath + @"/Categories/";
        public void savePN(Panel tam)
        {
            termsPN.Add(tam);
        } // lưu trữ quản lý panel để xử lý sự kiện
        public void createTask(int isDeleted, int important, int isComple, int belongList, String task, String dueDay, String descrip) // tạo các panel ra màn hình
        {
            Panel pn = new Panel();
            Label lTask = new Label();
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
                pn.ForeColor = Color.FromArgb(8, 64, 82);
            }
            Button btRemove = new Button();
            Button btRecovery = new Button();
            pn.Controls.Add(lDueDay);
            pn.Controls.Add(lDescription);
            pn.Controls.Add(btRecovery);
            pn.Controls.Add(btRemove);
            btRemove.Size = btRecovery.Size = new Size(45, 45);
            btRemove.Location = new Point(410, 78);
            btRecovery.Location = new Point(365, 78);
            if (File.Exists(Application.StartupPath + @"/Images/iconUndo.png") && File.Exists(Application.StartupPath + @"/Images/iconCancel.png"))
            {
                btRecovery.Image = Image.FromFile(Application.StartupPath + @"/Images/iconUndo.png");
                btRemove.Image = Image.FromFile(Application.StartupPath + @"/Images/iconCancel.png");
            }
            btRemove.Text = btRecovery.Text = "";
            btRecovery.FlatStyle = btRemove.FlatStyle = FlatStyle.Flat;
            btRecovery.FlatAppearance.MouseOverBackColor = btRemove.FlatAppearance.MouseOverBackColor = Color.FromArgb(122, 128, 117);
            btRecovery.FlatAppearance.BorderSize = btRemove.FlatAppearance.BorderSize = 0;
            pn.Controls.Add(lTask);
            pn.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pn.Width, pn.Height, 15, 15));
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
            if (isDeleted == 1) // task đã bị xóa
            {
                lTask.Font = new Font(lTask.Font.FontFamily, 10, FontStyle.Bold);
                flpTaskDeleted.Controls.Add(pn);
            }
            savePN(pn); // lưu lại để xử lý sự kiện
            btRecovery.Click += BtRecovery_Click;
            btRemove.Click += BtRemove_Click;
        }

        public void createCate(String nameCate, String isDeleted)
        {
            Panel pn = new Panel();
            Label lTask = new Label();
            pn.Size = new Size(460, 94);
            pn.BackColor = Color.FromArgb(252, 235, 192);
            pn.ForeColor = Color.FromArgb(8, 64, 82);
            Button btRemoveC = new Button();
            Button btRecoveryC = new Button();
            pn.Controls.Add(btRecoveryC);
            pn.Controls.Add(btRemoveC);
            btRemoveC.Size = btRecoveryC.Size = new Size(45, 45);
            btRemoveC.Location = new Point(412, 48);
            btRecoveryC.Location = new Point(361, 49);
            if (File.Exists(Application.StartupPath + @"/Images/iconUndo.png") && File.Exists(Application.StartupPath + @"/Images/iconCancel.png"))
            {
                btRecoveryC.Image = Image.FromFile(Application.StartupPath + @"/Images/iconUndo.png");
                btRemoveC.Image = Image.FromFile(Application.StartupPath + @"/Images/iconCancel.png");
            }
            btRemoveC.Text = btRecoveryC.Text = "";
            btRecoveryC.FlatStyle = btRemoveC.FlatStyle = FlatStyle.Flat;
            btRecoveryC.FlatAppearance.MouseOverBackColor = btRemoveC.FlatAppearance.MouseOverBackColor = Color.FromArgb(122, 128, 117);
            btRecoveryC.FlatAppearance.BorderSize = btRemoveC.FlatAppearance.BorderSize = 0;
            pn.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pn.Width, pn.Height, 15, 15));
            pn.Controls.Add(lTask);
            lTask.Text = nameCate;
            lTask.Location = new Point(3, 3);
            lTask.AutoSize = false;
            lTask.Size = new Size(450, 30);
            lTask.Font = new Font(lTask.Font.FontFamily, 10, FontStyle.Bold);
            if (isDeleted == "1") // task đã bị xóa
            {
                flpCateDeleted.Controls.Add(pn);
            }
            termsPNCate.Add(pn); // lưu lại để xử lý sự kiện
            btRecoveryC.Click += BtRecoveryC_Click;
            btRemoveC.Click += BtRemoveC_Click;
        }
        public void createTaskinCate(int isDeleted, int important, int isComple, String belongList, String task, String dueDay, String descrip)
        {
            Panel pn = new Panel();
            Label lTask = new Label();
            Label lDueDay = new Label();
            Label lDescription = new Label();
            Label lCate = new Label();
            pn.Size = new Size(460, 125);
            if (important == 0)
            {
                pn.BackColor = Color.FromArgb(252, 235, 192);
                pn.ForeColor = Color.FromArgb(8, 64, 82);
            }
            else
            {
                pn.BackColor = Color.FromArgb(247, 102, 19);
                pn.ForeColor = Color.FromArgb(8, 64, 82);
            }
            lCate.Text = belongList;
            lCate.Location = new Point(3, 3);
            lCate.Font = new Font(lCate.Font.FontFamily, 8, FontStyle.Italic);
            pn.Controls.Add(lDueDay);
            pn.Controls.Add(lDescription);
            pn.Controls.Add(lTask);
            pn.Controls.Add(lCate);
            pn.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pn.Width, pn.Height, 15, 15));
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
            if (isDeleted == 0) // task chuaw bị xóa
            {
                lTask.Font = new Font(lTask.Font.FontFamily, 10, FontStyle.Bold);
                flpTaskInCate.Controls.Add(pn);
            }
        }

        private void BtRemoveC_Click(object sender, EventArgs e)
        {
            Panel tamm = new Panel();
            Button bt = (Button)sender;
            int count = -1;
            foreach (Panel item in termsPNCate)
            {
                count++;
                if (item.Contains(bt))
                {
                    tamm = item;
                    break;
                }
            }
            DialogResult dR = MessageBox.Show("Are you sure you want to delete this category? You will not be able to recover it !!!", "To-Do List", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
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
                            ghiFile += "2#" + manTam2[1] + "$";
                            if (File.Exists(path + "/" + (count + 1).ToString() + "-" + manTam2[1] + ".txt"))
                            {
                                StreamWriter stW3 = new StreamWriter(path + "/" + (count + 1).ToString() + "-" + manTam2[1] + ".txt");
                                stW3.Close(); 
                            }
                        }
                    }
                    StreamWriter stW = new StreamWriter(path + "/read.txt");
                    stW.Write(ghiFile);
                    stW.Close();
                }
                readFileUser();
            }
        }

        private void BtRecoveryC_Click(object sender, EventArgs e)
        {
            Panel tamm = new Panel();
            Button bt = (Button)sender;
            int count = -1;
            foreach (Panel item in termsPNCate)
            {
                count++;
                if (item.Contains(bt))
                {
                    tamm = item;
                    break;
                }
            }
            DialogResult dR = MessageBox.Show("Are you sure you want to recover this category ?", "To-Do List", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
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
                            ghiFile += "0#" + manTam2[1] + "$";
                        }
                    }
                    StreamWriter stW = new StreamWriter(path + "/read.txt");
                    stW.Write(ghiFile);
                    stW.Close();
                }
                readFileUser();
            }

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
            DialogResult dR = MessageBox.Show("Are you sure you want to delete? You will not be able to recover it !!!", "To-Do List", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
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
                        tpTask[1] = "2";
                        tpTask[4] = "0";
                        tpTask[5] = "";
                        tpTask[6] = "";
                        tpTask[7] = "";
                    }
                    for (int i = 0; i < mangTask.Length - 1; i++) // tại vì mảng task sau khi tách sẽ dư 1 chuỗi có giá trị rỗng ở cuối nên lenght - 1 để bỏ qua nó
                    {
                        if (true)
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
                    }
                    StreamWriter stW = new StreamWriter(fileName);
                    stW.Write(gomNhom);
                    stW.Close();
                }
                readFileUser();
            }
        }

        private void BtRecovery_Click(object sender, EventArgs e)
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
            DialogResult dR = MessageBox.Show("Are you sure you want to recover this task?", "To-Do List", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
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
                        tpTask[1] = "0";
                        tpTask[4] = "0";
                    }
                    for (int i = 0; i < mangTask.Length - 1; i++) // tại vì mảng task sau khi tách sẽ dư 1 chuỗi có giá trị rỗng ở cuối nên lenght - 1 để bỏ qua nó
                    {
                        if (true)
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
                    }
                    StreamWriter stW = new StreamWriter(fileName);
                    stW.Write(gomNhom);
                    stW.Close();
                }
                readFileUser();
            }
        }

        public void readFileUser() // đọc file và ghi ra màn hình
        {
            if (File.Exists(fileName))
            {
                flpTaskDeleted.Controls.Clear();
                flpCateDeleted.Controls.Clear();
                flpTaskInCate.Controls.Clear();
                termsPN = new List<Panel>();
                termsPNCate = new List<Panel>();
                termsPNTaskInCate = new List<Panel>();
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
                                createCate(tam[1], tam[0]);
                                if (tam[0] == "1")
                                {
                                    if (File.Exists(path + "/" + (i + 1).ToString() + "-" + tam[1] + ".txt"))
                                    {
                                        StreamReader strmR = new StreamReader(path + "/" + (i + 1).ToString() + "-" + tam[1] + ".txt");
                                        String taskInCate = strmR.ReadToEnd();
                                        strmR.Close();
                                        if (userInfo != "")
                                        {
                                            String[] mangTIC = taskInCate.Split('$');
                                            foreach (String item in mangTIC)
                                            {
                                                String[] mangtam = item.Split('#');
                                                if (mangtam.Length == 8)
                                                {
                                                    int isDeleted = int.Parse(mangtam[1]);
                                                    int isImportant = int.Parse(mangtam[2]);
                                                    int isComple = int.Parse(mangtam[3]);
                                                    String dueDate = mangtam[6];
                                                    String taskName = mangtam[5];
                                                    String description = mangtam[7];
                                                    createTaskinCate(isDeleted, isImportant, isComple, tam[1] , taskName, dueDate, description);
                                                }
                                            }
                                        }
                                    }
                                }


                            }
                        }
                    }
                }
            }
        }
        public ctDeleted()
        {
            InitializeComponent();
        }
        private void ctDeleted_Load(object sender, EventArgs e)
        {
            readFileUser();
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


    }
}
