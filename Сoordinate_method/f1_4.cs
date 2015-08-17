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
    public partial class f1_4 : Form
    {
        float x_a, y_a, x_b, y_b, sumX, sumY, alpha, beta;

        public float Beta
        {
            get { return beta; }
            set { beta = value; }
        }

        public float Alpha
        {
            get { return alpha; }
            set { alpha = value; }
        }

        public float SumX
        {
            get { return sumX; }
            set { sumX = value; }
        }

        public float Y_b
        {
            get { return y_b; }
            set { y_b = value; }
        }

        public float SumY
        {
            get { return sumY; }
            set { sumY = value; }
        }

        public float X_b
        {
            get { return x_b; }
            set { x_b = value; }
        }

        public float Y_a
        {
            get { return y_a; }
            set { y_a = value; }
        }

        public float X_a
        {
            get { return x_a; }
            set { x_a = value; }
        }
      
        public f1_4()
        {
            InitializeComponent();
            label7.Text = String.Format("{0}=", (char)945);
            label8.Text = String.Format("{0}=", (char)946); 
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            fViewExample fView = new fViewExample();
            fView.Path_example = @"Examples\1\4.pdf";
            fView.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (readXaYaXbYb() == true)
            {
                SumX = Alpha*X_a +Beta*X_b;
                SumY = Alpha*Y_a + Beta*Y_b;
                groupBox3.Text = "Координаты вектора (a + b)";
                // вывод данных
                string solution;
                string task;
                string given;
                string search;
                task = " Найдите координаты вектора: ";
                task += "$\\alpha\\vec{a}+\\beta\\vec{b}$, если $\\vec{a}\\{" + X_a.ToString() + ";" + Y_a.ToString() + "\\}; \\vec{b}\\{" + X_b.ToString() + ";" + Y_b.ToString() + "\\};\\\\ \\alpha= " + Alpha.ToString() + "; \\beta =" + Beta.ToString() + ";$";
                
                given = " $\\vec{a}\\{" + X_a.ToString() + ";" + Y_a.ToString() + "\\}; \\vec{b}\\{" + X_b.ToString() + ";" + Y_b.ToString() + "\\}; \\alpha= " + Alpha.ToString() + "; \\beta =" + Beta.ToString() + "$.";
                
                search = "$\\alpha\\vec{a}+\\beta\\vec{b}$";
                
                solution = "Так как $\\vec{a}\\{" + X_a.ToString() + "; " + Y_a.ToString() + "\\}, \\vec{b}\\{" + X_b.ToString() + "; " + Y_b.ToString() + "\\}:\\\\$";
                
                solution += "$\\alpha\\vec{a}=\\{" + X_a.ToString() + "\\cdot\\alpha; " + Y_a.ToString() + "\\cdot\\alpha\\}=\\{" + X_a.ToString() + "\\cdot" + Alpha.ToString() + "; " + Y_a.ToString() + "\\cdot" + Alpha.ToString() + "\\}= \\{" + (Alpha * X_a).ToString() + "; " + (Alpha * Y_a).ToString() + "\\}$;\\\\";
                
                solution += "$\\beta\\vec{b}=\\{" + X_b.ToString() + "\\cdot\\beta; " + Y_b.ToString() + "\\cdot\\beta\\}=\\{" + X_b.ToString() + "\\cdot" + Beta.ToString() + "; " + Y_b.ToString() + "\\cdot" + Beta.ToString() + "\\}= \\{" + (Beta * X_b).ToString() + "; " + (Beta * Y_b).ToString() + "\\}$;\\\\";
                
                solution += "$(\\alpha\\vec{a}+\\beta\\vec{b})\\{"+(Alpha * X_a).ToString()+"+"+(Beta * X_b).ToString()+"; "+(Alpha * Y_a).ToString()+"+"+(Beta * Y_b).ToString()+"\\}=("+Alpha.ToString()+"\\vec{a}+"+Beta.ToString()+"\\vec{b})\\{"+SumX.ToString()+";"+sumY.ToString()+"\\}$.";
                
                GeneratorTexText generator = new GeneratorTexText();
                generator.Finish(task, given, search, solution);
                CleanXY();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (readXaYaXbYb() == true) { 
            SumX = Alpha*X_a - Beta*X_b;
            SumY = Alpha*Y_a -Beta*Y_b;
            //tbXasumb.Text = SumX.ToString();
            //tbYasumb.Text = SumY.ToString();
            groupBox3.Text = "Координаты вектора (a - b)";
            // вывод данных
            string solution;
            string task;
            string given;
            string search;
            task = " Найдите координаты вектора: ";
            task += "$\\alpha\\vec{a}-\\beta\\vec{b}$, если $\\vec{a}\\{" + X_a.ToString() + ";" + Y_a.ToString() + "\\}; \\vec{b}\\{" + X_b.ToString() + ";" + Y_b.ToString() + "\\};\\\\ \\alpha= " + Alpha.ToString() + "; \\beta =" + Beta.ToString() + ";$";

            given = " $\\vec{a}\\{" + X_a.ToString() + ";" + Y_a.ToString() + "\\}; \\vec{b}\\{" + X_b.ToString() + ";" + Y_b.ToString() + "\\}; \\alpha= " + Alpha.ToString() + "; \\beta =" + Beta.ToString() + "$.";

            search = "$\\alpha\\vec{a}-\\beta\\vec{b}$";

            solution = "Так как $\\vec{a}\\{" + X_a.ToString() + "; " + Y_a.ToString() + "\\}, \\vec{b}\\{" + X_b.ToString() + "; " + Y_b.ToString() + "\\}:\\\\$";

            solution += "$\\alpha\\vec{a}=\\{" + X_a.ToString() + "\\cdot\\alpha; " + Y_a.ToString() + "\\cdot\\alpha\\}=\\{" + X_a.ToString() + "\\cdot" + Alpha.ToString() + "; " + Y_a.ToString() + "\\cdot" + Alpha.ToString() + "\\}= \\{" + (Alpha * X_a).ToString() + "; " + (Alpha * Y_a).ToString() + "\\}$;\\\\";

            solution += "$\\beta\\vec{b}=\\{" + X_b.ToString() + "\\cdot\\beta; " + Y_b.ToString() + "\\cdot\\beta\\}=\\{" + X_b.ToString() + "\\cdot" + Beta.ToString() + "; " + Y_b.ToString() + "\\cdot" + Beta.ToString() + "\\}= \\{" + (Beta * X_b).ToString() + "; " + (Beta * Y_b).ToString() + "\\}$;\\\\";

            solution += "$(\\alpha\\vec{a}-\\beta\\vec{b})\\{" + (Alpha * X_a).ToString() + "-" + (Beta * X_b).ToString() + "; " + (Alpha * Y_a).ToString() + "-" + (Beta * Y_b).ToString() + "\\}=(" + Alpha.ToString() + "\\vec{a}-" + Beta.ToString() + "\\vec{b})\\{" + SumX.ToString() + ";" + sumY.ToString() + "\\}$.";

            GeneratorTexText generator = new GeneratorTexText();
            generator.Finish(task, given, search, solution);
            CleanXY();
            }

        }

        public bool readXaYaXbYb()
        {
            float x_a, y_a, x_b, y_b;
            try
            {
                x_a = float.Parse(tbXa.Text);
                y_a = float.Parse(tbYa.Text);
                x_b = float.Parse(tbXb.Text);
                y_b = float.Parse(tbYb.Text);
                alpha = float.Parse(textBox1.Text);
                beta = float.Parse(textBox2.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Неверно заполнены поля.", "Ошибка ввода!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CleanXY();
                return false;
            }
            X_a = x_a; Y_a = y_a; X_b = x_b; Y_b = y_b; Alpha = alpha; Beta = beta;
            return true;
        }
        public void CleanXY(){
            X_a = 0;
            Y_a = 0;
            X_b = 0;
            Y_b = 0;
            SumX = 0;
            SumY = 0;
            Alpha = 0;
            Beta = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    
    }
}
