using System.Linq;
using System.Text.Json.Serialization;

namespace W4_assignment_template.Models;

public class Character
{
    public string Name { get; set; }
    public string Class { get; set; }
    public int Level { get; set; }
    public int HP { get; set; }
    public List<string> Equipment { get; set; }
    public Character() { }


    public Character(string name, string job, int level, int hp, string equipment)
    {
        Name = name;
        Class = job;
        Level = level;
        HP = hp;
        Equipment = equipment.Split('|').ToList();

    }
    [JsonConstructor]
    public Character(string name, string job, int level, int hp, List<string> equipment)
    {
        Name = name;
        Class = job;
        Level = level;
        HP = hp;
        Equipment = equipment;
    }
}