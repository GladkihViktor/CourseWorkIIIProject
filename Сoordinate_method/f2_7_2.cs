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
    public partial class f2_7_2 : Form
    {
        public f2_7_2()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            fViewExample fView = new fViewExample();
            fView.Path_example = @"Examples\2\7\2.pdf";
            fView.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            float x_A, x_B, y_A, y_B1, y_B2, AB;
            try
            {
                x_A = float.Parse(textBox1.Text);
                y_A = float.Parse(textBox2.Text);
                x_B = float.Parse(textBox4.Text);
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
            task = "Найдите $y$, если известно что: $|\\vec{AB}|="+AB.ToString()+"; A("+x_A.ToString()+"; "+y_A.ToString()+"); B("+x_B.ToString()+"; y)$.";
            given = "$|\\vec{AB}|=" + AB.ToString() + "; A(" + x_A.ToString() + "; " + y_A.ToString() + "); B(" + x_B.ToString() + "; y)$.";
            search = "$y$";
            solution = "Так как $|\\vec{AB}|=\\sqrt{(x_B-x_A)^2+(y_B-y_A)^2}$, то \\\\";
            solution += "$" + AB.ToString() + "=\\sqrt{(" + x_B.ToString() + "-" + x_A.ToString() + ")^2+(y-" + y_A.ToString() + ")^2} \\Rightarrow " + AB.ToString() + "=\\sqrt{" + ((x_B - x_A) * (x_B - x_A)).ToString() + " + (y-" + y_A.ToString() + ")^2} \\Rightarrow " + (AB * AB).ToString() + " = " + ((x_B - x_A) * (x_B - x_A)).ToString() + " + (y-" + y_A.ToString() + ")^2 \\Rightarrow $\\\\";
            string str = "";
            float t;
            t = -x_B * x_B + 2 * x_B * x_A - x_A * x_A + AB * AB;
            if (t < 0)
            {
                str = "Действительных корней нет!";
                solution += str;
            }
            else
            {
                t = (float)Math.Sqrt((double)(t));
                y_B1 = y_A - t;
                y_B2 = y_A + t;

                solution += "$y_1= " + y_B1.ToString() + "; y_2=" + y_B2.ToString() + "$"; 
            }
            
           
            
            GeneratorTexText generator = new GeneratorTexText();
            generator.Finish(task, given, search, solution);
        
        }

        
    }
}
