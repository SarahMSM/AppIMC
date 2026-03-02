namespace AppIMC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblClassific = new Label();
            lblIMC = new Label();
            btCalc = new Button();
            nudPeso = new NumericUpDown();
            nudAltura = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)nudPeso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAltura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblClassific
            // 
            lblClassific.AutoSize = true;
            lblClassific.Font = new Font("Comic Sans MS", 18F);
            lblClassific.ForeColor = Color.DarkMagenta;
            lblClassific.Location = new Point(19, 233);
            lblClassific.Name = "lblClassific";
            lblClassific.Size = new Size(0, 33);
            lblClassific.TabIndex = 11;
            // 
            // lblIMC
            // 
            lblIMC.AutoSize = true;
            lblIMC.Font = new Font("Comic Sans MS", 18F);
            lblIMC.ForeColor = Color.DarkBlue;
            lblIMC.Location = new Point(19, 187);
            lblIMC.Name = "lblIMC";
            lblIMC.Size = new Size(0, 33);
            lblIMC.TabIndex = 10;
            // 
            // btCalc
            // 
            btCalc.Enabled = false;
            btCalc.FlatAppearance.BorderColor = Color.FromArgb(128, 128, 255);
            btCalc.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            btCalc.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btCalc.FlatStyle = FlatStyle.Flat;
            btCalc.Font = new Font("Comic Sans MS", 18F);
            btCalc.Location = new Point(95, 143);
            btCalc.Name = "btCalc";
            btCalc.Size = new Size(154, 41);
            btCalc.TabIndex = 9;
            btCalc.Text = "&Calcular";
            btCalc.UseVisualStyleBackColor = true;
            btCalc.Click += btCalc_Click;
            // 
            // nudPeso
            // 
            nudPeso.DecimalPlaces = 2;
            nudPeso.Font = new Font("Comic Sans MS", 18F);
            nudPeso.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudPeso.Location = new Point(95, 96);
            nudPeso.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudPeso.Name = "nudPeso";
            nudPeso.Size = new Size(154, 41);
            nudPeso.TabIndex = 8;
            // 
            // nudAltura
            // 
            nudAltura.AccessibleDescription = "oi";
            nudAltura.DecimalPlaces = 2;
            nudAltura.Font = new Font("Comic Sans MS", 18F);
            nudAltura.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudAltura.Location = new Point(95, 42);
            nudAltura.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudAltura.Name = "nudAltura";
            nudAltura.Size = new Size(154, 41);
            nudAltura.TabIndex = 7;
            nudAltura.ValueChanged += nudAltura_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Comic Sans MS", 18F);
            label5.ForeColor = Color.DarkTurquoise;
            label5.Location = new Point(255, 104);
            label5.Name = "label5";
            label5.Size = new Size(42, 33);
            label5.TabIndex = 6;
            label5.Text = "kg";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Comic Sans MS", 18F);
            label4.ForeColor = Color.Gold;
            label4.Location = new Point(255, 50);
            label4.Name = "label4";
            label4.Size = new Size(33, 33);
            label4.TabIndex = 5;
            label4.Text = "m";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Comic Sans MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(77, 40);
            label3.TabIndex = 4;
            label3.Text = "IMC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Comic Sans MS", 18F);
            label2.ForeColor = Color.SpringGreen;
            label2.Location = new Point(23, 96);
            label2.Name = "label2";
            label2.Size = new Size(73, 33);
            label2.TabIndex = 2;
            label2.Text = "Peso:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 18F);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(5, 44);
            label1.Name = "label1";
            label1.Size = new Size(91, 33);
            label1.TabIndex = 0;
            label1.Text = "Altura:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(327, 294);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(322, 291);
            Controls.Add(lblClassific);
            Controls.Add(lblIMC);
            Controls.Add(btCalc);
            Controls.Add(nudPeso);
            Controls.Add(nudAltura);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            ForeColor = Color.DodgerBlue;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora de IMC";
            ((System.ComponentModel.ISupportInitialize)nudPeso).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAltura).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblClassific;
        private Label lblIMC;
        private Button btCalc;
        private NumericUpDown nudPeso;
        private NumericUpDown nudAltura;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
