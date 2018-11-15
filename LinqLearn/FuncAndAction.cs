using System;
using System.Collections.Generic;
using System.Text;

namespace LinqLearn
{
    public class FuncAndAction
    {
        //Func accepts 0-16 input parameters + an output parameter
        public Func<int, int> func = Square;

        public Func<int, int, int, int> func1 = Cube;

        private static int Cube(int arg1, int arg2, int arg3)
        {
            return arg1 * arg2 * arg3;
        }

        private static int Square(int arg)
        {
            return arg * arg;
        }


        //Above implementation with Lambda expression

        public Func<int, int> funcLambda = x => x * x;

        public Func<int, int, int, int> funcLambda1 = (x, y, z) => x * y * z;

        //Func with method body

        public Func<int, int> funcLambdaWithBody = x => 
        {
            int result = x * x;
            return result;
        };

        //Action example

        public Action actionToWriteStar = () => Console.WriteLine("\n***************************************************************************\n");

        public Action<string> actionToWrite = a => Console.WriteLine(a);

    }
}
