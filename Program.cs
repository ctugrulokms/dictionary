using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.Collection.Generic
            Dictionary<int,string> kullanıcılar = new Dictionary<int, string>();

            kullanıcılar.Add(10, "Ayşe Yılmaz");
            kullanıcılar.Add(12, "Ahmet Yılmaz");
            kullanıcılar.Add(18, "Arda Deniz");
            kullanıcılar.Add(50, "Yılmaz Vural");

            // Dizinin elemanlarına erişim
            Console.WriteLine("***** Elemanlara Erişim *****");
            Console.WriteLine(kullanıcılar[12]);
            foreach (var item in kullanıcılar)
                Console.WriteLine(item);

            // Count
            Console.WriteLine("***** Count *****");
            Console.WriteLine(kullanıcılar.Count);
            
            // Contains
            Console.WriteLine("***** Contains *****");
            Console.WriteLine(kullanıcılar.ContainsKey(12));
            Console.WriteLine(kullanıcılar.ContainsValue("Tuğrul Okumuş"));

            // Remove
            Console.WriteLine("***** Remove *****");
            kullanıcılar.Remove(12);
            foreach (var item in kullanıcılar)
                Console.WriteLine(item);

            // Keys
            Console.WriteLine("***** Keys *****");
            foreach (var item in kullanıcılar.Keys)
                Console.WriteLine(item);

            // Values
            Console.WriteLine("***** Values *****");
            foreach (var item in kullanıcılar.Values)
                Console.WriteLine(item);
        }
    }
}
