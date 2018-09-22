//Your task is to construct a building which will be a pile of n cubes.The cube at the bottom will have a volume of n^3, the cube above will have volume of (n-1)^3 and so on until the top which will have a volume of 1^3.

//You are given the total volume m of the building.Being given m can you find the number n of cubes you will have to build?

//The parameter of the function findNb (find_nb, find-nb, findNb) will be an integer m and you have to return the integer n such as n^3 + (n-1)^3 + ... + 1^3 = m if such a n exists or -1 if there is no such n.

//Examples:
//findNb(1071225) --> 45
//findNb(91716553919377) --> -1

using System;

namespace Kata_Cubes
{
    public static class Kata
    {
        //https://mathschallenge.net/library/number/sum_of_cubes
        //Another implementation based on math (see above)
        public static long findNb2(long m)
        {
            return DoesSqrtExist(m) ? QuadraticSoln(m) : -1;
        }

        public static long QuadraticSoln(long m)
        {
            return (-1 + (long)Math.Sqrt(1 + 8 * (long)Math.Sqrt(m))) / 2;
        }

        public static bool DoesSqrtExist(long m)
        {
            return (m % (long)Math.Sqrt(m) == 0);
        }

        // First solution
        public static long findNb(long vol)
        {
            long init = 0;

            while (vol > 0)
            {
                init++;
                vol -= Cube(init);
            }
            return vol == 0 ? init : -1;
        }


        public static long Cube(long x)
        {
            return x * x * x;
        }
    }
}
