using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kinoteatr
{
    public partial class Form_Bilets : Form
    {
        Class_Connection_DB connection_DB = new Class_Connection_DB();
        public Form_Bilets()
        {
            InitializeComponent();
        }

        private void Form_Bilets_Load(object sender, EventArgs e)
        {
            Update();
        }
        public void Update()
        {
            SqlConnection sqlConnect = Class_Connection_DB.DatabaseSQL();
            SqlDataAdapter dataadapter = new SqlDataAdapter(connection_DB.qw_View_Sellsis_Bilets, sqlConnect);
            DataSet ds = new DataSet();
            sqlConnect.Open();
            dataadapter.Fill(ds, connection_DB.qw_View_Sellsis_Bilets_Nazv);
            sqlConnect.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = connection_DB.qw_View_Sellsis_Bilets_Nazv;
        }
    }
}
