namespace FSharpExploration

open NUnit.Framework
open FsUnit
open Microsoft.FSharp.Math.SI

[<TestFixture>] 
type ``Units of Measure`` () =

    [<Test>] 
    member test.``Should Multiply Time And Distance.`` () =
        5.0<s> * 10.0<m> |> should equal 50.0
