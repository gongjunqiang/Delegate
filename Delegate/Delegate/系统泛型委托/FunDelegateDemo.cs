using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Detegate
{
    /// <summary>
    /// 有返回值的系统泛型委托
    /// 
    /// 目的：方便开发者。Net基类库中针对常用的情况，提供了预定的委托
    /// </summary>
    public class FunDelegateDemo
    {
        /// <summary>
        /// Fun基本使用
        /// </summary>
        public void Test()
        {
            //Fun关联具体方法
            Func<int, int, int> fun1 = Add;
            Console.WriteLine("自定义泛型委托" + fun1(10, 20));
            //Fun直接使用lambda表达式
            Func<int, int, double> fun2 = (int a, int b) => a + b;
            Func<int, int, double> fun3 = (a, b) => a - b;
            Console.WriteLine("自定义泛型委托" + fun2(20, 20));
            Console.WriteLine("自定义泛型委托" + fun3(20, 40));
        }

        private int Add(int a, int b)
        {
            return a + b;
        }


        private int Mul1(int a, int b)
        {
            return a * b;
        }


        private double Sub(double a, double b)
        {
            return a - b;
        }

        public int Sum(int[] nums, int from, int to)
        {

            int result = 0;
            for (int i = from; i <= to; i++)
            {
                result += nums[i];
            }
            return result;
        }

        public int Mul(int[] nums, int from, int to)
        {

            int result = 1;
            for (int i = from; i <= to; i++)
            {
                result *= nums[i];
            }
            return result;
        }

        int[] muns = { 10, 5, 7, 6, 2, 3, 4, 9, 2 };
        /// <summary>
        /// 求数组连续的和、积
        /// </summary>
        public void Test1()
        {
            int result1 = Sum(muns, 4, 6);
            Console.WriteLine("求和：" + result1);

            int result2 = Mul(muns, 4, 6);
            Console.WriteLine("求乘积：" + result2);
        }

        /// <summary>
        /// 使用Fun委托：将运算本身作为方法参数
        /// </summary>
        public void Test2()
        {
            //传递委托的具体方法
            var mun = Operation(Add, muns, 4, 6);
            Console.WriteLine("求和：" + mun);
            var mun1 = Operation(Mul1, muns, 4, 6);
            Console.WriteLine("求积：" + mun1);


            //将func作为方法参数，结婚lambda表达式
            var mun2 = Operation((a, b) => a + b, muns, 4, 6);
            Console.WriteLine("求和：" + mun);
            var mun3 = Operation((a, b) => a * b, muns, 4, 6);
            Console.WriteLine("求积：" + mun1);

        }

        public int Operation(Func<int, int, int> methond, int[] nums, int from, int to)
        {

            int result = nums[from];
            for (int i = from + 1; i <= to; i++)
            {
                result = methond(result, nums[i]);
            }
            return result;
        }



    }
}
