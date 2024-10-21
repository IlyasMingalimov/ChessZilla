open ChessZilla.Core.Engine
open ChessZilla.Core.Fen

[<EntryPoint>]
let main args =
    let position = string_to_position "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1"
    let result = best_move position 3
    printfn "%O" (position_to_string result)
    0