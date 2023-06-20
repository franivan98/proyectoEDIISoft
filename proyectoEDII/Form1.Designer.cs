namespace proyectoEDII
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
            txtPuertos = new ComboBox();
            label2 = new Label();
            btnPiso1 = new Button();
            btnPiso2 = new Button();
            btnPiso3 = new Button();
            btnPiso4 = new Button();
            label3 = new Label();
            txtPisoActual = new Label();
            btnEncender = new Button();
            btnApagar = new Button();
            btnEmergencia = new Button();
            btnConectar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 0;
            label1.Text = "Seleccionar Puerto";
            // 
            // txtPuertos
            // 
            txtPuertos.FormattingEnabled = true;
            txtPuertos.Location = new Point(123, 6);
            txtPuertos.Name = "txtPuertos";
            txtPuertos.Size = new Size(121, 23);
            txtPuertos.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(167, 28);
            label2.TabIndex = 2;
            label2.Text = "Enviar Ascensor a:";
            // 
            // btnPiso1
            // 
            btnPiso1.Location = new Point(24, 126);
            btnPiso1.Name = "btnPiso1";
            btnPiso1.Size = new Size(139, 41);
            btnPiso1.TabIndex = 3;
            btnPiso1.Text = "Piso 1";
            btnPiso1.UseVisualStyleBackColor = true;
            btnPiso1.Click += btnPiso1_Click;
            // 
            // btnPiso2
            // 
            btnPiso2.Location = new Point(24, 194);
            btnPiso2.Name = "btnPiso2";
            btnPiso2.Size = new Size(139, 41);
            btnPiso2.TabIndex = 4;
            btnPiso2.Text = "Piso 2";
            btnPiso2.UseVisualStyleBackColor = true;
            btnPiso2.Click += btnPiso2_Click;
            // 
            // btnPiso3
            // 
            btnPiso3.Location = new Point(24, 270);
            btnPiso3.Name = "btnPiso3";
            btnPiso3.Size = new Size(139, 41);
            btnPiso3.TabIndex = 5;
            btnPiso3.Text = "Piso 3";
            btnPiso3.UseVisualStyleBackColor = true;
            btnPiso3.Click += btnPiso3_Click;
            // 
            // btnPiso4
            // 
            btnPiso4.Location = new Point(24, 357);
            btnPiso4.Name = "btnPiso4";
            btnPiso4.Size = new Size(139, 41);
            btnPiso4.TabIndex = 6;
            btnPiso4.Text = "Piso 4";
            btnPiso4.UseVisualStyleBackColor = true;
            btnPiso4.Click += btnPiso4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(324, 71);
            label3.Name = "label3";
            label3.Size = new Size(112, 28);
            label3.TabIndex = 7;
            label3.Text = "Piso Actual:";
            // 
            // txtPisoActual
            // 
            txtPisoActual.AutoSize = true;
            txtPisoActual.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtPisoActual.Location = new Point(455, 71);
            txtPisoActual.Name = "txtPisoActual";
            txtPisoActual.Size = new Size(23, 28);
            txtPisoActual.TabIndex = 8;
            txtPisoActual.Text = "0";
            // 
            // btnEncender
            // 
            btnEncender.Location = new Point(324, 126);
            btnEncender.Name = "btnEncender";
            btnEncender.Size = new Size(139, 41);
            btnEncender.TabIndex = 9;
            btnEncender.Text = "Prender Luz";
            btnEncender.UseVisualStyleBackColor = true;
            btnEncender.Click += btnEncender_Click;
            // 
            // btnApagar
            // 
            btnApagar.Location = new Point(324, 194);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(139, 41);
            btnApagar.TabIndex = 10;
            btnApagar.Text = "Apagar Luz";
            btnApagar.UseVisualStyleBackColor = true;
            btnApagar.Click += btnApagar_Click;
            // 
            // btnEmergencia
            // 
            btnEmergencia.Location = new Point(324, 357);
            btnEmergencia.Name = "btnEmergencia";
            btnEmergencia.RightToLeft = RightToLeft.Yes;
            btnEmergencia.Size = new Size(139, 41);
            btnEmergencia.TabIndex = 11;
            btnEmergencia.Text = "EMERGENCIA";
            btnEmergencia.UseVisualStyleBackColor = true;
            btnEmergencia.Click += btnEmergencia_Click;
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(250, 6);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(97, 24);
            btnConectar.TabIndex = 12;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 462);
            Controls.Add(btnConectar);
            Controls.Add(btnEmergencia);
            Controls.Add(btnApagar);
            Controls.Add(btnEncender);
            Controls.Add(txtPisoActual);
            Controls.Add(label3);
            Controls.Add(btnPiso4);
            Controls.Add(btnPiso3);
            Controls.Add(btnPiso2);
            Controls.Add(btnPiso1);
            Controls.Add(label2);
            Controls.Add(txtPuertos);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox txtPuertos;
        private Label label2;
        private Button btnPiso1;
        private Button btnPiso2;
        private Button btnPiso3;
        private Button btnPiso4;
        private Label label3;
        private Label txtPisoActual;
        private Button btnEncender;
        private Button btnApagar;
        private Button btnEmergencia;
        private Button btnConectar;
    }
}