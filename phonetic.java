// phonetic alphabet encoder (java)
import java.util.Scanner;
class phonetic
{
    public static void main(String[] args)
    {
        Scanner Scan = new Scanner(System.in);
        System.out.println("PHONETIC ALPHABET ENCODER!");
        System.out.println("insert a text right bellow:");
        while (true)
        {
            String txt = Scan.nextLine().toLowerCase();

            for (char c : txt.toCharArray())
            {
                switch (c)
                {
                    case 'a':
                        System.out.println("alpha ");
                        break;
                    case 'b':
                        System.out.println("bravo ");
                        break;
                    case 'c':
                        System.out.println("charlie ");
                        break;
                    case 'd':
                        System.out.println("delta ");
                        break;
                    case 'e':
                        System.out.println("echo ");
                        break;
                    case 'f':
                        System.out.println("foxtrot ");
                        break;
                    case 'g':
                        System.out.println("golf ");
                        break;
                    case 'h':
                        System.out.println("hotel ");
                        break;
                    case 'i':
                        System.out.println("india ");
                        break;
                    case 'j':
                        System.out.println("juliet ");
                        break;
                    case 'k':
                        System.out.println("kilo ");
                        break;
                    case 'l':
                        System.out.println("lima ");
                        break;
                    case 'm':
                        System.out.println("mike ");
                        break;
                    case 'n':
                        System.out.println("november ");
                        break;
                    case 'o':
                        System.out.println("oscar ");
                        break;
                    case 'p':
                        System.out.println("papa ");
                        break;
                    case 'q':
                        System.out.println("quebec ");
                        break;
                    case 'r':
                        System.out.println("romeo ");
                        break;
                    case 's':
                        System.out.println("sierra ");
                        break;
                    case 't':
                        System.out.println("tango ");
                        break;
                    case 'u':
                        System.out.println("uniform ");
                        break;
                    case 'v':
                        System.out.println("victor ");
                        break;
                    case 'w':
                        System.out.println("whiskey ");
                        break;
                    case 'x':
                        System.out.println("xray ");
                        break;
                    case 'y':
                        System.out.println("yankeey ");
                        break;
                    case 'z':
                        System.out.println("zulu ");
                        break;
                    default:
                        System.out.println(c + " ");
                        break;
                }
            }
            System.out.println("\n\nshow me another text: \n");
            continue;
        }
    }
}
