namespace CodeforcesAssiutSheets.NewCommers
{
    //https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/D
    class D_Difference
    {
        public D_Difference()
        {
            var userInput = Console.ReadLine() ?? string.Empty;
            var numbers = userInput.Split(" ");

            long.TryParse(numbers[0], out long firstNo);
            long.TryParse(numbers[1], out long secondNo);
            long.TryParse(numbers[2], out long thirdNo);
            long.TryParse(numbers[3], out long fourthNo);


            long result = (firstNo * secondNo) - (thirdNo * fourthNo);

            Console.WriteLine($"Difference = {result}");
        }
    }
}
