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
    public partial class f2_4_2 : Form
    {
        public f2_4_2()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            fViewExample fView = new fViewExample();
            fView.Path_example = @"Examples\2\4\2.pdf";
            fView.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float x_A, x_B, x_AB;
            float y_A, y_B, y_AB;
            try
            {
                x_AB = float.Parse(textBox1.Text);
                y_AB = float.Parse(textBox2.Text);
                x_A = float.Parse(textBox4.Text);
                y_A = float.Parse(textBox3.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Неверно заполнены поля.", "Ошибка ввода!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            x_B = x_AB + x_A;
            y_B = y_AB + y_A;
            string solution;
            string task;
            string given;
            string search;

            task = "Найдите координаты конца вектора $\\vec{AB}$, если известно, что: $\\vec{AB}\\{" + x_AB.ToString() + ";" + y_AB.ToString() + "\\}$; $A(" + x_A.ToString() + ";" + y_A.ToString() + ")$.";
            given = "$\\vec{AB}\\{" + x_AB.ToString() + ";" + y_AB.ToString() + "\\}$; $A(" + x_A.ToString() + ";" + y_A.ToString() + ")$.";
            search = "Координаты $B$.";
            solution = "Так как $\\vec{AB}=\\{x_B-x_A; y_B-y_A\\}$,то $x_B=x_{AB}+x_A; y_B=y_{AB}+y_A$";
            solution += "$\\Rightarrow x_B="+x_AB.ToString()+" + "+x_A.ToString()+" ="+x_B.ToString()+"; y_B="+y_AB.ToString()+" +"+y_A.ToString()+"="+y_B.ToString()+"$";

            GeneratorTexText generator = new GeneratorTexText();
            generator.Finish(task, given, search, solution);
        }
    }
}
