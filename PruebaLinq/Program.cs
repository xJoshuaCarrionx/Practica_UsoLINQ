using PruebaLinq;
using PruebaLinq.Control;

ControlEmpresa control =  new ControlEmpresa();

Console.WriteLine("Obteniendo empleado con salario menor de 15000");
control.obtenerSalario(15000);