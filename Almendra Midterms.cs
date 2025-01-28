namespace Midterms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] post = { "GRWM", "BLK", "Squad", "Vice", "Details", "EverBilena", "Nichido", "Maybelline", "Sace Lady", "BareNBliss" };

            for (int i = 0; i < post.Length; i++)
            {
                String input;
                String react;
                String like;
                String skip;

                Console.WriteLine(post[i]);
                Console.WriteLine("A to React " + "B to Skip");
                input = Console.ReadLine();


                if (input == "A")
                {
                    Console.WriteLine("Like or Dislike");
                    react = Console.ReadLine();

                    if (react == "Like")
                    {
                        like = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Wrong Input");
                    }
                }
                else if (input == "B")
                {
                    skip = Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Wrong input");
                }

                
            }

        }
    }
}
