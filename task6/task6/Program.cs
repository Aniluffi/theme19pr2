using task6;

class Program
{
    public static void Main()
    {
        int x1 = 10;
        int x2 = 12;
       
        Console.WriteLine($"Obj1:\n Переменная x1: {x1}\nПеременная x2: {x2}");
        Aa a = new Aa();

        Console.WriteLine($"{x1} + {x2} = { a.Plus(x1,x2)}");
        Console.WriteLine($"{x1} * {x2} = {a.Multiply(x1, x2)}");



        int y = 14;
        int z = -3;
        Console.WriteLine($"\nObj2:\n Переменная x: {x1}\nПеременная y: {y} \n Переменная z: {z}");
        Console.WriteLine($"{x1} + {y} + {z} = {a.Plus(a.Plus(x1,y), z)}");
    }
}
