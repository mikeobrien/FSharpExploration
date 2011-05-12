namespace FSharpExploration.Tests

open NUnit.Framework
open FsUnit

type Volume =
    | Liters of int
    | Gallons of int

[<TestFixture>] 
type ``Discrimintated Unions`` () =

    [<Test>] 
    member test.``Should Be 5 Gallons.`` () =
        match Gallons(5) with
            | Gallons(n) -> n
            | _ -> 0
        |> should equal 5

    [<Test>] 
    member test.``Should Be 20 Liters.`` () =
        match Liters(20) with
            | Liters(n) -> n
            | _ -> 0
        |> should equal 20

