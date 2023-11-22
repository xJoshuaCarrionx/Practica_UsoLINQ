namespace Practica_para_examen
{
    partial class frmRevistas
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
            txtBuscarRevista = new TextBox();
            label1 = new Label();
            dgvRevistas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvRevistas).BeginInit();
            SuspendLayout();
            // 
            // txtBuscarRevista
            // 
            txtBuscarRevista.Location = new Point(126, 29);
            txtBuscarRevista.Name = "txtBuscarRevista";
            txtBuscarRevista.Size = new Size(224, 23);
            txtBuscarRevista.TabIndex = 5;
            txtBuscarRevista.KeyDown += txtBuscarLibro_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 4;
            label1.Text = "Ingresa una revista:";
            // 
            // dgvRevistas
            // 
            dgvRevistas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRevistas.Location = new Point(12, 82);
            dgvRevistas.Name = "dgvRevistas";
            dgvRevistas.RowTemplate.Height = 25;
            dgvRevistas.Size = new Size(518, 150);
            dgvRevistas.TabIndex = 6;
            // 
            // frmRevistas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 404);
            ControlBox = false;
            Controls.Add(dgvRevistas);
            Controls.Add(txtBuscarRevista);
            Controls.Add(label1);
            Name = "frmRevistas";
            Text = "Revistas";
            ((System.ComponentModel.ISupportInitialize)dgvRevistas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtBuscarRevista;
        private Label label1;
        private DataGridView dgvRevistas;
    }
}