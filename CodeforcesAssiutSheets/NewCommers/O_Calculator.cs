namespace CodeforcesAssiutSheets.NewCommers
{
    //https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/O
    class O_Calculator
    {
        public O_Calculator()
        {
            string userInput = Console.ReadLine() ?? string.Empty;
            string[] operators = new string[] { "-", "+", "/", "*" };
            string[] userInputArray = new string[0];
            string op = "";

            for (int i = 0; i < operators.Length; i++)
            {
                userInputArray = userInput.Split(operators[i]);
                if (userInputArray.Length > 1)
                {
                    op = operators[i];
                    break;
                }
            }


            int no1 = int.Parse(userInputArray[0]);
            int no2 = int.Parse(userInputArray[1]);
            int result = 0;

            switch (op)
            {
                case "+":
                    result = no1 + no2;
                    break;
                case "-":
                    result = no1 - no2;
                    break;
                case "*":
                    result = no1 * no2;
                    break;
                case "/":
                    result = no1 / no2;
                    break;

                default:
                    result = 0;
                    break;
            }

            Console.WriteLine(result);

        }
    }
}