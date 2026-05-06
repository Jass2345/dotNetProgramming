// class Program
// {
//     class Parent
//     {
//         public int variable = 273;
//     }

//     class Child : Parent
//     {
//         public string variable = "shadowing";   
//     }

//     static void Main(string[] args)
//     {
//         Child child = new Child();
//         Console.WriteLine(child.variable);
//         Console.WriteLine(((Parent)child).variable);
//     }
// }

// class Program
// {
//     class Parent
//     {
//         public void Method()
//         {
//             Console.WriteLine("부모의 메서드");
//         }
//     }

//     class Child : Parent
//     {
//         public void Method()
//         {
//             Console.WriteLine("자식의 메서드");
//         } 
//     }

//     static void Main(string[] args)
//     {
//         Child child = new Child();
//         child.Method();
//         ((Parent)child).Method();
//     }
// }

// //7-4 오버라이딩
// class Program
// {
//     class Parent
//     {
//         public virtual void Method()
//         {
//             Console.WriteLine("부모의 메서드");
//         }
//     }

//     class Child : Parent
//     {
//         public override void Method()
//         {
//             Console.WriteLine("자식의 메서드");
//         } 
//     }

//     static void Main(string[] args)
//     {
//         Child child = new Child();
//         child.Method();
//         ((Parent)child).Method();
//     }
// }

// // 7-5 오버라이딩 방지
// class Program
// {
//     class Parent
//     {
//         public virtual void Test() {}
//     }

//     class Child : Parent
//     {
//         public sealed override void Test() {}
//     }

//     class GrandChild : Child
//     {
//         // public override void Test() {} //sealed키워드가 부모에게 있어서 더 이상 override 불가
//     }
// }

// // 7-6 추상 클래스
// class Program
// {
//     abstract class Parent
//     {
//         public void Test() {}
//     }

//     class Child : Parent
//     {
//         public void Test() {}
//     }

//     static void Main(string[] args)
//     {
//         // Parent parent = new Parent(); //상속해서 써야하므로 객체 생성 불가
//         Child child = new Child();
//         child.Test();
//     }
// }

// // 7-7 추상 메서드
// class Program
// {    
//     abstract class Parent
//     {
//         public abstract void Test();
//     }

//     class Child : Parent
//     {
//         public override void Test() {}
//     }
// }

//실습과제
class Program
{
    class University { }

    class Student : University 
    { 
        public void Study() { Console.WriteLine("학생"); } 
    }
    
    class Professor : University 
    { 
        public void Teach() { Console.WriteLine("교수"); } 
    }
    
    class Staff : University 
    { 
        public void Work() { Console.WriteLine("직원"); } 
    }

    class FlightPerson { }

    class Pilot : FlightPerson 
    { 
        public void Fly() { Console.WriteLine("파일럿"); } 
    }
    
    class Crew : FlightPerson 
    { 
        public void Serve() { Console.WriteLine("승무원"); } 
    }
    
    class Passenger : FlightPerson 
    { 
        public void Rest() { Console.WriteLine("탑승객"); } 
    }

    class Vehicle { }

    class Bicycle : Vehicle 
    { 
        public void Ride() { Console.WriteLine("자전거"); } 
    }
    
    class Motorcycle : Vehicle 
    { 
        public void RideFast() { Console.WriteLine("오토바이"); } 
    }
    
    class Car : Vehicle 
    { 
        public void Drive() { Console.WriteLine("자동차"); } 
    }

    static void Main(string[] args)
    {
        List<University> University = new List<University>();
        University.Add(new Student());
        University.Add(new Professor());
        University.Add(new Staff());

        foreach (University member in University)
        {
            if (member is Student)
            {
                Student s = (Student)member;
                s.Study();
            }
            else if (member is Professor)
            {
                Professor p = (Professor)member;
                p.Teach();
            }
            else
            {
                Staff staff = member as Staff;
                if (staff != null) 
                {
                    staff.Work();
                }
            }
        }
        Console.WriteLine();

        List<FlightPerson> flightPeople = new List<FlightPerson>();
        flightPeople.Add(new Pilot());
        flightPeople.Add(new Crew());
        flightPeople.Add(new Passenger());

        foreach (FlightPerson person in flightPeople)
        {
            if (person is Pilot)
            {
                ((Pilot)person).Fly();
            }
            else if (person is Crew)
            {
                ((Crew)person).Serve();
            }
            else
            {
                Passenger passenger = person as Passenger;
                if (passenger != null) passenger.Rest();
            }
        }
        Console.WriteLine();

        List<Vehicle> vehicles = new List<Vehicle>();
        vehicles.Add(new Bicycle());
        vehicles.Add(new Motorcycle());
        vehicles.Add(new Car());

        foreach (Vehicle vehicle in vehicles)
        {
            if (vehicle is Bicycle)
            {
                ((Bicycle)vehicle).Ride();
            }
            else if (vehicle is Motorcycle)
            {
                ((Motorcycle)vehicle).RideFast();
            }
            else
            {
                Car car = vehicle as Car;
                if (car != null) car.Drive();
            }
        }
    }
}