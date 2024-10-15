namespace Cola_Doble_Dinamica
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
            btnInsertarFrente = new Button();
            btnInsertarFinal = new Button();
            btnEliminarFrente = new Button();
            btnEliminarFinal = new Button();
            btnVerFrente = new Button();
            btnVerFinal = new Button();
            label1 = new Label();
            txtValor = new TextBox();
            listBoxCola = new ListBox();
            txtValue = new TextBox();
            sas = new Label();
            SuspendLayout();
            // 
            // btnInsertarFrente
            // 
            btnInsertarFrente.BackColor = SystemColors.ActiveCaption;
            btnInsertarFrente.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsertarFrente.ForeColor = SystemColors.ActiveCaptionText;
            btnInsertarFrente.Location = new Point(51, 231);
            btnInsertarFrente.Name = "btnInsertarFrente";
            btnInsertarFrente.Size = new Size(106, 46);
            btnInsertarFrente.TabIndex = 0;
            btnInsertarFrente.Text = "Insert Front";
            btnInsertarFrente.UseVisualStyleBackColor = false;
            btnInsertarFrente.Click += btnInsertarFrente_Click;
            // 
            // btnInsertarFinal
            // 
            btnInsertarFinal.BackColor = SystemColors.ActiveCaption;
            btnInsertarFinal.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsertarFinal.ForeColor = SystemColors.ActiveCaptionText;
            btnInsertarFinal.Location = new Point(51, 299);
            btnInsertarFinal.Name = "btnInsertarFinal";
            btnInsertarFinal.Size = new Size(106, 46);
            btnInsertarFinal.TabIndex = 1;
            btnInsertarFinal.Text = "Insert Rear";
            btnInsertarFinal.UseVisualStyleBackColor = false;
            btnInsertarFinal.Click += btnInsertarFinal_Click;
            // 
            // btnEliminarFrente
            // 
            btnEliminarFrente.BackColor = SystemColors.ActiveCaption;
            btnEliminarFrente.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarFrente.ForeColor = SystemColors.ActiveCaptionText;
            btnEliminarFrente.Location = new Point(193, 231);
            btnEliminarFrente.Name = "btnEliminarFrente";
            btnEliminarFrente.Size = new Size(106, 46);
            btnEliminarFrente.TabIndex = 2;
            btnEliminarFrente.Text = "Delete Front";
            btnEliminarFrente.UseVisualStyleBackColor = false;
            btnEliminarFrente.Click += btnEliminarFrente_Click;
            // 
            // btnEliminarFinal
            // 
            btnEliminarFinal.BackColor = SystemColors.ActiveCaption;
            btnEliminarFinal.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarFinal.ForeColor = SystemColors.ActiveCaptionText;
            btnEliminarFinal.Location = new Point(193, 299);
            btnEliminarFinal.Name = "btnEliminarFinal";
            btnEliminarFinal.Size = new Size(106, 46);
            btnEliminarFinal.TabIndex = 3;
            btnEliminarFinal.Text = "Delete Rear";
            btnEliminarFinal.UseVisualStyleBackColor = false;
            btnEliminarFinal.Click += btnEliminarFinal_Click;
            // 
            // btnVerFrente
            // 
            btnVerFrente.BackColor = SystemColors.ActiveCaption;
            btnVerFrente.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerFrente.ForeColor = SystemColors.ActiveCaptionText;
            btnVerFrente.Location = new Point(329, 231);
            btnVerFrente.Name = "btnVerFrente";
            btnVerFrente.Size = new Size(106, 46);
            btnVerFrente.TabIndex = 4;
            btnVerFrente.Text = "Show Front";
            btnVerFrente.UseVisualStyleBackColor = false;
            btnVerFrente.Click += btnVerFrente_Click;
            // 
            // btnVerFinal
            // 
            btnVerFinal.BackColor = SystemColors.ActiveCaption;
            btnVerFinal.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerFinal.ForeColor = SystemColors.ActiveCaptionText;
            btnVerFinal.Location = new Point(329, 299);
            btnVerFinal.Name = "btnVerFinal";
            btnVerFinal.Size = new Size(106, 46);
            btnVerFinal.TabIndex = 5;
            btnVerFinal.Text = "Show Rear";
            btnVerFinal.UseVisualStyleBackColor = false;
            btnVerFinal.Click += btnVerFinal_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 94);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 6;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(-74, -90);
            txtValor.Multiline = true;
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(139, 37);
            txtValor.TabIndex = 7;
            // 
            // listBoxCola
            // 
            listBoxCola.FormattingEnabled = true;
            listBoxCola.ItemHeight = 15;
            listBoxCola.Location = new Point(279, 42);
            listBoxCola.Name = "listBoxCola";
            listBoxCola.Size = new Size(242, 154);
            listBoxCola.TabIndex = 8;
            // 
            // txtValue
            // 
            txtValue.Location = new Point(72, 86);
            txtValue.Multiline = true;
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(123, 35);
            txtValue.TabIndex = 9;
            // 
            // sas
            // 
            sas.AutoSize = true;
            sas.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sas.Location = new Point(81, 42);
            sas.Name = "sas";
            sas.Size = new Size(138, 24);
            sas.TabIndex = 10;
            sas.Text = "Insert Number";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(sas);
            Controls.Add(txtValue);
            Controls.Add(listBoxCola);
            Controls.Add(txtValor);
            Controls.Add(label1);
            Controls.Add(btnVerFinal);
            Controls.Add(btnVerFrente);
            Controls.Add(btnEliminarFinal);
            Controls.Add(btnEliminarFrente);
            Controls.Add(btnInsertarFinal);
            Controls.Add(btnInsertarFrente);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInsertarFrente;
        private Button btnInsertarFinal;
        private Button btnEliminarFrente;
        private Button btnEliminarFinal;
        private Button btnVerFrente;
        private Button btnVerFinal;
        private Label label1;
        private TextBox txtValor;
        private ListBox listBoxCola;
        private TextBox txtValue;
        private Label sas;
    }
}
