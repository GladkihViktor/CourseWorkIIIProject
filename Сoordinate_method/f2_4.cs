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
    public partial class f2_4 : Form
    {
        public f2_4()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            fViewExample fView = new fViewExample();
            fView.Path_example = @"Examples\2\4.pdf";
            fView.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            float x_A, x_B;
            float y_A, y_B;
            float x, y;
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
            x = x_B - x_A;
            y = y_B - y_A;
           


            string solution;
            string task;
            string given;
            string search;

            task = "Найдите координаты вектора $\\vec{AB}$, если известны координаты его начала и конца: $A("+x_A.ToString()+";"+y_A.ToString()+")$; $B("+x_B.ToString()+","+y_B.ToString()+")$.";
            given = "$A("+x_A.ToString()+";"+y_A.ToString()+"), B("+x_B.ToString()+","+y_B.ToString()+")$";
            search = "$\\vec{AB}$.";
            solution = "Так как $\\vec{AB}=\\{x_B-x_A; y_B-y_A\\}=\\{"+x_B.ToString()+"-"+x_A.ToString()+"; "+y_B.ToString()+"-"+y_A.ToString()+"\\}=\\{"+x.ToString()+";"+y.ToString()+"\\}$";
           

            GeneratorTexText generator = new GeneratorTexText();
            generator.Finish(task, given, search, solution);
        
        }
    }
}
