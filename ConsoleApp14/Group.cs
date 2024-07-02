using System.Collections;

namespace ConsoleApp14;

public class Group:IEnumerable<Student>
{

    public string Name { get; set; }
    public IEnumerable<Student> students { get; set; }

    public Group(string name, IEnumerable<Student> students)
    {
        Name = name;
        this.students = students;
    }

    public IEnumerator<Student> GetEnumerator()
    {
        foreach(var item in students) { yield return item; }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}
