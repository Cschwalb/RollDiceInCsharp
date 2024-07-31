public class Programming
{
    public static void Main(string[] args)
    {
        Dice dice = new Dice();
        Console.Write("Enter your die roll(1d20 example):   ");
        string input = Console.ReadLine();
        Console.WriteLine(dice.rollDice(input));
    }
}