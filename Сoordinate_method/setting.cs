using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Сoordinate_method
{
    public partial class setting : Form
    {
        public setting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
                fViewExample exampleForm = new fViewExample();
                exampleForm.Path_example = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
