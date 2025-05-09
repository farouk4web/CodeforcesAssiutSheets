namespace CodeforcesAssiutSheets.NewCommers
{
    //https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/E
    class E_AreaOfACircle
    {
        public E_AreaOfACircle()
        {
            var userInput = Console.ReadLine() ?? string.Empty;

            double.TryParse(userInput, out double radius);
            var result = 3.141592653 * (radius * radius);

            Console.WriteLine(result.ToString("F9"));
        }
    }
}
