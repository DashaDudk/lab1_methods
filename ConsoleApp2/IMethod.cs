using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProgram.Methods
{
    internal interface IMethod
    {
        public double epsilon { get; }
        Tuple<bool, double> Iteration();
        // метод Iteration() робить ітерацію нашого численного методу,
        // тобто обчислює нове значення х, і перевіряє умову припинення.
        // Повертає цей метод кортеж із різниці попереднього та нового, і відповідь на запитання "чи виконалася умова припинення?"

        int NumberOfSteps(); //апріорна оцінка
        // щоб вирохувати апріорну оцінку, потрібно мати як значення х0, так і fi(x0), тому ідея полягає в тому,
        // щоб створити ще один екземпляр SimpleIteration задля того щоб оперативно вирахувати fi(x0), виконуючи
        // операцію Iteration(), бо згідно методу х1=fi(x0), ну а далі вже обчислювати все згідно формулі
        double GetX();
        // витягнути Хn
        double GetOldX();
        // витягнути Хn-1
    }
}
