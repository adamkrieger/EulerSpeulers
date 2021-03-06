﻿module Basics

let isPrime x =
    [1UL..x] |> List.filter (fun y -> x % y = 0UL) |> fun z -> z.Length = 2

let isMultipleOf x possibleFactors =
    possibleFactors |> List.exists (fun n -> x % n = 0)

let rec getFibonacciTermsUpTo (current:int list) x =
    let next = current.[0] + current.[1]
    match next >= x with
        | true -> current
        | false -> getFibonacciTermsUpTo (next :: current) x

let getFactors x =
    [1UL..x] |> List.filter (fun y -> x % y = 0UL)

let incrementBy y x =
    x + y

let isEvenlyDivisibleByEach set x =
    set |> List.forall (fun n -> x % n = 0)

let rec iterateAndEvaluate initial iterator evaluator =
    let next = iterator <| initial
    match next |> evaluator with
        | true -> next
        | false -> iterateAndEvaluate next iterator evaluator