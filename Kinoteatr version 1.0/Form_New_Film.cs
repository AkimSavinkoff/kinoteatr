using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kinoteatr
{
    public partial class Form_New_Film : Form
    {
        SqlConnection sqlConnection = Class_Connection_DB.DatabaseSQL();
        Class_Connection_DB connection_DB = new Class_Connection_DB();
        public Form_New_Film()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = Class_Connection_DB.DatabaseSQL();
            using (sqlConnection)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Afisha_Insert", sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCommand.Parameters.AddWithValue("@Nazv", textBox_Nazv.Text);
                sqlCommand.Parameters.AddWithValue("@Dlitelnost", maskedTextBox_D.Text);
                sqlCommand.Parameters.AddWithValue("@Ganr_Id", comboBox_G.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@Chena", Convert.ToInt32(textBox_Chena.Text));
                sqlCommand.ExecuteNonQuery();
                Update();
                MessageBox.Show("Новый фильм был добавлен");
                this.Hide();
            }
        }

        private void Form_New_Film_Load(object sender, EventArgs e)
        {
            comboBox_G.DataSource = connection_DB.TableFill("SELECT Nazv, Id_ganr_F FROM Ganr_Film", sqlConnection).Tables[0];
            comboBox_G.DisplayMember = "Nazv";
            comboBox_G.ValueMember = "Id_ganr_F";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
