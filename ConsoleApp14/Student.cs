using System.Collections;

namespace ConsoleApp14;

public class Student:IEnumerable<int>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public List<int> Scores { get; set; }
    public Student(int id,string name, string surname, List<int> scores)
    {
        Id = id;
        Name = name;
        Surname = surname;
        Scores = scores;
    }

    public IEnumerator<int> GetEnumerator()
    {
        foreach(var item  in Scores) yield return item;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}
