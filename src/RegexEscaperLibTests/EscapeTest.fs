module RegexEscaperLibTests.EscapeTest

open NUnit.Framework
open FsUnit
open RegexEscaperLib

[<Test>]
[<TestCase(" Bonjour ", "^ Bonjour $")>]
[<TestCase("   Salut \n\r\t Nounou, tu es la meilleure !!!", "^[\\s\\t\\r\\n]+Salut[\\s\\t\\r\\n]+Nounou, tu es la meilleure !!!$")>]
[<TestCase("[GitLab](https://avp-gitlab.availpro.com/)", @"^\[GitLab\]\(https://avp-gitlab\.availpro\.com/\)$")>]
let ``Simple escape`` input expected =
    input |> RegexEscape.simpleEscape true
    |> should equal expected
