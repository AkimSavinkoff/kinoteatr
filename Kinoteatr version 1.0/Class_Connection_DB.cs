using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Kinoteatr
{
    class Class_Connection_DB
    {
        //запросы
        public string qw_View_Sotrud = "select * from View_Sotrud";
        public string qw_View_Sotrud_Nazv = "View_Sotrud";
        public string qw_View_Dolj = "select * from View_Dolj";
        public string qw_View_Dolj_Nazv = "View_Dolj";
        public string qw_View_Aficha = "select * from View_Aficha";
        public string qw_View_Aficha_Nazv = "View_Aficha";
        public string qw_View_Klient = "select * from View_Klient";
        public string qw_View_Klient_Nazv = "View_Klient";
        public string qw_View_Sellsis_Bilets = "select * from View_Sellsis_Bilets";
        public string qw_View_Sellsis_Bilets_Nazv = "View_Sellsis_Bilets";


        public static int Rol;
        public event Action<DataTable> dtServers;
        public event Action<DataTable> dtDatabases;
        //private Register registry = new Register();
        public static bool logCon;
        public static string DataSource = @"USER-PC\SQLEXPRESS";  //Имя сервера
        public static string InitialCatalog = "Kino";   //Имя базы данных
        public static string UserID = "sa"; //Имя входа
        public static string Password = "123"; //Пароль входа

        public static bool CheckSecurity = true; //Проверка подлинности SQl



        public static SqlConnection DatabaseSQL()
        {
            SqlConnection sqlConnection = new SqlConnection($"Data Source = {DataSource}; Initial Catalog = {InitialCatalog};" +
            $"Persist Security Info = {CheckSecurity}; User ID = {UserID}; password = {Password}");

            return sqlConnection;
        }


        public DataSet TableFill(string query, SqlConnection sql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, sql);
            DataSet dataSet = new DataSet();
            dataSet.Clear();
            adapter.Fill(dataSet);
            return dataSet;
        }

        public void Servers_get()
        {
            SqlDataSourceEnumerator sourceEnumerator
                = SqlDataSourceEnumerator.Instance;
            dtServers(sourceEnumerator.GetDataSources());
        }

        public void Databases_get()
        {
            SqlConnection sql = new SqlConnection("Data Source = " + DataSource +
                "; Initial Catalog = Meto; Persist Security Info = true; " +
                " User ID = " + UserID + "; Password = \"" + Password + "\"");
            try
            {
                DataTable table = new DataTable();
                sql.Open();
                dtDatabases(table);
            }
            catch (SqlException ex)
            {
                Register.error_message += "\n" + DateTime.Now.ToLongDateString()
                    + ex.Message;
            }
            finally
            {
                sql.Close();
            }
        }
    }
}
