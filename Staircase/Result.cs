public class Result
{
    public static void staircase(int n)
    {
        for(int i = 1; i <= n; i++)
        {
            int numberOfSpaces = n - i; 
            for(int j = 1; j <= n; j++)
            {
                if(numberOfSpaces > 0)
                {
                    Console.Write(" ");
                    numberOfSpaces--;
                    continue;
                }
                Console.Write("#");
            } 
            Console.WriteLine();
        }
    }
}