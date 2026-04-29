// // 6-2
// class Program
// {
//     class Test
//     {
//         public int Multi(int x, int y)
//         {
//             return x * y;
//         }
//     }


//     static void Main(string[] args)
//     {
//         Test test = new Test();
//         Console.WriteLine(test.Multi(52, 273));
//         Console.WriteLine(test.Multi(103, 32));
//     }
// }

// class Program
// {
//     class Test
//     {
//         public void Print()
//         {
//             Console.WriteLine("Print() 메서드가 호출되었습니다.");
//         }
//     }

//     static void Main(string[] args)
//     {
//         Test test = new Test();
//         test.Print();
//         test.Print();
//         test.Print();
//     }
// }

// class Program
// {
//     class Test
//     {
//         public int Sum(int min, int max)
//         {
//             int output = 0;
//             for (int i = min; i <= max; i++)
//             {
//                 output += i;
//             }
//             return output;
//         }

//         static void Main(string[] args)
//         {
//             Test test = new Test();
//             Console.WriteLine(test.Sum(1, 100));
//         }
//     }
// }

// class Program
// {
//     class Test
//     {
//         public int Multiply(int min, int max)
//         {
//             int output = 1;
//             for (int i = min; i <= max; i++)
//             {
//                 output *= i;
//             }
//             return output;
//         }

//         static void Main(string[] args)
//         {
//             Test test = new Test();
//             Console.WriteLine(test.Multiply(1, 5));
//         }
//     }
// }

// class Program
// {
//     class Mymath
//     {
//         public static int Abs(int input)
//         {
//             if (input < 0)
//             {
//                 return -input;
//             }
//             else
//             {
//                 return input;
//             }
//         }

//         static void Main(string[] args)
//         {
//             Console.WriteLine(Mymath.Abs(52));
//             Console.WriteLine(Mymath.Abs(-273));
//         }
//     }
// }

// class Program
// {
//     class Mymath
//     {
//         public static int Abs(int input)
//         {
//             if (input < 0)
//             {
//                 return -input;
//             }
//             else
//             {
//                 return input;
//             }
//         }

//         public static double Abs(double intput)
//         {
//             if (intput < 0)
//             {
//                 return -intput;
//             }
//             else
//             {
//                 return intput;
//             }
//         }

//         public atatic long Abs(long intput)
//         {
//             if (intput < 0)
//             {
//                 return -intput;
//             }
//             else
//             {
//                 return intput;
//             }
//         }

//         static void Main(string[] args)
//         {
//             Console.WriteLine(Mymath.Abs(52));
//             Console.WriteLine(Mymath.Abs(-273));

//             Console.WriteLine(Mymath.Abs(52.273));
//             Console.WriteLine(Mymath.Abs(-32.103));

//             Console.WriteLine(Mymath.Abs(21474836470));
//             Console.WriteLine(Mymath.Abs(-21474836470));
//         }
//     }
// }

// class Program
// {
//     class Product
//     {
//         public static int counter = 0;
//         public int id;
//         public string name;
//         public int price;

//         public Product(string name, int price)
//         {
//             Product.counter = counter + 1;
//             this.id = counter;
//             this.name = name;
//             this.price = price;
//         }

//         static void Main(string[] args)
//         {
//             Product productA = new Product("감자", 2000);
//             Product productB = new Product("고구마", 3000);

//             Console.WriteLine(productA.id + ":" + productA.name);
//             Console.WriteLine(productB.id + ":" + productB.name);
//             Console.WriteLine(Product.counter + "개 생성되었습니다.");
//         }
//     }
// }

// using System;
// class Program
// {
//     class Product
//     {
//         public string name;
//         public int price;

//         public Product(string name, int price)
//         {
//             this.name = name;
//             this.price = price;
//         }

//         ~Product()
//         {
//             Console.WriteLine(this.name + "의 소멸자 호출");
//         }
//     }

//     static void Main(string[] args)
//     {
//         Product product = new Product("과자", 1000);
//     }
// }

// class Program
// {
//     class Box
//     {
//         private int width;
//         public int Width
//         {
//             get { return width; }
//             set
//             {
//                 if (value > 0)
//                 {
//                     width = value;
//                 }
//                 else
//                 {
//                     Console.WriteLine("너비는 양수여야 합니다.");
//                 }
//             }
//         }
//         private int height;
//         public int Height
//         {
//             get { return height; }
//             set
//             {
//                 if (value > 0)
//                 {
//                     height = value;
//                 }
//                 else
//                 {
//                     Console.WriteLine("높이는 양수여야 합니다.");
//                 }
//             }
//         }
//         public Box(int width, int height)
//         {
//             this.Width = width;
//             this.Height = height;
//         }
//         public int Area()
//         {
//             return width * height;
//         }
//     }

//     static void Main(string[] args)
//     {
//         Box box = new Box(-10, -20);

//         box.Width = -200;
//         box.Height = -100;
//     }
// }

//실습과제
class Program
{
    // 1. 컴퓨터 클래스
    // - 속성: 브랜드, 모델, 용도, 운영체제, 메모리 용량, 저장 용량, 화면 크기 등
    // - 메서드: 켜기, 끄기, 재부팅, 프로그램 실행, 파일 저장, 인터넷 연결 등
    class Computer
    {
        public static int TotalComputers = 0;

        private string brand;
        private string model;
        private int memoryCapacity;
        private string operatingSystem;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int MemoryCapacity
        {
            get { return memoryCapacity; }
            set { memoryCapacity = value > 0 ? value : 0; }
        }

        public string OperatingSystem
        {
            get { return operatingSystem; }
            set { operatingSystem = value; }
        }

        public Computer()
        {
            TotalComputers++;
        }

        public void TurnOn()
        {
            Console.WriteLine($"{Brand} 컴퓨터가 켜졌습니다.");
        }

        public void RunProgram(string programName)
        {
            Console.WriteLine($"{programName} 프로그램이 실행됩니다.");
        }

        public void RunProgram(string programName, bool runAsAdmin)
        {
            string mode = runAsAdmin ? "관리자 권한" : "일반 권한";
            Console.WriteLine($"{programName} 프로그램이 {mode}으로 실행됩니다.");
        }
    }

    // 2. 주문 클래스
    // - 속성: 주문번호, 주문자명, 주문일자, 주문 상품, 수량, 가격, 주소, 전화번호 등
    // - 메서드: 주문 생성, 주문 취소, 결제, 배송 등
    class Order
    {
        public static int TotalOrders = 0;

        private string orderNumber;
        private int price;
        private int orderCount;
        private string product;
        private string ordererName;

        public string OrderNumber
        {
            get { return orderNumber; }
            set { orderNumber = value; }
        }

        public string Product
        {
            get { return product; }
            set { product = value; }
        }

        public string OrdererName
        {
            get { return ordererName; }
            set { ordererName = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value >= 0 ? value : 0; }
        }

        public int OrderCount
        {
            get { return orderCount; }
            set { orderCount = value > 0 ? value : 1; }
        }

        public Order()
        {
            TotalOrders++;
        }

        public void OrderMake()
        {
            Console.WriteLine($"{Product}의 주문이 생성되었습니다.");
        }

        public void OrderPayment()
        {
            Console.WriteLine($"{Product} 결제가 완료되었습니다. 총 금액: {Price * OrderCount}원");
        }

        public void OrderPayment(string paymentMethod)
        {
            Console.WriteLine($"{Product} 결제가 {paymentMethod}(으)로 완료되었습니다. 총 금액: {Price * OrderCount}원");
        }
    }

    // 3. 학생 클래스
    // - 속성: 이름, 학번, 전공, 학년, 성적, 출석률, 이메일, 전화번호 등
    // - 메서드: 출석 체크, 성적 입력, 성적 조회, 이메일 발송, 전화 걸기 등
    class Student
    {
        public static int RegisteredStudentsCount = 0;

        private string name;
        private double score;
        private string studentId;
        private string major;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }

        public string Major
        {
            get { return major; }
            set { major = value; }
        }

        public double Score
        {
            get { return score; }
            set
            {
                if (value >= 0.0 && value <= 4.5)
                    score = value;
                else
                    Console.WriteLine("잘못된 성적입니다.");
            }
        }

        public Student()
        {
            RegisteredStudentsCount++;
        }

        public void CheckAttendance()
        {
            Console.WriteLine($"{Name} 학생의 출석이 체크되었습니다.");
        }

        public void CheckAttendance(string reasonForAbsence)
        {
            Console.WriteLine($"{Name} 학생은 결석 처리되었습니다. (사유: {reasonForAbsence})");
        }

        public void InputScore(double newScore)
        {
            Score = newScore;
            Console.WriteLine($"{Name} 학생의 성적이 {Score}로 입력되었습니다.");
        }
    }

    // 4. 음식 주문 시스템 클래스
    // - 속성: 주문번호, 주문자명, 주문일자, 주문 메뉴, 수량, 가격, 주소, 전화번호 등
    // - 메서드: 메뉴 선택, 수량 입력, 가격 계산, 주문 생성, 결제, 배송 등
    class FoodOrderSystem
    {
        public static int TodayOrderCount = 0;

        private string menu;
        private int orderCount;
        private int price;
        private string address;

        public string Menu
        {
            get { return menu; }
            set { menu = value; }
        }

        public int OrderCount
        {
            get { return orderCount; }
            set { orderCount = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public FoodOrderSystem()
        {
            TodayOrderCount++;
        }

        public void SelectMenu(string selectedMenu)
        {
            Menu = selectedMenu;
            Console.WriteLine($"{Menu} 메뉴가 선택되었습니다.");
        }

        public void SelectMenu(string selectedMenu, string options)
        {
            Menu = selectedMenu;
            Console.WriteLine($"{Menu} 메뉴가 선택되었습니다. (추가 옵션: {options})");
        }

        public void Payment()
        {
            Console.WriteLine($"{Menu} 결제가 완료되었습니다. 총 금액: {Price * OrderCount}원");
        }
    }
}
