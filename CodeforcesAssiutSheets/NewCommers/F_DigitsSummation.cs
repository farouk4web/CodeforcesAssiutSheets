namespace CodeforcesAssiutSheets.NewCommers
{
    //https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/F
    class F_DigitsSummation
    {
        public F_DigitsSummation()
        {
            var userInput = Console.ReadLine() ?? string.Empty;
            var numbersAsArray = userInput.Split(" ");

            long.TryParse(numbersAsArray[0].LastOrDefault().ToString(), out long firstNo);
            long.TryParse(numbersAsArray[1].LastOrDefault().ToString(), out long secondNo);

            Console.WriteLine(firstNo + secondNo);
        }
    }
}
