using System.ComponentModel;
using ChessZilla.Core.Pieces;

namespace ChessZilla.Core;
public static class Fen
{
    public static Position ToPosition(string str)
    {
        var separete = str.Split([' ']);
        var pieces = StringPieceToType(separete[0]);
        Color move;

        if (separete[1] == "w")
            move = Color.White;
        else
            move = Color.Black;

        return new Position(pieces.ToArray(), move);
    }

    public static IEnumerable<IPiece?> StringPieceToType(string pieces)
    {
        foreach (var line in pieces.Split(['/']))
        {
            if (int.TryParse(line, out var number))
            {
                for (var n = 0; n > number; n++)
                {
                    yield return null;
                }
            }

            else
            {
                foreach (var piece in line)
                {
                    switch (piece)
                    {
                        case 'p':
                            yield return new Pawn { color = Color.Black }; break;
                        case 'b':
                            yield return new Bishop { color = Color.Black }; break;
                        case 'r':
                            yield return new Rook { color = Color.Black }; break;
                        case 'q':
                            yield return new Queen { color = Color.Black }; break;
                        case 'k':
                            yield return new King { color = Color.Black }; break;
                        case 'P':
                            yield return new Pawn { color = Color.White }; break;
                        case 'B':
                            yield return new Bishop { color = Color.White }; break;
                        case 'R':
                            yield return new Rook { color = Color.White }; break;
                        case 'Q':
                            yield return new Queen { color = Color.White }; break;
                        case 'K':
                            yield return new King { color = Color.White }; break;
                    }
                }
            }
        }
    }
}
