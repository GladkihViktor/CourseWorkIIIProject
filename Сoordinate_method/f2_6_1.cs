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
    public partial class f2_6_1 : Form
    {
        public f2_6_1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            fViewExample fView = new fViewExample();
            fView.Path_example = @"Examples\2\6\1.pdf";
            fView.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float x_A, x_B, x_C, x_D;
            float y_A, y_B, y_C, y_D;
            try
            {
                x_A = float.Parse(textBox1.Text);
                y_A = float.Parse(textBox2.Text);
                x_B = float.Parse(textBox4.Text);
                y_B = float.Parse(textBox3.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Неверно заполнены поля.", "Ошибка ввода!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            x_C = 2 * x_B - x_A;
            y_C = 2 * y_B - x_A;
            string solution;
            string task;
            string given;
            string search;

            task = "Даны точки $A(" + x_A.ToString() + ";" + y_A.ToString() + ")$ и $B(" + x_B.ToString() + ";" + y_B.ToString() + ")$. Найдите координаты точки $C$, если известно, что точка $B$ -- середина отрезка $AC$.";
            given = "$A(" + x_A.ToString() + ";" + y_A.ToString() + ");  B(" + x_B.ToString() + ";" + y_B.ToString() + ")$; $B \\in AC: AB=BC$; $D \\in BC: BD=DC$.";
            search = "Координаты $C$.";
            solution = "Так как $B$ -- середина $AC$, то $x_C=2 \\cdot x_B - x_A; y_C=2 \\cdot y_B - y_A \\Rightarrow$ \\\\";
            solution += "$x_C=2 \\cdot "+x_B.ToString()+" - "+x_A.ToString()+" = "+x_C.ToString()+"; y_C=2 \\cdot "+y_B.ToString()+" -"+y_A.ToString()+"= "+y_C.ToString()+"$";
            GeneratorTexText generator = new GeneratorTexText();
            generator.Finish(task, given, search, solution);
        }
    }
}
