namespace ConsoleApp2;
public class ReversePlugin : ITextPlugin
{
    public string Name => "ReversePlugin";
    
    public string Process(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}