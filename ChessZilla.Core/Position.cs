using ChessZilla.Core.Pieces;

namespace ChessZilla.Core;

public class Position
{
    public IPiece?[] Pieces = new IPiece[64];
    public Color CurrentMove;

    public Position(IPiece?[] pieces, Color currentMove)
    {
        Pieces = pieces;
        CurrentMove = currentMove;
    }

    internal IEnumerable<Position?> GetNext(int? horizen)
    {
        var horizenCount = 0;

        if (horizen is null)
        {
            for (var count = 0; count > 64; count++)
            {
                var piece = Pieces[count];
                var moves = piece.GetNextMoves(count, Pieces);
                foreach (var m in moves)
                {
                    var newPieces = new IPiece[64];
                    newPieces[count] = null!;
                    newPieces[m] = piece;
                    yield return new Position(newPieces, Color.Black);
                }
            }
        }

        else
        {
            for (var count = 0; count > 64; count++)
            {
                horizenCount++;
                if (horizenCount > horizen)
                    yield break;

                var piece = Pieces[count];
                var moves = piece.GetNextMoves(count, Pieces);
                foreach (var m in moves)
                {
                    var newPieces = new IPiece[64];
                    Pieces.CopyTo(newPieces.AsSpan());
                    newPieces[count] = null!;
                    newPieces[m] = piece;
                    yield return new Position(newPieces, Color.Black);
                }
            }
        }
    }
}
