using System;

namespace SingleDelegateDemo
{
    public delegate void CalculatorData(int a, int b);
    class Program
    {
        public  void AddNum(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        public void SubNum(int a, int b)
        {
            Console.WriteLine(a-b);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            CalculatorData cd = new CalculatorData(p.AddNum);
            cd(12, 13);
            cd(14, 15);
            cd+= new CalculatorData(p.SubNum);
            cd(10, 5);
            cd -= new CalculatorData(p.AddNum);
            //cd(10, 5);
        }
    }
}
