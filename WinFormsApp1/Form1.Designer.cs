namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            entryBtn = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(282, 25);
            label1.Name = "label1";
            label1.Size = new Size(234, 41);
            label1.TabIndex = 0;
            label1.Text = "Autentificacion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 125);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(180, 185);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // entryBtn
            // 
            entryBtn.Location = new Point(299, 273);
            entryBtn.Name = "entryBtn";
            entryBtn.Size = new Size(204, 48);
            entryBtn.TabIndex = 3;
            entryBtn.Text = "Ingresar";
            entryBtn.UseVisualStyleBackColor = true;
            entryBtn.Click += entryBtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(282, 185);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(308, 31);
            textBox1.TabIndex = 4;
            textBox1.UseSystemPasswordChar = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(282, 119);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(308, 31);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(entryBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button entryBtn;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}