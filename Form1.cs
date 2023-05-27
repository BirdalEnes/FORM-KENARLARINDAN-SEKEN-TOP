using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORM_KENARLARINDAN_SEKEN_TOP
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        int dikeyYon = 1, yatayYon = 1;
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((kare.Bottom >= this.Height) || kare.Top<=0)
                dikeyYon *= -1;

            if ((kare.Right >= this.Width) || kare.Left<=0)
                yatayYon *= -1;

            kare.Top+=dikeyYon;
            kare.Left+=yatayYon;
        }
        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
