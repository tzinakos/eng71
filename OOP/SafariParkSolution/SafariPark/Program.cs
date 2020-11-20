using System;


namespace SafariPark
{
    class Program
    {
        static void Main(string[] args)
        {

            //Airplane a = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 };
            //a.Ascend(500);
            //Console.WriteLine(a.Move(3));
            //Console.WriteLine(a);
            //a.Descend(200);
            //Console.WriteLine(a.Move());
            //a.Move();
            //Console.WriteLine(a);
            Point3D tigerPosition = new Point3D(4, 0, 4);
            Point3D hunterPosition = new Point3D(2, 0, 1);

            Tiger tiger = new Tiger(Animals.animalType.aerial, 20, 40,tigerPosition,3);
            Hunter hunter = new Hunter("Jino", "Biba", hunterPosition);

            //tiger.Attack(hunter);

            Point3D tigerNewPosition = new Point3D(3, 0, 1);

            //tiger.Move(tigerNewPosition);

            //tiger.Attack(hunter);
            //tiger.Attack(hunter);
            //tiger.Attack(hunter);

            string input ="";
            Console.WriteLine("Hi Tiger, There is a hunter nearby! \n");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.WriteLine("");
            while (true)
            {
                Console.WriteLine("Press 'i' to get the hunters info");
                Console.WriteLine("Press 'a' to Attack the hunter");
                Console.WriteLine("Press 'e' to Run");
                Console.WriteLine("Press 'm' to Move closer to the hunter\n");
                Console.WriteLine($"Your Position On Safari is X: {tiger.Position.X} Y: {tiger.Position.Y} Z: {tiger.Position.Z}\n");

                input = Console.ReadLine();
                 switch (input)
                {
                    case "i":
                        Console.WriteLine($"Name: {hunter.GetFullName()}, Health: {hunter.Health}," +
                            $" Position On Safari X: {hunter.Position.X} Y: {hunter.Position.Y}, Z: {hunter.Position.Z}\n");
                        break;
                    case "a":
                        tiger.Attack(hunter);
                        break;
                    case "m":
                        tiger.Move(tigerNewPosition);
                        Console.WriteLine("You moved Closer, Try Attacking! \n");
                        break;
                    case "e":
                        if(hunter.Health <= 0)
                        {
                            Console.WriteLine("Thank you for taking down the hunters. \nSee you next time!");
                        }
                        else
                        {
                            Console.WriteLine("You Chose to Run Away. Nice move :p");
                        }
                        
                        Environment.Exit(0);
                        
                        break;
                }  

            }

            //Person jino = new Person("Jino", "Biba") {Age= 25};

            //Console.WriteLine(jino.GetFullName());

            //Person cathy;

            //cathy = new Person("Cathy","French");
            //cathy.Age = 20;

            //Console.WriteLine(cathy.GetFullName()+" "+cathy.Age);

            //Spartan spartan = new Spartan("Takis","Lakis");

            //Console.WriteLine(spartan.FirstName);
            //Console.WriteLine(spartan.LastName);

            //var list = new ShoppingList() {Bread =2, Potato =3 };

            //list.Lemon = 5;

            //var list2 = new ShoppingList();

            //list2.Milk = 5;

            //var milkAmount = list2.Milk;
            //Person jinakos = new Person("Jino", "Bimpa") { Age = 20 };
            //Point3D pr3D = new Point3D(5, 8, 2);
            //DemoMethod(pr3D, jinakos);

            //Hunter lauren = new Hunter("Lauren", "Pang", "Leica") {Age=20 };
            //Console.WriteLine(lauren.Shoot());
            //Console.WriteLine(lauren.Age);
            //Console.WriteLine(lauren.GetFullName());

            //Hunter h = new Hunter();
            //Console.WriteLine(lauren.ToString());


        }



    }
}
