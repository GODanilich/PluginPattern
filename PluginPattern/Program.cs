namespace PluginPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PluginManager pluginManager = new();

   
            string pluginsPath = @"Plugins.dll";

            pluginManager.LoadPlugin(pluginsPath);

            string filePath = @"text.txt";

            try
            {
                string content = File.ReadAllText(filePath);

                pluginManager.ProcessPlugins(content);

                Console.ReadLine();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Файл не найден: {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }

        }
    }
}
