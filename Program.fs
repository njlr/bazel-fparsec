open FParsec

let pNumberwang : Parser<string, unit> =
  pstring "numberwang"

[<EntryPoint>]
let main argv =
  let input = String.concat " " argv
  let result = run pNumberwang input

  printfn "%A" result

  match result with
  | Success (_, _, _) -> 0
  | _ -> 1
