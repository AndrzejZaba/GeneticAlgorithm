using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoLibrary
{
    public class Parameters 
    {
        public static double[] MaxRangeX = { -10.0, 10.0 };
        public static double[] MaxRangeY = { -10.0, 10.0 };

        public static int MaxSteps = 100;
        int CurrentMin = 50000;
        public static int Dimentions = 2;

        double ResultX = 1.0;
        double ResultY = 1.0;

        int EndingCondition = 0;

        public static double InitialStep = 4.0;
        public static double P1 = 2.0;
        public static double P2 = 10.0;

        static public int PopulationSize = 20;
        static public int NBestSuccessors = 10;
        public static double[] MutationRange = new double[MaxSteps];

        public static double[,] Elite = new double[1,3];
    }
}
