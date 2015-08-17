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
     
    public partial class fMain : Form
    {
       
        public fMain()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void найтиЧислоKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f1_1 form = new f1_1();
            form.Show();
        }

        private void найтиКоординатыВекторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f1_2 form = new f1_2();
            form.Show();
        }

        private void найтиРазложениеВектораПоВекторамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f1_3 form = new f1_3();
            form.Show();
        }

        private void найтиКоординатыВекторовAbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f1_4 form = new f1_4();
            form.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            f1_5 form = new f1_5();
            form.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            f1_6 form = new f1_6();
            form.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            f1_7 form = new f1_7();
            form.Show();
        }

        private void найтиКоординатыВершинToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void найтиКоординатыВершинПрямоугольникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2_2 form = new f2_2();
            form.Show();
        }

        private void найдитеКоординатыВершиныDПараллелограммаABCDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2_3 form = new f2_3();
            form.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            f2_4 form = new f2_4();
            form.Show();
        }

        private void найтиДлинуВектораПоЗаданнымКоординатамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2_5 form = new f2_5();
            form.Show();
        }

        private void найдитеКоординатыТочекCИDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2_6 form = new f2_6();
            form.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            f2_7 form = new f2_7();
            form.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            f2_8 form = new f2_8();
            form.Show();
        }

        private void найтиМедиануТреугольникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            //setting form = new setting();
            //form.Show();
        }

        private void fMain_Load(object sender, EventArgs e)
        {

        }

        private void задачиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void найдитеXЕслиИзветснаДлинаВектораToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void найдитеxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2_7_1 form = new f2_7_1();
            form.Show();
        }

        private void найтиxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2_7_2 form = new f2_7_2();
            form.Show();
        }

        private void найтиКоординатыТочкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2_6_1 form = new f2_6_1();
            form.Show();
        }

        private void toolStripMenuItem9_Click_1(object sender, EventArgs e)
        {
            f2_4_1 form = new f2_4_1();
            form.Show();
        }

        private void toolStripMenuItem10_Click_1(object sender, EventArgs e)
        {
            f2_4_2 form = new f2_4_2();
            form.Show();
        }

        private void найтиXЕслиИзвестнаДлинаВектораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2_5_1 form = new f2_5_1();
            form.Show();
        }

        private void найтиYЕслиИзвестнаДлинаВектораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2_5_2 form = new f2_5_2();
            form.Show();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
            switch (e.Node.Text) {
                case "1.1 Найти число K":
                    axAcroPDF1.LoadFile(@"Examples\1\1.pdf");
                //    MainStatus.Text = "1.1 Найти число K";
                    break;
                case "1.2 Найти координаты вектора":
                    axAcroPDF1.LoadFile(@"Examples\1\2.pdf");
                    break;
                case "1.3 Найти разложение вектора по координатным векторам i и j":
                    axAcroPDF1.LoadFile(@"Examples\1\3.pdf");
                    break;
                    
                case "1.4 Найти координаты вектора a+b или a-b":
                    axAcroPDF1.LoadFile(@"Examples\1\4.pdf");
                    break;
                case "1.5 Найти попарно коллинеарные векторы":
                    axAcroPDF1.LoadFile(@"Examples\1\6.pdf");
                    break;
                case "1.6 Найти x и y":
                    axAcroPDF1.LoadFile(@"Examples\1\7.pdf");
                    break;
                case "2.1 Найти координаты вершин прямоугольника":
                    axAcroPDF1.LoadFile(@"Examples\2\2.pdf");
                    break;
                case "2.2 Найти координаты вершины D параллелограмма ABCD":
                    axAcroPDF1.LoadFile(@"Examples\2\3.pdf");
                    break;
                case "2.3 Найти координаты вектора AB":
                    axAcroPDF1.LoadFile(@"Examples\2\4.pdf");
                    break;
                case "2.3.1 Найти координаты начала вектора":
                    axAcroPDF1.LoadFile(@"Examples\2\4\1.pdf");
                    break;
                case "2.3.2 Найти координаты конца вектора":
                    axAcroPDF1.LoadFile(@"Examples\2\4\2.pdf");
                    break;
                case "2.4 Найти длину вектора по заданным координатам":
                    axAcroPDF1.LoadFile(@"Examples\2\5.pdf");
                    break;
                case "2.4.1 Найти x если известна длина вектора":
                    axAcroPDF1.LoadFile(@"Examples\2\5\1.pdf");
                    break;
                case "2.4.2 Найти y если известна длина вектора":
                    axAcroPDF1.LoadFile(@"Examples\2\5\2.pdf");
                    break;
                case "2.5 Найти координаты середины отрезка":
                    axAcroPDF1.LoadFile(@"Examples\2\6.pdf");
                    break;
                case "2.5.1 Найти координаты точки":
                    axAcroPDF1.LoadFile(@"Examples\2\6\1.pdf");
                    break;
                case "2.6 Найти расстояние между точками":
                    axAcroPDF1.LoadFile(@"Examples\2\7.pdf");
                    break;
                case "2.6.1 Найти (x)":
                    axAcroPDF1.LoadFile(@"Examples\2\7\1.pdf");
                    break;
                case "2.6.2 Найти (y)":
                    axAcroPDF1.LoadFile(@"Examples\2\7\2.pdf");
                    break;
                case "2.7 Найти периметр треугольника":
                    axAcroPDF1.LoadFile(@"Examples\2\8.pdf");
                    break;

            }
        }
    }
}
