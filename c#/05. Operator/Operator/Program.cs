using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 연산자
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 수식 연산자 : +, -, *, /, %
             * 할당 연산자 : =, +=, -=, *=, /=, %=
             * 증가/감소 연산자 : ++, --
             * 논리 연산자 : &&(And), ||(Or), !(Not)
             * 관계 연산자 : <, >, ==, !=, >=, <=
             * 비트 연산자 : &(AND), |(OR), ^(XOR)
             * shift 연산자 : >>, <<
             * 조건 연산자 : ? ex) int a = (x>y)? k:m : 삼항 연산자의 개념.
             */
            int a = 100 + 200;
            Console.WriteLine(a);

            int b = 10;
            // 후치 증가 연산.
            // b의 값을 보여주고 그 다음 +1 하겠다.
            Console.WriteLine(b++);

            // 선치 증가 연산.
            // 먼저 + 1을 하고 b값을 보여주겠다.
            Console.WriteLine(++b);

            // 관계 연산자
            bool res;
            res = 11 > 20;
            res = 100 == 100;
            res = 11 != 20;
            Console.WriteLine(res);

            // 논리 연산자.
            Console.WriteLine(10 > 5 && 10 < 100);

            // 조건 연산자
            // 조건식 ? 참일 때 값 : 거짓일 때 값.
            string str = (100 % 2) == 0 ? "짝수" : "홀수";
            Console.WriteLine(str);

            // 비트 연산자(shift, &, |, ^)
            Console.WriteLine("-----------shift 연산-----------");
            int aa = 1, bb = 2, cc = 3;

            // Formating
            Console.WriteLine("aa : {0} bb : {1} cc :{2}", aa, bb, cc);

            int e = 3;
            // 5자리 수만을 표기.
            Console.WriteLine("{0:D5}", e);
            // 16진수(x로 표기)를 8자리로 표시
            Console.WriteLine("{0:x8}", aa);
            // C를 사용할 경우 통화 표시
            Console.WriteLine("{0:C}", e);

            Console.WriteLine("{0:D3} 0x{0:x8}", e );
            // 왼쪽 방향으로 5bit 만큼 옮김.
            Console.WriteLine("{0:D3} 0x{0:x8}", e << 5);

            int x = 9;
            int y = 10;
            Console.WriteLine(x & y);
            Console.WriteLine(x | y);
            Console.WriteLine(x ^ y);

            // ~ : 보수 연산자(1, 0을 서로 뒤바꾸는 연산자)
            int xx = 255;
            Console.WriteLine("{0} x{0:X8} {1} 0x{1:X8}", xx, ~xx);
        
        }
    }
}

