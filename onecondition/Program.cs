using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onecondition
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("--숫자를 입력해--");
            Console.Write("x: ");
            x = int.Parse(Console.ReadLine());//입력~
            
            if (x>10 && x < 20)
            {
                Console.WriteLine("조건에 맞습니다.");
            }
        }
    }
}
