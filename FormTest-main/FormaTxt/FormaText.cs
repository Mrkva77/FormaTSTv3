﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KontrolaWindowsForm
{
    public partial class FormaText : Form
    {
        public FormaText()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void ProgramName_TextChanged(object sender, EventArgs e)
        {
            get { return ProgramName.Text; }

        private void ProgramDescription_TextChanged(object sender, EventArgs e)
        {
            get { return ProgramDescription.Text; }
        }
    }
}
