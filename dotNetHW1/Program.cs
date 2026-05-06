using System;

class Program
{
    // 1. 컴퓨터 클래스
    // - 속성: 브랜드, 모델, 용도, 운영체제, 메모리 용량, 저장 용량, 화면 크기 등
    // - 메서드: 켜기, 끄기, 재부팅, 프로그램 실행, 파일 저장, 인터넷 연결 등
    public class Computer
    {
        public static int TotalComputers = 0;
        private string brand = "";
        private string model = "";
        private int memoryCapacity;
        private string operatingSystem = "";

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

        public Computer(string brand, string model, int memoryCapacity, string operatingSystem)
        {
            Brand = brand;
            Model = model;
            MemoryCapacity = memoryCapacity;
            OperatingSystem = operatingSystem;
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

    public static void UpgradeMemory_Value(int memory)
    {
        memory = 32;
        Console.WriteLine($"메모리를 {memory}GB로 변경했습니다.(값복사)");
    }

    public static void UpgradeMemory_Reference(Computer comp)
    {
        comp.MemoryCapacity = 32;
        Console.WriteLine($"메모리를 {comp.MemoryCapacity}GB로 변경했습니다.(참조복사)");
    }


    // 2. 주문 클래스
    // - 속성: 주문번호, 주문자명, 주문일자, 주문 상품, 수량, 가격, 주소, 전화번호 등
    // - 메서드: 주문 생성, 주문 취소, 결제, 배송 등
    public class Order
    {
        public static int TotalOrders = 0;
        private string orderNumber = "";
        private DateTime orderDate;
        private int price;
        private int orderCount;
        private string product = "";
        private string ordererName = "";

        public string OrderNumber
        {
            get { return orderNumber; }
            set { orderNumber = value; }
        }

        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
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

        public Order(string orderNumber, string ordererName, DateTime orderDate, string product, int orderCount)
        {
            OrderNumber = orderNumber;
            OrdererName = ordererName;
            OrderDate = orderDate;
            Product = product;
            OrderCount = orderCount;
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

    public static void ChangeOrderProduct_Value(string product)
    {
        product = "사과";
        Console.WriteLine($"주문된 상품이 {product}로 변경되었습니다.(값복사)");
    }

    public static void ChangeOrderProduct_Reference(Order product)
    {
        product.Product = "사과";
        Console.WriteLine($"주문된 상품이 {product.Product}로 변경되었습니다.(참조복사)");
    }

    // 3. 학생 클래스
    // - 속성: 이름, 학번, 전공, 학년, 성적, 출석률, 이메일, 전화번호 등
    // - 메서드: 출석 체크, 성적 입력, 성적 조회, 이메일 발송, 전화 걸기 등
    public class Student
    {
        public static int RegisteredStudentsCount = 0;
        private string name = "";
        private string studentId = "";
        private double score;
        private string major = "";
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

        public Student(string name, string studentId, string major)
        {
            Name = name;
            StudentId = studentId;
            Major = major;
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

    public static void ChangeStudentMajor_Value(string major)
    {
        major = "건축공학";
        Console.WriteLine($"전공이 {major}으로 변경되었습니다.(값복사)");
    }

    public static void ChangeStudentMajor_Reference(Student student)
    {
        student.Major = "건축공학";
        Console.WriteLine($"전공이 {student.Major}으로 변경되었습니다.(참조복사)");
    }

    // 4. 음식 주문 시스템 클래스
    // - 속성: 주문번호, 주문자명, 주문일자, 주문 메뉴, 수량, 가격, 주소, 전화번호 등
    // - 메서드: 메뉴 선택, 수량 입력, 가격 계산, 주문 생성, 결제, 배송 등
    public class FoodOrderSystem
    {
        public static int TodayOrderCount = 0;
        private string orderNumber = "";
        private string ordererName = "";
        private DateTime orderDate;
        private string menu = "";
        private int orderCount;
        private int price;
        private string address = "";

        public string OrderNumber
        {
            get { return orderNumber; }
            set { orderNumber = value; }
        }

        public string OrdererName
        {
            get { return ordererName; }
            set { ordererName = value; }
        }

        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }
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

        public FoodOrderSystem(string orderNumber, string menu, DateTime orderDate, int orderCount)
        {
            OrderNumber = orderNumber;
            Menu = menu;
            OrderDate = orderDate;
            OrderCount = orderCount;
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

    public static void ChangeFoodMenu_Value(string menu)
    {
        menu = "스테이크";
        Console.WriteLine($"메뉴가 {menu}로 변경되었습니다.(값복사)");
    }

    public static void ChangeFoodMenu_Reference(FoodOrderSystem foodOrder)
    {
        foodOrder.Menu = "스테이크";
        Console.WriteLine($"메뉴가 {foodOrder.Menu}로 변경되었습니다.(참조복사)");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Computer 테스트");
        Computer pc1 = new Computer("삼성", "갤럭시", 16, "Windows");
        Console.WriteLine($"pc1의 메모리: {pc1.MemoryCapacity}");
        UpgradeMemory_Value(pc1.MemoryCapacity);
        Console.WriteLine($"pc1의 값복사 후 메모리: {pc1.MemoryCapacity}");
        UpgradeMemory_Reference(pc1);
        Console.WriteLine($"pc1의 참조복사 후 메모리: {pc1.MemoryCapacity}");
        Console.WriteLine();

        Console.WriteLine("Order 테스트");
        Order order1 = new Order("001", "정재석", new DateTime(2026, 05, 06), "바나나", 3);
        Console.WriteLine($"order1의 주문 제품: {order1.Product}");
        ChangeOrderProduct_Value(order1.Product);
        Console.WriteLine($"order1의 값복사 후 주문 제품: {order1.Product}");
        ChangeOrderProduct_Reference(order1);
        Console.WriteLine($"order1의 참조복사 후 주문 제품: {order1.Product}");
        Console.WriteLine();

        Student std1 = new Student("정재석", "20222319", "컴퓨터공학");
        Console.WriteLine($"std1의 전공: {std1.Major}");
        ChangeStudentMajor_Value(std1.Major);
        Console.WriteLine($"std1의 값복사 후 전공: {std1.Major}");
        ChangeStudentMajor_Reference(std1);
        Console.WriteLine($"std1의 참조복사 후 전공: {std1.Major}");
        Console.WriteLine();

        FoodOrderSystem food1 = new FoodOrderSystem("F001", "파스타", new DateTime(2026, 05, 06), 2);
        Console.WriteLine($"food1의 메뉴: {food1.Menu}");
        ChangeFoodMenu_Value(food1.Menu);
        Console.WriteLine($"food1의 값복사 후 메뉴: {food1.Menu}");
        ChangeFoodMenu_Reference(food1);
        Console.WriteLine($"food1의 참조복사 후 메뉴: {food1.Menu}");
    }
}
