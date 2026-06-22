using System;
using System.Collections.Generic;

namespace DotNetFinalExam
{
    public class InvalidPriceException : Exception
    {
        public InvalidPriceException(string message) : base(message) { }
    }

    public class Product : IComparable<Product>
    {
        public string Name { get; set; }
        private int price;
        public int Price
        {
            get { return price; }
            set
            {
                if (value <= 0)
                    throw new InvalidPriceException("가격은 0원보다 커야 합니다.");
                price = value;
            }

        }

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }

    class Program
    {
        public static bool TryAddProduct(string nameInput, string priceInput, out Product prod)
        {
            prod = null;

            try
            {
                int parsedPrice = int.Parse(priceInput);
                prod = new Product(nameInput, parsedPrice);
                return true;
            }
            catch (FormatException)
            {
                Console.WriteLine("오류: 숫자만 적어주세요");
                return false;
            }
            catch (InvalidPriceException ex)
            {
                Console.WriteLine($"오류: {ex.Message}");
                return false;
            }
            catch (Exception)
            {
                Console.WriteLine("알 수 없는 오류 발생");
                return false;
            }
        }

        static void Main(string[] args)
        {
            List<Product> shopCart = new List<Product>();

            if (TryAddProduct("노트북", "1500000", out Product prod1))
            {
                shopCart.Add(prod1);
            }
            if (TryAddProduct("마우스", "30000", out Product prod2))
            {
                shopCart.Add(prod2);
            }
            shopCart.Sort();

            Console.WriteLine("가격 정렬 결과");
            foreach (var p in shopCart)
            {
                Console.WriteLine($"이름: {p.Name}, 가격: {p.Price}");
            }
        }
    }
}