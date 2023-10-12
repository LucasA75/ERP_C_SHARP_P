namespace WinFormsApp1
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            calcularBtn = new Button();
            guardarBtn = new Button();
            button3 = new Button();
            listBtn = new Button();
            namePerson = new Label();
            afpCombobox = new ComboBox();
            saludCombobox = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            sueldoBrutoBox = new TextBox();
            sueldoLiquidoBox = new TextBox();
            rutCombobox = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 137);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 0;
            label1.Text = "Horas Trabajadas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 198);
            label2.Name = "label2";
            label2.Size = new Size(110, 25);
            label2.TabIndex = 1;
            label2.Text = "Horas Extras";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(367, 379);
            label3.Name = "label3";
            label3.Size = new Size(115, 25);
            label3.TabIndex = 2;
            label3.Text = "Sueldo Bruto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(351, 456);
            label4.Name = "label4";
            label4.Size = new Size(131, 25);
            label4.TabIndex = 3;
            label4.Text = "Sueldo Liquido";
            // 
            // calcularBtn
            // 
            calcularBtn.Location = new Point(32, 288);
            calcularBtn.Name = "calcularBtn";
            calcularBtn.Size = new Size(112, 34);
            calcularBtn.TabIndex = 4;
            calcularBtn.Text = "Calcular";
            calcularBtn.UseVisualStyleBackColor = true;
            calcularBtn.Click += calcularBtn_Click;
            // 
            // guardarBtn
            // 
            guardarBtn.Location = new Point(32, 337);
            guardarBtn.Name = "guardarBtn";
            guardarBtn.Size = new Size(112, 34);
            guardarBtn.TabIndex = 5;
            guardarBtn.Text = "Guardar";
            guardarBtn.UseVisualStyleBackColor = true;
            guardarBtn.Click += guardarBtn_Click;
            // 
            // button3
            // 
            button3.Location = new Point(32, 377);
            button3.Name = "button3";
            button3.Size = new Size(112, 75);
            button3.TabIndex = 6;
            button3.Text = "Limpiar Campos";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBtn
            // 
            listBtn.Location = new Point(32, 457);
            listBtn.Name = "listBtn";
            listBtn.Size = new Size(112, 34);
            listBtn.TabIndex = 7;
            listBtn.Text = "Listar";
            listBtn.UseVisualStyleBackColor = true;
            listBtn.Click += listBtn_Click;
            // 
            // namePerson
            // 
            namePerson.AutoSize = true;
            namePerson.Location = new Point(64, 9);
            namePerson.Name = "namePerson";
            namePerson.Size = new Size(78, 25);
            namePerson.TabIndex = 8;
            namePerson.Text = "Nombre";
            // 
            // afpCombobox
            // 
            afpCombobox.FormattingEnabled = true;
            afpCombobox.Location = new Point(504, 129);
            afpCombobox.Name = "afpCombobox";
            afpCombobox.Size = new Size(182, 33);
            afpCombobox.TabIndex = 10;
            afpCombobox.SelectedIndexChanged += afpCombobox_SelectedIndexChanged;
            // 
            // saludCombobox
            // 
            saludCombobox.FormattingEnabled = true;
            saludCombobox.Location = new Point(504, 210);
            saludCombobox.Name = "saludCombobox";
            saludCombobox.Size = new Size(182, 33);
            saludCombobox.TabIndex = 11;
            saludCombobox.SelectedIndexChanged += saludCombobox_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(197, 134);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 12;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(197, 192);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 13;
            // 
            // sueldoBrutoBox
            // 
            sueldoBrutoBox.BackColor = SystemColors.Window;
            sueldoBrutoBox.Location = new Point(523, 379);
            sueldoBrutoBox.Name = "sueldoBrutoBox";
            sueldoBrutoBox.ReadOnly = true;
            sueldoBrutoBox.Size = new Size(150, 31);
            sueldoBrutoBox.TabIndex = 14;
            // 
            // sueldoLiquidoBox
            // 
            sueldoLiquidoBox.BackColor = SystemColors.Window;
            sueldoLiquidoBox.Location = new Point(523, 453);
            sueldoLiquidoBox.Name = "sueldoLiquidoBox";
            sueldoLiquidoBox.ReadOnly = true;
            sueldoLiquidoBox.Size = new Size(150, 31);
            sueldoLiquidoBox.TabIndex = 15;
            // 
            // rutCombobox
            // 
            rutCombobox.FormattingEnabled = true;
            rutCombobox.Location = new Point(319, 41);
            rutCombobox.Name = "rutCombobox";
            rutCombobox.Size = new Size(182, 33);
            rutCombobox.TabIndex = 16;
            rutCombobox.SelectedIndexChanged += rutCombobox_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(186, 44);
            label5.Name = "label5";
            label5.Size = new Size(127, 25);
            label5.TabIndex = 17;
            label5.Text = "Rut Trabajador";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(408, 134);
            label6.Name = "label6";
            label6.Size = new Size(43, 25);
            label6.TabIndex = 18;
            label6.Text = "AFP";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(408, 213);
            label7.Name = "label7";
            label7.Size = new Size(56, 25);
            label7.TabIndex = 19;
            label7.Text = "Salud";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(728, 532);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(rutCombobox);
            Controls.Add(sueldoLiquidoBox);
            Controls.Add(sueldoBrutoBox);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(saludCombobox);
            Controls.Add(afpCombobox);
            Controls.Add(namePerson);
            Controls.Add(listBtn);
            Controls.Add(button3);
            Controls.Add(guardarBtn);
            Controls.Add(calcularBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button button1;
        private Button guardarBtn;
        private Button button3;
        private Button listBtn;
        private Label namePerson;
        private ComboBox afpCombobox;
        private ComboBox saludCombobox;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox rutCombobox;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button calcularBtn;
        private TextBox sueldoBrutoBox;
        private TextBox sueldoLiquidoBox;
    }
}