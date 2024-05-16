using PluginInterfaces;

namespace Plugins
{
    public class UpperCasePlugin : ITextPlugin
    {
        public string Name => "Upper Case Plugin";

        public string Process(string input)
        {
            return input.ToUpper();
        }
    }
}
