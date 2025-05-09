namespace CodeforcesAssiutSheets.NewCommers
{
    //https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/L
    class M_CapitalOrSmallOrDigit
    {
        public M_CapitalOrSmallOrDigit()
        {
            //Digits(0–9): 48–57
            //Capital Letters(A–Z): 65–90
            //Small Letters(a–z): 97–122

            string userInput = Console.ReadLine() ?? string.Empty;
            char letter = char.Parse(userInput);

            if (letter >= 48 && letter <= 57)
            {
                Console.WriteLine("IS DIGIT");
            }
            else if (letter >= 65 && letter <= 90)
            {
                Console.WriteLine("ALPHA");
                Console.WriteLine("IS CAPITAL");
            }
            else if (letter >= 97 && letter <= 122)
            {
                Console.WriteLine("ALPHA");
                Console.WriteLine("IS SMALL");
            }
        }
    }
}