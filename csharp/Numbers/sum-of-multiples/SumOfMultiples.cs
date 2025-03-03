using Newtonsoft.Json.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;
public static class SumOfMultiples
{
    //For each magical item, take the base value and find all the multiples of that value that are less than the level number.
    //Combine the sets of numbers.
    //Remove any duplicates.
    //Calculate the sum of all the numbers that are left.

    public static int Sum(IEnumerable<int> multiples, int max)
    {
        //List<int> allVals = new List<int>();

        return multiples
            .SelectMany(num => Enumerable.Range(1, (max - 1) / num).Select(x => x * num))
            .Distinct()
            .Sum();
    }


    // Next, figure out how to use LINQ to do this same jawn.

    //public static int Sum(IEnumerable<int> multiples, int max)
    //{
    //    // store all multiples here, then at the end return a HashSet
    //    List<int> allNums = new List<int>();

    //    foreach (var item in multiples)
    //    {
    //        for (var i = item; i < max; i += item)
    //        {
    //            if (i == 0)
    //            {
    //                break;
    //            }
    //            else
    //            {
    //                allNums.Add(i);
    //            }
    //            //yield return i;
    //            //yield return allNums.Add(i);

    //        }

    //    }
    //    HashSet<int> setOfNums = new HashSet<int>(allNums);

    //    // return the sum of allNums
    //    int sum = setOfNums.Sum();
    //    return sum;
    //    //yield return sum;

    //}






}