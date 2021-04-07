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

        public static  Random rand = new Random();

        static public double[,] Coordinates = CreateCoordinates();



        public static double[,] CreateCoordinates()
        {
            double New;
            double[,] coords = new double[PopulationSize,Dimentions + 1];
            for (int k = 0; k < Dimentions; k++)
            {
                for (int i = 0; i < PopulationSize; i++)
                {
                    New = rand.NextDouble() * (MaxRangeX[1] - MaxRangeX[0] + MaxRangeX[0]);

                    coords[i, k] = Math.Max(MaxRangeX[0], Math.Min(New, MaxRangeX[1]));
                }
            }
            SetValues(coords);
            return coords;
        }


        public static void SetValues(double[,] Coordinates)
        {

            for (int i = 0; i < PopulationSize; i++)
            {
                Coordinates[i,2] = Math.Round(Function.FunctionOne(Coordinates[i,0],Coordinates[i,1]),3,MidpointRounding.AwayFromZero);
            }

        }

        public static void ShowPoints(double[,] Coordinates)
        {
            for (int i = 0; i < PopulationSize; i++)
            {
               Console.WriteLine($"X: {Coordinates[i, 0]}  \tY: {Coordinates[i,1]}  \tValue: {Coordinates[i,2]}" );
            }
        }

        static public void BubbleSort(double[,] coordinates)
        {
            bool exchanges;
            do
            {
                exchanges = false;
                for (int i = 0; i < coordinates.Length / 3 - 1; i++)
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