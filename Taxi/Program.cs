using System;
using Taxi.Views;
using Taxi.Data;
using Taxi.Data.Models;
using Taxi.Logic;

namespace Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager();
            CompanyManager companyManager = new CompanyManager();
            UserManager userManager = new UserManager();
            DriverManager driverManager = new DriverManager();
            TripManager tripManager = new TripManager();

            while (true)
           {
               Console.WriteLine("\n\nPlease choose an action\n 1. Display\n 2. Add\n 3. Delete\n 4. Update\n 5. Exit");
                try
                {
                    switch (short.Parse(Console.ReadLine()))
                    {
                        case 1:
                            {
                                Console.WriteLine("\nWhat would you like to display?\n 1. Trips\n 2. Cars\n 3. Users\n 4. Drivers\n 5. Companies");
                                short what = short.Parse(Console.ReadLine());

                                if (what == 1)
                                {
                                    Console.WriteLine("\nPlease select an action: (<id>|all)\n");
                                    string input1 = Console.ReadLine();
                                    if(input1.ToLower()=="all"){
                                        Console.Clear();
                                        DisplayTrips displayTrips = new DisplayTrips();
                                    } else
                                    {
                                        Console.Clear();
                                        DisplayTrips displayTrips = new DisplayTrips(int.Parse(input1));
                                    }
                                }

                                else if (what == 2)
                                {
                                    Console.WriteLine("\nPlease select an action: (<id>|all)\n");
                                    string input2 = Console.ReadLine();
                                    if(input2.ToLower()=="all"){
                                        Console.Clear();
                                        DisplayCars displayCars = new DisplayCars();
                                    } else
                                    {
                                        Console.Clear();
                                      DisplayCars displayCars = new DisplayCars(int.Parse(input2));
                                    }
                                }

                                else if (what == 3)
                                {
                                   Console.WriteLine("\nPlease select an action: (<id>|all)\n");
                                    string input3 = Console.ReadLine();
                                    if(input3.ToLower()=="all"){
                                        Console.Clear();
                                        DisplayUsers displayUsers = new DisplayUsers();
                                    } else
                                    {
                                        Console.Clear();
                                      DisplayUsers displayUsers = new DisplayUsers(int.Parse(input3));
                                    }
                                }
                                else if (what == 4)
                                {
                                   Console.WriteLine("\nPlease select an action: (<id>|all)\n");
                                    string input4 = Console.ReadLine();
                                    if(input4.ToLower()=="all"){
                                        Console.Clear();
                                        DisplayDrivers displayDrivers = new DisplayDrivers();
                                    } else
                                    {
                                        Console.Clear();
                                      DisplayDrivers displayDrivers = new DisplayDrivers(int.Parse(input4));
                                    }
                                }
                                else if (what == 5)
                                {
                                   Console.WriteLine("\nPlease select an action: (<id>|all)\n");
                                    string input5 = Console.ReadLine();
                                    if(input5.ToLower()=="all"){
                                        Console.Clear();
                                        DisplayCompanies displayCompanies = new DisplayCompanies();
                                    } else
                                    {
                                        Console.Clear();
                                      DisplayCompanies displayCompanies = new DisplayCompanies(int.Parse(input5));
                                    }
                                }

                                break;
                            }

                        case 2:
                            {
                                Console.WriteLine("What would you like to add?\n 1. Trips\n 2. Cars\n 3. Drivers\n 4. Companies");
                                short what = short.Parse(Console.ReadLine());
                                if (what == 1)
                                {
                                    throw new NotImplementedException();
                                    /*
                                    TripManager tripManager= new TripManager();
                                    Console.WriteLine("Write Origin:");
                                    string origin=Console.ReadLine();
                                    Console.WriteLine("Write Destnation:");
                                    string destination=Console.ReadLine();
                                    Console.WriteLine("Write date (dd/MM/yyyy HH:mm)");
                                    DateTime date = DateTime.Parse("dd/MM/yyyy HH:mm");
                                    Trip trip = new Trip()
                                    tripManager.Add();*/
                                }
                                else if (what == 2)
                                {
                                    Console.WriteLine("Write Make:");
                                    string make = Console.ReadLine();
                                    Console.WriteLine("Write Model:");
                                    string model = Console.ReadLine();
                                    Console.WriteLine("Write color:");
                                    string colour = Console.ReadLine();
                                    Console.WriteLine("Write company:");
                                    string company = Console.ReadLine();
                                    Console.WriteLine("Write year:");
                                    int year = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Write license:");
                                    string license = Console.ReadLine();
                                    Console.WriteLine("Write Cub:");
                                    int cub = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Write Cyl:");
                                    int cylinders = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Write Fuel Type:");
                                    string fuel = Console.ReadLine();
                                    Console.WriteLine("Write Kilometres to Litre:");
                                    int kmToLitre = int.Parse(Console.ReadLine());
                                    Car car = new Car(license, make, model, colour, -1, year.ToString(), -1, -1);
                                    carManager.Add(car);
                                }
                                else if (what == 3)
                                {
                                    DisplayDrivers displayDreivers = new DisplayDrivers();
                                    Console.WriteLine("Write first name:");
                                    string firstName = Console.ReadLine();
                                    Console.WriteLine("Write last name:");
                                    string lastName = Console.ReadLine();
                                    Console.WriteLine("Write telephone number:");
                                    string telephoneNumber = Console.ReadLine();
                                    Driver driver = new Driver(-1, -1, -1, firstName, lastName, telephoneNumber);
                                    driverManager.Add(driver);
                                }
                                else if (what == 4)
                                {
                                    Console.WriteLine("Write CompanyId:");
                                    string companyid = Console.ReadLine();
                                    Console.WriteLine("Write Name:");
                                    string name = Console.ReadLine();
                                    Console.WriteLine("Write adminId:");
                                    string adminid = Console.ReadLine();
                                    Console.WriteLine("Write Telephonenumber:");
                                    string telephonenumber = Console.ReadLine();
                                    Company company = new Company(-1, name, -1, telephonenumber);
                                    companyManager.Add(company);
                                }

                                break;
                            }

                        case 3:
                            {
                                Console.WriteLine("Where would you like to delete?\n 1. Trips\n 2. Cars\n 3. Users\n 4. Drivers\n 5. Companies");
                                short what = short.Parse(Console.ReadLine());
                                if (what == 1)
                                {
                                    Console.WriteLine("Trip ID to delete:");
                                    tripManager.Delete(int.Parse(Console.ReadLine()));

                                }
                                else if (what == 2)
                                {
                                    Console.WriteLine("Car Id to delete:");
                                    carManager.Delete(int.Parse(Console.ReadLine()));
                                }
                                else if (what == 3)
                                {
                                    Console.WriteLine("Write UserId to Delete:");
                                    userManager.Delete(int.Parse(Console.ReadLine()));
                                }
                                else if (what == 4)
                                {
                                    Console.WriteLine("Driver id to delete:");
                                    driverManager.Delete(int.Parse(Console.ReadLine()));
                                }
                                else if (what == 5)
                                {
                                    Console.WriteLine("User to delete:");
                                    userManager.Delete(int.Parse(Console.ReadLine()));
                                }

                                break;
                            }

                        case 5: return;
                        default: throw new ArgumentException("Invalid Action");
                    }
                }
                catch (Exception err)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error! "+err.Message);
                    Console.ResetColor();
                }
            }
        }
    }
}