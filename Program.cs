using GitCloneApp.Interface;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello Git!");
        IString implement = new ImplementInterafce();
        Mains mains = new Mains(implement);
        mains.callStringManipulation("Applied system");
        Console.ReadLine();


    }
}
  
public class Mains
{
    private IString implement;
    public Mains(IString implementInterafce)
    {
        this.implement = implementInterafce; 
    }

    public void callStringManipulation(string str)
    { 
        implement.stringManipulation(str);
    }
}
public class ImplementInterafce : IString
{
    public void stringManipulation(string str)
    {

        //Applied system
        Console.WriteLine("Out put is mpplied systeA");
        StringBuilder sb = new StringBuilder();
        char[] chars = str.ToCharArray();

        sb.Append(chars[13]);
        for(int i = 0; i < chars.Length; i++)
        {
            if (i == 0 || i == 14)
                continue;
            sb.Append(chars[i]);
        }
        sb.Append(chars[0]);
        Console.WriteLine("Output is {0}",sb.ToString());
    } 
}  