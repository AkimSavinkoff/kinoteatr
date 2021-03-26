using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinoteatr
{
    public partial class Pochta : Form
    {
        public Pochta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySendMail(comboBox_Tema.Text, "Пользователь 5", comboBox_Dizayn.Text, comboBox_Funchianal.Text, comboBox_Pont.Text, textBox_Opis.Text); // строка отвечающая за подключение к почте 
        }

        private void Pochta_Load(object sender, EventArgs e)
        {
            //Qw qw = new Qw();
            //ConnectBD connectBD = new ConnectBD();
            //SqlConnection sqlConnection = connectBD.GetSqlConnection(connect.dataSource, connect.initialCatalog, connect.userID, connect.password, connect.checkSecurity);
            //SqlCommand command = new SqlCommand(qw.qwLog_Pas, sqlConnection);
            //SqlCommand cmd_Name = new SqlCommand();
            //cmd_Name.Connection = sqlConnection;
            //sqlConnection.Open();
            //cmd_Name.CommandType = CommandType.Text;
            //cmd_Name.CommandText = "SELECT Prodaz FROM Analiz_Porodaz WHERE Prodaz  = (SELECT MAX(Prodaz) FROM Analiz_Porodaz)";
            ////возвращает первую ячейку вашего SQL запроса.
            //Name_Users = cmd_Name.ExecuteScalar().ToString();
        }

        public void MySendMail(string bodyMail, string nameAuthor, string dizayn, string funcianal, string pon, string subject)
        {
            try
            {
                var from = new MailAddress("", nameAuthor); // почта отправителя
                var to = new MailAddress("");         // почта получателя

                SmtpClient smtp = new SmtpClient("smtp.mail.ru", 587);    // создание протокола
                smtp.Credentials = new NetworkCredential
                #region array
                ("savinkov.akim@mail.ru", "79779552139akim");
                #endregion

                smtp.EnableSsl = true;

                MailMessage mail = new MailMessage(from, to);
                //mail.Attachments.Add(new Attachment("C:\\Users\\butri\\Desktop\\Otpravim po mail'y.txt"));  // передача файлов
                //mail.Attachments.Add(new Attachment("C:\\Users\\butri\\Desktop\\Otpravim po mail'y(1).txt"));
                //mail.Attachments.Add(new Attachment("C:\\Users\\butri\\Desktop\\Otpravim po mail'y(2).txt"));
                mail.Subject = "<h1><center></center></h1>" + bodyMail;
                mail.Body = "Дизайн: " + dizayn + " Фунционал: " + funcianal + " Понятность: " + pon + ". " + subject;   // визуальное изменение сообщения
                mail.IsBodyHtml = true; // разрешение на html язык

                smtp.Send(mail);
                MessageBox.Show("Сообщение отправлено!", "Информационное письмо", MessageBoxButtons.OK, MessageBoxIcon.Information); // вывод окна об отправке сообщения
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка отправки", MessageBoxButtons.OK, MessageBoxIcon.Error); // вывод окна при ошибке отправки сообщения
            }
        }
    }
}
