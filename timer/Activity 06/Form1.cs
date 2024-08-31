using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            KeyDown += Form1_KeyDown;
            timer1.Tick += Timer1_Tick;
            exiteToolStripMenuItem.Click += ExiteToolStripMenuItem_Click;
            timer1.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void ExiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
