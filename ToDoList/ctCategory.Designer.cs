
namespace ToDoList
{
    partial class ctCategory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.chkImportant = new System.Windows.Forms.CheckBox();
            this.chkDueDay = new System.Windows.Forms.CheckBox();
            this.groupBoxCompleted = new System.Windows.Forms.GroupBox();
            this.flpCompleted = new System.Windows.Forms.FlowLayoutPanel();
            this.btAdd = new System.Windows.Forms.Button();
            this.dtpDueDay1 = new System.Windows.Forms.DateTimePicker();
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.flpTask = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.lbCateName = new System.Windows.Forms.Label();
            this.dtpDueDay2 = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxCompleted.SuspendLayout();
            this.groupBoxTask.SuspendLayout();
            this.flpTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkImportant
            // 
            this.chkImportant.AutoSize = true;
            this.chkImportant.Location = new System.Drawing.Point(741, 175);
            this.chkImportant.Name = "chkImportant";
            this.chkImportant.Size = new System.Drawing.Size(18, 17);
            this.chkImportant.TabIndex = 18;
            this.chkImportant.UseVisualStyleBackColor = true;
            // 
            // chkDueDay
            // 
            this.chkDueDay.AutoSize = true;
            this.chkDueDay.Location = new System.Drawing.Point(127, 175);
            this.chkDueDay.Name = "chkDueDay";
            this.chkDueDay.Size = new System.Drawing.Size(18, 17);
            this.chkDueDay.TabIndex = 23;
            this.chkDueDay.UseVisualStyleBackColor = true;
            // 
            // groupBoxCompleted
            // 
            this.groupBoxCompleted.Controls.Add(this.flpCompleted);
            this.groupBoxCompleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCompleted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.groupBoxCompleted.Location = new System.Drawing.Point(566, 219);
            this.groupBoxCompleted.Name = "groupBoxCompleted";
            this.groupBoxCompleted.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxCompleted.Size = new System.Drawing.Size(516, 452);
            this.groupBoxCompleted.TabIndex = 20;
            this.groupBoxCompleted.TabStop = false;
            this.groupBoxCompleted.Text = "Completed";
            // 
            // flpCompleted
            // 
            this.flpCompleted.AutoScroll = true;
            this.flpCompleted.Location = new System.Drawing.Point(8, 30);
            this.flpCompleted.Name = "flpCompleted";
            this.flpCompleted.Size = new System.Drawing.Size(497, 412);
            this.flpCompleted.TabIndex = 1;
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(192)))));
            this.btAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.btAdd.Location = new System.Drawing.Point(842, 161);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(238, 41);
            this.btAdd.TabIndex = 22;
            this.btAdd.Text = "Add New Task";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // dtpDueDay1
            // 
            this.dtpDueDay1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.dtpDueDay1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(192)))));
            this.dtpDueDay1.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.dtpDueDay1.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(192)))));
            this.dtpDueDay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDueDay1.Location = new System.Drawing.Point(153, 169);
            this.dtpDueDay1.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtpDueDay1.Name = "dtpDueDay1";
            this.dtpDueDay1.Size = new System.Drawing.Size(224, 28);
            this.dtpDueDay1.TabIndex = 21;
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.flpTask);
            this.groupBoxTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.groupBoxTask.Location = new System.Drawing.Point(34, 219);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxTask.Size = new System.Drawing.Size(516, 452);
            this.groupBoxTask.TabIndex = 19;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Task";
            // 
            // flpTask
            // 
            this.flpTask.AutoScroll = true;
            this.flpTask.Controls.Add(this.flowLayoutPanel1);
            this.flpTask.Location = new System.Drawing.Point(8, 30);
            this.flpTask.Name = "flpTask";
            this.flpTask.Size = new System.Drawing.Size(497, 412);
            this.flpTask.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.label4.Location = new System.Drawing.Point(568, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Mark important";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.label3.Location = new System.Drawing.Point(30, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Due day";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.label2.Location = new System.Drawing.Point(566, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.label1.Location = new System.Drawing.Point(34, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "New task";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(192)))));
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(691, 102);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDescription.Size = new System.Drawing.Size(391, 30);
            this.txtDescription.TabIndex = 13;
            // 
            // txtTaskName
            // 
            this.txtTaskName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(192)))));
            this.txtTaskName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskName.Location = new System.Drawing.Point(153, 104);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTaskName.Size = new System.Drawing.Size(386, 30);
            this.txtTaskName.TabIndex = 12;
            // 
            // lbCateName
            // 
            this.lbCateName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCateName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.lbCateName.Location = new System.Drawing.Point(216, 24);
            this.lbCateName.Name = "lbCateName";
            this.lbCateName.Size = new System.Drawing.Size(725, 46);
            this.lbCateName.TabIndex = 14;
            this.lbCateName.Text = "Category";
            this.lbCateName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpDueDay2
            // 
            this.dtpDueDay2.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.dtpDueDay2.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(192)))));
            this.dtpDueDay2.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.dtpDueDay2.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(192)))));
            this.dtpDueDay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDueDay2.Location = new System.Drawing.Point(396, 169);
            this.dtpDueDay2.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtpDueDay2.Name = "dtpDueDay2";
            this.dtpDueDay2.Size = new System.Drawing.Size(143, 28);
            this.dtpDueDay2.TabIndex = 21;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ctCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(181)))), ((int)(((byte)(22)))));
            this.Controls.Add(this.chkImportant);
            this.Controls.Add(this.chkDueDay);
            this.Controls.Add(this.groupBoxCompleted);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.dtpDueDay2);
            this.Controls.Add(this.dtpDueDay1);
            this.Controls.Add(this.groupBoxTask);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbCateName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTaskName);
            this.Name = "ctCategory";
            this.Size = new System.Drawing.Size(1116, 695);
            this.Load += new System.EventHandler(this.ctCategory_Load);
            this.groupBoxCompleted.ResumeLayout(false);
            this.groupBoxTask.ResumeLayout(false);
            this.flpTask.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkImportant;
        private System.Windows.Forms.CheckBox chkDueDay;
        private System.Windows.Forms.GroupBox groupBoxCompleted;
        private System.Windows.Forms.FlowLayoutPanel flpCompleted;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.DateTimePicker dtpDueDay1;
        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.FlowLayoutPanel flpTask;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.Label lbCateName;
        private System.Windows.Forms.DateTimePicker dtpDueDay2;
        private System.Windows.Forms.Timer timer1;
    }
}
