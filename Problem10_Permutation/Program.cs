using System;
using System.Collections.Generic;

namespace Problem10_Permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            var ls = new List<string> { "A", "B", "C","D","E" };
            Permutations(ls);

        }
        static void Permutations(List<string> ls)
        {
            var results = new List<string>();
            Permutations1(ls, results,1);
        }
 static void Permutations1(List<string> ls, List<string> results,int k)
           
            
  
        {
            if (results.Count==k)
            {
                PrintList(results);
                return;
            }
            for (int i = 0; i < ls.Count; i++)
            {
                var newList = new List<string>(ls);
                var newResults = new List<string>(results);
                newList.RemoveAt(i);
                newResults.Add(ls[i]);
                Permutations1(newList, newResults,k);
            }
        }
        static void PrintList(List<string> ls)
        {
            Console.Write(" { ");
            foreach (string s in ls)
                Console.Write(s + " ");
            Console.WriteLine("}");
        }
    }
}


    
