//실습문제
// 1. 사각형을 추상화한 클래스를 선언하고 Icomparable 을 상속 받으시오.(CompareTo()는 사각형의 넓이를 비교하여야 함)
// 사각형을 리스트에 삽입하고, 이를 넓이로 sorting하는 코드를 작성하시오.
using System;
using System.Collections.Generic;

public class Rectangle : IComparable<Rectangle>
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double Area => Width * Height;

    public int CompareTo(Rectangle other)
    {
        if (other == null) return 1;
        
        return this.Area.CompareTo(other.Area);
    }

    public override string ToString()
    {
        return $"[가로: {Width}, 세로: {Height}, 넓이: {Area}]";
    }
}

class Program1
{
    static void Main()
    {
        List<Rectangle> rectangles = new List<Rectangle>
        {
            new Rectangle(5, 5),    
            new Rectangle(2, 10),   
            new Rectangle(3, 4),    
            new Rectangle(6, 7)     
        };

        Console.WriteLine("=== 정렬 전 ===");
        foreach (var rect in rectangles)
        {
            Console.WriteLine(rect);
        }

        rectangles.Sort();

        Console.WriteLine("\n=== 넓이 기준 오름차순 정렬 후 ===");
        foreach (var rect in rectangles)
        {
            Console.WriteLine(rect);
        }
    }
}

// 2. 3차원 공간의 점을 표현하는 Vector struct를 선언하고 Icomparable 을 상속 받으시오.
// 생성자를 구현하여 세 좌표를 입력하여 Vector를 생성하고, 이를 저장하는 리스트를 이용하여 저장하여야 한다. 전체 Vector를 정렬하여 출력하는 코드를 작성하시오.
public struct Vector : IComparable<Vector>
{
    public double X { get; }
    public double Y { get; }
    public double Z { get; }

    // 3개의 좌표를 입력받는 생성자
    public Vector(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public double MagnitudeSquared => (X * X) + (Y * Y) + (Z * Z);
    
    public double Magnitude => Math.Sqrt(MagnitudeSquared);

    public int CompareTo(Vector other)
    {
        return this.MagnitudeSquared.CompareTo(other.MagnitudeSquared);
    }

    public override string ToString()
    {
        return $"Vector(X: {X}, Y: {Y}, Z: {Z}) -> 크기: {Magnitude:F2}";
    }
}

class Program2
{
    static void Main()
    {
        // Vector 리스트 생성 및 초기화
        List<Vector> vectors = new List<Vector>
        {
            new Vector(3, 4, 0),    
            new Vector(1, 1, 1),    
            new Vector(0, 0, 0),    
            new Vector(5, 12, 0)    
        };

        Console.WriteLine("정렬 전");
        foreach (var v in vectors)
        {
            Console.WriteLine(v);
        }

        vectors.Sort();

        Console.WriteLine("\n크기 기준 오름차순 정렬 후");
        foreach (var v in vectors)
        {
            Console.WriteLine(v);
        }
    }
}