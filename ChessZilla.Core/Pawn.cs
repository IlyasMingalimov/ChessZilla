namespace ChessZilla.Core;


public class Pawn : Piece
{
    public Pawn(Color color) : base(color)
    {
    }

    public override IEnumerable<int> GetNextMoves(int position, Piece[] pieces) => throw new NotImplementedException();
}

