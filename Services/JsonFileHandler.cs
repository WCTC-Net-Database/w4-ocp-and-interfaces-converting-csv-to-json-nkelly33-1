using W4_assignment_template.Interfaces;
using W4_assignment_template.Models;
using Newtonsoft.Json;

namespace W4_assignment_template.Services;

public class JsonFileHandler : IFileHandler
{
    public List<Character> ReadCharacters(string filePath)
    {
        var json = File.ReadAllText(filePath);

        return JsonConvert.DeserializeObject<List<Character>>(json);
    }

    public void WriteCharacters(string filePath, List<Character> characters)
    {
        // TODO: Implement JSON writing logic
        var json = JsonConvert.SerializeObject(characters, Formatting.Indented);


        File.WriteAllText(filePath, json);
    }
}