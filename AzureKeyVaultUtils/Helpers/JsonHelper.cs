using System.Text.Json;

namespace AzureKeyVaultUtils.Helpers
{
    public class JsonHelper
    {
        /// <summary>
        /// An asynchronous task that stores key-value pairs to a JSON file.
        /// </summary>
        /// <param name="keyValues"></param>
        /// <returns></returns>
        public static async Task<bool> WriteToFile(Dictionary<string, string> keyValues, string filePath)
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string formattedJson = JsonSerializer.Serialize(keyValues, options);
            await File.WriteAllTextAsync(filePath, formattedJson);
            return true;
        }
    }
}
