using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Detegate
{
    /// <summary>
    /// 泛型委托
    /// </summary>
    public class GenericDelegate
    {
        public void Test()
        {
            //使用泛型方法：具体方法
            CalcDetegate<int> calc1 = Add;
            CalcDetegate<double> calc2 = Sub;
            Console.WriteLine("自定义泛型委托" + calc1(10, 20));
            Console.WriteLine("自定义泛型委托" + calc2(20, 10));


            //使用泛型方法：匿名方法
            CalcDetegate<int> calc3 = delegate (int a, int b) { return a + b; };
            CalcDetegate<double> calc4 = delegate (double a, double b) { return a - b; };
            Console.WriteLine("自定义泛型委托" + calc3(20, 20));
            Console.WriteLine("自定义泛型委托" + calc4(20, 50));


            //使用泛型方法：lambda表达式
            CalcDetegate<int> calc5 = (int a, int b) => { return a + b; };
            CalcDetegate<double> calc6 = (a, b) => a - b;
            Console.WriteLine("自定义泛型委托" + calc5(20, 20));
            Console.WriteLine("自定义泛型委托" + calc6(20, 23));



        }


        private int Add(int a, int b)
        {
            return a + b;
        }

        private double Sub(double a, double b)
        {
            return a - b;
        }

    }


    public delegate T CalcDetegate<T>(T a, T b);
}
