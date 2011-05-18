#light "off"

namespace FSharpExploration

open NUnit.Framework
open FsUnit

[<TestFixture>] 
type ``Verbose Syntax`` () =
class

    [<Test>] 
    member test.``Demonstrate Value Binding Scope.`` () =
        let planckConstant = 
        (
            // This is really just an expression. When its 
            // a value its just a simple expression.
            let x = 6.0 in (); 
            x + 0.62
        )
        in 
        ( 
            planckConstant |> should equal 6.62;
            // Shadowing does not effect outer scope
            let planckConstant = 999.0 in ();
            planckConstant |> should equal 999.0;
        );
        planckConstant |> should equal 6.62;

    [<Test>] 
    member test.``Demonstrate Value Binding And Explicit Scope.`` () =
        let planckConstant = 
        (
            let x = 6.0 in (); 
            x + 0.62
        ) in ();
        ( 
            planckConstant |> should equal 6.62;
            // Shadowing does not effect outer scope
            let planckConstant = 999.0 in ();
            planckConstant |> should equal 999.0;
        );
        planckConstant |> should equal 6.62;

    [<Test>] 
    member test.``Demonstrate Function Binding Scope.`` () =
        let log n = 
        (
            let e = 2.718281828 in ();
            e ** n;
        ) 
        in
        ( 
            log 2.0 |> should equal 7.3890560964350209;
            // Shadowing does not effect outer scope
            let log n = 0 in ();
            log 10 |> should equal 0;
        );
        log 2.0 |> should equal 7.3890560964350209;
end