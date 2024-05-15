namespace PREUBA_2
{
    partial class Form4
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
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            button7 = new Button();
            panel3 = new Panel();
            vScrollBar1 = new VScrollBar();
            comboBox1 = new ComboBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 116, 204);
            label2.Location = new Point(324, 30);
            label2.Name = "label2";
            label2.Size = new Size(1529, 175);
            label2.TabIndex = 18;
            label2.Text = "BUSCAR REPORTES";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(0, 116, 204);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 1021);
            panel1.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(0, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(320, 144);
            panel2.TabIndex = 8;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(0, 116, 204);
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Montserrat", 10.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.ForeColor = Color.White;
            button10.Location = new Point(0, 648);
            button10.Name = "button10";
            button10.Size = new Size(320, 72);
            button10.TabIndex = 6;
            button10.Text = "REGISTRO";
            button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.White;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Montserrat", 10.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.FromArgb(0, 116, 204);
            button9.Location = new Point(0, 504);
            button9.Name = "button9";
            button9.Size = new Size(320, 72);
            button9.TabIndex = 5;
            button9.Text = "ARCHIVO";
            button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(0, 116, 204);
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Montserrat", 10.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.White;
            button8.Location = new Point(0, 576);
            button8.Name = "button8";
            button8.Size = new Size(320, 72);
            button8.TabIndex = 4;
            button8.Text = "HISTORIAL";
            button8.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 116, 204);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Montserrat", 10.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 432);
            button1.Name = "button1";
            button1.Size = new Size(321, 72);
            button1.TabIndex = 0;
            button1.Text = "SUBIR REPORTE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.Font = new Font("Montserrat", 23.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(0, 116, 204);
            textBox1.Location = new Point(341, 305);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1512, 66);
            textBox1.TabIndex = 34;
            textBox1.Text = "NOMBRE";
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            button7.BackColor = Color.White;
            button7.FlatAppearance.BorderColor = Color.White;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseDownBackColor = Color.White;
            button7.FlatAppearance.MouseOverBackColor = Color.White;
            button7.Font = new Font("Montserrat", 23.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.FromArgb(0, 116, 204);
            button7.Location = new Point(1582, 206);
            button7.Margin = new Padding(0);
            button7.Name = "button7";
            button7.Size = new Size(246, 81);
            button7.TabIndex = 35;
            button7.Text = "BUSCAR";
            button7.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 116, 204);
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(vScrollBar1);
            panel3.ForeColor = Color.FromArgb(0, 116, 204);
            panel3.Location = new Point(341, 398);
            panel3.Name = "panel3";
            panel3.Size = new Size(1536, 623);
            panel3.TabIndex = 38;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(1497, 0);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(39, 497);
            vScrollBar1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Montserrat", 23.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Nombre de Paciente", "ID del Paciente", "Nombre de Reporte" });
            comboBox1.Location = new Point(685, 206);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(643, 66);
            comboBox1.TabIndex = 39;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 23.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 116, 204);
            label1.Location = new Point(332, 206);
            label1.Name = "label1";
            label1.Size = new Size(353, 58);
            label1.TabIndex = 40;
            label1.Text = "BUSCAR POR";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1473, 523);
            dataGridView1.TabIndex = 36;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button7);
            Controls.Add(panel3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Form4";
            Text = "Form4";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private Button button7;
        private Panel panel3;
        private VScrollBar vScrollBar1;
        private ComboBox comboBox1;
        private Label label1;
        private DataGridView dataGridView1;
    }
}