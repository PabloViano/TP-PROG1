﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindForm
{
    public partial class FormReportePago : Form
    {
        public FormReportePago()
        {
            InitializeComponent();
        }

        private void buttonVolverPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}