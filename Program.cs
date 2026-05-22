namespace Class_0522_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();//一般建立物件

            Console.WriteLine(p1.GetData());

            Console.WriteLine(p1.GetName());

            Console.WriteLine(p1.GetCard());
           
            Student s1 =new Student();
            Console.WriteLine(s1.GetCard());
            Console.WriteLine(s1.GetName());
            Console.WriteLine(s1.GetData());
        }
    }
}
