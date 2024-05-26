public class Program
{
    private static void Main(string[] args)
    {
        foreach (Color color in Enum.GetValues(typeof(Color)))
        {
            foreach (Rank rank in Enum.GetValues(typeof(Rank)))
            {
                Card card = new Card(color, rank);
                Console.WriteLine($"The {card.Color} {card.Rank}");
            }


        }
    }
}

class Card
{
    public Color Color { get; set; }
    public Rank Rank { get; set; }

    public Card(Color color,Rank rank)
    {
        Color= color;
        Rank= rank;
    }
    public bool isNumber()
    {
        return Rank >= Rank.One && Rank <= Rank.Ten;
    }
    public bool isSymbol()
    {
        return Rank == Rank.Dollar || Rank == Rank.Percent || Rank == Rank.Ampersand || Rank == Rank.Caret;
    }

}

enum Color
{
    Red=1,
    Green,
    Blue,
    Yellow
}

enum Rank
{
    One = 1,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    Dollar,
    Percent,
    Caret,
    Ampersand
}