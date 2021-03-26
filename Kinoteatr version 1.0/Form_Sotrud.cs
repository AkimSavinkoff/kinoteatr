using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kinoteatr
{
    public partial class Form_Sotrud : Form
    {
        int i;
        int j;
        SqlConnection sqlConnection = Class_Connection_DB.DatabaseSQL();
        Class_Connection_DB connection_DB = new Class_Connection_DB();
        public Form_Sotrud()
        {
            InitializeComponent();
        }

        private void button_Del_Click(object sender, EventArgs e)
        {
            Form_Del_Sot form_Del_Sot = new Form_Del_Sot();
            form_Del_Sot.Show();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Form_Add_Sotrudcs form_Add_Sotrudcs = new Form_Add_Sotrudcs();
            form_Add_Sotrudcs.Show();
        }

        private void button_UPD_Dolj_Click(object sender, EventArgs e)
        {
            Form_Dolj_Upd form_Dolj_Upd = new Form_Dolj_Upd();
            form_Dolj_Upd.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (i == 0)
            {
                dataGridView1.Sort(dataGridView1.Columns[6], ListSortDirection.Ascending);
                i = 1;
            }
            else
            {
                dataGridView1.Sort(dataGridView1.Columns[6], ListSortDirection.Descending);
                i = 0;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (j == 0)
            {
                dataGridView1.Sort(dataGridView1.Columns[7], ListSortDirection.Ascending);
                j = 1;
            }
            else
            {
                dataGridView1.Sort(dataGridView1.Columns[7], ListSortDirection.Descending);
                j = 0;
            }
        }

        private void Form_Sotrud_Load(object sender, EventArgs e)
        {
            Update();
        }
        public void Update()
        {
            SqlConnection sqlConnect = Class_Connection_DB.DatabaseSQL();
            SqlDataAdapter dataadapter = new SqlDataAdapter(connection_DB.qw_View_Sotrud, sqlConnect);
            DataSet ds = new DataSet();
            sqlConnect.Open();
            dataadapter.Fill(ds, connection_DB.qw_View_Sotrud_Nazv);
            sqlConnect.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = connection_DB.qw_View_Sotrud_Nazv;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)

                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value == null)
                    {
                        break;
                    }

                    if (textBox_Search.Text == dataGridView1.Rows[i].Cells[j].Value.ToString())
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[j];
                        dataGridView1.FirstDisplayedScrollingRowIndex = i;
                        break;
                    }

                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                SqlConnection sqlConnect = Class_Connection_DB.DatabaseSQL();
                SqlDataAdapter dataadapter = new SqlDataAdapter(@"SELECT dbo.Sotrud.Id_Sotrud AS Ключ, dbo.Sotrud.F_S AS Фамилия, dbo.Sotrud.I_S AS Имя, dbo.Sotrud.O_S AS Отчество, dbo.Sotrud.Phone_Number AS [Номер телефона], dbo.Sotrud.Date_Of_Bithd AS [Дата рождения], dbo.Dolj.Nazv_Dolj AS Должность, dbo.Dolj.Oklad AS Оклад, dbo.Autoriz.Login_ AS Аккаунт FROM dbo.Sotrud INNER JOIN dbo.Autoriz ON dbo.Sotrud.Autorir_S = dbo.Autoriz.Id_Auto INNER JOIN dbo.Dolj ON dbo.Sotrud.Dolj_S = dbo.Dolj.Id_Dolj where dbo.Sotrud.F_S like '%" + textBox2.Text + "%'", sqlConnect);
                DataSet ds = new DataSet();
                sqlConnect.Open();
                dataadapter.Fill(ds, connection_DB.qw_View_Sotrud_Nazv);
                sqlConnect.Close();
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = connection_DB.qw_View_Sotrud_Nazv;
            }
            else
            {
                MessageBox.Show("Заполните поля фильтрации");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                SqlConnection sqlConnect = Class_Connection_DB.DatabaseSQL();
                SqlDataAdapter dataadapter = new SqlDataAdapter(@"SELECT dbo.Sotrud.Id_Sotrud AS Ключ, dbo.Sotrud.F_S AS Фамилия, dbo.Sotrud.I_S AS Имя, dbo.Sotrud.O_S AS Отчество, dbo.Sotrud.Phone_Number AS [Номер телефона], dbo.Sotrud.Date_Of_Bithd AS [Дата рождения], dbo.Dolj.Nazv_Dolj AS Должность, dbo.Dolj.Oklad AS Оклад, dbo.Autoriz.Login_ AS Аккаунт FROM dbo.Sotrud INNER JOIN dbo.Autoriz ON dbo.Sotrud.Autorir_S = dbo.Autoriz.Id_Auto INNER JOIN dbo.Dolj ON dbo.Sotrud.Dolj_S = dbo.Dolj.Id_Dolj where dbo.Autoriz.Login_ like '%" + textBox3.Text + "%'", sqlConnect);
                DataSet ds = new DataSet();
                sqlConnect.Open();
                dataadapter.Fill(ds, connection_DB.qw_View_Sotrud_Nazv);
                sqlConnect.Close();
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = connection_DB.qw_View_Sotrud_Nazv;
            }
            else
            {
                MessageBox.Show("Заполните поля фильтрации");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                SqlConnection sqlConnect = Class_Connection_DB.DatabaseSQL();
                SqlDataAdapter dataadapter = new SqlDataAdapter(@"SELECT dbo.Sotrud.Id_Sotrud AS Ключ, dbo.Sotrud.F_S AS Фамилия, dbo.Sotrud.I_S AS Имя, dbo.Sotrud.O_S AS Отчество, dbo.Sotrud.Phone_Number AS [Номер телефона], dbo.Sotrud.Date_Of_Bithd AS [Дата рождения], dbo.Dolj.Nazv_Dolj AS Должность, dbo.Dolj.Oklad AS Оклад, dbo.Autoriz.Login_ AS Аккаунт FROM dbo.Sotrud INNER JOIN dbo.Autoriz ON dbo.Sotrud.Autorir_S = dbo.Autoriz.Id_Auto INNER JOIN dbo.Dolj ON dbo.Sotrud.Dolj_S = dbo.Dolj.Id_Dolj where dbo.Dolj.Nazv_Dolj like '%" + textBox4.Text + "%'", sqlConnect);
                DataSet ds = new DataSet();
                sqlConnect.Open();
                dataadapter.Fill(ds, connection_DB.qw_View_Sotrud_Nazv);
                sqlConnect.Close();
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = connection_DB.qw_View_Sotrud_Nazv;
            }
            else
            {
                MessageBox.Show("Заполните поля фильтрации");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Export_Word_Excel class_Export = new Export_Word_Excel();
            class_Export.Export_Data_To_Word(dataGridView1, "Сотрудники", "Сотрудники");
        }
    }
}
