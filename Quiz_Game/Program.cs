namespace Quiz_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Questions =
            {
                "1. What Is The Best Player In The World ? ",
                "2. What Is The Best Team ? ",
                "3. What Is The Best Planet ? "
            };
            string[] Answer =
            {
                "Messi",
                "Barcalona",
                "Marc"
            };
            int score = 0;


            Console.WriteLine("Welcome to the Game");
            Console.WriteLine("--------------");
            Console.WriteLine("please answer the following questiond");

            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine(Questions[i]);
                var useranswer = Console.ReadLine();
                try
                {
                    bool result = compare(useranswer, Answer[i]);

                    if (result)
                    {
                        Console.WriteLine("Correct Answer");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Wrong Answer , The Correct Answer is : {Answer[i]} ");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

             
            }
            Console.WriteLine("--------------");
            Console.WriteLine("Your Score : " + score);
            Console.WriteLine("Quiz Completed Thank You"); 

            
           
        }
        // method to compare
        private static bool compare(string userInput  , string Correct)
        {
            if(string.IsNullOrEmpty(userInput))
            {
                throw new Exception("Answer Can't Be Empty");
            }
            // the answer is right
            if(userInput == Correct)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
