// See https://aka.ms/new-console-template for more information

var kangorooA = new Kangoroo(2, 3);
var kangorooB = new Kangoroo(4, 2);

kangorooA.DisplayCurrentPosition(nameof(kangorooA));
kangorooB.DisplayCurrentPosition(nameof(kangorooB));

kangorooA.Jump();
kangorooA.Jump();
kangorooA.DisplayCurrentPosition(nameof(kangorooA));

kangorooB.Jump();
kangorooB.Jump();
kangorooB.DisplayCurrentPosition(nameof(kangorooB));

public class Kangoroo
{
    public int Position { get; private set; }
    public int Rate { get; private set; }
    
    public Kangoroo(int position, int rate)
    {
        Position = position;
        Rate = rate;
    }

    public int Jump()
    {
        Position += Rate;
        return Position;
    }

    public void DisplayCurrentPosition(string kangorooName)
    {
        Console.WriteLine($"{kangorooName}: {Position} {Rate}");
    }
}