//// 정수형
//Console.WriteLine(1 + 2);
//Console.WriteLine(1 - 2);
//Console.WriteLine(1 * 2);
//Console.WriteLine(1 / 2);
//Console.WriteLine(1 % 2);

////실수형
//Console.WriteLine(1.0 + 2.0);
//Console.WriteLine(1.0 - 2.0);
//Console.WriteLine(1.0 * 2.0);
//Console.WriteLine(1.0 / 2.0);

////문자
//Console.WriteLine('A');
//Console.WriteLine('가');
//Console.WriteLine('나');

////이스케이프 문자
//Console.WriteLine("한빛\t아카데미");
//Console.WriteLine("한빛\n아카데미");
//Console.WriteLine("\"\"\"");

////문자열 연결
//Console.WriteLine("가나다" + "라마" + "바사아" + "자차카타" + "파하");

////문자 선택
//Console.WriteLine("안녕하세요"[0]);
//Console.WriteLine("안녕하세요"[1]);
//Console.WriteLine("안녕하세요"[3]);

////불과 비교연산자
//Console.WriteLine(52 > 273);
//Console.WriteLine(52 < 273);

////논리 부정 연산자
//Console.WriteLine(!true);
//Console.WriteLine(!false);
//Console.WriteLine(!(52 < 273));
//Console.WriteLine(!(52 > 273));

////불과 논리 연산자
//Console.WriteLine(DateTime.Now.Hour < 3 || 8 < DateTime.Now.Hour);
//Console.WriteLine(3 < DateTime.Now.Hour && DateTime.Now.Hour < 8);

////정수 변수 생성
//int a = 273;
//int b = 52;

//Console.WriteLine(a + b);
//Console.WriteLine(a - b);
//Console.WriteLine(a * b);
//Console.WriteLine(a / b);
//Console.WriteLine(a % b);

////오버플로우
//int a = 2000000000;
//int b = 2000000000;
//Console.WriteLine(a + b);

////실수 변수 생성
//double a = 52.273;
//double b = 103.32;

//Console.WriteLine(a + b);
//Console.WriteLine(a - b);
//Console.WriteLine(a * b);
//Console.WriteLine(a / b);

////문자 변수 생성
//char a = 'a';
//Console.WriteLine(a);

//string message = "안녕하세요";
//Console.WriteLine(message + "!");
//Console.WriteLine(message[0]);
//Console.WriteLine(message[1]);
//Console.WriteLine(message[2]);

////불변수 생성
//bool one = 10 < 0;
//bool other = 20 > 100;

//Console.WriteLine(one);
//Console.WriteLine(other);

////숫자와 관련된 복합 대입 연산자
//int output = 0;
//output += 52;
//output += 273;
//output += 103;

//Console.WriteLine(output);

////문자열과 관련된 복합 대입 연산자
//string output = "hello ";
//output += "world";
//output += "!";

//Console.WriteLine(output);

////증감연산자
//int number = 10;
//number++;
//Console.WriteLine(number);
//number--;
//Console.WriteLine(number);

////증감 연산자의 후위 형태의 작성 코드 및 실행 결과
//int number = 10;
//Console.WriteLine(number);
//Console.WriteLine(number++);
//Console.WriteLine(number--);
//Console.WriteLine(number);

////증감 연산자의 후위 형태의 작성 코드 및 실행 결과
//int number = 10;
//Console.WriteLine(number);
//Console.WriteLine(++number);
//Console.WriteLine(--number);
//Console.WriteLine(number);

////GetType() 메서드 활용
//int _int = 273;
//long _long = 52227310333265;
//float _float = 52.273f;
//double _double = 52.273;
//char _char = '글';
//string _string = "문자열";

//Console.WriteLine(_int.GetType());
//Console.WriteLine(_long.GetType());
//Console.WriteLine(_float.GetType());
//Console.WriteLine(_double.GetType());
//Console.WriteLine(_char.GetType());
//Console.WriteLine(_string.GetType());

////직접적인 GetType() 메서드 활용
//Console.WriteLine((273).GetType());
//Console.WriteLine((522731033265).GetType());
//Console.WriteLine(('자').GetType());
//Console.WriteLine(("문자열").GetType());

////문자열 입력과 출력
//String input = Console.ReadLine();
//Console.WriteLine("input: " + input);

////강제 자료형 변환
//long longNumber = 2147483647L + 2147483647L;
//int intNumber = (int)longNumber;
//Console.WriteLine(intNumber);

////숫자 손상
//long longNumber = 2147483647L + 2147483647L;
//int longToInt = (int)longNumber;
//Console.WriteLine(longToInt);

////double 자료형을 int 자료형으로 변환
//double doubleNumber = 52.27310332;
//int doubleToInt = (int)doubleNumber;
//Console.WriteLine(doubleToInt);

// //2주차 과제 260311
// //1번
// String input = Console.ReadLine();
// int stringToInt = (int)input[0];
// double intToDouble = (double)stringToInt;
// double result = intToDouble * 1.5;
// Console.WriteLine(result);

// //2번
// Char doubleToChar = (Char)result;
// string charToString = doubleToChar.ToString();
// Console.WriteLine(charToString.Length);
