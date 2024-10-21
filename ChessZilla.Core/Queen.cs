namespace ChessZilla.Core;


public class Queen : Piece
{
    public Queen(Color color) : base(color)
    {
    }

    public override IEnumerable<int> GetNextMoves(int position, Piece[] pieces) => throw new NotImplementedException();
}

