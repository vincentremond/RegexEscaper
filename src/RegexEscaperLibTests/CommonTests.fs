module RegexEscaperLibTests.CommonTests

open NUnit.Framework
open FsUnit
open RegexEscaperLib

[<Test>]
let ``Conditional operator (true)`` () =
    "Bonjour"
    |> Common.cond true (sprintf "%s !")
    |> should equal "Bonjour !"

[<Test>]
let ``Conditional operator (false)`` () =
    "Bonjour"
    |> Common.cond false (sprintf "%s !")
    |> should equal "Bonjour"

[<Test>]
let ``Sandwich iterator`` () =
    Seq.init 5 (fun x -> x + 1)
    |> Common.sandwich 0
    |> Seq.toArray
    |> should equal [| 1; 0; 2; 0; 3; 0; 4; 0; 5 |]
