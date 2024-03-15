namespace GorselProgramlamaOdevDemo
{
    partial class Form3
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
            Listele = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // Listele
            // 
            Listele.Location = new Point(12, 262);
            Listele.Name = "Listele";
            Listele.Size = new Size(80, 24);
            Listele.TabIndex = 1;
            Listele.Text = "Listele";
            Listele.UseVisualStyleBackColor = true;
            Listele.Click += Listele_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(503, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(115, 274);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 26);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 3;
            label1.Text = "Seçilen öğrenci:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Info;
            label2.ForeColor = SystemColors.InfoText;
            label2.ImageAlign = ContentAlignment.TopLeft;
            label2.Location = new Point(12, 244);
            label2.Name = "label2";
            label2.Size = new Size(427, 15);
            label2.TabIndex = 4;
            label2.Text = "Lütfen işleminizi yaptıktan sonra tekrar butona basınız ve sekmeyi kapatmayınız.";
            label2.Click += label2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 303);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(Listele);
            Name = "Form3";
            Text = "Öğrenci listele";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Öğrenciler;
        private Button Listele;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
    }
}