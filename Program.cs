namespace Classes_And_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            Car.Mymethod();


            /*
            myCar.Make = "Benz S-Class";
            myCar.Model = "S-Class";
            myCar.Year = 2022;
            myCar.Color = "White";
            myCar.Price = 1215;
            */

            //Car myThirdCar = new Car("Ford", "Escape",  2022, "Black", 1215);
            
            /*
                Car myotherCar;
               myotherCar = myCar;

            Console.Write("{0} {1} {2} {3} {4}", 
                myotherCar.Make,
                myotherCar.Model,
                myotherCar.Year,
                myotherCar.Color,
                myCar.Price);

            myotherCar.Model = "98";

            myotherCar = null;

   
             Console.WriteLine("{0} {1} {2} {3} {4}",
                 myotherCar.Make,
                 myotherCar.Model, 
                 myotherCar.Year,
                 myotherCar.Color, 
                 myotherCar.Price);
        
            myCar = null;
            */
         
                
                Console.ReadLine();
        }
    }


      class Car
    {   
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }

        /*
        public Car()
        {
            // You Could Load From a confirguration File,
            // a Database, etc.
                Make = "Ford";
        }

         public Car(string make, string model, int year, string color, decimal price)
        {
            Make = make;
            Model = model;
            Year =  Year;
            Color  = color;
            Price = Price;
        }
        */

        public static void Mymethod()
        {
            Console.WriteLine("Called the static Mymethod");
            Console.WriteLine("Make");
        }
    }
}
