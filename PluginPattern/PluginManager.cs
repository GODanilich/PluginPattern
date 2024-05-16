using PluginInterfaces;
using System.Reflection;


namespace PluginPattern
{
    internal class PluginManager
    {
        private List<ITextPlugin> plugins = [];

        public void LoadPlugin(string pluginPath)
        {
            if (File.Exists(pluginPath))
            {
                Assembly assembly = Assembly.LoadFrom(pluginPath);
                var pluginTypes = assembly.GetTypes().Where(t => typeof(ITextPlugin).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract);

                foreach (var type in pluginTypes)
                {
                    ITextPlugin plugin = (ITextPlugin)Activator.CreateInstance(type);
                    plugins.Add(plugin);
                }
            }
            else
            {
                Console.WriteLine($"Plugin file not found: {pluginPath}");
            }
        }

        public void ProcessPlugins(string input)
        {
            foreach (var plugin in plugins)
            {
                Console.WriteLine($"Выполняется плагин: {plugin.Name}");
                Console.WriteLine(plugin.Process(input));
            }
        }
    }
}
