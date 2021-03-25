using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Functions; 

namespace AlgoLibrary
{
    public class Point : Parameters 
    {

        static Random random = new Random();

        private static readonly Random rand = new Random();

        static public double[,] Coordinates = CreateCoordinates();



        public static double[,] CreateCoordinates()
        {
            double New;
            double[,] coords = new double[PopulationSize,Dimentions + 1];
            for (int k = 0; k < Dimentions; k++)
            {
                for (int i = 0; i < PopulationSize; i++)
                {
                    New = rand.NextDouble() * (MaxRangeX[1] - MaxRangeX[0]) + MaxRangeX[0];
                    coords[i, k] = Math.Max(MaxRangeX[0], Math.Min(New, MaxRangeX[1]));
                }
            }
            SetValues(coords);
            return coords;
        }


        public static double SetValues(double[,] Coordinates)
        {
            double[] values = new double[PopulationSize];

            for (int i = 0; i < PopulationSize; i++)
            {
                Coordinates[i,2] = Function.FunctionOne(Coordinates[i,0],Coordinates[i,1]);
            }

            return 0;
        }

        public static void ShowPoints(double[,] Coordinates)
        {
            for (int i = 0; i < PopulationSize; i++)
            {
               Console.WriteLine($"X: {Coordinates[i, 0]}      Y: {Coordinates[i,1]}       Value: {Coordinates[i,2]}" );
            }
        }


    }
}