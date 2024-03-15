namespace GorselProgramlamaOdevDemo
{
    partial class Form5
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
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            Duzenle = new Button();
            SuspendLayout();
            // 
            // textBox5
            // 
            textBox5.Location = new Point(492, 87);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(124, 23);
            textBox5.TabIndex = 19;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(358, 87);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(124, 23);
            textBox4.TabIndex = 18;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(209, 87);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(124, 23);
            textBox3.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(49, 87);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(124, 23);
            textBox2.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(492, 53);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 15;
            label5.Text = "Bölüm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(358, 53);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 14;
            label4.Text = "Fakülte";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(209, 53);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 13;
            label2.Text = "Soyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 53);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 12;
            label1.Text = "Ad";
            // 
            // Duzenle
            // 
            Duzenle.Location = new Point(311, 196);
            Duzenle.Name = "Duzenle";
            Duzenle.Size = new Size(75, 23);
            Duzenle.TabIndex = 11;
            Duzenle.Text = "Düzenle";
            Duzenle.UseVisualStyleBackColor = true;
            Duzenle.Click += Duzenle_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 261);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Duzenle);
            Name = "Form5";
            Text = "Öğrenci düzenle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button Duzenle;
    }
}