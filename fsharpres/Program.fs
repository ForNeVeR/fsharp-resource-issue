open System.Reflection

[<EntryPoint>]
let main _ =
    Assembly.GetExecutingAssembly().GetManifestResourceNames()
    |> Array.iter (printfn "%s")
    0
