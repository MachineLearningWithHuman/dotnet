using System;

namespace Training_1_ms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string Fname = "Ravi";
            string Lname = "Kisan";

            Console.WriteLine($"Hello {Fname} {Lname}");
            Console.WriteLine($"String {Fname} has {Fname.Length} letters");

            string TrimedName = "     satyajit       ";
            Console.WriteLine($"removing leading spaces [{TrimedName.TrimStart()}]");
            Console.WriteLine($"removing end spaces [{TrimedName.TrimEnd()}]");
            Console.WriteLine($"removing all the spaces [{TrimedName.Trim()}]");

            string aString = "satyajit maitra";
            Console.WriteLine(aString);
            aString = aString.Replace("satya", "subha");
            Console.WriteLine(aString);

            string Sentence = " Hi I m satyajit maitra and I love to get things done quickly";
            Console.WriteLine(Sentence.Contains("satyajit"));
            Console.WriteLine(Sentence.Contains("sattu"));
            Console.WriteLine(Sentence.StartsWith(" Hi"));
            Console.WriteLine(Sentence.EndsWith("Hi"));



            int a = 4;
            int b = 12;
            int c = a + b;
            Console.WriteLine(c);
            int max = int.MaxValue;
            int min = int.MinValue;

            Console.WriteLine($"{max} and {min}");
            Console.WriteLine(max + 3);
            Console.WriteLine(min + 2);

            int d = 3;
            Console.WriteLine((a + b) / d);

            double a1 = 4;
            double b1 = 12;
            double c1 = 3;

            Console.WriteLine((a1 + b1) / c1);
            Console.WriteLine(Math.PI * a1);


        }
    }
}
