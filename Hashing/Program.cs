using System;
using System.Text;

namespace Hashing
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = HMAC.GenerateKey();


            Console.WriteLine("==== Chose ====");
            Console.WriteLine("1: - Hash");
            Console.WriteLine();
            Console.WriteLine("2: - HMAC");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("HASHING");
                    Console.WriteLine("Insert Text To Be Hashed");
                    input = Console.ReadLine();
                    Console.WriteLine();

                    var sha512HashedMessage = HashData.ComputeHashSha512(Encoding.UTF8.GetBytes(input));

                    Console.WriteLine("Input: - " + input);
                    Console.WriteLine();
                    Console.WriteLine("Hashed: - " + Convert.ToBase64String(sha512HashedMessage));

                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("HMAC");
                    Console.WriteLine("Insert Text To HMAC");
                    input = Console.ReadLine();
                    Console.WriteLine();

                    var hmacSha512Message = HMAC.ComputeHmacsha512(Encoding.UTF8.GetBytes(input), key);

                    Console.WriteLine("Input: - " + input);
                    Console.WriteLine();
                    Console.WriteLine("HMAC: - " + Convert.ToBase64String(hmacSha512Message));


                    break;
            }



            Console.ReadKey();
        }

    }
}
