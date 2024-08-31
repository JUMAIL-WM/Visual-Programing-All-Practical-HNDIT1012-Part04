using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonLogin.Click += ButtonLogin_Click;
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {

         var msg =   MessageBox.Show("Login Success"+Environment.NewLine+"Welcom to Page","Login",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (msg == DialogResult.Yes)
            {
                Close();
            }

            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
