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
    public partial class f2_8 : Form
    {
        public f2_8()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            fViewExample fView = new fViewExample();
            fView.Path_example = @"Examples\2\8.pdf";
            fView.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float x_M, x_N, x_P;
            float y_M, y_N, y_P;
            float MN, MP, NP;
            float P_MNP;
            try
            {
                x_M = float.Parse(textBox1.Text);
                y_M = float.Parse(textBox2.Text);
                x_N = float.Parse(textBox4.Text);
                y_N = float.Parse(textBox3.Text);
                x_P = float.Parse(textBox6.Text);
                y_P = float.Parse(textBox5.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Неверно заполнены поля.", "Ошибка ввода!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MN = (float)Math.Sqrt((double)((x_N - x_M) * (x_N - x_M) + (y_N - y_M) * (y_N - y_M)));
            NP = (float)Math.Sqrt((double)((x_P - x_N) * (x_P - x_N) + (y_P - y_N) * (y_P - y_N)));
            MP = (float)Math.Sqrt((double)((x_P - x_M) * (x_P - x_M) + (y_P - y_M) * (y_P - y_M)));
            P_MNP = MN + NP + MP;

            string solution;
            string task;
            string given;
            string search;

            task = "Найдите периметр треугольника $MNP$, если $M("+x_M.ToString()+"; "+y_M.ToString()+")$; $N("+x_N.ToString()+"; "+y_N.ToString()+")$; $P("+x_P.ToString()+";"+y_P.ToString()+")$.";
            given = "$\\triangle MNP, M(" + x_M.ToString() + "; " + y_M.ToString() + "); N(" + x_N.ToString() + "; " + y_N.ToString() + "), P(" + x_P.ToString() + ";" + y_P.ToString() + ")$.";
            search = " $P_{\\triangle MNP}$";
            solution = "$MN=\\sqrt{(x_M-x_N)^2+(y_M-y_N)^2}=\\sqrt{("+x_M.ToString()+"-"+x_N.ToString()+")^2+("+y_M.ToString()+"-"+y_N.ToString()+")^2}="+MN.ToString()+"$;\\\\";
            solution += " $NP=\\sqrt{(x_N-x_P)^2+(y_N-y_P)^2}=\\sqrt{("+x_N.ToString()+"-"+x_P.ToString()+")^2+("+y_N.ToString()+"-"+y_P.ToString()+")^2}="+NP.ToString()+"$;\\\\";
            solution += " $MP=\\sqrt{(x_P-x_M)^2+(y_P-y_M)^2}=\\sqrt{("+x_P.ToString()+"-"+x_M.ToString()+")^2+("+y_P.ToString()+"-"+y_M.ToString()+")^2}="+MP.ToString()+"$;\\\\";
            solution += "$P_{\\triangle MNP}=MN+NP+MP="+MN.ToString()+"+"+NP.ToString()+"+"+MP.ToString()+"="+P_MNP.ToString()+"$";

            GeneratorTexText generator = new GeneratorTexText();
            generator.Finish(task, given, search, solution);

        }
    }
}
