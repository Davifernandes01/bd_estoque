﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormVendas : Form
    {
        public FormVendas()
        {
            InitializeComponent();
        }

        private void button_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
