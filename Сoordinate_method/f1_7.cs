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
    public partial class f1_7 : Form
    {
        public f1_7()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            fViewExample fView = new fViewExample();
            fView.Path_example = @"Examples\1\7.pdf";
            fView.Show();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float n, t, m, p, x, y;
            x = 1;
            y = 1;
            
            try
            {
                n = float.Parse(textBox1.Text);
                t = float.Parse(textBox2.Text);
                m = float.Parse(textBox3.Text);
                p = float.Parse(textBox4.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Неверно заполнены поля.", "Ошибка ввода!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (t == 0)
                {
                    x = 0;
                    throw new System.DivideByZeroException();
                }
                else
                {
                    x = (-n) / t;
                   
                }
            }
            catch (System.DivideByZeroException)
            {
                x=0;
             }

            try
            {
                if (p == 0)
                {
                    y = 0;
                    throw new System.DivideByZeroException();
                }
                else
                {
                    y = (-m) / p;
                    
                }

            }
            catch (System.DivideByZeroException)
            {
                y = 0;
            }


            string solution;
            string task;
            string given;
            string search;
         
            task = "Векторы $\\vec{a}$ и $\\vec{b}$ не коллинеарны. Найдите числа $x$ и $y$, удовлетворяющие равенству: $"+n.ToString()+"\\vec{a}+"+t.ToString()+"x\\vec{a}+"+m.ToString()+"\\vec{b}+"+p.ToString()+"y\\vec{b}=0$.";
            given = "$"+n.ToString() + "\\vec{a}+" + t.ToString() + "x\\vec{a}+" + m.ToString() + "\\vec{b}+" + p.ToString() + "y\\vec{b}=0$;\\\\";
            given += "$n="+n.ToString()+"; t="+t.ToString()+"; m="+m.ToString()+"; p="+p.ToString()+"$";
            search = "$x, y$";
            solution = "Так как $\\vec{a}$ и $\\vec{b}$ не коллинеарны, то ";
            solution += "$("+n.ToString()+"+"+t.ToString()+"x)\\vec{a}+("+m.ToString()+"+"+p.ToString()+"y)\\vec{b}=\\vec{0}";
            solution += "\\Leftrightarrow$\\\\";
            solution += "$" + n.ToString() + "+" + t.ToString() + "x=0; " + m.ToString() + "+" + p.ToString() + "y=0;$";
            solution += " $x="+x.ToString()+"; y="+y.ToString()+".$";
         
            GeneratorTexText generator = new GeneratorTexText();
            generator.Finish(task, given, search, solution);

               
                
            
            
            
        }
    }
}
