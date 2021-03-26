using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kinoteatr
{
    public partial class Form_Aficha : Form
    {
        Class_Connection_DB connection_DB = new Class_Connection_DB();
        public Form_Aficha()
        {
            InitializeComponent();
        }

        private void Form_Aficha_Load(object sender, EventArgs e)
        {
            Update();
        }
        public void Update()
        {
            SqlConnection sqlConnect = Class_Connection_DB.DatabaseSQL();
            SqlDataAdapter dataadapter = new SqlDataAdapter(connection_DB.qw_View_Aficha, sqlConnect);
            DataSet ds = new DataSet();
            sqlConnect.Open();
            dataadapter.Fill(ds, connection_DB.qw_View_Aficha_Nazv);
            sqlConnect.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = connection_DB.qw_View_Aficha_Nazv;
        }
    }
}
