﻿
using System;


namespace A;
public class Program
{

    static void Main(string[] args)
    {
        
    }

    static void Main10(string[] args)
    {
        //INITIALIZING OR CREATING ARRAY WITH USER INPUT


        Console.WriteLine("enter the length of array");
        int num = int.Parse(Console.ReadLine());

        int[] numbers = new int[num];

        for (int i = 0; i < num; i++)
        {
            Console.WriteLine("enter your data on location " + i);
            int data = int.Parse(Console.ReadLine());
            numbers[i] = data;
        }


        foreach (int nums in numbers)
        {
            Console.WriteLine(nums);
        }

    }
    static void Main88(string[] args)
    {
        //ACCESSING ARRAY USING FOREACH LOOP

        int[] numbers = new int[4];
        numbers[0] = 11;
        numbers[1] = 22;
        numbers[2] = 33;
        numbers[3] = 44;

        //using for loop
        for (int i = 0; i < numbers.Length; i++)
        {
            // Console.WriteLine(numbers[i]);

        }

        // using foreach 
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

    }
    static void MainN(string[] args)
    {
        //string[] arr = new string[6];
        //string[] arr = new string[] {"virat","rohit","hardik","ms" };
        string[] arr = ["virat", "rohit", "hardik", "ms"];
        string[] arr1 = { "virat", "rohit", "hardik", "ms" };
        Console.WriteLine(arr[0]);
        Console.WriteLine(arr1[0]);
    }
    static void Main9(string[] args)
    {
        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
            {
                Console.WriteLine(i);
                goto stop;


            }

        }
    stop:
        Console.WriteLine("hello bcz of stop");
    }
    static void Main8(string[] args)
    {
        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                continue;

            }
            Console.WriteLine(i);
        }
    }

    static void Main99(string[] args)
    {
        //value type and referance type 
        int x = 5;
        int y = x;
        y = 20;
        Console.WriteLine(y);

        // refernace type 
        int[] arr = new int[] { 1, 2, 3, 4, 5 };
        int[] arr2 = arr;
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }

        arr2[0] = 9;
        // Console.WriteLine(arr2[0]);
    }
    static void Main7()
    {
        DateTime now = DateTime.Now;

        Console.WriteLine("Short Date: " + now.ToString("d"));
        Console.WriteLine("Long Date: " + now.ToString("D"));
        Console.WriteLine("Full Date/Time (Short Time): " + now.ToString("f"));
        Console.WriteLine("Full Date/Time (Long Time): " + now.ToString("F"));
        Console.WriteLine("General Date/Time (Short Time): " + now.ToString("g"));
    }

    class Constant
    {
        public const double PI = Math.PI;

        static void Main6()
        {
            //CONSTANT VARIABLE IN C-SHARP
            Console.WriteLine(PI);
        }
    }





    static void Main6(string[] args)
    {
        //DATA TYPE CONVERSION

        int a = 15;
        float b = a; // implicit conversion 

        Console.WriteLine(b);


        float c = 12.333f;
        int d = (int)c; //explicit conversion 

        Console.WriteLine(d);

        //OR
        int d2 = Convert.ToInt32(d);
        Console.WriteLine(d2);


        string x = "12";
        string y = "12";

        int z = Convert.ToInt32(x) + Convert.ToInt32(y);
        Console.WriteLine(z);
    }




    static void Main5(string[] args)
    {
        // escape sequence 
        Console.WriteLine("\"Hello World\"");
        Console.WriteLine("\\Hello World with backslash\\");
        Console.WriteLine("\t Hello");
        Console.WriteLine(" one\n two\n three");


    }



    public static void Main4()
    {
        float s = 23.3645566f;
        double d = 23456.45678d;
        decimal t = 12345.56777m;
        Console.WriteLine(s);
        Console.WriteLine(d);
        Console.WriteLine(t);



        //BOOLEAN DATA TYPE
        int a = 5;
        int b = 6;
        bool c = a < b;
        Console.WriteLine(c);
        Console.Read();
    }





    static void Main3(string[] args)
    {
        // DATA TYPES 
        // byte  b = 12;
        Console.WriteLine(int.MaxValue);
        Console.WriteLine(int.MinValue);

        Console.ReadLine();


    }
    static void Main2(string[] args)
    {
        Console.WriteLine("enter first number ");
        int num1 = int.Parse(Console.ReadLine());

        System.Console.WriteLine("enter second number ");
        int num2 = int.Parse(Console.ReadLine());

        int result = num1 + num2;
        Console.WriteLine("addition of numbers is : ", result);
        Console.ReadLine();
    }



    static void Main1(string[] args)
    {
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();
        // Console.WriteLine($"Hello {name}!");

        Console.WriteLine("Your name is :{0}", name); // using placeholder
                                                      // Console.WriteLine("Your name is  " + name); //concatenation
        Console.ReadLine();
    }

}








// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");




/* Code Formatting Shortcuts:
Ctrl + K, Ctrl + D: Format document
Ctrl + K, Ctrl + F: Format selection*/