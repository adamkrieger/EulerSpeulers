module Basics

let isMultipleOf x possibleFactors =
    possibleFactors |> List.exists (fun n -> x % n = 0)

let rec getFibonacciTermsUpTo (current:int list) x =
    let next = current.[0] + current.[1]
    match next >= x with
        | true -> current
        | false -> getFibonacciTermsUpTo (next :: current) x