namespace FSharpExploration.Tests

open NUnit.Framework
open FsUnit
open System.Diagnostics

[<TestFixture>] 
type ``Recursion`` () =

    let maxStack = 1000

    let stackTrace () = 
        let stackTrace = new StackTrace()
        stackTrace.GetFrames().Length

    let CannotTCO =
        let rec run x =
            let result =  
                if x < maxStack then run (x + 1)
                else stackTrace ()
            result
        run 0

    let rec CanTCO =
        let rec run x =
            if x < maxStack then run (x + 1)
            else stackTrace ()
        run 0

    [<Test>] 
    member test.``Should not apply TCO.`` () =
        CannotTCO |> should beGreaterThan maxStack

    [<Test>] 
    member test.``Should apply TCO.`` () =
        CanTCO |> should beLessThan maxStack