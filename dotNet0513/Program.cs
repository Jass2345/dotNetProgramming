// // 7-4 부모 클래스 정의
// class Animal
// {
//     public int Age { get; set; }
//     public void Eat()
//     {
//         Console.WriteLine("먹는다");
//     }
//     public void Sleep()
//     {
//         Console.WriteLine("잔다");
//     }
// }

// class Dog : Animal
// {
//     public void Bark()
//     {
//         Console.WriteLine("짖는다");
//     }
// }

// class Cat : Animal
// {
//     public void Meow()
//     {
//         Console.WriteLine("야옹");
//     }
// }

// // // is키워드
// // class Program
// // {
// //     static void Main(string[] args)
// //     {
// //         List<Animal> animals = new List<Animal>()
// //         {
// //             new Dog(), new Cat(), new Cat(), new Dog(),
// //             new Dog(), new Cat(), new Dog(), new Dog()
// //         };

// //         foreach (Animal item in animals)
// //         {
// //             item.Eat();
// //             item.Sleep();

// //             if (item is Dog dog) { dog.Bark(); }
// //             if (item is Cat cat) { cat.Meow(); }
// //         }
// //     }
// // }

// // as키워드
// class Program
// {
//     static void Main(string[] args)
//     {
//         List<Animal> animals = new List<Animal>()
//         {
//             new Dog(), new Cat(), new Cat(), new Dog(),
//             new Dog(), new Cat(), new Dog(), new Dog()
//         };

//         foreach (Animal item in animals)
//         {
//             item.Eat();
//             item.Sleep();

//             var dog = item as Dog;
//             if (dog != null) { dog.Bark(); }
//             var cat = item as Cat;
//             if (cat != null) { cat.Meow(); }
//         }
//     }
// }

//실습과제

class UniversityMember
{
    public string Name { get; set; }
    public string Id { get; set; }

    public UniversityMember()
    {
        Name = "없음";
        Id = "없음";
        Console.WriteLine("[부모 생성자1] 호출");
    }

    public UniversityMember(string name, string id)
    {
        Name = name;
        Id = id;
        Console.WriteLine($"[부모 생성자2] 이름={name}, ID={id}");
    }

    public virtual void Work()
    {
        Console.WriteLine($"{Name}이 일을 한다");
    }

    public void Info()
    {
        Console.WriteLine($"이름: {Name}, ID: {Id}");
    }
}

class Student : UniversityMember
{
    public string Major { get; set; }

    public Student() : base()
    {
        Major = "없음";
        Console.WriteLine($"[학생 생성자1] 학생 생성");
    }

    public Student(string name, string id, string major) : base(name, id)
    {
        Major = major;
        Console.WriteLine($"[학생 생성자2] 학과={major}");
    }

    public override void Work()
    {
        Console.WriteLine($"학생 {Name}이 공부를 한다");
    }

    public new void Info()
    {
        Console.WriteLine($"이름: {Name}, ID: {Id}, 학과: {Major}");
    }
}

class Professor : UniversityMember
{
    public string Department { get; set; }

    public Professor(string name, string id, string department) : base(name, id)
    {
        Department = department;
        Console.WriteLine($"[교수 생성자] 학부={department}\n");
    }

    public override void Work()
    {
        Console.WriteLine($"교수 {Name}이 강의를 한다");
    }
}

class Staff : UniversityMember
{
    public string Position { get; set; }

    public Staff(string name, string id, string position) : base(name, id)
    {
        Position = position;
        Console.WriteLine($"[직원 생성자] 직책={position}\n");
    }

    public override void Work()
    {
        Console.WriteLine($"직원 {Name}이 행정 업무를 한다");
    }
}

abstract class Vehicle
{
    public string Brand { get; set; }
    public int Price { get; set; }

    protected Vehicle(string brand, int price)
    {
        Brand = brand;
        Price = price;
    }

    public abstract void Introduce();
    public abstract void Drive();
}

class Bicycle : Vehicle
{
    public int Gears { get; set; }

    public Bicycle(string brand, int price, int gears) : base(brand, price)
    {
        Gears = gears;
    }

    public override void Introduce()
    {
        Console.WriteLine($"자전거: {Brand}, 가격: {Price}원, 기어: {Gears}단");
    }

    public override void Drive()
    {
        Console.WriteLine($"{Brand} 자전거를 탄다");
    }
}

class Motorcycle : Vehicle
{
    public int CylinderCC { get; set; }

    public Motorcycle(string brand, int price, int cc) : base(brand, price)
    {
        CylinderCC = cc;
    }

    public override void Introduce()
    {
        Console.WriteLine($"오토바이: {Brand}, 가격: {Price}원, 배기량: {CylinderCC}cc");
    }

    public override void Drive()
    {
        Console.WriteLine($"{Brand} 오토바이를 탄다");
    }
}

class Car : Vehicle
{
    public int Seats { get; set; }

    public Car(string brand, int price, int seats) : base(brand, price)
    {
        Seats = seats;
    }

    public override void Introduce()
    {
        Console.WriteLine($"자동차: {Brand}, 가격: {Price}원, 좌석: {Seats}인승");
    }

    public override void Drive()
    {
        Console.WriteLine($"{Brand} 자동차를 탄다");
    }
}

abstract class Shape
{
    protected string Name { get; set; }

    public abstract double CalculateArea();
    public abstract void Display();
}

class Triangle : Shape
{
    public double Base { get; set; }
    public double Height { get; set; }

    public Triangle(double baseValue, double heightValue)
    {
        Name = "삼각형";
        Base = baseValue;
        Height = heightValue;
    }

    public override double CalculateArea()
    {
        return (Base * Height) / 2;
    }

    public override void Display()
    {
        Console.WriteLine($"{Name}: 밑변={Base}, 높이={Height}, 넓이={CalculateArea()}");
    }
}

class Rectangle : Shape
{
    public double Width { get; set; }
    public double Length { get; set; }

    public Rectangle(double width, double length)
    {
        Name = "사각형";
        Width = width;
        Length = length;
    }

    public override double CalculateArea()
    {
        return Width * Length;
    }

    public override void Display()
    {
        Console.WriteLine($"{Name}: 가로={Width}, 세로={Length}, 넓이={CalculateArea()}");
    }
}

class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Name = "원";
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override void Display()
    {
        Console.WriteLine($"{Name}: 반지름={Radius}, 넓이={CalculateArea():F2}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("========== 예제 1: 대학 소속 멤버 ==========\n");
        
        Student student1 = new Student();
        
        Student student2 = new Student("김철수", "S001", "컴퓨터과학");
        Professor professor = new Professor("이영희", "P001", "공과대학");
        Staff staff = new Staff("박민수", "E001", "과장");

        Console.WriteLine("\n--- 메서드 호출 ---");
        student1.Work();
        student1.Info(); // 하이딩된 메서드
        
        Console.WriteLine();
        student2.Work(); // 오버라이딩된 메서드
        student2.Info(); // 하이딩된 메서드
        
        Console.WriteLine();
        professor.Work(); // 오버라이딩된 메서드
        professor.Info(); // 부모의 메서드
        
        Console.WriteLine();
        staff.Work(); // 오버라이딩된 메서드

        Console.WriteLine("\n========== 예제 2: 오토 쇼핑몰 ==========\n");
        
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Bicycle("삼천리", 300000, 21),
            new Motorcycle("야마하", 5000000, 155),
            new Car("현대 그랜저", 35000000, 5)
        };

        foreach (Vehicle vehicle in vehicles)
        {
            vehicle.Introduce();
            vehicle.Drive();
            Console.WriteLine();
        }

        Console.WriteLine("========== 예제 3: 도형 ==========\n");
        
        List<Shape> shapes = new List<Shape>
        {
            new Triangle(5, 4),
            new Rectangle(10, 5),
            new Circle(3)
        };

        foreach (Shape shape in shapes)
        {
            shape.Display();
        }
    }
}
