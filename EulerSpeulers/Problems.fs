module Problems

open Basics

let Problem1 =
    [1..999] |> List.filter (fun x -> isMultipleOf x [3;5]) |> List.sum

let Problem2 =
    getFibonacciTermsUpTo [2;1] 4000000 |> List.filter (fun x -> x % 2 = 0) |> List.sum

let Problem5 = 
    let curriedIncrementBy20 = 20 |> incrementBy
    let curriedEvenlyDivisibleBy1through20 = [1..20] |> isEvenlyDivisibleByEach
    iterateAndEvaluate 20 curriedIncrementBy20 curriedEvenlyDivisibleBy1through20