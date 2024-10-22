namespace ChessZilla.Core.Pieces;


public struct King : IPiece
{
    public Color color { get; set; }

    public IEnumerable<int> GetNextMoves(int position, IPiece[] pieces)
    {
        yield return 1;
    }
}