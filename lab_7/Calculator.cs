using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Calculator<T>
    {
        public delegate T AddDelegate(T a, T b);
        public delegate T SubtractDelegate(T a, T b);
        public delegate T MultiplyDelegate(T a, T b);
        public delegate T DivideDelegate(T a, T b);

        public T Add(T a, T b, AddDelegate addMethod)
        {
            return addMethod(a, b);
        }

        public T Subtract(T a, T b, SubtractDelegate subtractMethod)
        {
            return subtractMethod(a, b);
        }

        public T Multiply(T a, T b, MultiplyDelegate multiplyMethod)
        {
            return multiplyMethod(a, b);
        }

        public T Divide(T a, T b, DivideDelegate divideMethod)
        {
            return divideMethod(a, b);
        }

        public delegate T MathOperation(T a, T b);

        public T PerformOperation(T a, T b, MathOperation operation)
        {
            return operation(a, b);
        }
    }
}
