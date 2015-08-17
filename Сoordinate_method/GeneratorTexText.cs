using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
namespace Сoordinate_method
{
    class GeneratorTexText
    {        
       public GeneratorTexText() {
           
           Application.UseWaitCursor=true;    
            fileName = @"makePDF\\1.tex";
            preambleWrite();
        }
       // string solution;
        string fileName;
        
        Encoding enc = Encoding.GetEncoding(1251);

      
       
        private void preambleWrite()
        {
            String str = "";
            using (FileStream fs = File.Create(fileName))
            {// Запись преамбулы
                using (StreamWriter sw = new StreamWriter(fs, enc))
                {
                    str = "\\documentclass[14pt,a4paper]{extarticle}";
                    sw.WriteLine(str);
                    
                    str = "\\usepackage{amsmath,amsfonts,amssymb}";
                    sw.WriteLine(str);
                    
                    str = "\\usepackage[mathscr]{eucal}";
                    sw.WriteLine(str);
                    str = "\\usepackage{graphicx}";
                    sw.WriteLine(str);
                    str = "\\usepackage[russian]{babel}";
                    sw.WriteLine(str);
                    str = "\\usepackage[cp1251]{inputenc}";
                    sw.WriteLine(str);
                    str = "\\usepackage[T2A]{fontenc}";
                    sw.WriteLine(str);
                    str = "\\newenvironment{proof}[1][Доказательство]{\\noindent\\textbf{#1. \\ }}{\\ \\rule{0.5em}{0.5em}}";
                    sw.WriteLine(str);
                    str = "\\newenvironment{solution}[1][Решение]{\\noindent\\textbf{#1. \\ }}{\\ \\rule{0.5em}{0.5em}}";
                    sw.WriteLine(str);
                    str = "\\usepackage{geometry}";
                    sw.WriteLine(str);
                    str="\\geometry{left=3cm}";
                    sw.WriteLine(str);
                    str="\\geometry{right=1cm}";
                    sw.WriteLine(str);
                    str="\\geometry{top=2cm}";
                    sw.WriteLine(str);
                    str = "\\geometry{bottom=2cm}";
                    sw.WriteLine(str);
                    str = "\\renewcommand{\\baselinestretch}{1.3}";
                    sw.WriteLine(str);
                    str = "\\tolerance=500";
                    sw.WriteLine(str);
                    str = "\\begin{document}";
                    sw.WriteLine(str);             
                               
                }
               

            }
        }
      // \noindent{\bf Найти:}
        public void searchWrite(string strSearch) { 
            String str;
            using (System.IO.FileStream fs = new System.IO.FileStream(fileName, FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs, enc))
                {
                    str = "\\noindent{\\"+"bf Найти:}";
                    sw.WriteLine(str);
                    sw.WriteLine(strSearch);
                    str = "\\\\";
                    sw.WriteLine(str);
                }
            }
        
        }
        public void givenWrite(string strGiven) { // Запись дано
            String str;
         using (System.IO.FileStream fs = new System.IO.FileStream(fileName, FileMode.Append))
         {
             using (StreamWriter sw = new StreamWriter(fs, enc))
             {
                 str = "\\"+"noindent{\\"+"bf Дано:}\\\\";
                 sw.WriteLine(str);
                 sw.WriteLine(strGiven);
                 str = "\\\\";
                 sw.WriteLine(str);
             }
         }
        }

        public void taskWrite(string strTask)
        { // Запись условия задачи
            String str;
            using (System.IO.FileStream fs = new System.IO.FileStream(fileName, FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs, enc))
                {
                    str = "\\noindent{\\bf Задача.}";
                    sw.WriteLine(str);
                    str = "{\\it";
                    sw.WriteLine(str);
                    sw.WriteLine(strTask);
                    str = "}\\\\";
                    sw.WriteLine(str);
                }

            }

        }
        public void solutionWrite(String strSolution)
        {

            using (System.IO.FileStream fs = new System.IO.FileStream(fileName, FileMode.Append)) 
            { // Запись решения
                String str;
               using (StreamWriter sw = new StreamWriter(fs, enc))
                {
                    str = "\\begin{solution}";
                    sw.WriteLine(str);
                    sw.WriteLine(strSolution);
                    str = "\\end{solution}";
                    sw.WriteLine(str);
                }
            }
        }

        private void EndDocumentWrite(){ // Запись конца документа
              String str = "";
              using (System.IO.FileStream fs = new System.IO.FileStream(fileName, FileMode.Append)) 
              {
                  using (StreamWriter sw = new StreamWriter(fs, enc))
                  {
                      str = "\\end{document}";
                      sw.WriteLine(str);  
                  }
               
              }

}

        public void compilePDF() {
            // компиляция и открытие PDF файла 
            EndDocumentWrite();
            ProcessStartInfo startInfo = new ProcessStartInfo("pdflatex");
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.Arguments = fileName;
            Process process = Process.Start(startInfo);
            process.WaitForExit();
            process.Close();
            fViewExample fView = new fViewExample();
            fView.Path_example = @"1.pdf";
            fView.Show();
            Application.UseWaitCursor = false;
        }
        public void Finish(string task, string given, string search, string solution) {
            this.taskWrite(task);
            this.givenWrite(given);
            this.searchWrite(search);
            this.solutionWrite(solution);
            this.compilePDF();
        }
    }
}
