using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 懒人程序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // string EXE_path = path.Text;
            string s = AppDomain.CurrentDomain.BaseDirectory;
            string EXE_path = s.Substring(0, s.LastIndexOf("Debug")) + "AlcoStop.exe";
            System.Diagnostics.Process.Start(@""+EXE_path+"");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                path.Text = file.FileName;
            }
        }
    }
}
