namespace CodeforcesAssiutSheets.NewCommers
{
    //https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/K
    class K_MaxAndMin
    {
        public K_MaxAndMin()
        {
            string userInput = Console.ReadLine() ?? string.Empty;
            int[] ints = userInput.Split(' ').Select(int.Parse).ToArray();
            int no1 = ints[0],
                no2 = ints[1],
                no3 = ints[2];

            int max = Math.Max(no1, Math.Max(no2, no3));
            int min = Math.Min(no1, Math.Min(no2, no3));

            Console.WriteLine($"{min} {max}");
        }
    }
}