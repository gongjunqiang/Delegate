using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Detegate
{
    /// <summary>
    /// 无返回值的系统泛型委托：action
    /// </summary>
    public class FuncAction
    {
        public void Test()
        {
            Action<string> action = (name) => Console.WriteLine($"欢迎参加{name}的课程");
            action("常老师");

        }



    }
}
