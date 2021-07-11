using System;

namespace Data_type
{
    class Program
    {
        static void Main(string[] args)
        {
            /* c# 데이터 타입.
             * 
             * .NET 프로그래밍 언어는 .NET 공용 타입 형식을 사용.
             * int, double, string 키워드로 데이터 타입을 표현.
             * system.Int32, System.Double, System.String(.Net의 class로 데이터 타입을 표현하는 방법.)
             * 
             * ----- 논리형 -----
             * bool : True or False
             * 
             * ----- 정수형 -----
             * byte : 8bit unsigned 정수형(integer).
             * sbyte : 8bit signed 정수형.
             * (u)short : 16bit (un)signed 정수형.
             * (u)int : 32bit (un)sigend 정수형.
             * (u)long : 64bit (un)signed 정수형.
             * 
             * ----- 실수형 -----
             *float : 32bit 실수형.(데이터 손실의 발생이 가능성이 있음.)
             *double : 64bit 실수형.(일반적으로 데이터 손실을 위해 double 사용 권장)
             *decimal : 128bit 실수형(float, double 보다 정밀한 소수를 다룸.)
             *
             * ----- 문자형 -----
             * char : 16bit 유니코드 문자.
             * string : 유니코드 문자열.
             * 
             
            // 변수 선언.
            // 변수 사용시 _ 는 변수명으로 사용 가능.
            int x;

            // 변수의 초기화.
            x = 1000;

            // 선언과 초기화를 동시 수행.
            int y = 2000;

            // 여러개의 변수를 동시에 선언.
            int a, b, c;
            a = 1000;
            b = 2000;
            c = 3000;

            // 여러개의 변수를 선언과 초기화 동시에 수행.
            double z = 12.1, k = 11.11, kz = 22.22;

            */

            char a = 'H';
            char b = 'e';
            char c = 'l';
            char d = 'l';
            char e = 'o';

            string str = "Hello";
            Console.WriteLine(str);

            // 리터럴 데이터 : 123, True, "AGC" 와 같은 값들을 리터럴(Literal)이라 함.
            // 리터럴의 타입 : 123(int 리터럴), 11.11(double 리터럴 등)....
            // c# 컴파일러는 int, double, char, string, bool 데이터 타입에 기본적으로 그에 해당하는 값을 할당.
            // 데이터 타입별 접미사(Suffix)를 사용하여 특정 데이터 타입을 지정할 수 있음.
            // [ 접미어 ]
            // L : long형, U : Uint, UL : Ulong, F : float, D : double, M : desimal
            // ex) 11.11F : 실수형임을 보여줌. 대소문자 구분 없음.

            // 최댓값 속성.
            int aa = int.MaxValue;
            int aa_ = int.MinValue;
            Console.Write(aa_);
            Console.Write(" ~ ");
            Console.Write(aa);
            Console.ReadKey();

        }
    }
}
