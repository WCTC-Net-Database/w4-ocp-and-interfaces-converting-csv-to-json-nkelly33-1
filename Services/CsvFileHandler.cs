using W4_assignment_template.Interfaces;
using W4_assignment_template.Models;

namespace W4_assignment_template.Services;

public class CsvFileHandler : IFileHandler
{
    public List<Character> ReadCharacters(string filePath)
    {
        // TODO: Implement CSV reading logic
        var characters = new List<Character>();
        var lines = File.ReadAllLines(filePath);

        foreach (var line in lines)
        {
            var values = line.Split(',');
            var character = new Character(
                values[0],
                values[1],
                int.Parse(values[2]),
                int.Parse(values[3]),
                values[4].Split(';').ToList()
            );
            characters.Add(character);
        }

        return characters;
    }
    public void WriteCharacters(string filePath, List<Character> characters)
    {
        // TODO: Implement CSV writing logic
        var lines = new List<string>();

        foreach (var character in characters)
        {
            var line = $"{character.Name},{character.Class},{character.Level},{character.HP},{string.Join(';', character.Equipment)}";
            lines.Add(line);
        }

        File.WriteAllLines(filePath, lines);
    }
}