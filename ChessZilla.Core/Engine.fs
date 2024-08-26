namespace ChessZilla.Core

type Color = White | Black

type Piece =
    | King of Color
    | Queen of Color
    | Rook of Color
    | Bishop of Color
    | Knight of Color
    | Pawn of Color

type Position = 
    {
        color : Color
        pieces : Option<Piece> array2d
        evalation : float
    }

type CalculationTree =
    | Root of CalculationTree 
    | Leaf of Position

module Engine =

    let nextPositions (position : Position) (deep : int) : Position seq = seq{
        yield position
    }

    let Eval (position : Position) =
        position

    let calculation (position : Position) (deep : int) =
        position
        |> nextPositions <| deep
        |> Seq.map (fun p -> p |> Eval)
        |> Seq.maxBy (fun p -> p.evalation)
        
