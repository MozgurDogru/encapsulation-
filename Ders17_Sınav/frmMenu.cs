﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders17_Sınav
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void kapsüllemeRandomToolStripMenuItem_Click(object sender, EventArgs e)
        {
                frmKapsulleme_Random_If f = new frmKapsulleme_Random_If(); 
            f.ShowDialog();
        }
    }
}
