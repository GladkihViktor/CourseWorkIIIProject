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
    public partial class f1_2 : Form
    {
        public f1_2()
        {
            InitializeComponent();
           
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            fViewExample fView = new fViewExample();
            fView.Path_example = @"Examples\1\2.pdf";
            fView.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float x;
            float y;
            try
            {
                x = float.Parse(textBox1.Text);
                y = float.Parse(textBox2.Text);
            }
            catch (System.FormatException) {
                MessageBox.Show("Неверно указаны коэффициенты при (i) и (j).", "Ошибка ввода!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //textBox3.Text = x.ToString();
            //textBox4.Text = y.ToString();
        
        // вывод данных
            string solution;
            string task;
            string given;
            string search;
            string str;
            if (y < 0)
            {
                str = " ";
            }
            else
            {
                str = "+";
            }
            task = " Найдите координаты вектора $\\vec{a}=" + x.ToString() + "\\vec{i}"+str + y.ToString() + "\\vec{j}$.";
            given = "$\\vec{a}="+x.ToString()+"\\vec{i}"+str+y.ToString()+"\\vec{j}$";
            search = "$\\vec{a}\\{x;y\\}$";
            solution = "Так как $\\vec{a}="+x.ToString()+"\\vec{i}"+str+y.ToString()+"\\vec{j}$, то $x="+x.ToString()+", y="+y.ToString();
            solution+=" \\Rightarrow \\vec{a} \\{"+x.ToString()+"; "+y.ToString()+"\\}$";

            GeneratorTexText generator = new GeneratorTexText();
            generator.Finish(task, given, search, solution);
           
            
        }
    }
}
