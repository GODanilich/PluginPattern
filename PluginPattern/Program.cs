namespace PluginPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PluginManager pluginManager = new();

            string pluginsPath = @"Plugins.dll";

            pluginManager.LoadPlugin(pluginsPath);

            string defaultContent = "Хай, мир! Это строка из файла!";

            string filePath = @"text.txt";

            if (!File.Exists(filePath)) 
            {
                File.Create(filePath).Close();
                File.WriteAllText(filePath, defaultContent);
            } 

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
