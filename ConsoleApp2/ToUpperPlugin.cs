namespace ConsoleApp2;
public class ToUpperPlugin : ITextPlugin
{
    public string Name => "ToUpperPlugin";
    public string Process(string input)
    {
        return input.ToUpper();
    }
}