namespace ej1
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
            btnRegistrarMedida = new Button();
            btnVerCantidad = new Button();
            label2 = new Label();
            lbLote = new Label();
            btnVerNumeroLote = new Button();
            btnAsignarNumeroLote = new Button();
            btnCrearLote = new Button();
            label3 = new Label();
            lbCantidad = new Label();
            tbAsignarNumeroLote = new TextBox();
            btnVerMedida = new Button();
            tbIndice = new TextBox();
            label = new Label();
            label5 = new Label();
            lbMedida = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(29, 9);
            label1.Name = "label1";
            label1.Size = new Size(162, 28);
            label1.TabIndex = 0;
            label1.Text = "Registro de Lotes";
            // 
            // btnRegistrarMedida
            // 
            btnRegistrarMedida.Location = new Point(29, 223);
            btnRegistrarMedida.Name = "btnRegistrarMedida";
            btnRegistrarMedida.Size = new Size(180, 54);
            btnRegistrarMedida.TabIndex = 1;
            btnRegistrarMedida.Text = "Registrar medida";
            btnRegistrarMedida.UseVisualStyleBackColor = true;
            btnRegistrarMedida.Click += btnRegistrarMedida_Click;
            // 
            // btnVerCantidad
            // 
            btnVerCantidad.Location = new Point(249, 182);
            btnVerCantidad.Name = "btnVerCantidad";
            btnVerCantidad.Size = new Size(113, 50);
            btnVerCantidad.TabIndex = 3;
            btnVerCantidad.Text = "Mostrar cantidad";
            btnVerCantidad.UseVisualStyleBackColor = true;
            btnVerCantidad.Click += btnVerCantidad_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 122);
            label2.Name = "label2";
            label2.Size = new Size(43, 21);
            label2.TabIndex = 4;
            label2.Text = "Lote:";
            // 
            // lbLote
            // 
            lbLote.BackColor = SystemColors.ActiveCaption;
            lbLote.Location = new Point(298, 122);
            lbLote.Name = "lbLote";
            lbLote.Size = new Size(38, 21);
            lbLote.TabIndex = 5;
            lbLote.Click += lbLote_Click;
            // 
            // btnVerNumeroLote
            // 
            btnVerNumeroLote.Location = new Point(249, 30);
            btnVerNumeroLote.Name = "btnVerNumeroLote";
            btnVerNumeroLote.Size = new Size(113, 72);
            btnVerNumeroLote.TabIndex = 6;
            btnVerNumeroLote.Text = "Mostrar numero de lote";
            btnVerNumeroLote.UseVisualStyleBackColor = true;
            btnVerNumeroLote.Click += btnVerNumeroLote_Click;
            // 
            // btnAsignarNumeroLote
            // 
            btnAsignarNumeroLote.Location = new Point(21, 147);
            btnAsignarNumeroLote.Name = "btnAsignarNumeroLote";
            btnAsignarNumeroLote.Size = new Size(188, 29);
            btnAsignarNumeroLote.TabIndex = 7;
            btnAsignarNumeroLote.Text = "Asignar numero de lote";
            btnAsignarNumeroLote.UseVisualStyleBackColor = true;
            btnAsignarNumeroLote.Click += btnAsignarNumeroLote_Click;
            // 
            // btnCrearLote
            // 
            btnCrearLote.Location = new Point(29, 59);
            btnCrearLote.Name = "btnCrearLote";
            btnCrearLote.Size = new Size(113, 72);
            btnCrearLote.TabIndex = 8;
            btnCrearLote.Text = "Crear nuevo lote";
            btnCrearLote.UseVisualStyleBackColor = true;
            btnCrearLote.Click += btnCrearLote_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(249, 256);
            label3.Name = "label3";
            label3.Size = new Size(75, 21);
            label3.TabIndex = 9;
            label3.Text = "Cantidad:";
            // 
            // lbCantidad
            // 
            lbCantidad.BackColor = SystemColors.ActiveCaption;
            lbCantidad.Location = new Point(330, 256);
            lbCantidad.Name = "lbCantidad";
            lbCantidad.Size = new Size(38, 21);
            lbCantidad.TabIndex = 10;
            // 
            // tbAsignarNumeroLote
            // 
            tbAsignarNumeroLote.Location = new Point(21, 182);
            tbAsignarNumeroLote.Name = "tbAsignarNumeroLote";
            tbAsignarNumeroLote.Size = new Size(54, 29);
            tbAsignarNumeroLote.TabIndex = 11;
            // 
            // btnVerMedida
            // 
            btnVerMedida.Location = new Point(29, 295);
            btnVerMedida.Name = "btnVerMedida";
            btnVerMedida.Size = new Size(149, 39);
            btnVerMedida.TabIndex = 12;
            btnVerMedida.Text = "Ver medida";
            btnVerMedida.UseVisualStyleBackColor = true;
            btnVerMedida.Click += btnVerMedida_Click;
            // 
            // tbIndice
            // 
            tbIndice.Location = new Point(81, 340);
            tbIndice.Name = "tbIndice";
            tbIndice.Size = new Size(33, 29);
            tbIndice.TabIndex = 13;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(23, 343);
            label.Name = "label";
            label.Size = new Size(54, 21);
            label.TabIndex = 14;
            label.Text = "Indice:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(144, 343);
            label5.Name = "label5";
            label5.Size = new Size(65, 21);
            label5.TabIndex = 15;
            label5.Text = "Medida:";
            // 
            // lbMedida
            // 
            lbMedida.BackColor = SystemColors.ActiveCaption;
            lbMedida.Location = new Point(215, 340);
            lbMedida.Name = "lbMedida";
            lbMedida.Size = new Size(38, 26);
            lbMedida.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 384);
            Controls.Add(lbMedida);
            Controls.Add(label5);
            Controls.Add(label);
            Controls.Add(tbIndice);
            Controls.Add(btnVerMedida);
            Controls.Add(tbAsignarNumeroLote);
            Controls.Add(lbCantidad);
            Controls.Add(label3);
            Controls.Add(btnCrearLote);
            Controls.Add(btnAsignarNumeroLote);
            Controls.Add(btnVerNumeroLote);
            Controls.Add(lbLote);
            Controls.Add(label2);
            Controls.Add(btnVerCantidad);
            Controls.Add(btnRegistrarMedida);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnRegistrarMedida;
        private Button btnVerCantidad;
        private Label label2;
        private Label lbLote;
        private Button btnVerNumeroLote;
        private Button btnAsignarNumeroLote;
        private Button btnCrearLote;
        private Label label3;
        private Label lbCantidad;
        private TextBox tbAsignarNumeroLote;
        private Button btnVerMedida;
        private TextBox tbIndice;
        private Label label;
        private Label label5;
        private Label lbMedida;
    }
}
