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

                
                Console.Write("Ingrese nombre del alumno: ");
                asignatura.NombreAlumno = Console.ReadLine();

                Console.Write("Ingrese número de cuenta: ");
                asignatura.NumeroCuenta = Console.ReadLine();

                Console.Write("Ingrese correo electrónico: ");
                asignatura.Email = Console.ReadLine();

                
                Console.Write("Ingrese nombre de la clase: ");
                asignatura.NombreAsignatura = Console.ReadLine();

                Console.Write("Ingrese horario de la clase: ");
                asignatura.Horario = Console.ReadLine();

                Console.Write("Ingrese nombre del docente: ");
                asignatura.NombreDocente = Console.ReadLine();

                
                asignatura.N1 = SolicitarNota("primer", 30);
                asignatura.N2 = SolicitarNota("segundo", 30);
                asignatura.N3 = SolicitarNota("tercer", 40);

                asignatura.Imprimir();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error: " + ex.Message);
            }
        }

      
        static int SolicitarNota(string nombreParcial, int maxNota)
        {
            int nota;
            while (true)
            {
                try
                {
                    Console.Write($"Ingrese nota del {nombreParcial} parcial (máximo {maxNota}%): ");
                    nota = int.Parse(Console.ReadLine());

                    if (nota >= 0 && nota <= maxNota)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"La nota del {nombreParcial} parcial debe estar entre 0 y {maxNota}. Inténtelo de nuevo.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Formato de entrada inválido. Por favor, ingrese un número entero.");
                }
            }
            return nota;
        }
    }
}
