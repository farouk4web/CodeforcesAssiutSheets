namespace CodeforcesAssiutSheets.NewCommers
{
    //https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/H
    class H_TwoNumbers
    {
        public H_TwoNumbers()
        {
            var userInput = Console.ReadLine() ?? string.Empty;
            int[] ints = userInput.Split(' ').Select(int.Parse).ToArray();
            int no1 = ints[0],
                no2 = ints[1];

            decimal divisionResult = (decimal)no1 / no2;

            Console.WriteLine($"floor {no1} / {no2} = {Math.Floor(divisionResult)}");
            Console.WriteLine($"ceil {no1} / {no2} = {Math.Ceiling(divisionResult)}");
            Console.WriteLine($"round {no1} / {no2} = {Math.Round(divisionResult, MidpointRounding.AwayFromZero)}");
        }
    }
}