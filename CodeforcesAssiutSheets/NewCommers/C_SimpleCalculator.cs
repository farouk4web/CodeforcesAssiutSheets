namespace CodeforcesAssiutSheets.NewCommers
{
    //https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/C
    class C_SimpleCalculator
    {
        public C_SimpleCalculator()
        {
            var userInput = Console.ReadLine() ?? string.Empty;
            var numbers = userInput.Split(" ");

            long.TryParse(numbers[0], out long firstNo);
            long.TryParse(numbers[1], out long secondNo);

            string summation = $"{firstNo} + {secondNo} = {firstNo + secondNo}";
            string multiplication = $"{firstNo} * {secondNo} = {firstNo * secondNo}";
            string subtraction = $"{firstNo} - {secondNo} = {firstNo - secondNo}";

            Console.WriteLine($"{summation}\n{multiplication}\n{subtraction}");
        }
    }
}
