using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaLinq.Datos
{
    internal class Empresa
    {
        public int ID { get; set; }
        public string Nombre { get; set; }

        public override string ToString()
        {
            return string.Format($"La empresa{Nombre} con id {ID}");
        }
    }
}
