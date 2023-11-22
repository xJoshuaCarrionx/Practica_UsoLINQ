namespace Practica_para_examen
{
    partial class frmLibros
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
            txtBuscarLibro = new TextBox();
            dgvLibros = new DataGridView();
            label2 = new Label();
            txtAutorLibros = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingresa un Libro:";
            // 
            // txtBuscarLibro
            // 
            txtBuscarLibro.Location = new Point(113, 12);
            txtBuscarLibro.Name = "txtBuscarLibro";
            txtBuscarLibro.Size = new Size(224, 23);
            txtBuscarLibro.TabIndex = 1;
            txtBuscarLibro.KeyDown += txtBuscarLibro_KeyDown;
            // 
            // dgvLibros
            // 
            dgvLibros.AccessibleRole = AccessibleRole.Client;
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Location = new Point(12, 41);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.RowTemplate.Height = 25;
            dgvLibros.Size = new Size(443, 158);
            dgvLibros.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 229);
            label2.Name = "label2";
            label2.Size = new Size(181, 15);
            label2.TabIndex = 4;
            label2.Text = "Autor con mas libros Publicados:";
            // 
            // txtAutorLibros
            // 
            txtAutorLibros.Location = new Point(202, 221);
            txtAutorLibros.Name = "txtAutorLibros";
            txtAutorLibros.Size = new Size(171, 23);
            txtAutorLibros.TabIndex = 5;
            // 
            // frmLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 296);
            ControlBox = false;
            Controls.Add(txtAutorLibros);
            Controls.Add(label2);
            Controls.Add(dgvLibros);
            Controls.Add(txtBuscarLibro);
            Controls.Add(label1);
            Name = "frmLibros";
            Text = "Libros";
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBuscarLibro;
        private DataGridView dgvLibros;
        private Label label2;
        private TextBox txtAutorLibros;
    }
}