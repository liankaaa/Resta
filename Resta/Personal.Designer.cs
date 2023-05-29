namespace Resta
{
    partial class Personal
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources._85dce4f03e9388fff97a7eb8a6a8594f;
            pictureBox1.Location = new Point(98, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(273, 325);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(647, 322);
            button1.Name = "button1";
            button1.Size = new Size(94, 38);
            button1.TabIndex = 1;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(482, 98);
            label1.Name = "label1";
            label1.Size = new Size(152, 22);
            label1.TabIndex = 2;
            label1.Text = "Личные данные";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(423, 193);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(301, 25);
            textBox1.TabIndex = 3;
            textBox1.Text = "Михайлова Ангелина Павловна";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(423, 164);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(301, 25);
            textBox2.TabIndex = 4;
            textBox2.Text = "Администратор";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(423, 135);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(301, 25);
            textBox3.TabIndex = 5;
            textBox3.Text = "ID - 627263";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(423, 222);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(301, 25);
            textBox4.TabIndex = 6;
            textBox4.Text = "+7 992 675 78 56";
            // 
            // Personal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1674275669_catherineasquithgallery_com_p_serii_fon_dlya_instagram_storis_foto_180;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Personal";
            Text = "Personal";
            WindowState = FormWindowState.Maximized;
            Load += Personal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}