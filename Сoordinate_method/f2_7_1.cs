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
    public partial class f2_7_1 : Form
    {
        public f2_7_1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            fViewExample fView = new fViewExample();
            fView.Path_example = @"Examples\2\7\1.pdf";
            fView.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float x_A1, x_A2, x_B, y_A, y_B, AB;
            try
            {
                x_B = float.Parse(textBox1.Text);
                y_B = float.Parse(textBox2.Text);
                y_A = float.Parse(textBox4.Text);
                AB = float.Parse(textBox3.Text);
                if (AB < 0)
                {
                    throw new System.FormatException();
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Неверно заполнены поля.", "Ошибка ввода!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string solution;
            string task;
            string given;
            string search;
            task = "Найдите $x$, если известно что: $|\\vec{AB}|=" + AB.ToString() + "; A(x; " + y_A.ToString() + "); B(" + x_B.ToString() + "; " + y_B.ToString() + ")$.";
            given = "$|\\vec{AB}|=" + AB.ToString() + "; A(x; " + y_A.ToString() + "); B(" + x_B.ToString() + "; " + y_B.ToString() + ")$.";
            search = "$ x$.";
            solution = "Так как $|\\vec{AB}|=\\sqrt{(x_B-x_A)^2+(y_B-y_A)^2}$, то \\\\";
            solution += "$" + AB.ToString() + "=\\sqrt{(" + x_B.ToString() + "-x)^2+(" + y_B.ToString() + "-" + y_A.ToString() + ")^2} \\Rightarrow " + AB.ToString() + "=\\sqrt{(" + y_B.ToString() + "-x)^2+" + ((y_B - y_A) * (y_B - y_A)).ToString() + "} \\Rightarrow " + (AB * AB).ToString() + " = (" + y_B.ToString() + "-x)^2+" + ((y_B - y_A) * (y_B - y_A)).ToString() + " \\Rightarrow $\\\\";
            
            string str = "";
            float t = -y_A * y_A + AB * AB - y_B * y_B + 2 * y_B * y_A;
            
            if (t < 0)
            {
                str = "Действительных корней нет!";
                solution += str;
            } else
            {
                t = (float)Math.Sqrt((double)(t));
                x_A1 = x_B - t;
                x_A2 = x_B + t;
                solution += "$x_1= " + x_A1.ToString() + "; x_2=" + x_A2.ToString() + "$";

            }


            GeneratorTexText generator = new GeneratorTexText();
            generator.Finish(task, given, search, solution);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
