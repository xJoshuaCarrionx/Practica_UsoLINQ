using PruebaLinq.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PruebaLinq.Control
{
    internal class ControlEmpresa
    {
        public List<Empresa> listaEmpresas;
        public List<Empleado> listaEmpleado;
        
        public ControlEmpresa()
        {
            listaEmpresas = new List<Empresa>()
            {
                new Empresa()
                {
                    ID = 1,
                    Nombre = "Google"
                },
                new Empresa()
                {
                    ID= 2,
                    Nombre = "Amazon"
                }
            };
            listaEmpleado = new List<Empleado>()
            {
                new Empleado()
                {
                    Nombre = "Rosa Martinez",
                    IdEmpresa = 1,
                    ID = 1,
                    Cargo = "Mantenimiento interno",
                    Salario = 15000
                },
                new Empleado()
                {
                    Nombre = "Laura Arauz",
                    IdEmpresa = 2,
                    ID = 2,
                    Cargo = "Programadora",
                    Salario = 25000
                }, 
                new Empleado()
                {
                    Nombre = "Pedro Guillen",
                    IdEmpresa = 2,
                    ID = 3,
                    Cargo = "CEO",
                    Salario = 1000
                }
            };
            

        }
        public void obtenerSalario(double salario)
        {
            var querySalario = (from empleado in listaEmpleado
                                orderby empleado.Salario descending
                                where empleado.Salario <  salario
                                select empleado).ToList();
            querySalario.ForEach(e => Console.WriteLine(e));
        }


    }
}
