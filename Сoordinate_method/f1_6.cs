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
    public partial class f1_6 : Form
    {
        public f1_6()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            fViewExample fView = new fViewExample();
            fView.Path_example = @"Examples\1\6.pdf";
            fView.Show();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float x1, x2, y1, y2, x3, y3;
            try
            {
                x1 = float.Parse(textBox1.Text);
                y1 = float.Parse(textBox2.Text);
                x2 = float.Parse(textBox3.Text);
                y2 = float.Parse(textBox4.Text);
                x3 = float.Parse(textBox6.Text);
                y3 = float.Parse(textBox5.Text);
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
            string str;
            task = "Найти попарно коллинеарные векторы если: ";
            task += "$\\vec{a}\\{"+x1.ToString()+";"+y1.ToString()+"\\}; \\vec{b}\\{"+x2.ToString()+";"+y2.ToString()+"\\}; \\vec{c}\\{"+x3.ToString()+";"+y3.ToString()+"\\}$.";
            given = "$\\vec{a}\\{"+x1.ToString()+";"+y1.ToString()+"\\}; \\vec{b}\\{"+x2.ToString()+";"+y2.ToString()+"\\}; \\vec{c}\\{"+x3.ToString()+";"+y3.ToString()+"\\}$.";
            search = "\\\\ $\\vec{a}||\\vec{b}$ -- ?\\\\";
            search += "$\\vec{a}||\\vec{c}$ -- ?\\\\";
            search += "$\\vec{c}||\\vec{b}$ -- ?";
            string Message="";
            if (((x1 == y1) && (x1 == 0)) || ((x2 == y2) && (x2 == 0))) {
                Message = "коллинеарны.";
                str="=";
            }else if ((x1 * y2) == (x2 * y1))
            {
                Message = "коллинеарны.";
                str="=";
            }
            else {
                Message = "не коллинеарны.";
                str="\\neq";
            }
           solution="\\\\ $\\vec{a}||\\vec{b} \\Rightarrow \\frac{x_a}{x_b}=\\frac{y_a}{y_b}=k$ ";
           solution += " проверим: ";
           solution += "$\\frac{"+x1.ToString()+"}{"+y1.ToString()+"} "+str+" \\frac{"+x2.ToString()+"}{"+y2.ToString()+"} \\Rightarrow \\vec{a}, \\vec{b}$ -"+Message+"\\\\";


            if (((x1 == y1) && (x1 == 0)) || ((x3 == y3) && (x3 == 0)))
            {
                Message = "коллинеарны.";
                str = "=";
            }
            else if ((x1 * y3) == (x3 * y1))
            {
                Message = "коллинеарны.";
                str = "=";
            }
            else
            {
                Message = "не коллинеарны.";
                str = "\\neq";
            }
            solution += "$\\vec{a}||\\vec{c}\\Rightarrow \\frac{x_a}{x_c}=\\frac{y_a}{y_c}=k $";
            solution += " проверим: ";
            solution += "$\\frac{" + x1.ToString() + "}{" + y1.ToString() + "} " + str + " \\frac{" + x3.ToString() + "}{" + y3.ToString() + "} \\Rightarrow \\vec{a}, \\vec{b}$ -" + Message + "\\\\";

            if (((x3 == y3) && (x3 == 0)) || ((x2 == y2) && (x2 == 0)))
            {
                Message = "коллинеарны.";
                str = "=";
            }
            else if ((x3 * y2) == (x2 * y3))
            {
                Message = "коллинеарны."; 
                str = "=";
            }
            else
            {
                Message = "не коллинеарны.";
                str = "\\neq";
            }
            solution+="$\\vec{c}||\\vec{b}\\Rightarrow \\frac{x_c}{x_b}=\\frac{y_c}{y_b}=k $";
            solution += " проверим: ";
            solution += "$\\frac{" + x3.ToString() + "}{" + y3.ToString() + "} " + str + " \\frac{" + x2.ToString() + "}{" + y2.ToString() + "} \\Rightarrow \\vec{a}, \\vec{b}$ -" + Message;

            
            GeneratorTexText generator = new GeneratorTexText();
            generator.Finish(task, given, search, solution);
        }

        private void f1_6_Load(object sender, EventArgs e)
        {

        }
    }
}
