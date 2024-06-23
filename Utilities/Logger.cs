namespace Factory_Test.Utilities
{
    public class Logger
    {
        public void WriteLine(string message)
        {
            var dateTime = DateTime.Now.ToString("dd-MM-yy");
            Console.WriteLine(message + Environment.NewLine);
            File.AppendAllText($"D:\\TestLogs\\FactoryTest-{dateTime}.txt", $" {message} {Environment.NewLine}");
        }
    }
}
