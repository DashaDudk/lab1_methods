using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProgram.Methods
{
    internal class SimpleIteration: IMethod
    {
        private double currentX, yesterX;
        public double epsilon { get; }
        public SimpleIteration(double x0, double epsilon) 
        {
            currentX = x0;
            yesterX = 0;
            this.epsilon = epsilon;
        }
        private double Function(double x)
        {
            return -12/(Math.Pow(x,2)-6*x+5); // -12/(x^2-6x+5)
        }
        public Tuple<bool, double >Iteration()
        {
            yesterX = currentX;
            currentX = Function(currentX);
            bool stop = false;
            double diff = Math.Abs(currentX - yesterX);
            if ( diff <= epsilon)
            {
                stop = true;
            }

            return Tuple.Create(stop, diff);
        }
        public int NumberOfSteps() // апріорна оцінка кількості кроків
        {
            IMethod method = new SimpleIteration(currentX, epsilon);
            var myTuple = method.Iteration();
            double q = 6.0 / 25, eps = 0.0001;

            double n = Math.Log((Math.Abs(method.GetX()-method.GetOldX())/((1-q)*eps)),1/q) + 1;
            return Convert.ToInt32(n);
        }
        public double GetX()
        {
            return currentX;
        }
        public double GetOldX()
        {
            return yesterX;
        }
    }
}
