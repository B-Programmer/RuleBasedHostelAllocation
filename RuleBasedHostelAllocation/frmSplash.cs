﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RuleBasedHostelAllocation
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 2;
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                this.Hide();
                FrmUserType f1 = new FrmUserType();
                f1.Show();
            }
            lblMarquee.Left = lblMarquee.Left - 120;
            if (lblMarquee.Left <= -1164) lblMarquee.Left = 120;
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
