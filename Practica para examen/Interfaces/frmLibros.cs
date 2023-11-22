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
using System.Xml.Linq;

namespace Practica_para_examen
{
    public partial class frmLibros : Form
    {
        List<Libro> listalibro = null;
        public frmLibros()
        {
            InitializeComponent();
            MostrarLibros();
        }

        private void MostrarLibros()
        {
            ControlDeVentas objcon = new ControlDeVentas();
            listalibro = objcon.obtenerLibro();
            dgvLibros.DataSource = null;
            dgvLibros.DataSource = listalibro;

        }

        private void txtBuscarLibro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mostar(txtBuscarLibro.Text);
            }
        }

        private void mostar(string Titulo)
        {
            if (Titulo == string.Empty)
            {
                dgvLibros.DataSource = null;
                dgvLibros.DataSource = listalibro;
            }
            else
            {
                var queryTitulo = (from libro in listalibro
                                   where libro.titulo.Contains(Titulo)
                                   select libro).ToList();
                dgvLibros.DataSource = null;
                dgvLibros.DataSource = queryTitulo;
            }
        }



    }
}
