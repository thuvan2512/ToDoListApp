
namespace ToDoList
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpCategory = new System.Windows.Forms.FlowLayoutPanel();
            this.btLogOut = new System.Windows.Forms.Button();
            this.lbMark = new System.Windows.Forms.Label();
            this.btAddCategory = new System.Windows.Forms.Button();
            this.btDeleted = new System.Windows.Forms.Button();
            this.btNote = new System.Windows.Forms.Button();
            this.btImportant = new System.Windows.Forms.Button();
            this.btTaskAndCompleted = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbHour = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tmSystemTime = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btRefresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btHide = new System.Windows.Forms.Button();
            this.btQuit = new System.Windows.Forms.Button();
            this.ctNote1 = new ToDoList.ctNote();
            this.ctCategoryMain = new ToDoList.ctCategory();
            this.ctImportantMain = new ToDoList.ctImportant();
            this.ctDeletedMain = new ToDoList.ctDeleted();
            this.ctTaskMain = new ToDoList.ctTask();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.flpCategory);
            this.panel1.Controls.Add(this.btLogOut);
            this.panel1.Controls.Add(this.lbMark);
            this.panel1.Controls.Add(this.btAddCategory);
            this.panel1.Controls.Add(this.btDeleted);
            this.panel1.Controls.Add(this.btNote);
            this.panel1.Controls.Add(this.btImportant);
            this.panel1.Controls.Add(this.btTaskAndCompleted);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbUserName);
            this.panel1.Controls.Add(this.lbHour);
            this.panel1.Controls.Add(this.lbDate);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 762);
            this.panel1.TabIndex = 0;
            // 
            // flpCategory
            // 
            this.flpCategory.AutoScroll = true;
            this.flpCategory.Location = new System.Drawing.Point(19, 571);
            this.flpCategory.Name = "flpCategory";
            this.flpCategory.Size = new System.Drawing.Size(337, 167);
            this.flpCategory.TabIndex = 6;
            // 
            // btLogOut
            // 
            this.btLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(192)))));
            this.btLogOut.FlatAppearance.BorderSize = 0;
            this.btLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(181)))), ((int)(((byte)(22)))));
            this.btLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogOut.Location = new System.Drawing.Point(19, 114);
            this.btLogOut.Margin = new System.Windows.Forms.Padding(0);
            this.btLogOut.Name = "btLogOut";
            this.btLogOut.Size = new System.Drawing.Size(86, 29);
            this.btLogOut.TabIndex = 5;
            this.btLogOut.Text = "Log Out";
            this.btLogOut.UseVisualStyleBackColor = false;
            this.btLogOut.Click += new System.EventHandler(this.btLogOut_Click);
            // 
            // lbMark
            // 
            this.lbMark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(181)))), ((int)(((byte)(22)))));
            this.lbMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbMark.Location = new System.Drawing.Point(0, 190);
            this.lbMark.Margin = new System.Windows.Forms.Padding(0);
            this.lbMark.Name = "lbMark";
            this.lbMark.Size = new System.Drawing.Size(16, 65);
            this.lbMark.TabIndex = 4;
            // 
            // btAddCategory
            // 
            this.btAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(192)))));
            this.btAddCategory.FlatAppearance.BorderSize = 0;
            this.btAddCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(181)))), ((int)(((byte)(22)))));
            this.btAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.btAddCategory.Image = global::ToDoList.Properties.Resources.iconPlus2;
            this.btAddCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAddCategory.Location = new System.Drawing.Point(61, 513);
            this.btAddCategory.Margin = new System.Windows.Forms.Padding(0);
            this.btAddCategory.Name = "btAddCategory";
            this.btAddCategory.Size = new System.Drawing.Size(261, 43);
            this.btAddCategory.TabIndex = 3;
            this.btAddCategory.Text = "ADD NEW LIST";
            this.btAddCategory.UseVisualStyleBackColor = false;
            this.btAddCategory.Click += new System.EventHandler(this.btAddCategory_Click);
            // 
            // btDeleted
            // 
            this.btDeleted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(192)))));
            this.btDeleted.FlatAppearance.BorderSize = 0;
            this.btDeleted.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(181)))), ((int)(((byte)(22)))));
            this.btDeleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.btDeleted.Image = global::ToDoList.Properties.Resources.iconArtboard_1;
            this.btDeleted.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDeleted.Location = new System.Drawing.Point(16, 409);
            this.btDeleted.Margin = new System.Windows.Forms.Padding(0);
            this.btDeleted.Name = "btDeleted";
            this.btDeleted.Size = new System.Drawing.Size(354, 65);
            this.btDeleted.TabIndex = 3;
            this.btDeleted.Text = "          DELETED";
            this.btDeleted.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDeleted.UseVisualStyleBackColor = false;
            this.btDeleted.Click += new System.EventHandler(this.btDeleted_Click);
            // 
            // btNote
            // 
            this.btNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(192)))));
            this.btNote.FlatAppearance.BorderSize = 0;
            this.btNote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(181)))), ((int)(((byte)(22)))));
            this.btNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.btNote.Image = global::ToDoList.Properties.Resources.iconArtboard_3;
            this.btNote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNote.Location = new System.Drawing.Point(16, 336);
            this.btNote.Margin = new System.Windows.Forms.Padding(0);
            this.btNote.Name = "btNote";
            this.btNote.Size = new System.Drawing.Size(354, 65);
            this.btNote.TabIndex = 3;
            this.btNote.Text = "          NOTE";
            this.btNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNote.UseVisualStyleBackColor = false;
            this.btNote.Click += new System.EventHandler(this.btNote_Click);
            // 
            // btImportant
            // 
            this.btImportant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(192)))));
            this.btImportant.FlatAppearance.BorderSize = 0;
            this.btImportant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(181)))), ((int)(((byte)(22)))));
            this.btImportant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btImportant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btImportant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.btImportant.Image = global::ToDoList.Properties.Resources.iconArtboard_4;
            this.btImportant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btImportant.Location = new System.Drawing.Point(16, 263);
            this.btImportant.Margin = new System.Windows.Forms.Padding(0);
            this.btImportant.Name = "btImportant";
            this.btImportant.Size = new System.Drawing.Size(354, 65);
            this.btImportant.TabIndex = 3;
            this.btImportant.Text = "          IMPORTANT";
            this.btImportant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btImportant.UseVisualStyleBackColor = false;
            this.btImportant.Click += new System.EventHandler(this.btImportant_Click);
            // 
            // btTaskAndCompleted
            // 
            this.btTaskAndCompleted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(192)))));
            this.btTaskAndCompleted.FlatAppearance.BorderSize = 0;
            this.btTaskAndCompleted.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(181)))), ((int)(((byte)(22)))));
            this.btTaskAndCompleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTaskAndCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTaskAndCompleted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.btTaskAndCompleted.Image = global::ToDoList.Properties.Resources.iconArtboard_2;
            this.btTaskAndCompleted.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTaskAndCompleted.Location = new System.Drawing.Point(16, 190);
            this.btTaskAndCompleted.Margin = new System.Windows.Forms.Padding(0);
            this.btTaskAndCompleted.Name = "btTaskAndCompleted";
            this.btTaskAndCompleted.Size = new System.Drawing.Size(354, 65);
            this.btTaskAndCompleted.TabIndex = 3;
            this.btTaskAndCompleted.Text = "          TASK AND COMPLETED";
            this.btTaskAndCompleted.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTaskAndCompleted.UseVisualStyleBackColor = false;
            this.btTaskAndCompleted.Click += new System.EventHandler(this.btTaskAndCompleted_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(181)))), ((int)(((byte)(22)))));
            this.label6.Location = new System.Drawing.Point(1, 497);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(370, 5);
            this.label6.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(181)))), ((int)(((byte)(22)))));
            this.label2.Location = new System.Drawing.Point(0, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(370, 5);
            this.label2.TabIndex = 2;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(181)))), ((int)(((byte)(22)))));
            this.lbUserName.Location = new System.Drawing.Point(114, 29);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(85, 29);
            this.lbUserName.TabIndex = 1;
            this.lbUserName.Text = "label1";
            // 
            // lbHour
            // 
            this.lbHour.AutoSize = true;
            this.lbHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(192)))));
            this.lbHour.Location = new System.Drawing.Point(111, 125);
            this.lbHour.Name = "lbHour";
            this.lbHour.Size = new System.Drawing.Size(103, 20);
            this.lbHour.TabIndex = 1;
            this.lbHour.Text = "12:45:54 AM";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(192)))));
            this.lbDate.Location = new System.Drawing.Point(111, 97);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(154, 20);
            this.lbDate.TabIndex = 1;
            this.lbDate.Text = "15 September 2021";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ToDoList.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(19, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tmSystemTime
            // 
            this.tmSystemTime.Interval = 1000;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ToDoList.Properties.Resources.logo5;
            this.pictureBox2.Location = new System.Drawing.Point(400, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(237, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // btRefresh
            // 
            this.btRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(181)))), ((int)(((byte)(22)))));
            this.btRefresh.FlatAppearance.BorderSize = 0;
            this.btRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(102)))), ((int)(((byte)(19)))));
            this.btRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRefresh.ForeColor = System.Drawing.Color.Black;
            this.btRefresh.Image = global::ToDoList.Properties.Resources.iconRefresh22;
            this.btRefresh.Location = new System.Drawing.Point(1383, 0);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(49, 44);
            this.btRefresh.TabIndex = 10;
            this.btRefresh.UseVisualStyleBackColor = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(181)))), ((int)(((byte)(22)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(102)))), ((int)(((byte)(19)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::ToDoList.Properties.Resources.iconsetting;
            this.button1.Location = new System.Drawing.Point(643, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 45);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btHide
            // 
            this.btHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btHide.BackColor = System.Drawing.Color.Transparent;
            this.btHide.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(181)))), ((int)(((byte)(22)))));
            this.btHide.FlatAppearance.BorderSize = 0;
            this.btHide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(102)))), ((int)(((byte)(19)))));
            this.btHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHide.ForeColor = System.Drawing.Color.Black;
            this.btHide.Image = global::ToDoList.Properties.Resources.iconArtboard_2_copy;
            this.btHide.Location = new System.Drawing.Point(1332, -1);
            this.btHide.Name = "btHide";
            this.btHide.Size = new System.Drawing.Size(45, 45);
            this.btHide.TabIndex = 10;
            this.btHide.UseVisualStyleBackColor = false;
            this.btHide.Click += new System.EventHandler(this.btHide_Click);
            // 
            // btQuit
            // 
            this.btQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btQuit.BackColor = System.Drawing.Color.Transparent;
            this.btQuit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(181)))), ((int)(((byte)(22)))));
            this.btQuit.FlatAppearance.BorderSize = 0;
            this.btQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(102)))), ((int)(((byte)(19)))));
            this.btQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuit.ForeColor = System.Drawing.Color.Black;
            this.btQuit.Image = global::ToDoList.Properties.Resources.iconArtboard_4_copy;
            this.btQuit.Location = new System.Drawing.Point(1438, 0);
            this.btQuit.Name = "btQuit";
            this.btQuit.Size = new System.Drawing.Size(45, 45);
            this.btQuit.TabIndex = 10;
            this.btQuit.UseVisualStyleBackColor = false;
            this.btQuit.Click += new System.EventHandler(this.btQuit_Click);
            // 
            // ctNote1
            // 
            this.ctNote1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(181)))), ((int)(((byte)(22)))));
            this.ctNote1.Location = new System.Drawing.Point(373, 56);
            this.ctNote1.Name = "ctNote1";
            this.ctNote1.Size = new System.Drawing.Size(1116, 694);
            this.ctNote1.TabIndex = 19;
            // 
            // ctCategoryMain
            // 
            this.ctCategoryMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(181)))), ((int)(((byte)(22)))));
            this.ctCategoryMain.Location = new System.Drawing.Point(374, 55);
            this.ctCategoryMain.Name = "ctCategoryMain";
            this.ctCategoryMain.Size = new System.Drawing.Size(1116, 695);
            this.ctCategoryMain.TabIndex = 18;
            // 
            // ctImportantMain
            // 
            this.ctImportantMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(181)))), ((int)(((byte)(22)))));
            this.ctImportantMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.ctImportantMain.Location = new System.Drawing.Point(374, 55);
            this.ctImportantMain.Name = "ctImportantMain";
            this.ctImportantMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctImportantMain.Size = new System.Drawing.Size(1116, 695);
            this.ctImportantMain.TabIndex = 17;
            // 
            // ctDeletedMain
            // 
            this.ctDeletedMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ctDeletedMain.AutoScroll = true;
            this.ctDeletedMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(181)))), ((int)(((byte)(22)))));
            this.ctDeletedMain.Location = new System.Drawing.Point(374, 47);
            this.ctDeletedMain.Name = "ctDeletedMain";
            this.ctDeletedMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctDeletedMain.Size = new System.Drawing.Size(1116, 691);
            this.ctDeletedMain.TabIndex = 16;
            // 
            // ctTaskMain
            // 
            this.ctTaskMain.AutoScroll = true;
            this.ctTaskMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(181)))), ((int)(((byte)(22)))));
            this.ctTaskMain.Location = new System.Drawing.Point(374, 55);
            this.ctTaskMain.Name = "ctTaskMain";
            this.ctTaskMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctTaskMain.Size = new System.Drawing.Size(1109, 695);
            this.ctTaskMain.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(181)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(1497, 754);
            this.Controls.Add(this.ctNote1);
            this.Controls.Add(this.ctCategoryMain);
            this.Controls.Add(this.ctImportantMain);
            this.Controls.Add(this.ctDeletedMain);
            this.Controls.Add(this.ctTaskMain);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btHide);
            this.Controls.Add(this.btQuit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btQuit;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbHour;
        private System.Windows.Forms.Button btHide;
        private System.Windows.Forms.Button btTaskAndCompleted;
        private System.Windows.Forms.Label lbMark;
        private System.Windows.Forms.Button btDeleted;
        private System.Windows.Forms.Button btNote;
        private System.Windows.Forms.Button btImportant;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer tmSystemTime;
        private System.Windows.Forms.Button btLogOut;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ctTask ctTaskMain;
        private ctDeleted ctDeletedMain;
        private ctImportant ctImportantMain;
        private System.Windows.Forms.Button btAddCategory;
        private System.Windows.Forms.FlowLayoutPanel flpCategory;
        private ctCategory ctCategoryMain;
        private System.Windows.Forms.Button btRefresh;
        private ctNote ctNote1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}