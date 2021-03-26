namespace Kinoteatr
{
    partial class Form_Sotrud
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Del = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_UPD_Dolj = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1436, 384);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_Del
            // 
            this.button_Del.Location = new System.Drawing.Point(1261, 390);
            this.button_Del.Name = "button_Del";
            this.button_Del.Size = new System.Drawing.Size(163, 38);
            this.button_Del.TabIndex = 1;
            this.button_Del.Text = "Уволить сотрудника";
            this.button_Del.UseVisualStyleBackColor = true;
            this.button_Del.Click += new System.EventHandler(this.button_Del_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(1261, 434);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(163, 38);
            this.button_Add.TabIndex = 2;
            this.button_Add.Text = "Принять нового";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_UPD_Dolj
            // 
            this.button_UPD_Dolj.Location = new System.Drawing.Point(1111, 421);
            this.button_UPD_Dolj.Name = "button_UPD_Dolj";
            this.button_UPD_Dolj.Size = new System.Drawing.Size(144, 51);
            this.button_UPD_Dolj.TabIndex = 3;
            this.button_UPD_Dolj.Text = "Изменить должность";
            this.button_UPD_Dolj.UseVisualStyleBackColor = true;
            this.button_UPD_Dolj.Click += new System.EventHandler(this.button_UPD_Dolj_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(13, 405);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(162, 22);
            this.textBox_Search.TabIndex = 5;
            this.toolTip1.SetToolTip(this.textBox_Search, "Данные поиска");
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(212, 434);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 38);
            this.button2.TabIndex = 6;
            this.button2.Text = "Фильтрация (Фамилия)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(406, 434);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 38);
            this.button3.TabIndex = 7;
            this.button3.Text = "Фильтрация (Аккаунт)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(600, 426);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 46);
            this.button4.TabIndex = 8;
            this.button4.Text = "Фильтрация (Должность)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(794, 434);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(188, 38);
            this.button5.TabIndex = 9;
            this.button5.Text = "Сортировать по окладу";
            this.toolTip1.SetToolTip(this.button5, "Производится сортировка по столбцу \"Оклад\"");
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(794, 390);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(188, 38);
            this.button6.TabIndex = 10;
            this.button6.Text = "Сортировать должности";
            this.toolTip1.SetToolTip(this.button6, "Производится сортировка по столбцу \"Должность\"");
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(212, 406);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 22);
            this.textBox2.TabIndex = 11;
            this.toolTip1.SetToolTip(this.textBox2, "Данные фильтрации для стоблца \"Фамилия\"");
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(406, 406);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(188, 22);
            this.textBox3.TabIndex = 12;
            this.toolTip1.SetToolTip(this.textBox3, "Данные фильтрации для стоблца \"Аккаунт\"");
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(600, 398);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(188, 22);
            this.textBox4.TabIndex = 13;
            this.toolTip1.SetToolTip(this.textBox4, "Данные фильтрации для стоблца \"Должность\"");
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(988, 416);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(117, 25);
            this.button7.TabIndex = 14;
            this.button7.Text = "Обновить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(988, 447);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(117, 25);
            this.button8.TabIndex = 15;
            this.button8.Text = "Экспорт";
            this.toolTip1.SetToolTip(this.button8, "Производится выгрузка данных в Word");
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form_Sotrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 480);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_UPD_Dolj);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Del);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form_Sotrud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кинотеатр \"Сотрудники\"";
            this.Load += new System.EventHandler(this.Form_Sotrud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Del;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_UPD_Dolj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}