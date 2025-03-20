namespace pp_lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problem problem = new Problem(1, 100);
            Console.WriteLine(problem);
            problem.Solve(20);
            Console.WriteLine(problem);
        }
    }
}
