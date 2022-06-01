using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname;
            string lastname;


            firstname = "Steven Clark";
            lastname = "Clark";
            Console.WriteLine(firstname.Clone());
            Console.WriteLine(lastname.Clone());
            Console.WriteLine(firstname.CompareTo(lastname));

            Console.WriteLine(firstname.Contains("ven"));

            Console.WriteLine(firstname.EndsWith("n"));
            Console.WriteLine(firstname.Equals(lastname));

            Console.WriteLine(firstname.GetHashCode());
            Console.WriteLine(firstname.GetType());

            Console.WriteLine(firstname.GetTypeCode());
            Console.WriteLine(firstname.IndexOf("e"));
            Console.WriteLine(firstname.ToLower());
            Console.WriteLine(firstname.ToUpper());

            Console.WriteLine(firstname.Insert(0, "Hello"));
            Console.WriteLine(firstname.IsNormalized());
            Console.WriteLine(firstname.LastIndexOf("e"));
            Console.WriteLine(firstname.Length);
            Console.WriteLine(firstname.Remove(5));
            Console.WriteLine(firstname.Replace('e','i'));


            string[] split = firstname.Split(new char[] { 'e' });

            Console.WriteLine(split[0]);
            Console.WriteLine(split[1]);
            Console.WriteLine(split[2]);
            Console.WriteLine(firstname.StartsWith("S"));
            Console.WriteLine(firstname.Substring(2,5));
            Console.WriteLine(firstname.ToCharArray());
            Console.WriteLine(firstname.Trim());

            string a = "hello";
            string b = (String)a.Clone();
            Console.WriteLine(b);

           


        }
    }
}
