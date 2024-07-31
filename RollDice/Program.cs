// See https://aka.ms/new-console-template for more information

using System.Text;

public class Dice
{
    private int m_nFace;
    private int m_nNumberOfDie;

    public void setface(int face)
    {
        this.m_nFace = face;
    }

    public void setNumberOfDice(int num)
    {
        this.m_nNumberOfDie = num;
    }

    public Dice()
    {
        this.m_nFace = 20;
        this.m_nNumberOfDie = 1;
    }

    public int rollDice(string input)
    {
        string [] arr = input.Split('d');
        this.m_nFace = Int32.Parse(arr[1]);
        this.m_nNumberOfDie = Int32.Parse(arr[0]);
        Random random = new Random();
        int randomNumber = random.Next(1, this.m_nNumberOfDie * this.m_nFace);
        return randomNumber;
    }
}