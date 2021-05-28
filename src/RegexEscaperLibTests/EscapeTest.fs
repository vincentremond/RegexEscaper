module RegexEscaperLibTests.EscapeTest

open NUnit.Framework
open FsUnit
open RegexEscaperLib

[<Test>]
let ``Simple escape`` () =
    " Bonjour " |> RegexEscape.simpleEscape true
    |> should equal "^ Bonjour $"

[<Test>]
let ``Text escape`` () =
    "   Salut \n\r\t Nounou, tu es la meilleure !!!" |> RegexEscape.simpleEscape true
    |> should equal "^[\\s\\t\\r\\n]+Salut[\\s\\t\\r\\n]+Nounou, tu es la meilleure !!!$"
