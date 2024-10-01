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
        evaluation: float
        ``current move`` : Color
        preview : Position option
    }

module Engine =

    let ``set evaluation`` position =
        position

    let ``get next positions`` position = seq{
        yield ``set evaluation`` position
    }

    let rec ``get all move options`` position deep acc = seq{
        let nexts = ``get next positions`` position
        if deep >= acc then
            yield! nexts
        else
            for next in nexts do
                if next.evaluation = 100.0 then
                    yield next
                else if next.evaluation = -100.0 then
                    yield next
                else 
                    yield! ``get all move options`` next deep (acc + 1u)

    }

    let rec ``get first move`` position = 
        match position.preview with
            | Some(position) -> ``get first move`` position
            | None -> position

    let ``best move`` position deep =
        let options = ``get all move options`` position  deep 0u
        let ``best end`` =
            match position.``current move`` with
                | White -> 
                    options |> Seq.maxBy (fun p -> p.evaluation)
                | Black -> 
                    options |> Seq.minBy (fun p -> p.evaluation)

        ``get first move`` ``best end``
        
