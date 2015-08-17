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
    public partial class f2_3 : Form
    {
        public f2_3()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            fViewExample fView = new fViewExample();
            fView.Path_example = @"Examples\2\3.pdf";
            fView.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float x_A, x_B, x_D, x_C;
            float y_A, y_B, y_D, y_C;
            try
            {
                x_A = float.Parse(textBox1.Text);
                y_A = float.Parse(textBox2.Text);
                x_B = float.Parse(textBox4.Text);
                y_B = float.Parse(textBox3.Text);
                x_C = float.Parse(textBox6.Text);
                y_C = float.Parse(textBox5.Text);

            }
            catch (System.FormatException)
            {
                MessageBox.Show("Неверно заполнены поля.", "Ошибка ввода!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            x_D = (x_C - x_B) + x_A;
            y_D = y_C;
           

            string solution;
            string task;
            string given;
            string search;

            task = "Найдите координаты вершины $D$ параллелограмма $ABCD$, если $A("+x_A.ToString()+";"+y_A.ToString()+")$, $B("+x_B.ToString()+";"+y_B.ToString()+")$; $C("+x_C.ToString()+","+y_D.ToString()+")$.";
            given = "$ABCD$ -- параллелограмм, $A("+x_A.ToString()+";"+y_A.ToString()+"), B("+x_B.ToString()+";"+y_B.ToString()+"), C("+x_C.ToString()+","+y_C.ToString()+")$.";
            search = "$D(x; y)$.";
            solution = "$\\vec{AC}=\\vec{AD}+\\vec{AB} \\Rightarrow \\vec{AD}=\\vec{AC}-\\vec{AB}$ -- по свойству параллелограмма.";
            solution += " $D("+x_D.ToString()+"; "+y_D.ToString()+")$, т.к. $x=x_C-x_B="+x_D.ToString()+"; y=y_C="+y_D.ToString()+"$.";

            GeneratorTexText generator = new GeneratorTexText();
            generator.Finish(task, given, search, solution);
        }
    }
}
