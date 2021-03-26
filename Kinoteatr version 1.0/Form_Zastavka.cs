using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinoteatr
{
    public partial class Form_Zastavka : Form
    {
        public Form_Zastavka()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
            {
                Form_Autorization form_Autorization = new Form_Autorization();
                form_Autorization.Show();
                timer1.Enabled = false;
                this.Hide();
            }
            else
            {
                progressBar1.Value += 10;
            }
        }

        private void Form_Zastavka_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
        }
    }
}
