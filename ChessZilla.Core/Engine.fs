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
        ``current move`` : Color
        Pieces : Piece option seq
    }

module Engine =
        
        let next_positions postion = seq{
            yield postion
        }

        let eval_position position =
            position, 1.0

        let best_move start_position deep =

            let accum : Position seq = list.Empty

            for move_count in [1..deep] do
                let nexts = next_positions start_position
                let eval_nexts = nexts |> Seq.map (fun x -> eval_position x)
                let max = eval_nexts |> Seq.maxBy (fun (_,eval) -> eval)
                printfn "%O" max
            start_position


module Fen =
    let string_piece_to_type (pieces: string) = seq{
        for line in pieces.Split [|'/'|] do
            match System.Int32.TryParse line with
            | true, int -> yield! seq { for i in 1..int -> None }
            | _ ->
                for piece in line do
                    match piece with
                        | 'p' -> yield Some(Pawn(Black))
                        | 'n' -> yield Some(Knight(Black))
                        | 'b' -> yield Some(Bishop(Black))
                        | 'r' -> yield Some(Rook(Black))
                        | 'q' -> yield Some(Queen(Black))
                        | 'k' -> yield Some(King(Black))
                        | 'P' -> yield Some(Pawn(White))
                        | 'N' -> yield Some(Knight(White))
                        | 'B' -> yield Some(Bishop(White))
                        | 'R' -> yield Some(Rook(White))
                        | 'Q' -> yield Some(Queen(White))
                        | 'K' -> yield Some(King(White))
                        | _ -> yield None
    }

    let string_to_position (str: string) =
        let separete = str.Split [|' '|]
        let pieces = string_piece_to_type separete[0]
        let move = match separete[1] with |"w" -> White |_ -> Black     
        {
            ``current move`` = move
            Pieces = pieces
        }

    let position_to_string (position : Position) =
        let mutable result = ""
        ""