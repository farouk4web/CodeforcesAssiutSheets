namespace CodeforcesAssiutSheets.NewCommers
{
    //https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/P
    class P_FirstDigit
    {
        public P_FirstDigit()
        {
            string userInput = Console.ReadLine() ?? string.Empty;
            int.TryParse(userInput[0].ToString(), out int n);

            var reminder = n % 2;

            Console.WriteLine(reminder == 0 ? "EVEN" : "ODD");
        }
    }
}