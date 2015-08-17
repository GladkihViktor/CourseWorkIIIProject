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
    public partial class f2_5_2 : Form
    {
        public f2_5_2()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            fViewExample fView = new fViewExample();
            fView.Path_example = @"Examples\2\5\2.pdf";
            fView.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a, x, y;
            try
            {
                a = float.Parse(textBox1.Text);
                x = float.Parse(textBox2.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Неверно заполнены поля.", "Ошибка ввода!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            y = (float)Math.Sqrt((double)(a * a - x * x));
            string solution;
            string task;
            string given;
            string search;

            task = "Найдите $y$, если $\\vec{a}\\{"+x.ToString()+"; y \\}, |\\vec{a}|=" + a.ToString() + "$";
            given = "$\\vec{a}\\{" + x.ToString() + "; y \\}, |\\vec{a}|=" + a.ToString() + "$";
            search = "$y$.";
            solution = "$|\\vec{a}|=\\sqrt{x^2+y^2} \\Rightarrow y=\\sqrt{\\vec{|a|}^2-x^2} $ $\\Rightarrow y_1=\\sqrt{" + (a * a).ToString() + "-" + (x * x).ToString() + "}=" + y.ToString() + "; y_2=-" + y.ToString() + "$";
            GeneratorTexText generator = new GeneratorTexText();
            generator.Finish(task, given, search, solution);
        }
    }
}
