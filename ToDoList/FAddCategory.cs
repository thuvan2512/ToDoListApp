using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class FAddCategory : Form
    {
        public static String nameCategory;
        public static int flag = 0;
        public void addCate()
        {
            try
            {
                if (txtNameCategory.Text == "")
                {
                    throw new Exception("You can't leave it blank !!!");
                }
                flag = 1;
                nameCategory = txtNameCategory.Text;
                Close();
            }
            catch (Exception e3)
            {

                MessageBox.Show(e3.Message);
            }
        }
        public FAddCategory()
        {
            InitializeComponent();
        }
        private void FAddCategory_Load(object sender, EventArgs e)
        {
            txtNameCategory.Focus();
            txtNameCategory.KeyPress += TxtNameCategory_KeyPress;
        }

        private void TxtNameCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNameCategory.Text.Length >= 15 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNameCategory.Text.Contains('#') || txtNameCategory.Text.Contains('.') || txtNameCategory.Text.Contains('/')) // kiểm soát chuỗi copy dán
                {
                    throw new Exception("Do not enter (# . /) signs");
                }
                if (txtNameCategory.Text.Length > 15)// kiểm soát chuỗi copy dán
                {
                    throw new Exception("Category name exceed 100 characters");
                }
                addCate();
            }
            catch (Exception ex1)
            {

                MessageBox.Show(ex1.Message);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    try
                    {
                        if (txtNameCategory.Text.Contains('#') || txtNameCategory.Text.Contains('.')) // kiểm soát chuỗi copy dán
                        {
                            throw new Exception("Do not enter (# .) signs");
                        }
                        if (txtNameCategory.Text.Length > 15)// kiểm soát chuỗi copy dán
                        {
                            throw new Exception("Category name exceed 100 characters");
                        }
                        addCate();
                    }
                    catch (Exception ex1)
                    {

                        MessageBox.Show(ex1.Message);
                    }
                    return true;
                case Keys.Escape:
                    Close();  
                    return true;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}
