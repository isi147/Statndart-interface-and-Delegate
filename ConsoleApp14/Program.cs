//class Program
//{

//    static IEnumerable<int> foo()
//    {
//        yield return 1;
//        yield return 2;
//        yield return 3;

//    }


//    static void Main(string[] args)
//    {
//        foreach (int i in foo())
//        {
//            Console.WriteLine(i);
//        }
//        //foo().Min();



//    }
//}




//using ConsoleApp14;
//using System.Buffers;
//using System.Xml;

//Student student1 = new("nazim", "nazimli", new List<int> { 1, 2, 3, 4, 5 });
//Student student2 = new("fikret", "fikretli", new List<int> { 1, 2, 3, 4, 5 });
//Student student3 = new("cavidan", "cavidanli", new List<int> { 1, 2, 3, 4, 5 });

////foreach(int i  in student1)
////{
////    Console.WriteLine(i);
////}

//List<Student> students = new List<Student> { student1, student2, student3 };

//Group group = new Group("FBMS-1254", students);



//foreach (var item in group)
//{
//    Console.WriteLine(item);
//}
//ICloneable


//Teacher teacher1 = new Teacher("Cebis","Muellim");
//Teacher teacher2 = new Teacher("Sebiw","Muellim");

//Teacher teacher3 = new Teacher();

//teacher3 = (Teacher)teacher2.Clone();


//teacher3.Name = "Teriw";
//Console.WriteLine(teacher3);
//Console.WriteLine(teacher2);


//IComparable
//IConvertable
//IDisposable

//Delegate

//1 funksiya basqa bir funksiyani argument kimi gondere bilerik
//Delegate Refrence type dir
//Delegate yranan zaman default olraq internal olur public ede bilirik
//+= ile funksiyalari delegate e qeydiyatdan kecirel biler 
//ve delegate cagiran zaman hamisini cagira bilerik
//eger class icerisinde yazilarsa yalniz class icerisinde istifade olunur
//namespace iceriisnde yazilarasa her yerde gorunur

//delegate void MyDelegate();
//delegate void MyDelegate2(string text);

//class Program
//{
//    static void foo()
//    {
//        Console.WriteLine("Foo");
//    }
//    static void boo()
//    {
//        Console.WriteLine("Boo");
//    }
//    static void AllMethod(MyDelegate myDelegate)
//    {
//        myDelegate.Invoke();
//    }
//    static void Main(string[] args)
//    {
//        MyDelegate myDell = null;
//        myDell += foo;
//        myDell += boo;
//        //myDell -= boo;
//        //myDell.Invoke();

//        //MyDelegate2 myDell = null;

//        //Anonim function
//        //myDell += delegate (string str) { Console.WriteLine(str); };

//        //Lambda expresion
//        //myDell += str => Console.WriteLine($"Lamdda{str}");


//        //myDell.Invoke("Hello");


//        AllMethod(myDell);


//    }




//}

//Hazir delegate ler 
//1.Action - return type void olanlari qebul edir
//2.Func - return istenilen type ola biler void den basqa istnilen sayda parametr yaz bilerik
//3.Predicate - yalniz bool return typelara gore isleyie yalniz  1 parametr ile isleyir


using ConsoleApp14;

class Program
{
    //public static void Foo()
    //{
    //    Console.WriteLine("Foo");
    //}
    //public static void Boo()
    //{
    //    Console.WriteLine("Boo");
    //}

    //static void Main(string[] args)
    //{
    //    Action action = Foo;
    //    action += Boo;
    //    action.Invoke();
    //}

    //public static int foo(int a,int b)
    //{
    //    return a + b;
    //}
    //public static int boo(int a, int b)
    //{
    //    return a + b;
    //}
    //static void Main(string[] args)
    //{
    //    Func<int, int, int> func = foo;
    //    func += boo;

    //    Console.WriteLine(func.Invoke(5, 4));
    //}


    //public static bool IsEven(int num)
    //{
    //    return num%2 == 0;  
    //}


    //static void Main(string[] args)
    //{
    //    Predicate<int> predicate = IsEven;

    //    Console.WriteLine(predicate.Invoke(7));
    //}


    static void Main(string[] args)
    {

        


        Student student1 = new(1,"nazim", "nazimli", new List<int> { 1, 2, 3, 4, 5 });
        Student student2 = new(2,"fikret", "fikretli", new List<int> { 1, 2, 3, 4, 5 });
        Student student3 = new(3,"cavidan", "cavidanli", new List<int> { 1, 2, 3, 4, 5 });



        List<Student> students = new List<Student> { student1, student2, student3 };

        Group group = new Group("FBMS-1254", students);

        Predicate<Student> predicate = student => student.Id == 1;




    }







}





































