namespace ChessZilla.Core;


public class Knight : Piece
{
    public Knight(Color color) : base(color)
    {
    }

    public override IEnumerable<int> GetNextMoves(int position, Piece[] pieces) => throw new NotImplementedException();
}

