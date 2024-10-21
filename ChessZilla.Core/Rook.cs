namespace ChessZilla.Core;


public class Rook : Piece
{
    public Rook(Color color) : base(color)
    {
    }

    public override IEnumerable<int> GetNextMoves(int position, Piece[] pieces) => throw new NotImplementedException();
}

