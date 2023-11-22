using Practica_para_examen.Jerarquia_de_clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_para_examen
{
    public partial class frmRevistas : Form
    {
        List<Revista> ListaRevistas = null;
        public frmRevistas()
        {
            InitializeComponent();
            MostrarRevista();
        }

        private void MostrarRevista()
        {
            ControlDeVentas objcon = new ControlDeVentas();
            ListaRevistas = objcon.obtenerRevista();
            dgvRevistas.DataSource = null;
            dgvRevistas.DataSource = ListaRevistas;
        }

        private void txtBuscarLibro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mostar(txtBuscarRevista.Text);
            }

        }

        private void mostar(string Titulo)
        {
            if (Titulo == string.Empty)
            {
                dgvRevistas.DataSource = null;
                dgvRevistas.DataSource = ListaRevistas;
            }
            else
            {
                var queryTitulo = (from Revista in ListaRevistas
                                   where Revista.titulo.Contains(Titulo)
                                   select Revista).ToList();
                dgvRevistas.DataSource = null;
                dgvRevistas.DataSource = queryTitulo;
            }
        }
    }
}
