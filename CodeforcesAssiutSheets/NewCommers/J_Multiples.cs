namespace CodeforcesAssiutSheets.NewCommers
{
    //https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/J
    class J_Multiples
    {
        public J_Multiples()
        {
            var userInput = Console.ReadLine() ?? string.Empty;
            int[] ints = userInput.Split(' ').Select(int.Parse).ToArray();
            int noA = ints[0],
                noB = ints[1];

            int remainder = noA % noB;
            if (remainder != 0)
                remainder = noB % noA;

            string msg = remainder == 0 ? "Multiples" : "No Multiples";
            Console.WriteLine(msg);
        }
    }
}