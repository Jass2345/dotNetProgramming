//11-5 델리게이트 선언과 사용

// // 11-7 델리게이트 초기화 방법
// class Program
// {
//     public delegate void MyDelegate(string message);
//     static void Main(string[] args)
//     {
//         // 1. 메서드 그룹을 이용한 초기화
//         MyDelegate del1 = MethodA;
//         del1("Hello from MethodA!");

//         // 2. 익명 메서드를 이용한 초기화
//         MyDelegate del2 = delegate (string message)
//         {
//             Console.WriteLine("Hello from Anonymous Method: " + message);
//         };
//         del2("Hello from Anonymous Method!");

//         // 3. 람다 식을 이용한 초기화
//         MyDelegate del3 = (message) => Console.WriteLine("Hello from Lambda Expression: " + message);
//         del3("Hello from Lambda Expression!");
//     }
//     static void MethodA(string message)    {
//         Console.WriteLine("Hello from MethodA: " + message);
//     }
// }

