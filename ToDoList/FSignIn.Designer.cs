
namespace ToDoList
{
    partial class FSignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSignIn));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.btSignIn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btSignUp = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.chkShowPass = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btQuit = new System.Windows.Forms.Button();
            this.picPass = new System.Windows.Forms.PictureBox();
            this.picUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.label1.Location = new System.Drawing.Point(66, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.label2.Location = new System.Drawing.Point(72, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "You don\'t have an account?";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(111, 183);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(275, 30);
            this.txtUserName.TabIndex = 0;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassWord.Location = new System.Drawing.Point(111, 277);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(275, 30);
            this.txtPassWord.TabIndex = 1;
            // 
            // btSignIn
            // 
            this.btSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(192)))));
            this.btSignIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(102)))), ((int)(((byte)(19)))));
            this.btSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSignIn.Location = new System.Drawing.Point(166, 363);
            this.btSignIn.Name = "btSignIn";
            this.btSignIn.Size = new System.Drawing.Size(133, 47);
            this.btSignIn.TabIndex = 2;
            this.btSignIn.Text = "Sign in";
            this.btSignIn.UseVisualStyleBackColor = false;
            this.btSignIn.Click += new System.EventHandler(this.btSignIn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.label3.Location = new System.Drawing.Point(170, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sign In";
            // 
            // btSignUp
            // 
            this.btSignUp.BackColor = System.Drawing.Color.Transparent;
            this.btSignUp.FlatAppearance.BorderSize = 0;
            this.btSignUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(102)))), ((int)(((byte)(19)))));
            this.btSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSignUp.Location = new System.Drawing.Point(289, 431);
            this.btSignUp.Name = "btSignUp";
            this.btSignUp.Size = new System.Drawing.Size(86, 32);
            this.btSignUp.TabIndex = 3;
            this.btSignUp.Text = "Sign up";
            this.btSignUp.UseVisualStyleBackColor = false;
            this.btSignUp.Click += new System.EventHandler(this.btSignUp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.label4.Location = new System.Drawing.Point(66, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Username";
            // 
            // chkShowPass
            // 
            this.chkShowPass.AutoSize = true;
            this.chkShowPass.Location = new System.Drawing.Point(111, 319);
            this.chkShowPass.Name = "chkShowPass";
            this.chkShowPass.Size = new System.Drawing.Size(128, 21);
            this.chkShowPass.TabIndex = 8;
            this.chkShowPass.Text = "Show password";
            this.chkShowPass.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ToDoList.Properties.Resources.logo3;
            this.pictureBox1.Location = new System.Drawing.Point(16, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btQuit
            // 
            this.btQuit.BackColor = System.Drawing.Color.Transparent;
            this.btQuit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(181)))), ((int)(((byte)(22)))));
            this.btQuit.FlatAppearance.BorderSize = 0;
            this.btQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(102)))), ((int)(((byte)(19)))));
            this.btQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuit.ForeColor = System.Drawing.Color.Black;
            this.btQuit.Image = global::ToDoList.Properties.Resources.iconQuit;
            this.btQuit.Location = new System.Drawing.Point(418, 2);
            this.btQuit.Name = "btQuit";
            this.btQuit.Size = new System.Drawing.Size(50, 50);
            this.btQuit.TabIndex = 9;
            this.btQuit.UseVisualStyleBackColor = false;
            this.btQuit.Click += new System.EventHandler(this.btQuit_Click);
            // 
            // picPass
            // 
            this.picPass.Location = new System.Drawing.Point(68, 277);
            this.picPass.Name = "picPass";
            this.picPass.Size = new System.Drawing.Size(35, 30);
            this.picPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPass.TabIndex = 2;
            this.picPass.TabStop = false;
            // 
            // picUser
            // 
            this.picUser.Location = new System.Drawing.Point(68, 183);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(35, 30);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUser.TabIndex = 2;
            this.picUser.TabStop = false;
            // 
            // FSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(181)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(471, 495);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btQuit);
            this.Controls.Add(this.chkShowPass);
            this.Controls.Add(this.btSignUp);
            this.Controls.Add(this.btSignIn);
            this.Controls.Add(this.picPass);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "To-Do List";
            this.Load += new System.EventHandler(this.FSignIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.PictureBox picPass;
        private System.Windows.Forms.Button btSignIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btSignUp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkShowPass;
        private System.Windows.Forms.Button btQuit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

