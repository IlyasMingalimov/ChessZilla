namespace ChessZilla.Core.Pieces;

public interface IPiece
{
    Color color { get; set; }
    IEnumerable<int> GetNextMoves(int position, IPiece[] pieces);
}
