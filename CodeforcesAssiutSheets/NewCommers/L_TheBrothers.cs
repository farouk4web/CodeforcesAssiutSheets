namespace CodeforcesAssiutSheets.NewCommers
{
    //https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/L
    class L_TheBrothers
    {
        public L_TheBrothers()
        {
            string firstUserName = Console.ReadLine() ?? string.Empty;
            string secondUserName = Console.ReadLine() ?? string.Empty;

            string firstUserFatherName = firstUserName.Split(' ')[1];
            string secondUserFatherName = secondUserName.Split(' ')[1];

            string result = firstUserFatherName == secondUserFatherName ? "ARE Brothers" : "NOT";
            Console.WriteLine($"{result}");
        }
    }
}