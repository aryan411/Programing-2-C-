using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    { 
        // main mathod
        static void Main(string[] args)
        {
            // create 4 Objects with 0,1 or 2 arguments
            Rational object1 = new Rational();
            Rational object2 = new Rational(4);
            Rational object3 = new Rational(3,9);
            Rational object4 = new Rational(7,25);

            Console.WriteLine($"Object1 = Object1 : {object1.ToString()} + Object2: {object2.ToString()}");
            object1.IncreaseBy(object2);   // call increaseby function
            Console.WriteLine("After calling IncreaseBy mathod");
            Console.WriteLine($"Object1 : {object1.ToString()}\nObject2: {object2.ToString()}");
            Console.WriteLine($"Object3 = Object3 : {object3.ToString()} + Object4: {object4.ToString()}");
            object3.DecreaseBy(object4); // call decreaseBy function
            Console.WriteLine("After calling DecreaseBy mathod");
            Console.WriteLine($"Object3 : {object3.ToString()} \n Object4: {object4.ToString()}");


        }
    }
}
