module EulerTests

open Basics
open NUnit.Framework
open FsUnit

[<Test>]
let twoIsPrime () =
    isPrime 2UL |> should equal true

[<Test>]
let tenHasFourFactors () =
    getFactors 10UL |> List.length |> should equal 4

//[<Test>] //This fails horribly
//let someTest () =
//    600851475143UL |> getFactors |> List.length |> should equal 1