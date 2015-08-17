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
    public partial class f2_7 : Form
    {
        public f2_7()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            fViewExample fView = new fViewExample();
            fView.Path_example = @"Examples\2\7.pdf";
            fView.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float x_A, x_B, y_A, y_B;
            float d;
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
            d = (float)Math.Sqrt((double)((x_B - x_A) * (x_B - x_A) + (y_B - y_A) * (y_B - y_A)));
            //textBox5.Text = d.ToString();
            string solution;
            string task;
            string given;
            string search;
            
            task = "Найдите расстояние между точками $A$ и $B$, если: $A("+x_A.ToString()+";"+y_A.ToString()+")$; $B("+x_B.ToString()+";"+y_B.ToString()+")$";
            given = "$A("+x_A.ToString()+";"+y_A.ToString()+")$; $B("+x_B.ToString()+";"+y_B.ToString()+")$";
            search = "$AB$.";
            solution = "$AB=\\sqrt{(x_B-x_A)^2+(y_B-y_A)^2}=\\sqrt{("+x_B.ToString()+"-"+x_A.ToString()+")^2+("+y_B.ToString()+"-"+y_A.ToString()+")^2}="+d.ToString()+"$;";
            GeneratorTexText generator = new GeneratorTexText();
            generator.Finish(task, given, search, solution);
        }
    }
}
