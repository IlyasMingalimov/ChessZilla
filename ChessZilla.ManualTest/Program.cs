using ChessZilla.Core;

internal class Program
{
    private static void Main(string[] args)
    {
        var position = Fen.ToPosition("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1");
        var engine = new Engine();
        foreach(var next in engine.Calculation(position, 3, 3)) 
        { 
            Console.WriteLine(next);
        }
    }
}