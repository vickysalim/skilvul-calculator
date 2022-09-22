class Program {
    static void Main() {
        var program = "Y";

        while(program == "Y" || program == "y") {
            Console.WriteLine("\n==== Calculator ====");
            Console.WriteLine("Enter the action to be performed");
            Console.WriteLine("- Press 1 for Addition");
            Console.WriteLine("- Press 2 for Subtraction");
            Console.WriteLine("- Press 3 for Multiplication");
            Console.WriteLine("- Press 4 for Division");

            Console.WriteLine("");

            Console.Write("Enter Action: ");
            var operation = Console.ReadLine();

            Console.Write("Enter 1st input: ");
            var number1 = Console.ReadLine();

            Console.Write("Enter 2nd input: ");
            var number2 = Console.ReadLine();

            Console.WriteLine("");

            try {
                Calculation calc = new Calculation(Convert.ToDouble(number1), Convert.ToDouble(number2));

                switch(operation) {
                    case "1":
                        Console.WriteLine("The result is " + calc.GetAddition());
                        break;
                    case "2":
                        Console.WriteLine("The result is " + calc.GetSubtraction());
                        break;
                    case "3":
                        Console.WriteLine("The result is " + calc.GetMultiplication());
                        break;
                    case "4":
                        Console.WriteLine("The result is " + calc.GetDivision());
                        break;
                    default:
                        Console.WriteLine("There is invalid input.");
                        break;
                }
            } catch {
                Console.WriteLine("There is invalid input.");
            }

            Console.Write("\nRepeat calculator? (Y/N): ");
            program = Console.ReadLine();
        }
    }
}