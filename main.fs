open System

let lines = IO.File.ReadLines "./words.txt"
let l2 = Seq.toList lines

[<EntryPoint>]
let main argv =
    printfn "%s" l2.[4]
    0
