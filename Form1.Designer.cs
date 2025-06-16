namespace Конвертер_СНЦ144К_в_J599
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Преобразовать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1QG/9",
            "2/9",
            "3/9",
            "6/9",
            "9/9",
            "1/11",
            "2/11",
            "4/11",
            "5/11",
            "6/11",
            "7/11",
            "13/11",
            "19/11",
            "4/13",
            "8/13",
            "10/13",
            "22/13",
            "26/13",
            "32/13",
            "4/15",
            "5/15",
            "12/15",
            "18/15",
            "19/15",
            "37/15",
            "55/15",
            "2/17",
            "4/17",
            "6/17",
            "8/17",
            "23/17",
            "26/17",
            "39/17",
            "55/17",
            "73/17",
            "11/19",
            "15/19",
            "32/19",
            "66/19",
            "88/19",
            "4/21",
            "4А/21",
            "11/21",
            "16/21",
            "20/21",
            "39/21",
            "41/21",
            "79/21",
            "121/21",
            "6/23",
            "14/23",
            "21/23",
            "53/23",
            "55/23",
            "100/23",
            "151/23",
            "8/25",
            "11/25",
            "19/25",
            "24/25",
            "25/25",
            "29/25",
            "30/25",
            "37/25",
            "42/25",
            "43/25",
            "46/25",
            "56/25",
            "61/25",
            "66/25",
            "99/25",
            "128/25",
            "187/25"});
            this.comboBox1.Location = new System.Drawing.Point(244, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "СНЦ144К";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "J599/";
            // 
            // comboBox2
            // 
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "9",
            "11",
            "13",
            "15",
            "17",
            "19",
            "21",
            "23",
            "25"});
            this.comboBox2.Location = new System.Drawing.Point(244, 58);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "В",
            "Р"});
            this.comboBox3.Location = new System.Drawing.Point(244, 85);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 5;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "О",
            "П"});
            this.comboBox4.Location = new System.Drawing.Point(244, 112);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 6;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "->";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(12, 466);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(46, 13);
            this.labelError.TabIndex = 16;
            this.labelError.Text = "No Error";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Способ монтажа";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Тип контакта";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Условный размер корпуса";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Обозначение контактной схемы";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Тип соединителя";
            // 
            // comboBox5
            // 
            this.comboBox5.Enabled = false;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBox5.Location = new System.Drawing.Point(244, 139);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 142);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Тип хвостовика";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 169);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Покрытие контактов";
            // 
            // comboBox6
            // 
            this.comboBox6.Enabled = false;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "1"});
            this.comboBox6.Location = new System.Drawing.Point(244, 166);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 21);
            this.comboBox6.TabIndex = 26;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 197);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "Поляризация";
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "N",
            "A",
            "B",
            "C",
            "D"});
            this.comboBox7.Location = new System.Drawing.Point(244, 194);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(121, 21);
            this.comboBox7.TabIndex = 30;
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 278);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(107, 13);
            this.label19.TabIndex = 45;
            this.label19.Text = "Размер хвостовика";
            // 
            // comboBox10
            // 
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Items.AddRange(new object[] {
            "C",
            "L"});
            this.comboBox10.Location = new System.Drawing.Point(244, 276);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(121, 21);
            this.comboBox10.TabIndex = 42;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 250);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(70, 13);
            this.label21.TabIndex = 41;
            this.label21.Text = "Тип корпуса";
            this.label21.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // comboBox9
            // 
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Items.AddRange(new object[] {
            "П",
            "К",
            "Н"});
            this.comboBox9.Location = new System.Drawing.Point(244, 248);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(121, 21);
            this.comboBox9.TabIndex = 38;
            this.comboBox9.SelectedIndexChanged += new System.EventHandler(this.comboBox9_SelectedIndexChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(12, 223);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(159, 13);
            this.label23.TabIndex = 37;
            this.label23.Text = "Покрытие корпусных деталей";
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
            "F",
            "W",
            "K"});
            this.comboBox8.Location = new System.Drawing.Point(244, 221);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(121, 21);
            this.comboBox8.TabIndex = 34;
            this.comboBox8.SelectedIndexChanged += new System.EventHandler(this.comboBox8_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Конвертер_СНЦ144К_в_J599.Properties.Resources._599;
            this.pictureBox2.Location = new System.Drawing.Point(541, 328);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(431, 313);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Конвертер_СНЦ144К_в_J599.Properties.Resources.СНЦ144;
            this.pictureBox1.Location = new System.Drawing.Point(541, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(431, 313);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(402, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 48;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 671);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.comboBox10);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.comboBox9);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.comboBox8);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Конвертер СНЦ144К в J599";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

