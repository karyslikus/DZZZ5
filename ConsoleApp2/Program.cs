namespace ConsoleApp2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Система обработки текста на плагинах ---\n");
        string originalText = "Hello World! This is a test.";
        Console.WriteLine($"Исходная строка: {originalText}\n");
        var plugins = new List<ITextPlugin>
        {
            new ToUpperPlugin(),
            new SpaceRemoverPlugin(),
            new ReversePlugin()
        };
        var processor = new TextProcessor();
        processor.PrintPluginsInfo(plugins);
        string result = processor.Process(originalText, plugins);
        Console.WriteLine($"\nРезультат после обработки: {result}\n");
        var customPlugins = new List<ITextPlugin>
        {
            new ToUpperPlugin(),
            new ReversePlugin()
        };

        
    }


}