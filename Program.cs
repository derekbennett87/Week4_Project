using Week4_Project;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("please enter min rectangle");
        int min = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("please enter max rectangle");
        int max = Convert.ToInt32(Console.ReadLine());
        int length;
        int width;

        MakeRectangle(min, max, out length, out width);

        int area = Utility.GetArea(length, width);
        int perimeter = Utility.Perimeter(length, width);

        Console.WriteLine("Length:" + length.ToString());
        Console.WriteLine("Width:" + width.ToString());
        Console.WriteLine("Area:" + area.ToString());
        Console.WriteLine("Perimeter:" + perimeter.ToString());
    }

    public static void MakeRectangle(int min, int max, out int length, out int width)
    {
        Random rnd = new Random();


        length = new Random().Next(min, max);
        width = new Random().Next(min, max);

    }
}