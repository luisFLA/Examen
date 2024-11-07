using System;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Asignatura asignatura = new Asignatura();

                // Ingresar datos del alumno
                Console.Write("Ingrese nombre del alumno: ");
                asignatura.NombreAlumno = Console.ReadLine();

                Console.Write("Ingrese número de cuenta: ");
                asignatura.NumeroCuenta = Console.ReadLine();

                Console.Write("Ingrese correo electrónico: ");
                asignatura.Email = Console.ReadLine();

                // Ingresar datos de la asignatura
                Console.Write("Ingrese nombre de la clase: ");
                asignatura.NombreAsignatura = Console.ReadLine();

                Console.Write("Ingrese horario de la clase: ");
                asignatura.Horario = Console.ReadLine();

                Console.Write("Ingrese nombre del docente: ");
                asignatura.NombreDocente = Console.ReadLine();

                // Ingresar y validar notas
                Console.Write("Ingrese nota del primer parcial: ");
                asignatura.N1 = int.Parse(Console.ReadLine());
                if (asignatura.N1 > 30)
                    throw new Exception("La nota del primer parcial sobrepasa del 30%");

                Console.Write("Ingrese nota del segundo parcial: ");
                asignatura.N2 = int.Parse(Console.ReadLine());
                if (asignatura.N2 > 30)
                    throw new Exception("La nota del segundo parcial sobrepasa del 30%");

                Console.Write("Ingrese nota del tercer parcial: ");
                asignatura.N3 = int.Parse(Console.ReadLine());
                if (asignatura.N3 > 40)
                    throw new Exception("La nota del tercer parcial sobrepasa del 40%");

                // Imprimir resultados
                asignatura.Imprimir();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
