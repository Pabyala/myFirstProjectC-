// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;
using System.IO;

namespace myFirstProject {

    // creating a class and object;
    class Car {

        static void MyMethod() {
            Console.WriteLine("Hello welcome to my world.");
        }

        static void Greeting(string text) {
            if (text.Length > 5) {
                Console.WriteLine(text);
            } else {
                Console.WriteLine("Empty parameter");
            }
            //Console.WriteLine(text);
        }

        static int PlusMethod(int a, int b) { 
            return a + b;
        }

        // student data
        string name = "Marco";
        string color = "Black";
        int roll_num = 150;
        string class_name = "Grade 8";
        string section = "A";
        string subject2 = "C#";
        string subject1 = ".Net";
        int sub1_marks = 95;
        int sub2_marks = 97;

        // employee data
        int emp_num = 120;
        string desig_name = ".Net Developer";
        string dept = "IT Dep";

        static void Main(string[] args)
        {
            // object instancaton / creating an objects
            Car myObj = new Car();
            Console.WriteLine(myObj.color);
            MyMethod();
            Greeting("Hello marco.");
            int c = PlusMethod(1, 2);
            Console.WriteLine(c);
        }
    }




    
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
            //Console.WriteLine("Enter your name here: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Your name is " + name );


            // WHILE LOOP and DO WHILE LOOP
            //int i = 0;

            //do {
            //    Console.WriteLine(i);
            //    i++; // increamenting i values
            //} while (i < 5);
            //Console.WriteLine("While loop is terminated.");



            // FOR LOOP
            //for (int i = 0; i < 5; i++) {
            //    Console.WriteLine(i);
            //}


            // FOR EACH Statement
            //string[] travel = { "Car", "Train", "Bus", "Auto" };
            //foreach (string i in travel) {
            //    Console.WriteLine("Your travel is: " + i);
            //    if (i == "Train") {
            //        Console.WriteLine("MRT");
            //        break; // break or continue
            //    }
            //}


            // ARRAYS
            //string[] travel = { "Car", "Train", "Bus", "Beep", "Jeep", "Motor"};
            //int[] myNumber = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //for (int i = 0; i < travel.Length; i++)
            //{
            //    Console.WriteLine(travel[i]);
            //}


            // LIST ITEMS
            //var cities = new List<string>() {
            //    "Marikina",
            //    "Quezon City",
            //    "Pasig",
            //    "Makati",
            //};
            //cities.Add("Marikina");
            //cities.Add("Quezon City");
            //cities.Add("Pasig");


            // Datetime Method and Different formats;
            //DateTime today = DateTime.Now;
            //Console.WriteLine(today.ToString("MM/dd/yyyy")); //05/12/2025
            //Console.WriteLine(today.ToString("dddd, dd MMMM yyyy")); // Monday, 12 May 2025\


            // TimeSpan
            // DateTime lunchDate = new DateTime(2025, 5, 15, 9, 0, 0);
            // DateTime now = DateTime.Now;
            // Calculate the interval between the two dates.
    //        // TimeSpan
    //    }
    //}   
}
    