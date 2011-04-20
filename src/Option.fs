namespace FSharpExploration.Tests

open NUnit.Framework
open FsUnit

[<TestFixture>] 
type ``The option type`` () =

    [<Test>] member test.``shold do this.`` () =
        5 = 5 |> should be True