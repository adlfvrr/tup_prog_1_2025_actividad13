namespace ej1
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
            tbRegistrarMedida = new TextBox();
            btnAsignar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 21);
            label1.TabIndex = 0;
            label1.Text = "Medida:";
            // 
            // tbRegistrarMedida
            // 
            tbRegistrarMedida.Location = new Point(116, 28);
            tbRegistrarMedida.Name = "tbRegistrarMedida";
            tbRegistrarMedida.Size = new Size(82, 29);
            tbRegistrarMedida.TabIndex = 1;
            tbRegistrarMedida.TextChanged += tbRegistrarMedida_TextChanged;
            // 
            // btnAsignar
            // 
            btnAsignar.DialogResult = DialogResult.OK;
            btnAsignar.Location = new Point(207, 69);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(107, 45);
            btnAsignar.TabIndex = 2;
            btnAsignar.Text = "Asignar";
            btnAsignar.UseVisualStyleBackColor = true;
            btnAsignar.Click += btnAsignar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(60, 69);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(93, 45);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 164);
            Controls.Add(btnCancelar);
            Controls.Add(btnAsignar);
            Controls.Add(tbRegistrarMedida);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public TextBox tbRegistrarMedida;
        public Button btnAsignar;
        public Button btnCancelar;
    }
}