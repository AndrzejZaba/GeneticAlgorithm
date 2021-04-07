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
            Parameters.MutationRange[0] = 0.5;
            double[,] coords = Point.CreateCoordinates();


            for (int i = 0; i < Parameters.MaxSteps; i++)
            {

                double[,] coordsSorted = coords;
                double[,] coordsPot = new double[Parameters.PopulationSize,Parameters.Dimentions+1];
                Point.BubbleSort(coordsSorted);
                Parameters.Elite[0,0] = coordsSorted[0,0];
                Parameters.Elite[0,1] = coordsSorted[0,1];
                Parameters.Elite[0,2] = coordsSorted[0,2];
                coordsPot[0, 0] = Parameters.Elite[0, 0];
                coordsPot[0, 1] = Parameters.Elite[0, 1];
                coordsPot[0, 2] = Parameters.Elite[0, 2];
                Parameters.MutationRange[i] = Parameters.InitialStep * (1 / (1 + Math.Exp((i - (Parameters.MaxSteps / Parameters.P1)) / Parameters.P2)));





                for (int k = 1; k < Parameters.PopulationSize; k++)
                {
                    int ind = Point.rand.Next(Parameters.NBestSuccessors+1);
                    coordsPot[k, 0] = (coordsSorted[ind, 0] + Parameters.MutationRange[i] * SampleGaussian(Point.rand, 0, 1));
                    coordsPot[k, 1] = (coordsSorted[ind, 1] + Parameters.MutationRange[i] * SampleGaussian(Point.rand, 0, 1));

                    coordsPot[k, 0] = Math.Min(Parameters.MaxRangeX[1], Math.Max(Parameters.MaxRangeX[0], coordsPot[k, 0]));
                    
                    coordsPot[k, 1] = Math.Min(Parameters.MaxRangeY[1], Math.Max(Parameters.MaxRangeY[0], coordsPot[k, 1]));


                }

              
                
                coords = coordsPot;        
                Point.SetValues(coords);
                Point.BubbleSort(coords);
                Console.WriteLine("\n\n\n");
                Point.ShowPoints(coords);

            }


            // Have no idea if for values mean = 0 , stddev = 1 works poperly but it has to stay untill better solution is found
            static double SampleGaussian(Random random, double mean, double stddev)
            {
                // The method requires sampling from a uniform random of (0,1]
                // but Random.NextDouble() returns a sample of [0,1).
                double x1 = 1 - random.NextDouble();
                double x2 = 1 - random.NextDouble();

                double y1 = Math.Sqrt(-2.0 * Math.Log(x1)) * Math.Cos(2.0 * Math.PI * x2);
                return y1 * stddev + mean;
            }

            Console.WriteLine("\n\n\nThe mimimum of the function is:");
            Console.WriteLine($"X: {coords[0,0]}    Y: {coords[0,1]}    Value: {coords[0,2]}");
        }

    } 

}

    

