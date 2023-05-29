namespace Resta
{
    partial class ReservHall
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button2 = new Button();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox5 = new MaskedTextBox();
            maskedTextBox6 = new MaskedTextBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(24, 19);
            button1.Name = "button1";
            button1.Size = new Size(94, 38);
            button1.TabIndex = 0;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(170, 136);
            label1.Name = "label1";
            label1.Size = new Size(165, 22);
            label1.TabIndex = 1;
            label1.Text = "Дата проведения:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(261, 163);
            label2.Name = "label2";
            label2.Size = new Size(70, 22);
            label2.TabIndex = 2;
            label2.Text = "Время:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(223, 193);
            label3.Name = "label3";
            label3.Size = new Size(112, 22);
            label3.TabIndex = 3;
            label3.Text = "Выбор зала:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(161, 222);
            label4.Name = "label4";
            label4.Size = new Size(174, 22);
            label4.TabIndex = 4;
            label4.Text = "Тип мероприятия:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(274, 251);
            label5.Name = "label5";
            label5.Size = new Size(61, 22);
            label5.TabIndex = 5;
            label5.Text = "ФИО:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(174, 280);
            label6.Name = "label6";
            label6.Size = new Size(161, 22);
            label6.TabIndex = 6;
            label6.Text = "Номер телефона:";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(625, 350);
            button2.Name = "button2";
            button2.Size = new Size(116, 53);
            button2.TabIndex = 13;
            button2.Text = "Записать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Anchor = AnchorStyles.None;
            maskedTextBox1.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox1.Location = new Point(341, 137);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(262, 22);
            maskedTextBox1.TabIndex = 14;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Anchor = AnchorStyles.None;
            maskedTextBox2.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox2.Location = new Point(341, 166);
            maskedTextBox2.Mask = "00:00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(262, 22);
            maskedTextBox2.TabIndex = 15;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Anchor = AnchorStyles.None;
            maskedTextBox3.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox3.Location = new Point(341, 194);
            maskedTextBox3.Mask = "№0";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(262, 22);
            maskedTextBox3.TabIndex = 16;
            // 
            // maskedTextBox5
            // 
            maskedTextBox5.Anchor = AnchorStyles.None;
            maskedTextBox5.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox5.Location = new Point(341, 252);
            maskedTextBox5.Name = "maskedTextBox5";
            maskedTextBox5.Size = new Size(262, 22);
            maskedTextBox5.TabIndex = 18;
            // 
            // maskedTextBox6
            // 
            maskedTextBox6.Anchor = AnchorStyles.None;
            maskedTextBox6.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox6.Location = new Point(341, 281);
            maskedTextBox6.Mask = "+7 999 000 0000";
            maskedTextBox6.Name = "maskedTextBox6";
            maskedTextBox6.Size = new Size(262, 22);
            maskedTextBox6.TabIndex = 19;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Свадьба", "Юбилей", "День рождения", "Встреча одноклассников", "Выпускной", "Поминки", "Корпоратив " });
            comboBox1.Location = new Point(341, 222);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(262, 23);
            comboBox1.TabIndex = 20;
            // 
            // ReservHall
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1674275669_catherineasquithgallery_com_p_serii_fon_dlya_instagram_storis_foto_180;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(maskedTextBox6);
            Controls.Add(maskedTextBox5);
            Controls.Add(maskedTextBox3);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "ReservHall";
            Text = "ReservHall";
            WindowState = FormWindowState.Maximized;
            Load += ReservHall_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button2;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox5;
        private MaskedTextBox maskedTextBox6;
        private ComboBox comboBox1;
    }
}