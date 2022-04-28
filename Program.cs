using System;

namespace OIGA
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass ref1 = new BaseClass();
            var makeVisible = ref1.PValueMod2;
            makeVisible = ref1.PValueFactorial;
            BaseClass ref2 = new BaseClass(20);
            makeVisible = ref2.PValueMod2;
            makeVisible = ref2.PValueFactorial;
            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }

    }
    class BaseClass
    {
        public int PValue { get; set; }
        public int PValueMod2
        {
            get
            {
                return Module2(PValue);
            }
        }
        public int PValueFactorial
        {
            get
            {
                return Factorial(PValue);
            }
        }            
            
                
        public BaseClass()
        {
            this.PValue = 10;
        }
        public BaseClass(int pValue)
        {
            this.PValue = pValue;
        }        
        private int Module2(int pValue)
        {
            int res = pValue % 2;
            Console.WriteLine("Module of 2 of " + pValue.ToString() + " is " + res.ToString());            
            return res;            
        }
        private static int Factorial(int number)
        {
            /*
             * Old method
            if (number == 0)
                return 1;
            return number * Factorial(number - 1);
            */
            int res = 1;
            bool oddUptoValue = ((number & 1) == 1);
            int tempUptoValue = number; 
            if (oddUptoValue)
            {
                tempUptoValue = number - 1;
            }

            int nextSum = tempUptoValue;
            int nextMulti = tempUptoValue;
            while (nextSum >= 2)
            {
                res *= nextMulti;
                nextSum -= 2;
                nextMulti += nextSum;
            }
            if (oddUptoValue)
            {
                res *= number;
            }
            Console.WriteLine("Factor of " + number.ToString() + " is " + res.ToString());
            return res;
        }
    }
}
