using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kinoteatr
{
    public partial class Form_Del_Film : Form
    {
        SqlConnection sqlConnection = Class_Connection_DB.DatabaseSQL();
        Class_Connection_DB connect_DB = new Class_Connection_DB();
        public Form_Del_Film()
        {
            InitializeComponent();
        }

        private void Form_Del_Film_Load(object sender, EventArgs e)
        {
            comboBox_Film.DataSource = connect_DB.TableFill("SELECT Nazv, Id_Afisha FROM Afisha", sqlConnection).Tables[0];
            comboBox_Film.DisplayMember = "Nazv";
            comboBox_Film.ValueMember = "Id_Afisha";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = Class_Connection_DB.DatabaseSQL();
            using (sqlConnect)
            {
                try
                {
                    sqlConnect.Open();
                    SqlCommand sqlCommand = new SqlCommand("Afisha_Delete", sqlConnect)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    sqlCommand.Parameters.AddWithValue("@Id", comboBox_Film.SelectedValue);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Фильм успешно удален", "Уведомление");
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Какие либо данные введены не корректно." + ex, "Ошибка");
                }
            }
        }
    }
}
