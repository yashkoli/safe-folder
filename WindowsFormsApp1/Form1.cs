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
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            if (logintxtusername.Text == "admin" && logintxtpassword.Text == "1234")
            {
                new mainhome().Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("incorrect password or username");
                logintxtusername.Clear();
                logintxtpassword.Clear();
                
            }
        }
    }
}
