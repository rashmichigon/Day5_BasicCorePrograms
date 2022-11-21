namespace Day5_BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // FlipCoin.FindPercentageOffFlipCoin();
            LeapYearProgram obj = new LeapYearProgram();
            obj.readdata();
            obj.leap();
        }
    }
}