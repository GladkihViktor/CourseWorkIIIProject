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
    public partial class f2_5 : Form
    {
        public f2_5()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            fViewExample fView = new fViewExample();
            fView.Path_example = @"Examples\2\5.pdf";
            fView.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float x, y, d, d1;
            try
            {
            x=float.Parse(textBox1.Text);
            y=float.Parse(textBox2.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Неверно заполнены поля.", "Ошибка ввода!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            d= x * x + y * y;
            d1 = (float)Math.Sqrt((double)(d));
           // textBox3.Text = d.ToString();
            string solution;
            string task;
            string given;
            string search;

            task = "Найдите длину вектора $\\vec{a}\\{"+x.ToString()+";"+y.ToString()+"\\}$";
            given = "$\\vec{a}\\{"+x.ToString()+";"+y.ToString()+"\\}$";
            search = "$|\\vec{a}|$.";
            solution = "$|\\vec{a}|=\\sqrt{x^2 + y^2}=\\sqrt{"+x.ToString()+"^2 + "+y.ToString()+"^2}=\\sqrt{"+(x*x).ToString()+"+"+(y*y).ToString()+"}=\\sqrt{"+d.ToString()+"}="+d1.ToString()+"$";


            GeneratorTexText generator = new GeneratorTexText();
            generator.Finish(task, given, search, solution);
        }

        

        
    }
}
