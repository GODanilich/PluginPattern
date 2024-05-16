using PluginInterfaces;

namespace Plugins
{
    public class SearchReplacePlugin : ITextPlugin
    {

        public string Name => "Search and Replace Plugin";

        public string Process(string input)
        {
            return input.Replace("Хай", "Привет");
        }
    }
}
