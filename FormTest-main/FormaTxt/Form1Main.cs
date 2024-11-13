using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KontrolaWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Notepad");
            comboBox1.Items.Add("Paint");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedProgram = comboBox1.SelectedItem as string;

            if (selectedProgram == "Notepad")
            {
                System.Diagnostics.Process.Start("notepad.exe");
            }
            else if (selectedProgram == "Paint")
            {
                System.Diagnostics.Process.Start("mspaint.exe");
            }
            else
            {
                MessageBox.Show("Please select a program to run.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = checkBox1.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {            
                MessageBox.Show("Open functionality is not implemented yet.");           
            }

            private void exitToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Save functionality is not implemented yet.");
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaText formText = new FormaText();

            if (formText.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = formText.ProgramName;
                textBox2.Text = formText.ProgramDescription;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Font settings are not implemented yet.");
        }

        private void optionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Options are not implemented yet.");
        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Do you want to proceed with the action?",
        "Information",
        MessageBoxButtons.YesNoCancel,
        MessageBoxIcon.Information
    );

            switch (result)
            {
                case DialogResult.Yes:
                    MessageBox.Show("You chose Yes.");
                    break;
                case DialogResult.No:
                    MessageBox.Show("You chose No.");
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("You chose Cancel.");
                    break;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program Control Application\nVersion 1.0\n© 2024 Your Company", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

