using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cscomment
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.Write("x 값 입력 : ");
            x = int.Parse(Console.ReadLine());

            Console.Write("y 값 입력 : ");
            y = int.Parse(Console.ReadLine());

            if (x > 4)
            {
                if (y > 2)
                {
                    Console.WriteLine(x * y);
                }
                else
                {
                    Console.WriteLine("이런..y값이 작아서 결과를 못 내보냅니다.");
                }
            }
            else
            {
                Console.WriteLine("이런..x값이 작아서 결과를 못 내보냅니다.");
            Console.WriteLine();
            }

        }
    }
}
