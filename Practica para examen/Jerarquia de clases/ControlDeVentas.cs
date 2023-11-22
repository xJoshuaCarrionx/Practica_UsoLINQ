using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practica_para_examen.Jerarquia_de_clases
{
    internal class ControlDeVentas
    {
        public List<Libro> listaLibros;
        public List<Revista> listaRevista;

        public ControlDeVentas()
        {
            listaLibros = new List<Libro>()
            {
                new Libro()
                {
                    titulo = "Quijote de la mancha",
                    autor = "Miguel de servante",
                    publicacion = "18/08/1999",
                    costo = 12,
                },
                new Libro()
                {
                    titulo = "Quijote de la azucena",
                    autor = "Miguel de servante",
                    publicacion = "18/08/1999",
                    costo = 12,

                }
            };
            listaRevista = new List<Revista>()
            {
                new Revista()
                {
                    titulo = "La nomina",
                    autor = "New York Time",
                    publicacion = "18/08/1999",
                    periocidad = "Mensual",
                    costo = 3
                }
            };
            

        }
        public List<Libro> obtenerLibro()
        {
            return (from Libro in listaLibros
                    select Libro).ToList();
        }
        public List<Revista> obtenerRevista()
        {
            return (from Revista in listaRevista
                    select Revista).ToList();
        }

        public void ObtenerAutorConMasLibros()
        {
           var autorConMasLibros = 
        }


    }
}
