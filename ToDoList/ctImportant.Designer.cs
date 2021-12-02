
namespace ToDoList
{
    partial class ctImportant
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
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.flpTaskImportant = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flpTaskImpoComple = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxTask.SuspendLayout();
            this.flpTaskImportant.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flpTaskImpoComple.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.flpTaskImportant);
            this.groupBoxTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.groupBoxTask.Location = new System.Drawing.Point(36, 43);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxTask.Size = new System.Drawing.Size(516, 627);
            this.groupBoxTask.TabIndex = 10;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Important Task ";
            // 
            // flpTaskImportant
            // 
            this.flpTaskImportant.AutoScroll = true;
            this.flpTaskImportant.Controls.Add(this.flowLayoutPanel1);
            this.flpTaskImportant.Location = new System.Drawing.Point(8, 36);
            this.flpTaskImportant.Name = "flpTaskImportant";
            this.flpTaskImportant.Size = new System.Drawing.Size(497, 572);
            this.flpTaskImportant.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flpTaskImpoComple);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.groupBox1.Location = new System.Drawing.Point(570, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(516, 627);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Important Task Completed";
            // 
            // flpTaskImpoComple
            // 
            this.flpTaskImpoComple.AutoScroll = true;
            this.flpTaskImpoComple.Controls.Add(this.flowLayoutPanel3);
            this.flpTaskImpoComple.Location = new System.Drawing.Point(8, 36);
            this.flpTaskImpoComple.Name = "flpTaskImpoComple";
            this.flpTaskImpoComple.Size = new System.Drawing.Size(497, 572);
            this.flpTaskImpoComple.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // ctImportant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(181)))), ((int)(((byte)(22)))));
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxTask);
            this.Name = "ctImportant";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1116, 695);
            this.Load += new System.EventHandler(this.ctImportant_Load);
            this.groupBoxTask.ResumeLayout(false);
            this.flpTaskImportant.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flpTaskImpoComple.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.FlowLayoutPanel flpTaskImportant;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flpTaskImpoComple;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
    }
}
