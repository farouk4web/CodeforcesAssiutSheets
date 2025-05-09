namespace CodeforcesAssiutSheets.NewCommers
{
    //https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/G
    class G_SummationFrom1toN
    {
        public G_SummationFrom1toN()
        {
            string userInput = Console.ReadLine() ?? string.Empty;
            long.TryParse(userInput, out long number);
            long result = number * (number + 1) / 2;

            Console.WriteLine(result);
        }
    }
}