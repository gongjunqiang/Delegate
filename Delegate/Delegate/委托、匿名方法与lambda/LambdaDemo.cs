using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Detegate
{
    /// <summary>
    /// 委托=》匿名方法=》lambda表达式
    /// 
    /// 委托作为方法参数：传递的是具体方法
    /// </summary>
    public class LambdaDemo
    {

        public void Test()
        {
            //1.委托关联独立的方法
            CalcDetegate calc1 = Add;

            //2.委托关联匿名方法

            CalcDetegate calc2 = delegate (int a, int b)
            {
                return a + b;
            };
            Console.WriteLine("匿名方法计算结果：" + calc2(5, 2));
            //3.将匿名方法用lambda简化
            CalcDetegate calc3 = (int a, int b) => { return a + b; };
            //进一步简化（方法中只有一行代码）
            CalcDetegate calc4 = (a, b) => a - b; ;


            Console.WriteLine("lambda表达式匿名方法计算结果：" + calc4(5, 2));


            HelloDetegate helloDetegate = () => ".net课程";


        }

        private int Add(int a, int b)
        {
            return a + b;
        }

        private double Add(double a, double b)
        {
            return a + b;
        }
    }


    public delegate int CalcDetegate(int a, int b);

    public delegate string HelloDetegate();
}
