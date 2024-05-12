namespace PREUBA_2
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
            label3 = new Label();
            button4 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            panel2 = new Panel();
            button2 = new Button();
            button3 = new Button();
            button1 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 116, 204);
            label3.Location = new Point(335, 304);
            label3.Name = "label3";
            label3.Size = new Size(320, 34);
            label3.TabIndex = 17;
            label3.Text = "Nombre del reporte...";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 116, 204);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Montserrat", 10.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(587, 585);
            button4.Name = "button4";
            button4.Size = new Size(253, 48);
            button4.TabIndex = 16;
            button4.Text = "SUBIR ARCHIVO";
            button4.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(0, 116, 204);
            textBox1.Location = new Point(341, 341);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(632, 42);
            textBox1.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 60F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 116, 204);
            label2.Location = new Point(325, 5);
            label2.Name = "label2";
            label2.Size = new Size(1474, 292);
            label2.TabIndex = 14;
            label2.Text = "CONTINUAR REPORTE \r\nDE RESULTADOS";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Montserrat", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.ForeColor = Color.FromArgb(0, 116, 204);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(340, 486);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(718, 37);
            comboBox2.TabIndex = 13;
            comboBox2.Text = "Estudio Anterior";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Montserrat", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = Color.FromArgb(0, 116, 204);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(340, 413);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(718, 37);
            comboBox1.TabIndex = 12;
            comboBox1.Text = "Nombre del paciente";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 116, 204);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 1021);
            panel1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(0, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(320, 144);
            panel2.TabIndex = 9;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 116, 204);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Montserrat", 10.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 288);
            button2.Name = "button2";
            button2.Size = new Size(320, 72);
            button2.TabIndex = 2;
            button2.Text = "INICIO";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 116, 204);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Montserrat", 10.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(0, 360);
            button3.Name = "button3";
            button3.Size = new Size(320, 72);
            button3.TabIndex = 3;
            button3.Text = "REGISTRO DE ESPERA";
            button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 116, 204);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Montserrat", 10.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 432);
            button1.Name = "button1";
            button1.Size = new Size(320, 72);
            button1.TabIndex = 0;
            button1.Text = "SUBIR REPORTE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(0, 116, 204);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Montserrat", 10.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(0, 576);
            button5.Name = "button5";
            button5.Size = new Size(320, 72);
            button5.TabIndex = 18;
            button5.Text = "ARCHIVO";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(0, 116, 204);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Montserrat", 10.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(0, 648);
            button6.Name = "button6";
            button6.Size = new Size(320, 72);
            button6.TabIndex = 19;
            button6.Text = "HISTORIAL";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(0, 116, 204);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Montserrat", 10.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.White;
            button7.Location = new Point(0, 720);
            button7.Name = "button7";
            button7.Size = new Size(320, 72);
            button7.TabIndex = 20;
            button7.Text = "REGISTRO";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Montserrat", 10.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.FromArgb(0, 116, 204);
            button8.Location = new Point(0, 504);
            button8.Name = "button8";
            button8.Size = new Size(320, 72);
            button8.TabIndex = 21;
            button8.Text = "CONTINUAR REPORTE";
            button8.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form3";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button button4;
        private TextBox textBox1;
        private Label label2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel2;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}
