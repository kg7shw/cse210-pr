using System;
using System.IO;
using Newtonsoft.Json;

public class FileHandler
{
    public void Save(object data, string filePath)
    {
        string jsonData = JsonConvert.SerializeObject(data);
        File.WriteAllText(filePath, jsonData);
        Console.WriteLine("Data saved successfully.");
    }

    public T Load<T>(string filePath)
    {
        if (File.Exists(filePath))
        {
            string jsonData = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<T>(jsonData);
        }
        else
        {
            Console.WriteLine("File not found.");
            return default(T);
        }
    }

    
}
