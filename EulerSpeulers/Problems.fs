module Problems

open Basics

let isMultipleOf x possibleFactors =
    possibleFactors |> List.exists (fun n -> x % n = 0)
        
let valueIfMultipleOf x possibleFactors =
    match isMultipleOf x possibleFactors with
        | true -> x
        | false -> 0

let Problem1 =
    [1..999] |> List.map (fun x -> valueIfMultipleOf x [3;5]) |> List.sum
    