
namespace ToDoList
{
    partial class ctNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctNote));
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.chkTime = new System.Windows.Forms.CheckBox();
            this.btClear = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.treeView = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.flpFileNote = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.rtbContent);
            this.groupBoxTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.groupBoxTask.Location = new System.Drawing.Point(359, 103);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxTask.Size = new System.Drawing.Size(729, 356);
            this.groupBoxTask.TabIndex = 10;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Note";
            // 
            // rtbContent
            // 
            this.rtbContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(192)))));
            this.rtbContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbContent.Location = new System.Drawing.Point(7, 25);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(716, 325);
            this.rtbContent.TabIndex = 0;
            this.rtbContent.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.label5.Location = new System.Drawing.Point(382, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(192)))));
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(472, 16);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTitle.Size = new System.Drawing.Size(389, 30);
            this.txtTitle.TabIndex = 0;
            // 
            // chkTime
            // 
            this.chkTime.AutoSize = true;
            this.chkTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.chkTime.Location = new System.Drawing.Point(906, 48);
            this.chkTime.Name = "chkTime";
            this.chkTime.Size = new System.Drawing.Size(117, 29);
            this.chkTime.TabIndex = 11;
            this.chkTime.Text = "Time pin";
            this.chkTime.UseVisualStyleBackColor = true;
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(192)))));
            this.btClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.btClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.btClear.Location = new System.Drawing.Point(472, 61);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(166, 36);
            this.btClear.TabIndex = 15;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(192)))));
            this.btSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.btSave.Location = new System.Drawing.Point(678, 61);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(183, 36);
            this.btSave.TabIndex = 15;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(181)))), ((int)(((byte)(22)))));
            this.treeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.treeView.Location = new System.Drawing.Point(0, 3);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(343, 689);
            this.treeView.TabIndex = 17;
            this.treeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder_icon (1).png");
            this.imageList1.Images.SetKeyName(1, "txt_icon.png");
            // 
            // flpFileNote
            // 
            this.flpFileNote.AutoScroll = true;
            this.flpFileNote.Location = new System.Drawing.Point(352, 461);
            this.flpFileNote.Name = "flpFileNote";
            this.flpFileNote.Size = new System.Drawing.Size(761, 184);
            this.flpFileNote.TabIndex = 18;
            // 
            // ctNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(181)))), ((int)(((byte)(22)))));
            this.Controls.Add(this.flpFileNote);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.chkTime);
            this.Controls.Add(this.groupBoxTask);
            this.Name = "ctNote";
            this.Size = new System.Drawing.Size(1116, 695);
            this.Load += new System.EventHandler(this.ctNote_Load);
            this.groupBoxTask.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.CheckBox chkTime;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.FlowLayoutPanel flpFileNote;
    }
}
