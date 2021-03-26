using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kinoteatr
{
    public partial class Form_Klient : Form
    {
        Class_Connection_DB connection_DB = new Class_Connection_DB();
        string idS;
        public Form_Klient()
        {
            InitializeComponent();
        }

        private void Form_Klient_Load(object sender, EventArgs e)
        {
            Update();
        }
        public void Update()
        {
            SqlConnection sqlConnect = Class_Connection_DB.DatabaseSQL();
            SqlDataAdapter dataadapter = new SqlDataAdapter(connection_DB.qw_View_Klient, sqlConnect);
            DataSet ds = new DataSet();
            sqlConnect.Open();
            dataadapter.Fill(ds, connection_DB.qw_View_Klient_Nazv);
            sqlConnect.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = connection_DB.qw_View_Klient_Nazv;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = Class_Connection_DB.DatabaseSQL();
            using (sqlConnection)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("klient_Insert", sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCommand.Parameters.AddWithValue("@F_K", textBox_F.Text);
                sqlCommand.Parameters.AddWithValue("@I_K", textBox_I.Text);
                sqlCommand.Parameters.AddWithValue("@O_K", textBox_O.Text);
                sqlCommand.Parameters.AddWithValue("@Phone_Number", maskedTextBox_Phone.Text);
                sqlCommand.ExecuteNonQuery();
                Update();
                MessageBox.Show("Клиент был доабвен");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = Class_Connection_DB.DatabaseSQL();
            using (sqlConnection)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("klient_Update", sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCommand.Parameters.AddWithValue("@Id", Convert.ToInt32(idS));
                sqlCommand.Parameters.AddWithValue("@F_K", textBox_F.Text);
                sqlCommand.Parameters.AddWithValue("@I_K", textBox_I.Text);
                sqlCommand.Parameters.AddWithValue("@O_K", textBox_O.Text);
                sqlCommand.Parameters.AddWithValue("@Phone_Number", maskedTextBox_Phone.Text);
                sqlCommand.ExecuteNonQuery();
                Update();
                MessageBox.Show("Даныне клиента обновлены");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idS = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox_F.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox_I.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox_O.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            maskedTextBox_Phone.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = Class_Connection_DB.DatabaseSQL();
            using (sqlConnection)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("klient_Delete", sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCommand.Parameters.AddWithValue("@Id", Convert.ToInt32(idS));
                sqlCommand.ExecuteNonQuery();
                Update();
                MessageBox.Show("Клиент был удален");
            }
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

        private void button5_Click(object sender, EventArgs e)
        {
            Export_Word_Excel class_Export = new Export_Word_Excel();
            class_Export.Export_Data_To_Word(dataGridView1, "Клиенты", "Клиенты");
        }
    }
}
