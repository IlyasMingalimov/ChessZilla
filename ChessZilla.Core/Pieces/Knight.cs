﻿namespace ChessZilla.Core.Pieces;


public struct Knight : IPiece
{
    public Color color { get; set; }

    public IEnumerable<int> GetNextMoves(int position, IPiece[] pieces)
    {
        yield return 1;
    }
}
