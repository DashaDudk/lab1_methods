using MainProgram.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProgram
{
    internal class Helper
    {
        public static void CountValue(IMethod counter)
        { 
            Tuple<bool, double> myTuple;
            int i = 0;
            do
            {
                myTuple = counter.Iteration();
                Console.WriteLine(
                    "Iteration " + i + "\n" +
                    "x" + i + " = " + counter.GetOldX() + "\n" +
                    "x" + (i + 1) + " = " + counter.GetX() + "\n" +
                    "Termination condition: " + myTuple.Item2 + " <= " + counter.epsilon + " - " + myTuple.Item1 + "\n");

                i++;
            } while (!myTuple.Item1);
        }
    }
}
