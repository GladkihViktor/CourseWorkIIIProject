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
    public partial class f2_2 : Form
    {
        public f2_2()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            fViewExample fView = new fViewExample();
            fView.Path_example = @"Examples\2\2.pdf";
            fView.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float d_OA, d_OB;
            float x_OA, y_OB;
            try
            {
                d_OA = float.Parse(textBox1.Text);
                d_OB = float.Parse(textBox2.Text);
                if ((d_OA < 0) || (d_OB < 0)) {
                    throw new System.FormatException(); 
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Неверно заполнены поля.", "Ошибка ввода!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string solution="";
            string task="";
            string given="";
            string search="";

            x_OA = (float)Math.Sqrt((double)(d_OA * d_OA));
            y_OB = (float)Math.Sqrt((double)(d_OB * d_OB));
            solution = "Так как $O$-- точка начала координат, то $O(0;0)$.";
            if (checkBox1.Checked == true) {
                x_OA = -x_OA;
                task = "Точка $A$  лежит на отрицательной полуоси $Ox$, а точка $B$ -- на положительной полуоси $Oy$. Найдите координаты вершин прямоугольника $OACB$, если $OA=" + d_OA.ToString() + "$; $OB=" + d_OB.ToString() + "$.";
                given = "$OACB$ -- прямоугольник, $OA=" + d_OA.ToString() + "; OB=" + d_OB.ToString() + "$; $A\\in Ox_-, B\\in Oy_+$";
            
            } 
            if (checkBox2.Checked == true) {
                y_OB = -y_OB;
                task = "Точка $A$  лежит на положительной полуоси $Ox$, а точка $B$ -- на отрицательной полуоси $Oy$. Найдите координаты вершин прямоугольника $OACB$, если $OA=" + d_OA.ToString() + "$; $OB=" + d_OB.ToString() + "$.";
                given = "$OACB$ -- прямоугольник, $OA=" + d_OA.ToString() + "; OB=" + d_OB.ToString() + "$; $A\\in Ox_+, B\\in Oy_-$";
            } 
                if ((checkBox1.Checked == true) && (checkBox2.Checked == true))
                {
                    
                    task = "Точка $A$  лежит на отрицательной полуоси $Ox$, а точка $B$ -- на отрицательной полуоси $Oy$. Найдите координаты вершин прямоугольника $OACB$, если $OA=" + d_OA.ToString() + "$; $OB=" + d_OB.ToString() + "$.";
                    given = "$OACB$ -- прямоугольник, $OA=" + d_OA.ToString() + "; OB=" + d_OB.ToString() + "$; $A\\in Ox_-, B\\in Oy_-$";
                }
                if ((checkBox1.Checked==false)&& (checkBox2.Checked==false)) {
                    task = "Точка $A$  лежит на положительной полуоси $Ox$, а точка $B$ -- на положительной полуоси $Oy$. Найдите координаты вершин прямоугольника $OACB$, если $OA=" + d_OA.ToString() + "$; $OB=" + d_OB.ToString() + "$.";
                    given = "$OACB$ -- прямоугольник, $OA=" + d_OA.ToString() + "; OB=" + d_OB.ToString() + "$; $A\\in Ox_+, B\\in Oy_+$";
                }


            
           
          
            search = "Координаты вершин $OACB$";
            
            solution += "Тогда, так как $OA="+d_OA.ToString()+"; OB="+d_OB.ToString()+" \\Rightarrow A("+x_OA.ToString()+";0), B(0;"+y_OB.ToString()+"), C("+x_OA.ToString()+"; "+y_OB.ToString()+")$.";

            GeneratorTexText generator = new GeneratorTexText();
            generator.Finish(task, given, search, solution);
        
        }
    }
}
