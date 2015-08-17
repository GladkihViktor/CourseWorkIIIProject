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
    public partial class f2_6 : Form
    {
        public f2_6()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            fViewExample fView = new fViewExample();
            fView.Path_example = @"Examples\2\6.pdf";
            fView.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float x_A, x_B, x_C, x_D;
            float y_A, y_B, y_C, y_D;
            try
            {
                x_A = float.Parse(textBox1.Text);
                y_A = float.Parse(textBox2.Text);
                x_C = float.Parse(textBox4.Text);
                y_C = float.Parse(textBox3.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Неверно заполнены поля.", "Ошибка ввода!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            x_B = (x_C + x_A) /2;
            y_B = (y_C + y_A) / 2;



            string solution;
            string task;
            string given;
            string search;

            task = "Даны точки $A("+x_A.ToString()+";"+y_A.ToString()+")$ и $C("+x_C.ToString()+";"+y_C.ToString()+")$. Найдите координаты точки $B$, если известно, что точка $B$ -- середина отрезка $AC$.";
            given = "$A(" + x_A.ToString() + ";" + y_A.ToString() + ");  C(" + x_C.ToString() + ";" + y_C.ToString() + ")$; $B \\in AC: AB=BC$; $D \\in BC: BD=DC$.";
            search = "Координаты $B$.";
            solution = "Так как $B$ -- середина $AC$, то $x_B=\\frac{x_C+x_A}{2}; y_B=\\frac{y_C+y_A}{2} \\Rightarrow$ \\\\";
            solution += "$x_B=\\frac{"+x_C.ToString()+"+"+x_A.ToString()+"}{2}="+x_B.ToString()+"; y_B=\\frac{"+y_C.ToString()+"+"+y_A.ToString()+"}{2}="+y_B.ToString()+"$";
            GeneratorTexText generator = new GeneratorTexText();
            generator.Finish(task, given, search, solution);
        }
    }
}
