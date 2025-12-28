namespace ConsoleApp2;
public class SpaceRemoverPlugin : ITextPlugin
{
    public string Name => "SpaceRemoverPlugin";
    public string Process(string input)
    {
        return input.Replace(" ", "");
    }
}