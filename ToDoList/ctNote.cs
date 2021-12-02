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
    public partial class ctNote : UserControl
    {
        List<Panel> termsPN = new List<Panel>();
        List<Label> termsPN2 = new List<Label>();
        String path = Application.StartupPath + @"\Images\txt_icon.png";
        public ctNote()
        {
            InitializeComponent();
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
        private void ctNote_Load(object sender, EventArgs e)
        {
            Init();
            chkTime.Checked = true;
            rtbContent.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, rtbContent.Width, rtbContent.Height, 25, 25));
            rtbContent.Text += "\n \t";
            treeView.ImageList = imageList1;
            if (treeView.Nodes.Count >= 2)
            {
                treeView.Nodes[1].Expand();
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "";
            rtbContent.Text = "";
            treeView.SelectedNode = null;
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
        private void btSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDL = new SaveFileDialog();
            saveDL.DefaultExt = "note";
            saveDL.Filter = "Text File (*.txt)|*.txt|Rich Text File (*.rtf)|*.rft|XML file (*.xml)|*.xml";
            saveDL.Title = "Where do you want to save this note?";
            String date = DateTime.Now.ToString("f");
            if (saveDL.ShowDialog() == DialogResult.OK)
            {
                StreamWriter stw = new StreamWriter(saveDL.FileName);
                if (chkTime.Checked == true)
                {
                    if (txtTitle.Text != "")
                    {
                        stw.WriteLine("Title: " + txtTitle.Text);
                        stw.WriteLine("Initialization date: " + date);
                        stw.Write("\n" + rtbContent.Text);
                        stw.Close();
                    }
                    else
                    {
                        stw.WriteLine("Initialization date: " + date);
                        stw.Write("\n" + rtbContent.Text);
                        stw.Close();
                    }
                }
                else
                {
                    if (txtTitle.Text != "")
                    {
                        stw.WriteLine("Title: " + txtTitle.Text);
                        stw.Write("\n" + rtbContent.Text);
                        stw.Close();

                    }
                    else
                    {
                        stw.Write(rtbContent.Text);
                        stw.Close();
                    }
                }
                if (FSetting.flagOffNofi == 0)
                {
                    if (txtTitle.Text != "")
                    {
                        showBalloon("Note \"" + txtTitle.Text + "\" has been saved", DateTime.Now.ToString("F"));
                    }
                    else
                    {
                        showBalloon("Note \"Unknow\" has been saved", DateTime.Now.ToString("F"));
                    }     
                }
                treeView.Nodes.Clear();
                Init();
                if (treeView.Nodes.Count >= 2)
                {
                    treeView.Nodes[1].Expand(); 
                }
            }
        }
        private void Init()
        {
            string[] drives = Directory.GetLogicalDrives();
            foreach (string drive in drives)
            {
                TreeNode node = new TreeNode();
                node.Text = drive;
                node.Nodes.Add("tam");
                treeView.Nodes.Add(node);
            }
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            try
            {
                
                TreeNode node = e.Node;
                node.Nodes.Clear();
                string[] directories = Directory.GetDirectories(node.FullPath);
                String [] files = Directory.GetFiles(node.FullPath);
                if (files.Length > 0)
                {
                    foreach (string item in files)
                    {
                        if (item.ToLower().EndsWith(".txt"))
                        {
                            TreeNode n = new TreeNode();
                            n.Text = Path.GetFileName(item);
                            n.ImageIndex = 1;
                            node.Nodes.Add(n);

                        }
                    }
                }
                foreach (string item in directories)
                {
                    TreeNode n = new TreeNode();  
                    n.Text = Path.GetFileName(item);
                    n.Nodes.Add("tam");
                    node.Nodes.Add(n);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                termsPN.Clear();
                termsPN2.Clear();
                flpFileNote.Controls.Clear();

                TreeNode node;
                String[] files;

                node = e.Node;
                if (!node.FullPath.ToLower().EndsWith(".txt"))
                {
                    files = Directory.GetFiles(node.FullPath);
                    if (files.Length > 0)
                    {
                        flpFileNote.Controls.Clear();
                        foreach (string item in files)
                        {
                            if (item.ToLower().EndsWith(".txt"))
                            {
                                TaopicureBox(item);
                            }
                        }
                    } 
                }
                else
                {
                    StreamReader streamReader = new StreamReader(node.FullPath);
                    String chuoiTam = streamReader.ReadToEnd();
                    rtbContent.Text = chuoiTam;
                    streamReader.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Error !!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void TaopicureBox(String text)
        {
            PictureBox pic;
            Panel pn = new Panel();
            Label lb = new Label();
            Label lb2 = new Label();
            lb2.Text = text;
            lb.Text = Path.GetFileName(text);
            lb.Location = new Point(7, 117);
            lb.Size = new Size(162, 51);
            lb.AutoSize = false;
            lb.AutoSize = false;
            lb.ForeColor = Color.FromArgb(8, 64, 82);
            lb.TextAlign = ContentAlignment.MiddleCenter;
            lb.Font = new Font("Arial", 8, FontStyle.Bold);
            pn.Size = new Size(172, 171);
            pic = new PictureBox();
            pic.Size = new Size(165, 108);
            pic.Location = new Point(3,3);
            pic.Image = Image.FromFile(path);
            pn.Controls.Add(pic);
            pn.Controls.Add(lb);
            lb2.Hide();
            pn.Controls.Add(lb2);
            termsPN.Add(pn);
            termsPN2.Add(lb2);
            pic.Click += Pn_Click1;
            flpFileNote.Controls.Add(pn);
        }

        private void Pn_Click1(object sender, EventArgs e)
        {
            foreach (Panel item1 in termsPN)
            {
                item1.BackColor = Color.FromArgb(245, 181, 22);
            }
            PictureBox pic = (PictureBox)sender;
            foreach (Panel item1 in termsPN)
            {
                if (item1.Contains(pic))
                {
                    item1.BackColor = Color.FromArgb(247, 102, 19);
                    foreach (Label item2 in termsPN2)
                    {
                        if (item1.Contains(item2))
                        {
                            StreamReader streamReader = new StreamReader(item2.Text);
                            String chuoiTam = streamReader.ReadToEnd();
                            rtbContent.Text = chuoiTam;
                            streamReader.Close();
                            break;
                        }
                    }
                   
                }
            }
        }

    }
}
