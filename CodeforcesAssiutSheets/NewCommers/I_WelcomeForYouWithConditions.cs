namespace CodeforcesAssiutSheets.NewCommers
{
    //https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/I
    class I_WelcomeForYouWithConditions
    {
        public I_WelcomeForYouWithConditions()
        {
            var userInput = Console.ReadLine() ?? string.Empty;
            byte[] ints = userInput.Split(' ').Select(byte.Parse).ToArray();
            int noA = ints[0],
                noB = ints[1];

            string msg = noA >= noB ? "Yes" : "No";
            Console.WriteLine(msg);
        }
    }
}