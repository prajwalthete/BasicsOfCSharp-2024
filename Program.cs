namespace a;
class Program
{



    static void Main8(string[] args)
    {
        Console.WriteLine("Enter Your Name");
        string name = Console.ReadLine();
        Console.WriteLine("enter your roll no");
        string roll = Console.ReadLine();
        Console.WriteLine("enter your standard");
        string standard = Console.ReadLine();
        Console.WriteLine("enter hindi marks");
        int hindi = int.Parse(Console.ReadLine());
        Console.WriteLine("enter english marks");
        int english = int.Parse(Console.ReadLine());
        Console.WriteLine("enter math marks");
        int math = int.Parse(Console.ReadLine());
        Console.WriteLine("enter your physics marks");
        int physics = int.Parse(Console.ReadLine());
        Console.WriteLine("enter your Chem marks ");
        int chem = int.Parse(Console.ReadLine());

        int obt = hindi + english + math + physics + chem;
        int percent = obt * 100 / 500;

        Console.WriteLine("------------MARKSHEET-------------");
        Console.WriteLine("Your Name {0}", name);
        Console.WriteLine("Your roll no {0}", roll);
        Console.WriteLine("Your class Is {0}", standard);
        Console.WriteLine("Your Obtained Marks " + obt);
        Console.WriteLine("Your Perscentage is " + percent + "%");

        if (percent >= 80)
        {
            Console.WriteLine("Your Grade is : A-1  \n remark : excellent");
        }
        else if (percent < 80 && percent >= 70)
        {
            Console.WriteLine("Your Grade is : A-2 \n remark :good ");
        }
        else if (percent >= 60)
        {
            Console.WriteLine("Your Grade is : B ");
        }
        else if (percent >= 50)
        {
            Console.WriteLine("Your Garde is : C ");
        }
        else { Console.WriteLine("Your Garde is : D"); }
    }
}