// For more information see https://aka.ms/fsharp-console-apps



let trimSpaces (inputList: string list) =
    inputList |> List.map (fun s -> s.Trim())


let namesWithSpaces = [" Charles"; "Babbage  "; "  Von Neumann  "; "  Dennis Ritchie  "]

let trimmedNames = trimSpaces namesWithSpaces

trimmedNames |> List.iter (printfn "%s")









