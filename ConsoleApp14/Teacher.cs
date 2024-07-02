namespace ConsoleApp14;

public class Teacher : ICloneable
{

    public string Name { get; set; }
    public string Surname { get; set; }
    public Teacher(string name, string surname)
    {
        Name = name;
        Surname = surname;
    }
    public Teacher()
    {

    }

    //public Teacher Clone()
    //{
    //    return new Teacher(this.Name, this.Surname);
    //}

    public override string ToString()
    => $"Name:{Name}\nSurname:{Surname}";

    public object Clone()
    {
        return new Teacher(this.Name, this.Surname);
    }
}
