using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program360
{
    public class PeriodicStrings
    {
        public static int[] process(string[] input)
        {
            List<int> kperiod = new List<int>();
            int[] factors;

            foreach(string str in input)
            {
                if (isEmpty(str))
                {
                    kperiod.Add(0);
                }
                else if (allSameChars(str))
                {
                    kperiod.Add(1);
                }
                else if (allDifferentChars(str))
                {
                    kperiod.Add(str.Length);
                }
                else
                {
                    factors = findFactors(str);
                    List<int> kperiod2 = new List<int>();
                    int count = 0;
                    foreach (int value in factors)
                    {
                        string firstVal = str.Substring(0, value);
                        string secondVal = str.Substring(value, value);
                        if (firstVal.Substring(0, value - 1) == secondVal.Substring(1, value - 1)
                            && firstVal[value - 1] == secondVal[0])
                        {
                            kperiod2.Add(value);
                            count++;
                        }
                    }
                    if (count == 0)
                    {
                        kperiod2.Add(str.Length);
                    }
                    if (kperiod2.Count > 0)
                    {
                        kperiod.Add(kperiod2.Max());
                    }
                }
            }
            
            int[] kperiodArray = kperiod.ToArray();
            return kperiodArray;
        }

        public static Boolean isEmpty(string str)
        {
            return (str.Length == 0);
        }

        public static Boolean allSameChars(string str)
        {
            char[] array = str.ToCharArray();
            char firstChar = array[0];
            foreach(char val in array)
            {
                if(val != firstChar)
                {
                    return false;
                }
            }
            return true;
        }

        public static Boolean allDifferentChars(string str)
        {
            char[] array = str.ToCharArray();
            char firstChar = array[0];
            for (int i = 1; i < array.Length - 1; i++)
            {
                if(array[i] == firstChar)
                {
                    return false;
                }
            }
            return true;
        }

        public static int[] findFactors(string str)
        {
            List<int> factors = new List<int>();
            for (int i = 1; i <= str.Length / 2; i++)
            {
                if (str.Length % i == 0)
                {
                    factors.Add(i);
                }
            }
            factors.Remove(1);
            int[] newMultiples = factors.ToArray();
            return newMultiples;
        }

        public static void Main(String[] args)
        {

        }
    }
}
