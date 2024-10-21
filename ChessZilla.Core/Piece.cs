namespace ChessZilla.Core;

public abstract class Piece
{
    public Piece(Color color)
    {
        this.color = color;
    }

    Color color;
    public abstract IEnumerable<int> GetNextMoves(int position, Piece[] pieces);
}
