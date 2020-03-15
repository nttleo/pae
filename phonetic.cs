// phonetic alphabet encoder (c#)
using System;

class phonetic
{
    static void Main(string[] args)
    {
        Console.WriteLine("\x1B[35mPHONETIC ALPHABET ENCODER!\x1B[37m");
        Console.WriteLine("insert a text right bellow:");
        while (true)
        {
            string txtz = Console.ReadLine();
            string txt = txtz.ToLower();

            foreach (char c in txt)
            {
                switch (c)
                {
                    case 'a':
                        Console.Write("alpha ");
                        break;
                    case 'b':
                        Console.Write("bravo ");
                        break;
                    case 'c':
                        Console.Write("charlie ");
                        break;
                    case 'd':
                        Console.Write("delta ");
                        break;
                    case 'e':
                        Console.Write("echo ");
                        break;
                    case 'f':
                        Console.Write("foxtrot ");
                        break;
                    case 'g':
                        Console.Write("golf ");
                        break;
                    case 'h':
                        Console.Write("hotel ");
                        break;
                    case 'i':
                        Console.Write("india ");
                        break;
                    case 'j':
                        Console.Write("juliet ");
                        break;
                    case 'k':
                        Console.Write("kilo ");
                        break;
                    case 'l':
                        Console.Write("lima ");
                        break;
                    case 'm':
                        Console.Write("mike ");
                        break;
                    case 'n':
                        Console.Write("november ");
                        break;
                    case 'o':
                        Console.Write("oscar ");
                        break;
                    case 'p':
                        Console.Write("papa ");
                        break;
                    case 'q':
                        Console.Write("quebec ");
                        break;
                    case 'r':
                        Console.Write("romeo ");
                        break;
                    case 's':
                        Console.Write("sierra ");
                        break;
                    case 't':
                        Console.Write("tango ");
                        break;
                    case 'u':
                        Console.Write("uniform ");
                        break;
                    case 'v':
                        Console.Write("victor ");
                        break;
                    case 'w':
                        Console.Write("whiskey ");
                        break;
                    case 'x':
                        Console.Write("xray ");
                        break;
                    case 'y':
                        Console.Write("yankeey ");
                        break;
                    case 'z':
                        Console.Write("zulu ");
                        break;
                    default:
                        Console.Write(c + " ");
                        break;
                }
            }
            Console.WriteLine("\n\nshow me another text: \n");
            continue;
        }
    }
}
