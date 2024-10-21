namespace ChessZilla.Core;

public class Position
{
    public Piece?[] Pieces = new Piece[64];

    public Position(Piece[] pieces)
    {
        Pieces = pieces;
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
                foreach(var m in moves) 
                {
                    var newPieces = new Piece[64];
                    Pieces.CopyTo(newPieces.AsSpan());
                    newPieces[count] = null!;
                    newPieces[m] = piece;
                    yield return new Position(newPieces);
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
            }
        }
    }
}
