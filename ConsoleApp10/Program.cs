namespace SingleFileConflict
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== System Start ===");
            Console.WriteLine(GetVersion());
            Console.WriteLine("=== System End ===");
        }

        private static string GetVersion()
        {
            // Базовая версия
            return "v1.0.0-stable";
        }
    }
}