namespace FSharpExploration.Tests

open NUnit.Framework
open FsUnit

[<TestFixture>] 
type ``Pattern Matching`` () =

    [<Test>] 
    member test.``Should Be Some Name.`` () =
        match Some("Yakov") with
            | Some(name) -> name
            | _ -> null
        |> should equal "Yakov"

    [<Test>] 
    member test.``Should Be Some Name Greater Than 3 Chars.`` () =
        match Some("Yakov") with
            | Some(name) when name.Length > 3 -> name
            | _ -> null
        |> should equal "Yakov"

    [<Test>] 
    member test.``Should Be Some Nested Some Name And None.`` () =
        match Some((Some("Yakov"), None)) with
            | Some(Some(name), None) -> name
            | _ -> null
        |> should equal "Yakov"


