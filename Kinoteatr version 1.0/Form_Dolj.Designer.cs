namespace Kinoteatr
{
    partial class Form_Dolj
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Del = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Upd = new System.Windows.Forms.Button();
            this.textBox_Oklad = new System.Windows.Forms.TextBox();
            this.textBox_Nazv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(280, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(543, 221);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button_Del
            // 
            this.button_Del.Location = new System.Drawing.Point(12, 181);
            this.button_Del.Name = "button_Del";
            this.button_Del.Size = new System.Drawing.Size(262, 33);
            this.button_Del.TabIndex = 27;
            this.button_Del.Text = "Удалить";
            this.button_Del.UseVisualStyleBackColor = true;
            this.button_Del.Click += new System.EventHandler(this.button_Del_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(12, 142);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(262, 33);
            this.button_Add.TabIndex = 26;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Upd
            // 
            this.button_Upd.Location = new System.Drawing.Point(12, 103);
            this.button_Upd.Name = "button_Upd";
            this.button_Upd.Size = new System.Drawing.Size(262, 33);
            this.button_Upd.TabIndex = 25;
            this.button_Upd.Text = "Изменить";
            this.button_Upd.UseVisualStyleBackColor = true;
            this.button_Upd.Click += new System.EventHandler(this.button_Upd_Click);
            // 
            // textBox_Oklad
            // 
            this.textBox_Oklad.Location = new System.Drawing.Point(94, 53);
            this.textBox_Oklad.Name = "textBox_Oklad";
            this.textBox_Oklad.Size = new System.Drawing.Size(180, 22);
            this.textBox_Oklad.TabIndex = 24;
            // 
            // textBox_Nazv
            // 
            this.textBox_Nazv.Location = new System.Drawing.Point(94, 17);
            this.textBox_Nazv.Name = "textBox_Nazv";
            this.textBox_Nazv.Size = new System.Drawing.Size(180, 22);
            this.textBox_Nazv.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(30, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Оклад:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Название:";
            // 
            // Form_Dolj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 221);
            this.Controls.Add(this.button_Del);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Upd);
            this.Controls.Add(this.textBox_Oklad);
            this.Controls.Add(this.textBox_Nazv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_Dolj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кинотеатр \"Должности\"";
            this.Load += new System.EventHandler(this.Form_Dolj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Del;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Upd;
        private System.Windows.Forms.TextBox textBox_Oklad;
        private System.Windows.Forms.TextBox textBox_Nazv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}