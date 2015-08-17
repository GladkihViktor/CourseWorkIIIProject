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
    
    public partial class f1_1 : Form
    {
      
        public f1_1()
        {
            InitializeComponent();
            
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            fViewExample fView = new fViewExample();
            fView.Path_example = @"Examples\1\1.pdf";
            fView.Show();
        }

        private void f1_1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool vector=false; // не соноправленны
            float k, m, n;
            m = 0; n = 1;
            try
            {
                m = float.Parse(textBox1.Text);
                n = float.Parse(textBox2.Text);
                if (n == 0)
                {
                    MessageBox.Show("Деление на 0 не возможно, измените n.", "Ошибка ввода!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new System.DivideByZeroException();

                }
                else if (m < 0 || n < 0) {
                    MessageBox.Show("Длина вектора не может быть меньше 0.", "Ошибка ввода!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new System.Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Неверно указаны m и n.", "Ошибка ввода!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (checkBox1.Checked == true)
            {
                vector = true;
                k = m / n;
            }
            else
            {
                vector = false;
                //k = (-1) * (m / n);
                k = m / n;
            }
// вывод данных
            string solution;
            string task;
            string given;
            string search;
            if (vector == true)
            {
                given = "$\\vec{n}=\\vec{m}k, |\\vec{m}|="+m.ToString()+", |\\vec{n}|="+n.ToString()+", \\vec{m}\\uparrow\\uparrow\\vec{n}$";
                task = "Найдите такое число $k$, чтобы выполнялось равенство $\\vec{n}=k\\vec{m}$, если известно что";
                task += " Векторы $\\vec{m}$ и $\\vec{n}$ сонаправлены и $|\\vec{m}|=" + m.ToString() + "$,  $|\\vec{n}|=" + n.ToString() + "$.";
                search = "$k$";
                solution = "Так как $\\vec{n}=\\vec{m}k$,то $|\\vec{n}|=|\\vec{m}||k|\\Rightarrow |k|=\\frac{|\\vec{n}|}{|\\vec{m}|}$\\\\";
                solution += "$|k|=\\frac{" + n.ToString() + "}{" + m.ToString() + "}=" + k.ToString() + "$.";
                solution += "Так как $\\vec{m} \\uparrow\\uparrow \\vec{n}$, то $k>0 \\Rightarrow k=" + k.ToString() + "$";
            }
            else {
                given = "$\\vec{n}=\\vec{m}k, |\\vec{m}|=" + m.ToString() + ", |\\vec{n}|=" + n.ToString() + ", \\vec{m}\\uparrow\\downarrow\\vec{n}$";
                task = "Найдите такое число $k$, чтобы выполнялось равенство $\\vec{n}=k\\vec{m}$, если известно что";
                task += " Векторы $\\vec{m}$ и $\\vec{n}$ противоположно направлены и $|\\vec{m}|=" + m.ToString() + "$,  $|\\vec{n}|=" + n.ToString() + "$.";
                search = "$k$";
                solution = "Так как $\\vec{n}=\\vec{m}k$,то $|\\vec{n}|=|\\vec{m}||k|\\Rightarrow |k|=\\frac{|\\vec{n}|}{|\\vec{m}|}$\\\\";
                solution += "$|k|=\\frac{" + n.ToString() + "}{" + m.ToString() + "}=" + k.ToString() + "$.";
                solution += "Так как $\\vec{m} \\uparrow\\downarrow \\vec{n}$, то $k<0 \\Rightarrow k= -" + k.ToString() + "$";
            }

            GeneratorTexText generator = new GeneratorTexText();
            generator.Finish(task, given, search, solution);
                
        }
        

        }
            
    }    
    
   

