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
