namespace ChessZilla.Core;

public class Bishop : Piece
{
    public Bishop(Color color) : base(color)
    {
    }

    public override IEnumerable<int> GetNextMoves(int position, Piece[] pieces) => throw new NotImplementedException();
}

