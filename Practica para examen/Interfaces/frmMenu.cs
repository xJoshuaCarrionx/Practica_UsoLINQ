using System.Runtime.InteropServices;

namespace Practica_para_examen
{
    public partial class frmMenu : Form
    {
        //Codigo para mover la ventana del menu
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwind, int wMsg, int WPara, int lParam);
        private void PnlBarraDeTitulo_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public frmMenu()
        {
            InitializeComponent();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }
        private void AbrirLibro(object libro1)
        {
            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0);
            frmLibros frmLi = libro1 as frmLibros;
            frmLi.TopLevel = false;
            frmLi.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(frmLi);
            this.pnlContenedor.Tag = frmLi;
            frmLi.Show();

        }

        private void BtnLibros_Click(object sender, EventArgs e)
        {
            AbrirLibro(new frmLibros());
        }

        private void AbrirRevistas(object Revista1)
        {
            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0);
            frmRevistas frmRe = Revista1 as frmRevistas;
            frmRe.TopLevel = false;
            frmRe.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(frmRe);
            this.pnlContenedor.Tag = frmRe;
            frmRe.Show();

        }

        private void BtnRevistas_Click(object sender, EventArgs e)
        {
            AbrirRevistas(new frmRevistas());
        }
    }
}





