using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kinoteatr
{
    public partial class Form_Dolj : Form
    {
        string idS;
        Class_Connection_DB connection_DB = new Class_Connection_DB();
        public Form_Dolj()
        {
            InitializeComponent();
        }

        private void Form_Dolj_Load(object sender, EventArgs e)
        {
            Update();
        }
        public void Update()
        {
            SqlConnection sqlConnect = Class_Connection_DB.DatabaseSQL();
            SqlDataAdapter dataadapter = new SqlDataAdapter(connection_DB.qw_View_Dolj, sqlConnect);
            DataSet ds = new DataSet();
            sqlConnect.Open();
            dataadapter.Fill(ds, connection_DB.qw_View_Dolj_Nazv);
            sqlConnect.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = connection_DB.qw_View_Dolj_Nazv;
        }

        private void button_Upd_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = Class_Connection_DB.DatabaseSQL();
            using (sqlConnection)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Dolj_Update", sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCommand.Parameters.AddWithValue("@Id", Convert.ToInt32(idS));
                sqlCommand.Parameters.AddWithValue("@Nazv_Dolj", textBox_Nazv.Text);
                sqlCommand.Parameters.AddWithValue("@Oklad", textBox_Oklad.Text);
                sqlCommand.ExecuteNonQuery();
                Update();
                MessageBox.Show("Должность была изменена");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idS = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox_Nazv.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox_Oklad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = Class_Connection_DB.DatabaseSQL();
            using (sqlConnection)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Dolj_Insert", sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCommand.Parameters.AddWithValue("@Nazv_Dolj", textBox_Nazv.Text);
                sqlCommand.Parameters.AddWithValue("@Oklad", textBox_Oklad.Text);
                sqlCommand.ExecuteNonQuery();
                Update();
                MessageBox.Show("Должность была добавлена");
            }
        }

        private void button_Del_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = Class_Connection_DB.DatabaseSQL();
            using (sqlConnection)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Dolj_Delete", sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCommand.Parameters.AddWithValue("@Id", Convert.ToInt32(idS));
                sqlCommand.ExecuteNonQuery();
                Update();
                MessageBox.Show("Должность была удалена");
            }
        }
    }
}
