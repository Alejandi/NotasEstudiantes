using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasEstudiantesMejorado
{
    class Program
    {
        static void Main(string[] args)
        {
            float[,] matrixNotasEstudiantes = new float[5, 4];
            leerDeConsolaNotasEstudiante(matrixNotasEstudiantes);
            escribirEnConsolaMatrixEStudiante(matrixNotasEstudiantes);


            float[,] matrixResultados = new float[5,3];
            //Sacar el promedio de cada fila de la matriz matrixNotasEstudiantes
            for (int i=0; i<= 4; i++)
            {
                //Promedio
                matrixResultados[i,0] = calcularPromedioEstudiante(matrixNotasEstudiantes, i);
                //Max
                matrixResultados[i,1] = calcularMaximaNotaDelEstudiante(matrixNotasEstudiantes, i);
                //Min
                matrixResultados[i, 2] = calcularMinimaNotaDelEstudiante(matrixNotasEstudiantes, i);
            }

            escribirEnConsolaResultados(matrixResultados);
        }

        private static float calcularMinimaNotaDelEstudiante(float[,] matrixNotasEstudiantes, int i)
        {
            float minimaNota = 0f;
            minimaNota = matrixNotasEstudiantes[i, 0];
            for (int j = 0; j<=3; j++)
            {
                
                if (matrixNotasEstudiantes[i, j] < minimaNota)
                {
                    minimaNota = matrixNotasEstudiantes[i, j];
                }
            }
            return minimaNota;
        }

        private static float calcularMaximaNotaDelEstudiante(float[,] matrixNotasEstudiantes, int i)
        {
            float maximaNota = 0f;
            for (int j = 0; j<=3; j++ )
            {
                if (matrixNotasEstudiantes [i,j] > maximaNota)
                {
                    maximaNota = matrixNotasEstudiantes[i,j];
                }                    
            }
            return maximaNota;
        }

        private static void escribirEnConsolaResultados(float[,] matrixDeResultados)
        {
            Console.WriteLine($"La matrix de resultados es");
            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j<=2; j++)
                { 
                Console.Write($" {matrixDeResultados[i,j]}");
            }
                Console.WriteLine();
            }
            Console.ReadLine();
        }       

        private static float calcularPromedioEstudiante(float[,] matrixNotasEstudiantes, int i)
        {
            float sum = 0f;
            for(int j =0; j<=3; j++)
            {
                sum = sum + matrixNotasEstudiantes[i, j];
            }
            float promedioEstudiante = sum / 4;
            return promedioEstudiante;
        }

        private static void leerDeConsolaNotasEstudiante(float[,] matrixNotasEstudiantes)
        {
            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    Console.WriteLine($"Ingrese la nota {j + 1} del estudiante {i + 1}");
                    matrixNotasEstudiantes[i, j] = float.Parse(Console.ReadLine());
                }
            }
        }

        private static void escribirEnConsolaMatrixEStudiante(float[,] matrixNotasEstudiantes)
        {
            Console.WriteLine($"La matrix de notas es");
            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    Console.Write( $" {matrixNotasEstudiantes[i, j]}");
                }
                Console.WriteLine();
            }
           Console.ReadLine();
        }
        
    }

}
