using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mariani_Articoli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void alimentare_CheckedChanged(object sender, EventArgs e)
        {
            if (alimentare.Checked) { alimentareFresco.Visible = true; }
            else { alimentareFresco.Visible = false;}
        }

        private void alimentareFresco_CheckedChanged(object sender, EventArgs e)
        {
            if (alimentareFresco.Checked) { alimentareFresco.Visible = true; }
            else { alimentareFresco.Visible = false;}
        }
    }
}