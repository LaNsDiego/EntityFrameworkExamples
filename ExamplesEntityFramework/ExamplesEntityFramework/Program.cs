using ExamplesEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplesEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            ContextoDominio Db = new ContextoDominio();
            Empleado Gerente = new Empleado()
            {
                Dni = "123456789",
                Apellidos = "Layme Valeriano",
                Nombres = "Diego Rolando",
                Cargo = NombresCargo.Gerente
            };
            

            Empleado Vendedor = new Empleado()
            {
                Dni = "726555939",
                Apellidos = "Layme Valeriano2",
                Nombres = "Diego Rolando2",
                Cargo = NombresCargo.Vendedor
            };

            Db.Empleados.Add(Gerente);
            Db.Empleados.Add(Vendedor);
            try
            {
                Db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            var empleados  = Db.Empleados.Select(emp => emp);

            
            foreach (var empleado in empleados)
            {
                Console.WriteLine(empleado.Id);
                Console.WriteLine(empleado.Nombres);
                Console.WriteLine(empleado.Apellidos);
                Console.WriteLine(empleado.Dni);
                Console.WriteLine(empleado.Cargo);
            }

            Console.WriteLine("terminando...");
            Console.ReadKey();
        }
    }
}
