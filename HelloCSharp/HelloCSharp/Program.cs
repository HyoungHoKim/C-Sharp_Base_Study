using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello C#");
            Console.WriteLine("Hello " + args[0]);

            Console.ReadKey();
        }
    }
}

// cmd로 접근가능, 프로젝트 파일의 Debug파일에서 실행 
// ex> HelloCSharp test1 test2
