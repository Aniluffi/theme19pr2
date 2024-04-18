using Task5;

class Program
{
    public static void Main()
    {
        TVSet tv = new TVSet();
        PersonalComputer pc = new PersonalComputer();
        tv.TVState(tv.On());
        tv.TVState(tv.Off());

        pc.PCState(tv.On());
        pc.PCState(tv.Off());
    }
}
