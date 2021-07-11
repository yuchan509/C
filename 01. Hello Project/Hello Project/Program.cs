using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloPrj
{
    class Program
    {
        // args : 매개변수.
        static void Main(string[] args)
        // 프로그램의 시작.
        {   // Write : print의 역할, WriteLine : 프린트 후 줄 바꿈.
            // 문자열 덧셈, 수치형 덧셈의 결과는 파이썬과 동일.
            Console.WriteLine("Hello C#!!" + args[0] + args[1]);
            Console.WriteLine("yuchan");
            // 인자 출력.
            Console.Write(args.Length);
            // 사용자가 어떤 키를 누르기를 대기. 누르기 전까지 콘솔 화면 유지.
            Console.ReadKey();
        // 프로그램의 끝.
        }
    }
}

