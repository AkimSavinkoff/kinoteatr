using System;
using System.Windows.Forms;

namespace Kinoteatr
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }

        private void Form_Menu_Load(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void принятиеНаРаботуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Add_Sotrudcs form_Add_Sotrudcs = new Form_Add_Sotrudcs();
            form_Add_Sotrudcs.Show();
        }

        private void увольнениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Del_Sot form_Del_Sot = new Form_Del_Sot();
            form_Del_Sot.Show();
        }

        private void изменениеДолжностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Dolj_Upd form_Dolj_Upd = new Form_Dolj_Upd();
            form_Dolj_Upd.Show();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Sotrud form_Sotrud = new Form_Sotrud();
            form_Sotrud.Show();
        }

        private void фильмыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Aficha form_Aficha = new Form_Aficha();
            form_Aficha.Show();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_New_Film form_New_Film = new Form_New_Film();
            form_New_Film.Show();
        }

        private void удалитьФильмToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Del_Film form_Del_Film = new Form_Del_Film();
            form_Del_Film.Show();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Klient form_Klient = new Form_Klient();
            form_Klient.Show();
        }

        private void билетыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_Bilets form_Bilets = new Form_Bilets();
            form_Bilets.Show();
        }

        private void должностиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_Dolj form_Dolj = new Form_Dolj();
            form_Dolj.Show();
        }

        private void оформлениеПродажиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_New_Sell_Bilets form_New_Sell_Bilets = new Form_New_Sell_Bilets();
            form_New_Sell_Bilets.Show();
        }

        private void почтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pochta pochta = new Pochta();
            pochta.Show();
        }

        private void micorosftOfficeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Type officeType = Type.GetTypeFromProgID("Excel.Application");
            if (officeType == null)
            {
                DialogResult result = MessageBox.Show("Excel не уставнвлен, скачать программу?", "Установка", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("https://softoffice.org/microsoft-excel/");
                }    
            }
            else
            {
                MessageBox.Show("Excel установлен на вашем ПК.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void microsoftWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Type officeType = Type.GetTypeFromProgID("Word.Application");
            if (officeType == null)
            {
                DialogResult result = MessageBox.Show("Word не уставнвлен, скачать программу?", "Установка", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("https://softoffice.org/microsoft-word/");
                }
            }
            else
            {
                MessageBox.Show("Word установлен на вашем ПК.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
