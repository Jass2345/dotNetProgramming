// //기본예제 4-2 원하는 크기의 배열 생성
// int[] intArray = new int[100];

// Console.WriteLine(intArray[0]);
// Console.WriteLine(intArray[99]);

// //기본예제 4-3 while 반복문의 이용
// int i = 0;
// int[] intArray = {52, 273, 32, 65, 103};

// while (i < intArray.Length)
// {
//     Console.WriteLine(i + "번째 출력: " + intArray[i]);
//     i++;
// }

// //기본예제 4-4 do while 반복문의 활용
// string input;
// do
// {
//     Console.Write("입력(exit을 입력하면 종료): ");
//     input = Console.ReadLine();
// } while (input != "exit");

// //기본예제 4-5 for 반복문으로 덧셈
// int output = 0;

// for (int i = 1; i <= 100; i++)
// {
//     output += i;
// }

// Console.WriteLine(output);

// //기본예제 4-6 for 반복문으로 곱셈
// int output = 1;
// for (int i = 1; i <= 5; i++)
// {    
//     output *= i;
// }
// Console.WriteLine(output);

// //기본예제 4-7 한글 전부 출력
// for (int i = '가'; i <= '힣'; i++)
// {
//     Console.Write((char)i);
// }

// //기본예제 4-8 역 for 반복문
// int[] intArray = {1,2,3,4,5,6};

// for (int i = intArray.Length - 1; i >= 0; i--)
// {
//     Console.WriteLine(intArray[i]);
// }

// //기본예제 4-9
// string[] array = {"사과", "배", "포도", "딸기","바나나"};

// foreach (string item in array)
// {
//     Console.WriteLine(item);
// }

// //기본예제 4-11 별 피라미드
// for (int i = 1; i <= 10; i++)
// {
//     for (int j = 0; j < i; j++)
//     {
//         Console.Write("*");
//     }
//     Console.WriteLine();
// }

// //기본예제 4-12 별 피라미드 우로정렬
// for (int i = 1; i <= 10; i++)
// {
//     for (int j = 0; j < 10 - i; j++)
//     {
//         Console.Write(" ");
//     }
//     for (int k = 0; k < i; k++)
//     {
//         Console.Write("*");
//     }
//     Console.WriteLine();
// }

// //기본예제 4-13 break 키워드
// while (true)
// {
//     Console.Write("입력(짝수를 입력하면 종료): ");
//     int input = int.Parse(Console.ReadLine());
//     if (input % 2 == 0) break;
// }

// //기본예제 4-14 continue 키워드
// for (int i = 1; i <= 10; i++)
// {
//     if (i % 2 == 0) continue;
//     Console.WriteLine(i);
// }

//5주차 실습과제
// 1. continue 키워드를 이용하여 1부터 1000까지의 정수 중에서 3 또는 5의 배수인 수들의 합을 출력하는 프로그램을 작성하세요.
// int sum = 0;
// for (int i = 1; i <= 1000; i++)
// {
//     if (i % 3 != 0 && i % 5 != 0)
//     {
//         continue;
//     }
//     sum += i;
// }
// Console.WriteLine(sum);

// 2. for문을 이용하여 피보나치 수열의 20번째 항까지 출력하는 프로그램을 작성하세요. (피보나치 수열은 첫 번째 항과 두 번째 항이 각각 1이며, 이후의 항은 앞의 두 항을 더한 값입니다.)
// int first = 1, second = 1;
// Console.Write($"{first} {second} ");

// for (int i = 3; i <= 20; i++)
// {
//     int next = first + second;
//     Console.Write($"{next} ");
    
//     first = second;
//     second = next;
// }
// Console.WriteLine();

// 3. do-while문 이용하여 사용자로부터 입력받은 양수 n에 대하여, n의 약수를 모두 출력하는 프로그램을 작성하세요.
// Console.Write("양수 n을 입력하세요: ");
// int n = int.Parse(Console.ReadLine() ?? "1");
// int i = 1;

// Console.Write($"{n}의 약수: ");
// do
// {
//     if (n % i == 0)
//     {
//         Console.Write($"{i} ");
//     }
//     i++;
// } while (i <= n);
// Console.WriteLine();
// 4. break 키워드를 이용하여 사용자로부터 입력받은 양수 n에 대하여, n! (n팩토리얼)을 계산하는 프로그램을 작성하세요.
// Console.Write("n 입력: ");
// int n = int.Parse(Console.ReadLine() ?? "1");
// long factorial = 1;
// int current = 1;

// while (true)
// {
//     factorial *= current;
//     if (current >= n)
//     {
//         break;
//     }
//     current++;
// }
// Console.WriteLine($"{n}! = {factorial}");
// 5. while문을 이용하여 1부터 100까지의 정수 중에서 소수인 수들의 합을 출력하는 프로그램을 작성하세요.
// int num = 2;
// int totalSum = 0;

// while (num <= 100)
// {
//     bool isPrime = true;
//     int divisor = 2;

//     while (divisor <= Math.Sqrt(num))
//     {
//         if (num % divisor == 0)
//         {
//             isPrime = false;
//             break;
//         }
//         divisor++;
//     }

//     if (isPrime)
//     {
//         totalSum += num;
//     }
//     num++;
// }
// Console.WriteLine($"1부터 100까지 소수의 합: {totalSum}");