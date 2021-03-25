using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoLibrary
{
    public class Parameters 
    {
        public static double[] MaxRangeX = { -10.0, 10.0 };
        public static double[] MaxRangeY = { -10.0, 10.0 };

        int MaxSteps = 100;
        int CurrentMin = 50000;
        internal static int Dimentions = 2;

        double ResultX = 1.0;
        double ResultY = 1.0;

        int EndingCondition = 0;

        float InitialStep = 0;
        float P1 = 0;
        float P2 = 0;

        static internal int PopulationSize = 20;
        int NBestSuccessors = 1;
        double MutationRange = 0.5;
    
    }
}
