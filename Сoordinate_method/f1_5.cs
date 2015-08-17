using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сoordinate_method
{
    public partial class f1_5 : Form
    {
        public f1_5()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            fViewExample fView = new fViewExample();
            fView.Path_example = @"Examples\1\5.pdf";
            fView.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float x, y, k;
            try
            {
                x = float.Parse(textBox1.Text);
                y = float.Parse(textBox2.Text);
                k = float.Parse(textBox3.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Неверно заполнены поля.", "Ошибка ввода!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            textBox4.Text = (k * x).ToString();
            textBox5.Text = (k * y).ToString();
        }
    }
}
