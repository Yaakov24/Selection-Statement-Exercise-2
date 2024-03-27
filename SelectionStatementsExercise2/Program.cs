namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject in school?");
            string answer = Console.ReadLine();

            switch (answer.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is intellectually stimulating!");
                    break;
                case "science":
                    Console.WriteLine("Science is so cool and fun!");
                    break;
                case "social studies":
                    Console.WriteLine("That is a very interesting subject!");
                    break;
                case "history":
                    Console.WriteLine("Everyone should know History");
                    break;
                case "english":
               
                    Console.WriteLine("That is a neccassary thing to know for all areas");
                    break;
                default:
                    Console.WriteLine("I never heard of it but cool!");
                    break;
            }
                
        }
    }
};