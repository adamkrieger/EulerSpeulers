// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

open Problems

[<EntryPoint>]
let main argv = 
    printfn "%A" argv

    printfn "%A" Problem1

    let result = System.Console.ReadKey();
    
    0 // return an integer exit code
