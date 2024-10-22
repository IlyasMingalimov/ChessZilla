namespace ChessZilla.Core.Pieces;


public struct Queen : IPiece
{
    public Color color { get; set; }

    public IEnumerable<int> GetNextMoves(int position, IPiece[] pieces)
    {
        yield return 1;
    }
}

