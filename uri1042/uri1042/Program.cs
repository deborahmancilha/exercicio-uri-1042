using System;

namespace ex1042
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            String[] vet;

            vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);

            if (a < b && b < c)
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
                Console.WriteLine("");
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
            }
            else
            {
                if (a < c && c < b)
                {
                    Console.WriteLine(a);
                    Console.WriteLine(c);
                    Console.WriteLine(b);
                    Console.WriteLine("");
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                }
                else
                {
                    if (b < a && a < c)
                    {
                        Console.WriteLine(b);
                        Console.WriteLine(a);
                        Console.WriteLine(c);
                        Console.WriteLine("");
                        Console.WriteLine(a);
                        Console.WriteLine(b);
                        Console.WriteLine(c);
                    }
                    else
                    {
                        if (b < c && c < a)
                        {
                            Console.WriteLine(b);
                            Console.WriteLine(c);
                            Console.WriteLine(a);
                            Console.WriteLine("");
                            Console.WriteLine(a);
                            Console.WriteLine(b);
                            Console.WriteLine(c);
                        }
                        else
                        {
                            if (c < a && a < b)
                            {
                                Console.WriteLine(c);
                                Console.WriteLine(a);
                                Console.WriteLine(b);
                                Console.WriteLine("");
                                Console.WriteLine(a);
                                Console.WriteLine(b);
                                Console.WriteLine(c);
                            }
                            else
                            {
                                if (c < b && b < a)
                                {
                                    Console.WriteLine(c);
                                    Console.WriteLine(b);
                                    Console.WriteLine(a);
                                    Console.WriteLine("");
                                    Console.WriteLine(a);
                                    Console.WriteLine(b);
                                    Console.WriteLine(c);
                                }
                                else
                                {

                                    Console.WriteLine("");
                                    Console.WriteLine(a);
                                    Console.WriteLine(b);
                                    Console.WriteLine(c);
                                }
                            }
                        }
                    }
                }

            }


        }
    }
}
