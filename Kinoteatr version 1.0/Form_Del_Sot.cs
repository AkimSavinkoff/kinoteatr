using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kinoteatr
{
    public partial class Form_Del_Sot : Form
    {
        SqlConnection sqlConnection = Class_Connection_DB.DatabaseSQL();
        Class_Connection_DB connect_DB = new Class_Connection_DB();
        public Form_Del_Sot()
        {
            InitializeComponent();
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
                    SqlCommand sqlCommand = new SqlCommand("Sotrud_Delete", sqlConnect)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    sqlCommand.Parameters.AddWithValue("@Id", comboBox_Sot.SelectedValue);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Сотрудник уволен", "Уведомление");
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Какие либо данные введены не корректно." + ex, "Ошибка");
                }
            }
        }

        private void Form_Del_Sot_Load(object sender, EventArgs e)
        {
            comboBox_Sot.DataSource = connect_DB.TableFill("SELECT F_S, Id_Sotrud FROM Sotrud", sqlConnection).Tables[0];
            comboBox_Sot.DisplayMember = "F_S";
            comboBox_Sot.ValueMember = "Id_Sotrud";
        }
    }
}
