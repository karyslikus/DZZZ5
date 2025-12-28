namespace ConsoleApp2;
public interface ITextPlugin
{
    string Name { get; } 
    string Process(string input); 
}