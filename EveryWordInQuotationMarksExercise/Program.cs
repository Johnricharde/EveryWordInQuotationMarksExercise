namespace EveryWordInQuotationMarksExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            string[] wordArray = userInput.Split(" ");

            foreach (string word in wordArray)
            {
                Console.Write($"\"{word}\" ");
            }
        }
    }
}
