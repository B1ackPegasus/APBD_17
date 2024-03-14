class Program
{
    static int number_still = 0;
    static int number_user1 = 0;
    static int number_user2 = 0;
    static string sign = "";
    static bool check = true;

    static void Main(string[] args)
    {
        
        Console.Write("Calculator \n");
        AskUser();
    }

    static void AskUser()
    {
        Console.Write("Put first number: ");
        number_user1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Choose the operation (*,-,+,/) : ");
        sign = Console.ReadLine();

        Console.Write("Put second number: ");
        number_user2 = Convert.ToInt32(Console.ReadLine());

        number_user1 = AfterOperation(sign);
        Console.WriteLine($"Answer: {number_user1}");

        while (check)
        {
            Console.Write("Would you like to work with previous value? (yes/no): ");
            string check_cont = Console.ReadLine().ToLower();

            if (check_cont == "yes")
            {
                Console.Write("Put second number: ");
                number_user2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Put the operation: ");
                sign = Console.ReadLine();

                number_user1 = AfterOperation(sign);
                Console.WriteLine(number_user1);
            }
            else
            {
                check = false;
            }
        }
    }

    static int AfterOperation(string sign)
    {
        switch (sign)
        {
            case "+":
                return number_user1 + number_user2;
            case "-":
                return number_user1 - number_user2;
            case "/":
                return number_user1 / number_user2;
            case "*":
                return number_user1 * number_user2;
            default:
                return 0; 
        }
    }
}