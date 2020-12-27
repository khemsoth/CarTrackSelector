using System;
using System.Collections.Generic;

namespace CarTrackSelectorApp
{
    struct Car
    {
        public string Make;
        public string Model;
        
            public override string ToString()
        {
            return string.Format("{0} {1}", Make, Model);
        }
    }

    class Program
    {
        public static Car AddCar()
        {
            Car NewCar;
            Car c;
            Console.WriteLine("Please add a car.");
            Console.Write("Make: ");
            c.Make = Console.ReadLine();
            Console.Write("Model: ");
            c.Model = Console.ReadLine();
            NewCar.Make = c.Make;
            NewCar.Model = c.Model;
            return NewCar;
        }
        public static string AddTrack()
        {
            string NewTrack;
            Console.WriteLine("Please add a track.");
            Console.Write("Track: ");
            NewTrack = Console.ReadLine();
            return NewTrack;
        }
        static void Main(string[] args)
        {
            List<Car> CarSelection = new List<Car>();
            List<string> Tracks = new List<string>();
            bool endApp = false;
            string[] InitTracks = { "Nurburgring GP", "Circuit de Spa Francorchamps", "Mid-Ohio Sportscar Course", "Laguna Seca", "Kyalami" };
            Tracks.AddRange(InitTracks);

            Car car1 = new Car { Make = "Audi", Model = "R8 LMS GT3" };
            Car car2 = new Car { Make = "BMW", Model = "M6 GT3" };
            Car car3 = new Car { Make = "Bentley", Model = "Continental GT3" };
            Car car4 = new Car { Make = "Honda", Model = "NSX GT3 Evo" };
            Car car5 = new Car { Make = "Mercedes", Model = "AMG GT3" };

            CarSelection.Add(car1);
            CarSelection.Add(car2);
            CarSelection.Add(car3);
            CarSelection.Add(car4);
            CarSelection.Add(car5);


            while (!endApp)
            {
                string choice;
                Car NewCar;
                string NewTrack;

                Console.WriteLine("What would you like to do?");
                Console.WriteLine("c: Add car");
                Console.WriteLine("t: Add track");
                Console.WriteLine("vc: View car list");
                Console.WriteLine("vt: View track list");
                Console.WriteLine("e: End app");
                choice = Console.ReadLine();
                if (choice == "c")
                {
                    NewCar = AddCar();
                    CarSelection.Add(NewCar);
                }
                else if(choice == "t")
                {
                    NewTrack = AddTrack();
                    Tracks.Add(NewTrack);
                }
                else if(choice == "vt")
                {
                    Console.WriteLine("Tracks:\n");
                    foreach (string t in Tracks)
                    {
                        Console.WriteLine(t);
                    }
                    Console.WriteLine("\n");
                }
                else if(choice == "vc")
                {
                    Console.WriteLine("Cars:\n");
                    foreach(Car c in CarSelection)
                    {
                        Console.WriteLine("{0} {1}", c.Make, c.Model);
                    }
                    Console.WriteLine("\n");
                }
                else if(choice == "e")
                {
                    endApp = true;
                    return;
                }
                else
                {
                    Console.WriteLine("Please choose a valid option");

                }
            }
        }
    }
}
