using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProgram.Methods
{
    internal class Newton_s: IMethod
    {
        private double currentX, yesterX;
        public double epsilon { get; }
        public Newton_s(double x0, double epsilon)
        {
            currentX = x0;
            yesterX = 0;
            this.epsilon = epsilon;
        }
        private double Function(double x)
        {
            return x-(Math.Pow(x,3) - 7*x - 6)/(3*Math.Pow(x,2)-7); // x-(x^3-7x-6)/(3x^2-7)
        }
        public Tuple<bool, double> Iteration()
        {
            yesterX = currentX;
            currentX = Function(currentX);
            bool stop = false;
            double diff = Math.Abs(currentX - yesterX);
            if (diff <= epsilon)
            {
                stop = true;
            }

            return Tuple.Create(stop, diff);
        }
        public double GetX()
        {
            return currentX;
        }
        public double GetOldX()
        {
            return yesterX;
        }

        public int NumberOfSteps()
        {
            throw new NotImplementedException();
        }
    }
}