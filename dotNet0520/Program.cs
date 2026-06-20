﻿//class Wanted<T>
//{
//    public T Value;

//    public Wanted(T value)
//    {
//        this.Value = value;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Wanted<string> wantedString = new Wanted<string>("Hello, World!");
//        Wanted<int> wantedInt = new Wanted<int>(42);
//        Wanted<double> wantedDouble = new Wanted<double>(3.14);

//        Console.WriteLine($"Wanted String: {wantedString.Value}");
//        Console.WriteLine($"Wanted Int: {wantedInt.Value}"); 
//        Console.WriteLine($"Wanted Double: {wantedDouble.Value}");
//    }
//}


//class Products
//{
//    public int this[int i]
//    {
//        get { return i; }
//        set { Console.WriteLine($"Setting value {value} at index {i}"); }
//    }
//}

//class Program
//    {
//        static void Main(string[] args)
//        {
//            Products product = new Products();
//            product[3] = 100;

//            Console.WriteLine(product[3]);
//        }
//    }

//class Calculator
//{
//    public int this[int i]
//    {
//        set
//        {
//            return i * 2;
//        }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Calculator calculator = new Calculator();
//        Console.WriteLine(calculator[5]);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("숫자 입력: ");
//        int output;
//        bool result = int.TryParse(Console.ReadLine(), out output);

//        if (result)
//        {
//            Console.WriteLine("입력한 숫자: " + output);
//        }
//        else
//        {
//            Console.WriteLine("숫자를 입력해주세요");
//        }
//    }
//}

//class Program
//{
//    static void NextPosition(int x, int y, int vx, int vy, out int rx, out int ry)
//    {
//        rx = x + vx;
//        ry = y + vy;
//    }

//    static void Main()
//    {
//        int x = 0, y = 0, vx = 1, vy = 1;
//        Console.WriteLine("현재 좌표 (x, y): ({0}, {1})", x, y);

//        NextPosition(x, y, vx, vy, out x, out y);
//        Console.WriteLine("다음 좌표 (x, y): ({0}, {1})", x, y);
//    }
//}

//class Program
//{
//    struct Point
//    {
//        public int x;
//        public int y;
//    }

//    static void Main(string[] args)
//    {
//        Point point;
//        point.x = 10;
//        point.y = 20;
//    }
//}

//class Program
//{
//    struct Point
//    {
//        public int x;
//        public int y;

//        public Point(int x, int y)
//        {
//            this.x = x;
//            this.y = y;
//        }
//    }

//    static void Main(string[] args)
//    {
//        Point point = new Point(1, 2);
//        Console.WriteLine(point.x);
//        Console.WriteLine(point.y);
//    }
//}

//실습과제
// 1. 제네릭 클래스로 구현된 Stack 클래스를 만들어보시오
// Push, Pop, Peek 으로 구성됨
// 실제 리스트를 이용하여 Product를 push, pop, peek하는 프로그램을 작성하시오.
using System;
using System.Collections.Generic;

public class Product
{
    public string Name { get; set; }
    public int Price { get; set; }

    public Product(string name, int price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"[{Name}: {Price:#,0}원]";
    }
}

public class CustomStack<T>
{
    private List<T> _list = new List<T>();

    public void Push(T item)
    {
        _list.Add(item);
    }

    public T Pop()
    {
        if (_list.Count == 0)
            throw new InvalidOperationException("스택이 비어 있습니다.");

        int lastIndex = _list.Count - 1;
        T item = _list[lastIndex];
        _list.RemoveAt(lastIndex);
        return item;
    }

    public T Peek()
    {
        if (_list.Count == 0)
            throw new InvalidOperationException("스택이 비어 있습니다.");

        return _list[_list.Count - 1];
    }
    
    public int Count => _list.Count;
}

class Program1
{
    static void Main()
    {
        CustomStack<Product> stack = new CustomStack<Product>();

        stack.Push(new Product("노트북", 1500000));
        stack.Push(new Product("스마트폰", 1000000));
        stack.Push(new Product("키보드", 150000));

        Console.WriteLine($"Peek (가장 위 데이터 확인): {stack.Peek()}"); 
        Console.WriteLine($"Pop (데이터 꺼내기): {stack.Pop()}");   
        Console.WriteLine($"Pop (데이터 꺼내기): {stack.Pop()}");   
    }
}

// 2. String 2개를 받는 Try.Parse2를 정의해보라.
// 하나의 스트링을 받아서, int 또는 double로 바꿔서 
// 둘 중 하나 성공적으로 되면 true를 리턴하고 성공적으로 변경된 값은 out parameter에 넣는 프로그램
class Program2
{
    public static bool TryParse2(string input, out int intResult, out double doubleResult)
    {
        intResult = 0;
        doubleResult = 0.0;

        if (int.TryParse(input, out intResult))
        {
            return true;
        }
        if (double.TryParse(input, out doubleResult))
        {
            return true;
        }

        return false;
    }

    static void Main()
    {
        Console.Write("숫자 입력: ");
        string input = Console.ReadLine();

        if (TryParse2(input, out int intVal, out double doubleVal))
        {
            if (intVal != 0 || input.Trim() == "0")
            {
                Console.WriteLine($"-> int로 변환 성공: {intVal}");
            }
            else
            {
                Console.WriteLine($"-> double로 변환 성공: {doubleVal}");
            }
        }
        else
        {
            Console.WriteLine("-> 변환 실패: int 또는 double로 변경할 수 없는 문자열입니다.");
        }
    }
}