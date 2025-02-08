using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal static class Integers
    {
        public static string [] DigitsOfArray(this string [] Arr)
        {
            List <string> results = new List <string> ();
            for (int i = 0; i < Arr.Length; i++)
            {
                if(Arr[i].Length < i )
                {
                    results.Add($"{i}: {Arr[i]}");
                }
            }
            return results.ToArray();
        }

        public static List<bool> InPlace(this int[] Arr)
        {
            List <bool> InPlace = new List<bool> ();
            for (int i = 0; i < Arr.Length; i++)
            { 
                    InPlace.Add(Arr[i] == i);  
            }
            return InPlace;
        }

        public static List<(int, int)> Pairs(this int[] Arr , int[]Arr2)
        {
            List<(int, int)> Result = new List<(int,int)>();
            for (int i = 0; i<Arr.Length; i++)
            {
                for(int j = 0; j<Arr2.Length; j++)
                {
                    if(Arr[i] < Arr2[j])
                        Result.Add((Arr[i], Arr2[j]));
                }
            }
            return Result;
        }
    }
}
