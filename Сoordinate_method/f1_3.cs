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
    public partial class f1_3 : Form
    {
        public f1_3()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            fViewExample fView = new fViewExample();
            fView.Path_example = @"Examples\1\3.pdf";
            fView.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float x, y;
           try {
                x = float.Parse(textBox1.Text);
                y = float.Parse(textBox2.Text);
            }
            catch (System.FormatException) {
                MessageBox.Show("Неверно указаны i и j.", "Ошибка ввода!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
           else {
               str = "+";
           }
           task = " Найдите разложение по координатным векторам $\\vec{i}$ и $\\vec{j}$ вектора $\\vec{x}\\{"+x.ToString()+"; "+y.ToString()+"\\}$.";
           given = "$\\vec{x}\\{"+x.ToString()+"; "+y.ToString()+"\\}$.";
           search = "$\\vec{x}=x_1\\vec{i}+x_2\\vec{j}$";
           solution = "Так как $\\vec{x}=x_1\\cdot\\vec{i}+x_2\\cdot\\vec{j}$, где $x_1="+x.ToString()+"; x_2="+y.ToString()+"$, то $\\vec{x}="+x.ToString()+"\\vec{i}"+str+y.ToString()+"\\vec{j}$";
           
           GeneratorTexText generator = new GeneratorTexText();
           generator.Finish(task, given, search, solution);
        
        }
    }
}
