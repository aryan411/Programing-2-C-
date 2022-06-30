using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Aryan Patel
 * SIN:  301-226-774
 * Date: January 19, 2022
 */

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Car Object
            Car car1 = new Car(2001, "Audi", "A8", 1000000);
            Console.WriteLine(car1);
            Car car2 = new Car(2002, "BMW", "X3", 52990,false);
            Console.WriteLine(car2);
            Car car3 = new Car(2003, "Honda", "Civic", 46200);
            Console.WriteLine(car3);
            Car car4 = new Car(2004, "GMC", "Hummer", 41350);
            Console.WriteLine(car4);
            Car car5 = new Car(2005, "Bugatti", "Chiron", 2998000, false);
            Console.WriteLine(car5);

            // Create a Date Object
            Date dt = new Date(2016, 5, 4);
            Console.WriteLine(dt);
            int comand ;
            Console.WriteLine("\n To add days in current date press 1" +
                   "\n To add days,and  months in current date press 2" +
                   "\n To add days,  month and  year  in current date press 3" +
                   "\n To exit press 4");
            comand = Convert.ToInt32(Console.ReadLine());
            while (comand < 3)
            {
                if (comand == 1)
                {
                    Console.WriteLine("Enter days");
                    dt.Add(Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine(dt);
                }
                else if (comand == 2)
                {
                    int td;
                    int tm;
                    Console.WriteLine("Enter days");
                    td = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter months");
                    tm = Convert.ToInt32(Console.ReadLine());
                    dt.Add(tm, td);
                    Console.WriteLine(dt);
                }
                else if (comand == 3)
                {
                    int td;
                    int tm;
                    int ty;
                    Console.WriteLine("Enter days");
                    td = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter months");
                    tm = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter years");
                    ty = Convert.ToInt32(Console.ReadLine());
                    Date tdt = new Date(ty, tm, td);
                    dt.Add(tdt);
                    Console.WriteLine(dt);
                }
                else
                {
                    Console.WriteLine("\nWrong input");
                }
                Console.WriteLine("\n To add days in current date press 1" +
                    "\n To add days,and  months in current date press 2" +
                    "\n To add days,  month and  year  in current date press 3" +
                    "\n To exit press 4");
                comand = Convert.ToInt32(Console.ReadLine());
            };

        }
        class Car 
        {
            private int year;               //field              
            private string manufacturer;    //field
            private string model;           //field
            private bool isDrivable;        //field
            private double price;           //field
            // Constuctor with default parameter
            public Car(int year, string manufacturer, string model, double price, bool isDrivable = true)
            {
                this.year = year;
                this.manufacturer = manufacturer;
                this.model = model;
                this.isDrivable = isDrivable;
                this.price = price;
            }
            // Printing meaningfull Object details
            public override string ToString()
            {
                return base.ToString() + ":-\n " + 
                       "\tManufacturer: " + this.manufacturer + "\n"+
                        "\tYear: " + this.year.ToString() + "\n" +
                         "\tModel: " + this.model + "\n" +
                          "\tPrice: " + this.price.ToString() + "\n" +
                           "\tIs Drivable: " + this.isDrivable.ToString() + "\n" ;
            }
        }
        class Date
        {
            private int year;   // Field
            private int month;  // Field
            private int day;    // Field
            readonly int[] month30s = { 4, 6, 9, 11 };
            readonly int[] month31s = { 1, 3, 5, 7, 8, 9, 10, 12 };
            readonly int[] month28or29 = { 2 };
            // Constructor
            public Date(int year, int month, int day)
            {
                this.year = year;
                this.month= month;
                this.day = day;
            }
            // Add method with day perameter
            public void Add(int days)
            {
                this.day += days;
                this.Normalize();
            }
            // Add method with day,month perameter
            public void Add(int month,int days)
            {
                this.month +=  month;
                this.day += days;
                this.Normalize();
            }
            // Add method with day,month,year perameter
            public void Add(Date other)
            {
                this.month += other.month;
                this.day += other.day;
                this.year += other.year;
                this.Normalize();
            }
            // normalize function
            private void Normalize()
            {
                bool x = false;
                while (!x)
                {

                    if (this.month31s.Contains(this.month) && this.day > 31)
                    {
                        this.month++;
                        this.day -= 31;
                    }
                    else if (this.month30s.Contains(this.month) && this.day > 30)
                    {
                        this.month++;
                        this.day -= 30;
                    }
                    else if (this.month28or29.Contains(this.month) && Convert.ToBoolean(this.year % 4) && this.day > 29)
                    {
                        this.month++;
                        this.day -= 29;

                    }
                    else if (this.month28or29.Contains(this.month) && !Convert.ToBoolean(this.year % 4) && this.day > 28)
                    {
                        this.month++;
                        this.day -= 28;

                    }
                    else {
                        if (this.month > 12)
                        {
                            this.year++;
                            this.month -= 12;
                            x = false;
                        }
                        else
                        {
                            x = true;
                        }
                    }
                    
                }
            }
            // Tostring() function
            public override string ToString()
            {
                return "Date Object note:-" + " *Displyed date will be in MM-DD-YYYY formate" +
                    "\nDate:- " + this.month.ToString() + "-" + this.day + "-" + this.year +
                    "\n";
                    
                    
            }
        }

    }
}
