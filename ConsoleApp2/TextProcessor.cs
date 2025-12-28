namespace ConsoleApp2;

using System.Collections.Generic;
public class TextProcessor
{
    public string Process(string input, List<ITextPlugin> plugins)
    {
        string result = input;
        foreach (var plugin in plugins)
        {
            result = plugin.Process(result);
        }
        
        return result;
    }
    public void PrintPluginsInfo(List<ITextPlugin> plugins)
    {
        Console.WriteLine("Примененные плагины:");
        foreach (var plugin in plugins)
        {
            Console.WriteLine($" - {plugin.Name}");
        }
    }
}