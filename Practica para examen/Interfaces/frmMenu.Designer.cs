namespace Practica_para_examen
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            PnlBarraDeTitulo = new Panel();
            btnMaximizar = new Button();
            btnMinimizar = new Button();
            btnRestaurar = new Button();
            btnSalir = new Button();
            pnlContenedor = new Panel();
            panel2 = new Panel();
            BtnRevistas = new Button();
            BtnLibros = new Button();
            pictureBox1 = new PictureBox();
            PnlBarraDeTitulo.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PnlBarraDeTitulo
            // 
            PnlBarraDeTitulo.BackColor = Color.FromArgb(0, 0, 64);
            PnlBarraDeTitulo.Controls.Add(btnMaximizar);
            PnlBarraDeTitulo.Controls.Add(btnMinimizar);
            PnlBarraDeTitulo.Controls.Add(btnRestaurar);
            PnlBarraDeTitulo.Controls.Add(btnSalir);
            PnlBarraDeTitulo.Dock = DockStyle.Top;
            PnlBarraDeTitulo.Location = new Point(0, 0);
            PnlBarraDeTitulo.Name = "PnlBarraDeTitulo";
            PnlBarraDeTitulo.Size = new Size(559, 34);
            PnlBarraDeTitulo.TabIndex = 1;
            PnlBarraDeTitulo.MouseDown += PnlBarraDeTitulo_MouseDown_1;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.FlatStyle = FlatStyle.Flat;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(491, 3);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(25, 25);
            btnMaximizar.TabIndex = 3;
            btnMaximizar.UseVisualStyleBackColor = true;
            btnMaximizar.Click += BtnMaximizar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(460, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(25, 25);
            btnMinimizar.TabIndex = 2;
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += BtnMinimizar_Click;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.FlatStyle = FlatStyle.Flat;
            btnRestaurar.Image = (Image)resources.GetObject("btnRestaurar.Image");
            btnRestaurar.Location = new Point(491, 3);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(25, 25);
            btnRestaurar.TabIndex = 1;
            btnRestaurar.UseVisualStyleBackColor = true;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.Location = new Point(522, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(25, 25);
            btnSalir.TabIndex = 0;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.FromArgb(0, 0, 64);
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(108, 34);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(451, 276);
            pnlContenedor.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(BtnRevistas);
            panel2.Controls.Add(BtnLibros);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(108, 276);
            panel2.TabIndex = 2;
            // 
            // BtnRevistas
            // 
            BtnRevistas.Cursor = Cursors.Hand;
            BtnRevistas.FlatStyle = FlatStyle.Flat;
            BtnRevistas.ForeColor = SystemColors.ButtonShadow;
            BtnRevistas.Image = (Image)resources.GetObject("BtnRevistas.Image");
            BtnRevistas.ImageAlign = ContentAlignment.BottomLeft;
            BtnRevistas.Location = new Point(3, 181);
            BtnRevistas.Name = "BtnRevistas";
            BtnRevistas.Size = new Size(149, 41);
            BtnRevistas.TabIndex = 5;
            BtnRevistas.Text = "Revistas";
            BtnRevistas.UseVisualStyleBackColor = true;
            BtnRevistas.Click += BtnRevistas_Click;
            // 
            // BtnLibros
            // 
            BtnLibros.Cursor = Cursors.Hand;
            BtnLibros.FlatStyle = FlatStyle.Flat;
            BtnLibros.ForeColor = SystemColors.ButtonShadow;
            BtnLibros.Image = (Image)resources.GetObject("BtnLibros.Image");
            BtnLibros.ImageAlign = ContentAlignment.MiddleLeft;
            BtnLibros.Location = new Point(3, 100);
            BtnLibros.Name = "BtnLibros";
            BtnLibros.Size = new Size(133, 41);
            BtnLibros.TabIndex = 4;
            BtnLibros.Text = "Libros";
            BtnLibros.UseVisualStyleBackColor = true;
            BtnLibros.Click += BtnLibros_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(5, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(559, 310);
            ControlBox = false;
            Controls.Add(pnlContenedor);
            Controls.Add(panel2);
            Controls.Add(PnlBarraDeTitulo);
            IsMdiContainer = true;
            Name = "frmMenu";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            PnlBarraDeTitulo.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlBarraDeTitulo;
        private Button btnMaximizar;
        private Button btnMinimizar;
        private Button btnRestaurar;
        private Button btnSalir;
        private Panel pnlContenedor;
        private Panel panel2;
        private Button BtnRevistas;
        private Button BtnLibros;
        private PictureBox pictureBox1;
    }
}