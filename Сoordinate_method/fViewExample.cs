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
    public partial class fViewExample : Form
    {
        string path_example = "";

        public string  Path_example
        {
            get { return path_example; }
            set { path_example = value; }
        }

        public fViewExample()
        {
            InitializeComponent();
       
        }

        private void fViewExample_Load(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile(path_example);
            
        }

        private void axAcroPDF1_OnError(object sender, EventArgs e)
        {

        }
    }
}
