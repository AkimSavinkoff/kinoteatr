using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kinoteatr
{
    public partial class Form_New_Sell_Bilets : Form
    {
        Class_Connection_DB connect_DB = new Class_Connection_DB();
        SqlConnection sqlConnection = Class_Connection_DB.DatabaseSQL();
        public Form_New_Sell_Bilets()
        {
            InitializeComponent();
        }

        private void Form_New_Sell_Bilets_Load(object sender, EventArgs e)
        {
            comboBox_Film.DataSource = connect_DB.TableFill("SELECT Nazv, Id_Afisha FROM Afisha", sqlConnection).Tables[0];
            comboBox_Film.DisplayMember = "Nazv";
            comboBox_Film.ValueMember = "Id_Afisha";

            comboBox_Klient.DataSource = connect_DB.TableFill("SELECT F_K, Id_Klient FROM klient", sqlConnection).Tables[0];
            comboBox_Klient.DisplayMember = "F_K";
            comboBox_Klient.ValueMember = "Id_Klient";

            comboBox_Sotrud.DataSource = connect_DB.TableFill("SELECT F_S, Id_Sotrud FROM Sotrud", sqlConnection).Tables[0];
            comboBox_Sotrud.DisplayMember = "F_S";
            comboBox_Sotrud.ValueMember = "Id_Sotrud";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = Class_Connection_DB.DatabaseSQL();
            using (sqlConnection)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Pokupka_Bileta_Insert", sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCommand.Parameters.AddWithValue("@Afisha_Id", comboBox_Film.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@klient_Id", comboBox_Klient.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@Sotrud_Id", comboBox_Sotrud.SelectedValue);
                sqlCommand.ExecuteNonQuery();
                Update();
                MessageBox.Show("Билет успешно оформлен");
            }
        }
    }
}
