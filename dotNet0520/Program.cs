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