namespace CodeforcesAssiutSheets.NewCommers
{
    //https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/B
    class B_BasicDataTypes
    {
        //int : 32 Bit integer.
        //long : 64 bit integer
        //Char : 8 bit Characters & symbols
        //Float : 32 bit real value
        //Double : 64 bit real value

        public B_BasicDataTypes()
        {
            var userInput = Console.ReadLine() ?? string.Empty;

            foreach (var num in userInput.Split(" "))
            {
                Console.WriteLine(num);
            }
        }
    }
}