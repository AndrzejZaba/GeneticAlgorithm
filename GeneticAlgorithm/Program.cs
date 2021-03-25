using System;
using System.Collections.Generic;
using System.Linq;
using AlgoLibrary;

namespace GeneticAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] coords = Point.CreateCoordinates();
            Point.ShowPoints(coords);

            //double[,] SortedByValues = coords.OrderBy(x => x[1,2]);

            BubbleSort(coords);

            //Console.WriteLine($"{coords.Length}");

            Console.WriteLine("\n\n\n");
            Point.ShowPoints(coords);

        }


        static void BubbleSort(double[,] coordinates)
        {
            bool exchanges;
            do
            {
                exchanges = false;
                for (int i = 0; i < coordinates.Length/3 -1; i++)
                {
                    if (coordinates[i, 2] > coordinates[i + 1, 2])
                    {
                        //Exchange elements
                        double temp = coordinates[i, 2];
                        coordinates[i, 2] = coordinates[i + 1, 2];
                        coordinates[i + 1, 2] = temp;
                        

                        temp = coordinates[i, 1];
                        coordinates[i, 1] = coordinates[i + 1, 1];
                        coordinates[i + 1, 1] = temp;

                        temp = coordinates[i, 0];
                        coordinates[i, 0] = coordinates[i + 1, 0];
                        coordinates[i + 1, 0] = temp;

                        exchanges = true;

                    }
                }
            } while (exchanges);


        }

    }
}
