abstract class Haircut
{
    public string Scissors;
    public string HairDryer;

    public Haircut(string scissors, string hairDryer)
    {
        Scissors = scissors;
        HairDryer = hairDryer;
    }

    public void TemplateMethod()
    {
        WashHair();
        Cut(Scissors);
        Dry(HairDryer);
    }

    private void WashHair()
    {
        int a = 1;
    }

    private void Dry(string dryer)
    {
        dryer = dryer + " done";
    }

    public abstract void Cut(string scissors);
}

class Trimming : Haircut
{
    public Trimming(string s, string h) : base(s, h) {}

    public override void Cut(string s)
    {
        s = s + " done only trimming";
    }
}

class BaldHair : Haircut
{
    public BaldHair(string s, string h) : base(s, h) {}

    public override void Cut(string s)
    {
        s = s + " done all hair";
    }
}

class Program
{
    static void Main()
    {
        
    }
}
