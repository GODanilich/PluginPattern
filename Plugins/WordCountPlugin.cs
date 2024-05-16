using PluginInterfaces;

namespace Plugins
{
    public class WordCountPlugin : ITextPlugin
    {
        public string Name => "Word Count Plugin";

        public string Process(string input)
        {
            int wordCount = input.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
            return $"Количество слов: {wordCount}";
        }
    }
}
