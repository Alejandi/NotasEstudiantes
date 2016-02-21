using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasEstudiantes
{
    class Program
    {
        static void Main(string[] args)
        {

            float[] estudiante1 = new float[5];
            leerNotasEstudiante(estudiante1, 1);
            float[] estudiante2 = new float[5];
            leerNotasEstudiante(estudiante2, 2);
            float[] estudiante3 = new float[5];
            leerNotasEstudiante(estudiante3, 3);
            float[] estudiante4 = new float[5];
            leerNotasEstudiante(estudiante4, 4 );


            float promedioEstudiante1 = promedio(estudiante1);
            float promedioEstudiante2 = promedio(estudiante2);
            float promedioEstudiante3 = promedio(estudiante3);
            float promedioEstudiante4 = promedio(estudiante4);
            float promedioClase = (promedioEstudiante1 + promedioEstudiante2 + promedioEstudiante3 + promedioEstudiante4) / 4;

            escribirPromedioEnCosola(promedioEstudiante1, 1);
            escribirPromedioEnCosola(promedioEstudiante2, 2);
            escribirPromedioEnCosola(promedioEstudiante3, 3);
            escribirPromedioEnCosola(promedioEstudiante4, 4);

            Console.WriteLine($"El promedio de la clase es {promedioClase}");
            Console.ReadLine();

        }
        private static float promedio(float[] estudiante)
        {
            float promedioEstudiante = 0f;
            promedioEstudiante = estudiante.Sum() / 5;
            return promedioEstudiante;
        }

        public static void escribirPromedioEnCosola(float promedioEstudiante, int numeroEstudiante)
        {
            Console.WriteLine($"El promedio del estudiante {numeroEstudiante} es {promedioEstudiante}");
        }

        public static void leerNotasEstudiante (float[] estudiante, int numeroEstudiante)
        {
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine($"Digite la nota {i + 1} del estudiante {numeroEstudiante}");
                estudiante[i] = float.Parse(Console.ReadLine());
            }    
        }       
    }
}


