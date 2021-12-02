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

namespace ToDoList
{
    public partial class FSetting : Form
    {
        public static int flagOffNofi = 0;
        public static int flagAutoComplete = 0;
        public FSetting()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            if (File.Exists(Application.StartupPath + @"/Setting/read.txt"))
            {
                StreamReader streamReader = new StreamReader(Application.StartupPath + @"/Setting/read.txt");
                String mangTam = streamReader.ReadToEnd();
                streamReader.Close();
                String[] mangSetting = mangTam.Split('#');
                flagOffNofi = int.Parse(mangSetting[0]);
                flagAutoComplete = int.Parse(mangSetting[1]);
            }
        }
        private void FSetting_Load(object sender, EventArgs e)
        {
            if(flagOffNofi !=0)
            {
                chkTurnOffNofi.Checked = true;
            }
            else
            {
                chkTurnOffNofi.Checked = false;
            }    
            if(flagAutoComplete != 0)
            {
                chkAutoComplete.Checked = true;
            }   
            else
            {
                chkAutoComplete.Checked = false;
            }    
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (chkTurnOffNofi.Checked == true)
            {
                flagOffNofi = 1;
            }
            else
            {
                flagOffNofi = 0;
            }
            if (chkAutoComplete.Checked == true)
            {
                flagAutoComplete = 1;
            }
            else
            {
                flagAutoComplete = 0;
            }
            StreamWriter streamWriter = new StreamWriter(Application.StartupPath + @"/Setting/read.txt");
            streamWriter.Write(flagOffNofi.ToString() + "#" + flagAutoComplete.ToString());
            streamWriter.Close();
            Hide();
        }
    }
}
