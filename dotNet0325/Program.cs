// //3-1 홀수 짝수 구분
// Console.Write("숫자 입력: ");
// int input = int.Parse(Console.ReadLine());

// if (input % 2 == 0)
// {
//     Console.WriteLine("짝수입니다!");
// }

// if (input % 2 == 1)
// {
//     Console.WriteLine("홀수입니다!");
// }

// //3-2 오전과 오후 구분
// Console.WriteLine(DateTime.Now.Year);
// Console.WriteLine(DateTime.Now.Month);
// Console.WriteLine(DateTime.Now.Day);
// Console.WriteLine(DateTime.Now.Hour);
// Console.WriteLine(DateTime.Now.Minute);
// Console.WriteLine(DateTime.Now.Second);

// if (DateTime.Now.Hour < 12)
// {
//     Console.WriteLine("오전입니다!");
// }

// if (12 < DateTime.Now.Hour)
// {
//     Console.WriteLine("오후입니다!");
// }

// //3-3 홀수 짝수 구분
// Console.Write("숫자 입력: ");
// int input = int.Parse(Console.ReadLine());

// if (input % 2 == 0)
// {
//     Console.WriteLine("짝수입니다!");
// }

// else
// {
//     Console.WriteLine("홀수입니다!");
// }

// //3-4 오전과 오후 구분
// if (DateTime.Now.Hour < 12)
// {
//     Console.WriteLine("오전입니다.");
// }

// else
// {
//     Console.WriteLine("오후입니다.");
// }

// //3-5 중첩 조건문 활용
// if (DateTime.Now.Hour < 11)
// {
//     Console.WriteLine("아침 먹을 시간입니다.");
// }

// else
// {
//     if (DateTime.Now.Hour < 15)
//     {
//         Console.WriteLine("점심 먹을 시간입니다.");
//     }
//     else
//     {
//         Console.WriteLine("저녁 먹을 시간입니다.");
//     }
// }

// //3-6 if else if 조건문 활용
// if (DateTime.Now.Hour < 11)
// {
//     Console.WriteLine("아침 먹을 시간입니다.");
// }

// else if (DateTime.Now.Hour < 15)
// {
//     Console.WriteLine("점심 먹을 시간입니다.");
// }

// else
// {
//     Console.WriteLine("저녁 먹을 시간입니다.");
// }

// //3-7 switch 조건문 활용
// Console.WriteLine("숫자 입력: ");
// int input = int.Parse(Console.ReadLine());

// switch (input % 2)
// {
//     case 0:
//         Console.WriteLine("짝수입니다");
//         break;

//     case 1:
//         Console.WriteLine("짝수입니다");
//         break;
// }

// //3-8 switch 조건문 활용
// Console.WriteLine("이번 달은 몇 월인가요: ");
// int input = int.Parse(Console.ReadLine());

// switch (input)
// {
//     case 12:
//     case 1:
//     case 2:
//         Console.WriteLine("겨울입니다.");
//         break;

//     case 3:
//     case 4:
//     case 5:
//         Console.WriteLine("봄입니다.");
//         break;
        
//     case 6:
//     case 7:
//     case 8:
//         Console.WriteLine("여름입니다.");
//         break;
    
//     case 9:
//     case 10:
//     case 11:
//         Console.WriteLine("가을입니다.");
//         break;
    
//     default:
//         Console.WriteLine("대체 어떤 행성에 살고 계신가요?");
//         break;
// }

// //3-9 삼항연산자
// string input = Console.ReadLine();
// int number = int.Parse(input);

// Console.WriteLine(number > 0 ? "자연수입니다" : "자연수가 아닙니다");

// //실습과제
// //1. 중첩 조건문을 사용하여 사용자에게 입력받은 숫자가 양수인지, 음수인지, 0인지 판단하여 출력하는 프로그램을 작성하라.
// int input = int.Parse(Console.ReadLine());
// if (input > 0)
// {
//     Console.WriteLine("양수입니다.");
// }
// else
// {
//     if (input < 0)
//     {
//         Console.WriteLine("음수입니다.");
//     }
//     else
//     {
//         Console.WriteLine("0입니다.");
//     }
// }

// //2. 삼항연산자을 사용하여 사용자에게 입력받은 숫자를 이진수로 변환하여 출력하는 프로그램을 작성하라.
// int input = int.Parse(Console.ReadLine());
// string result = (input < 0) ? "양수를 입력하세요." : Convert.ToString(input, 2);

// //3. if문을 사용하여 사용자에게 숫자 3개를 입력받아 오름차순으로 정렬하여 출력하는 프로그램을 작성하라.
// Console.Write("첫 번째 숫자: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("두 번째 숫자: ");
// int b = int.Parse(Console.ReadLine());
// Console.Write("세 번째 숫자: ");
// int c = int.Parse(Console.ReadLine());
// int temp;

// if (a > b) { temp = a; a = b; b = temp; }
// if (a > c) { temp = a; a = c; c = temp; }
// if (b > c) { temp = b; b = c; c = temp; }

// Console.WriteLine($"오름차순 정렬 결과: {a}, {b}, {c}");

// //4. switch문을 사용하여, 사용자에게 입력받은 문자열에서 모음(a, e, i, o, u)의 개수를 세어 출력하는 프로그램을 작성하라.
// Console.Write("영문 문자열을 입력하세요: ");
// string input = Console.ReadLine().ToLower();
// int count = 0;

// foreach (char ch in input) {
//     switch (ch) {
//         case 'a':
//         case 'e':
//         case 'i':
//         case 'o':
//         case 'u':
//             count++;
//             break;
//         default:
//             break;
//     }
// }

// Console.WriteLine($"모음의 총 개수: {count}개");