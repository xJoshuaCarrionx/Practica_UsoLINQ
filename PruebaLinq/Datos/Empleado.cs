using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaLinq.Datos
{
    internal class Empleado
    {
        public int IdEmpresa {  get; set; }
        public int ID { get; set; }
        public string Nombre {  get; set; }
        public int Salario { get; set; }
        public string Cargo { get; set; }

        public override string ToString()
        {
            return string.Format($"El empleado {Nombre} con id {ID}, de la empresa {IdEmpresa}," +
                $"con cargo {Cargo} y salario {Salario}");
        }

    }
}
