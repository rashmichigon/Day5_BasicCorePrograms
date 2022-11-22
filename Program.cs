namespace Day5_BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.Write("\n\n");
            Console.Write("Vowel or Consonant checker tool\n");
            Console.Write("-----------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Please Enter an Alphabet (A-Z or a-z) : ");
            ch = Convert.ToChar(Console.ReadLine().ToLower());
            int i = ch;
            if (i >= 48 && i <= 57)
            {
                Console.Write("Err! Please enter an alphabet not a number.");
            }
            else
            {
                switch (ch)
                {
                    case 'a':
                        Console.WriteLine("Entered alphabet is vowel");
                        break;
                    case 'i':
                        Console.WriteLine("Entered alphabet is vowel");
                        break;
                    case 'o':
                        Console.WriteLine("Entered alphabet is vowel");
                        break;
                    case 'u':
                        Console.WriteLine("Entered alphabet is vowel");
                        break;
                    case 'e':
                        Console.WriteLine("Entered alphabet is vowel");
                        break;
                    default:
                        Console.WriteLine("Entered alphabet is a Consonant");
                        break;
                }
            }
        }
    }
}