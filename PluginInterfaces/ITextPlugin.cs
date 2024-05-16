namespace PluginInterfaces
{
    public interface ITextPlugin
    {
        string Name { get; }
        string Process(string input);
    }
}
