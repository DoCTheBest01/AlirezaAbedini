using System;
using System.Collections.Generic;
using System.Linq;

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/// A Console App For Managing a Confectionery As the Final Project For c# supplementary ( Ms. Hamidizadah ) by Alireza Abedini
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace AlirezaAbedini
{
    class Sweets
    {
        ////////////////////////////////////////////////////////////////////
        /// Class Properties 
        ////////////////////////////////////////////////////////////////////

        protected string category;
        protected short count;
        protected string name;
        protected int price;
        protected string unit;

        public static List<Sweets> sweetsList = new List<Sweets>();
        public static void Printer()
        {
            short id = 0;
            Console.Clear();
            foreach (var item in sweetsList)
            {
                id++;
                Console.WriteLine($"id = {id}\tname = {item.name}\tcategory = {item.category}\tcount = {item.count}\tprice = {item.price} per {item.unit}");
            }
        }
    }

    class Cake : Sweets // Inherited From Sweets Class
    {
        ////////////////////////////////////////////////////////////////////
        /// Class Properties 
        ////////////////////////////////////////////////////////////////////
        public string Category
        {
            get { return category; }
        }
        public short Count
        {
            get { return count; }
            set 
            {
                if (value < 0)
                    value = 0;
                else if (value > 32767)
                    value = 32767;
                count = value; 
            }
        }
        public string Name
        {
            get { return name; }
            set { name= value; }
        }
        public int Price
        {
            get { return price; }
            set
            {
                if (value < 0) 
                    value= 0;
                else if (value > 10000000)
                {
                    value = 10000000; // assigning max price to 10 million Toman
                }
                price= value;
            }
        }
        public string Unit
        {
            get 
            {
                return unit; 
            }
            set
            {
                string[] units = new string[2] {"adad", "kilo"};
                if (units.Contains(value.ToLower()))
                    unit = value.ToLower();
                else
                    unit = "(none)".ToUpper();
            }
        }

        ////////////////////////////////////////////////////////////////////
        /// Class Methods 
        ////////////////////////////////////////////////////////////////////

        public Cake()
        {
            category = "Cake";
        }

    }
    class Pastry : Sweets   // Inherited From Sweets Class
    {
        ////////////////////////////////////////////////////////////////////
        /// Class Properties 
        ////////////////////////////////////////////////////////////////////

        public string Category
        {
            get { return category; }
        }
        public short Count
        {
            get { return count; }
            set
            {
                if (value < 0)
                    value = 0;
                else if (value > 32767)
                    value = 32767;
                count = value;
            }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                    value = 0;
                else if (value > 10000000)
                {
                    value = 10000000; // assigning max price to 10 million Toman
                }
                price = value;
            }
        }
        public string Unit
        {
            get
            {
                return unit;
            }
            set
            {
                string[] units = new string[2] { "adad", "kilo" };
                if (units.Contains(value.ToLower()))
                    unit = value.ToLower();
                else
                    unit = "(none)".ToUpper();
            }
        }
        ////////////////////////////////////////////////////////////////////
        /// Class Methods 
        ////////////////////////////////////////////////////////////////////

        public Pastry()
        {
            category = "Pastry";
        }
    }
    class Cookie : Sweets   // Inherited From Sweets Class
    {
        ////////////////////////////////////////////////////////////////////
        /// Class Properties 
        ////////////////////////////////////////////////////////////////////

        public string Category
        {
            get { return category; }
        }
        public short Count
        {
            get { return count; }
            set
            {
                if (value < 0)
                    value = 0;
                else if (value > 32767)
                    value = 32767;
                count = value;
            }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                    value = 0;
                else if (value > 10000000)
                {
                    value = 10000000; // assigning max price to 10 million Toman
                }
                price = value;
            }
        }
        public string Unit
        {
            get
            {
                return unit;
            }
            set
            {
                string[] units = new string[2] { "adad", "kilo" };
                if (units.Contains(value.ToLower()))
                    unit = value.ToLower();
                else
                    unit = "(none)".ToUpper();
            }
        }
        ////////////////////////////////////////////////////////////////////
        /// Class Methods 
        ////////////////////////////////////////////////////////////////////
        public Cookie()
        {
            category = "Cookie";
        }
    }
    class Chocolate : Sweets    // Inherited From Sweets Class
    {
        ////////////////////////////////////////////////////////////////////
        /// Class Properties 
        ////////////////////////////////////////////////////////////////////

        public string Category
        {
            get { return category; }
        }
        public short Count
        {
            get { return count; }
            set
            {
                if (value < 0)
                    value = 0;
                else if (value > 32767)
                    value = 32767;
                count = value;
            }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                    value = 0;
                else if (value > 10000000)
                {
                    value = 10000000; // assigning max price to 10 million Toman
                }
                price = value;
            }
        }
        public string Unit
        {
            get
            {
                return unit;
            }
            set
            {
                string[] units = new string[2] { "adad", "kilo" };
                if (units.Contains(value.ToLower()))
                    unit = value.ToLower();
                else
                    unit = "(none)".ToUpper();
            }
        }
        ////////////////////////////////////////////////////////////////////
        /// Class Methods 
        ////////////////////////////////////////////////////////////////////

        public Chocolate()
        {
            category = "Chocolate";
        }
    }

    class Program
    {
        static void AddProduct()
        {
            Console.Clear();
            byte _categ;
            Console.WriteLine("Enter the Category By Number:\n\n1) Cake\n2) Pastry\n3) Cookie\n4) Chocolate\n5) Go Back");
            try
            {
                Console.Write(">>> ");
                _categ = byte.Parse(Console.ReadLine());
                switch (_categ)
                {
                    case 1:
                        Console.Write("How Many Cakes Do You Wanna Add? ");
                        short cakeCount = short.Parse(Console.ReadLine());
                        for (int i = 0; i < cakeCount; i++)
                        {
                            Cake cake = new Cake();
                            Console.Clear();
                            Console.WriteLine("Enter The Name Of The Cake:");
                            cake.Name = Console.ReadLine();
                            Console.WriteLine($"How Many {cake.Name} Do You Have? (minimum:0, maximum: 32767)");
                            cake.Count = short.Parse(Console.ReadLine());
                            Console.WriteLine("Choose the Counting Unit (Adad, Kilo):");
                            cake.Unit = Console.ReadLine();
                            Console.WriteLine($"Enter The Price Per Each {cake.Unit} (minimum: 0, maximum: 10000000)\n(enter the price number only):");
                            cake.Price = int.Parse(Console.ReadLine());
                            Sweets.sweetsList.Add(cake);
                        }
                        break;
                    case 2:
                        Console.Write("How Many Pastries Do You Wanna Add? ");
                        short pastryCount = short.Parse(Console.ReadLine());
                        for (int i = 0; i < pastryCount; i++)
                        {
                            Pastry pastry = new Pastry();
                            Console.Clear();
                            Console.WriteLine("Enter The Name Of The Pastry:");
                            pastry.Name = Console.ReadLine();
                            Console.WriteLine($"How Many {pastry.Name} Do You Have? (minimum:0, maximum: 32767)");
                            pastry.Count = short.Parse(Console.ReadLine());
                            Console.WriteLine("Choose the Counting Unit (Adad, Kilo):");
                            pastry.Unit = Console.ReadLine();
                            Console.WriteLine($"Enter The Price Per Each {pastry.Unit} (minimum: 0, maximum: 10000000)\n(enter the price number only):");
                            pastry.Price = int.Parse(Console.ReadLine());
                            Sweets.sweetsList.Add(pastry);
                        }
                        break;
                    case 3:
                        Console.Write("How Many Cookie Do You Wanna Add? ");
                        short cookieCount = short.Parse(Console.ReadLine());
                        for (int i = 0; i < cookieCount; i++)
                        {
                            Cookie cookie = new Cookie();
                            Console.Clear();
                            Console.WriteLine("Enter The Name Of The Cookie:");
                            cookie.Name = Console.ReadLine();
                            Console.WriteLine($"How Many {cookie.Name} Do You Have? (minimum:0, maximum: 32767)");
                            cookie.Count = short.Parse(Console.ReadLine());
                            Console.WriteLine("Choose the Counting Unit (Adad, Kilo):");
                            cookie.Unit = Console.ReadLine();
                            Console.WriteLine($"Enter The Price Per Each {cookie.Unit} (minimum: 0, maximum: 10000000)\n(enter the price number only):");
                            cookie.Price = int.Parse(Console.ReadLine());
                            Sweets.sweetsList.Add(cookie);
                        }
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Write("How Many Chocolate Do You Wanna Add? ");
                        short chocolateCount = short.Parse(Console.ReadLine());
                        for (int i = 0; i < chocolateCount; i++)
                        {
                            Chocolate chocolate = new Chocolate();
                            Console.Clear();
                            Console.WriteLine("Enter The Name Of The Chocolate:");
                            chocolate.Name = Console.ReadLine();
                            Console.WriteLine($"How Many {chocolate.Name} Do You Have? (minimum:0, maximum: 32767)");
                            chocolate.Count = short.Parse(Console.ReadLine());
                            Console.WriteLine("Choose the Counting Unit (Adad, Kilo):");
                            chocolate.Unit = Console.ReadLine();
                            Console.WriteLine($"Enter The Price Per Each {chocolate.Unit} (minimum: 0, maximum: 10000000)\n(enter the price number only):");
                            chocolate.Price = int.Parse(Console.ReadLine());
                            Sweets.sweetsList.Add(chocolate);
                        }
                        Console.ReadKey();
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("[X] Invalid Category!!");
                        break;
                }
            }
            catch (Exception)
            {
                
            }
        }
        static void ListProducts()
        {
            Sweets.Printer();
            Console.WriteLine("\nPress Any Key To Go Back To Main Menu...");
            Console.ReadKey();
        }
        static void Exit()
        {
            Environment.Exit(0);
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Hello World!");
                Console.WriteLine("Welcome To Alireza Abedini's Confectionery Managment System ( Ms. Hamidizadeh )");
                Console.WriteLine("Enter The Number To Choose The Opperation:\n\n1)Add A Product.\n2)List All Products You've Added\n3)Clear The Console\n4)Exit The Program");
                byte choise;
                while (true)
                {
                    Console.Write(">>> ");
                    try
                    {
                        choise = byte.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                    switch (choise)
                    {
                        case 1:
                            AddProduct();
                            break;
                        case 2:
                            ListProducts();
                            break;
                        case 3:
                            break;
                        case 4:
                            Exit();
                            break;
                        default:
                            Console.WriteLine("[X] Invalid Choise");
                            continue;
                    }
                    Console.Clear();
                    break;
                }
            }
        }
    }
}
