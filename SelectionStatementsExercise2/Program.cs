namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject?");

            string subject = Console.ReadLine();

            switch (subject.ToLower()) 
            {
                case "math":
                    Console.WriteLine("I hate Math!");
                    break;
                case "science":
                    Console.WriteLine("I love science!");
                    break;
                case "pe":
                    Console.WriteLine("PE is the best!");
                    break;
                case "history":
                    Console.WriteLine("Histopry is fun.");
                    break;
                case "english":
                    Console.WriteLine("English is boring");
                    break;
                default
                    : Console.WriteLine("I dont know that subject.");
                    break;
            }
        }
    }
}