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
    public partial class f2_5_1 : Form
    {
        public f2_5_1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            fViewExample fView = new fViewExample();
            fView.Path_example = @"Examples\2\5\1.pdf";
            fView.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a, x, y;
            try
            {
                a = float.Parse(textBox1.Text);
                y = float.Parse(textBox2.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Неверно заполнены поля.", "Ошибка ввода!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            x=(float)Math.Sqrt((double)(a*a-y*y));
            string solution;
            string task;
            string given;
            string search;

            task = "Найдите $x$, если $\\vec{a}\\{x;"+y.ToString()+"\\}, |\\vec{a}|="+a.ToString()+"$";
            given = "$\\vec{a}\\{x;" + y.ToString() + "\\}, |\\vec{a}|=" + a.ToString() + "$";
            search = "$x$.";
            solution = "$|\\vec{a}|=\\sqrt{x^2+y^2} \\Rightarrow x=\\sqrt{\\vec{|a|}^2-y^2} $ $\\Rightarrow x_1=\\sqrt{"+(a*a).ToString()+"-"+(y*y).ToString()+"}="+x.ToString()+"; x_2=-"+x.ToString()+"$";


            GeneratorTexText generator = new GeneratorTexText();
            generator.Finish(task, given, search, solution);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
