namespace ChessZilla.Core;


public class King : Piece
{
    public King(Color color) : base(color)
    {
    }

    public override IEnumerable<int> GetNextMoves(int position, Piece[] pieces) => throw new NotImplementedException();
}