namespace CodeforcesAssiutSheets.NewCommers
{
    //https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/N
    class N_Char
    {
        public N_Char()
        {
            //Capital Letters(A–Z): 65–90
            //Small Letters(a–z): 97–122

            string userInput = Console.ReadLine() ?? string.Empty;
            char letter = char.Parse(userInput);

            char result = ' ';
            if (letter >= 65 && letter <= 90)
                result = (char)(letter + 32);

            else if (letter >= 97 && letter <= 122)
                result = (char)(letter - 32);

            Console.WriteLine(result);
        }
    }
}