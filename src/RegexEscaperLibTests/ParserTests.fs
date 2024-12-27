module RegexEscaperLibTests.ParserTests

open NUnit.Framework
open FsUnit
open RegexEscaperLib.RegexModifier

[<Test>]
let ``Parse 0`` () =
    let result = getRegexParts "abcdef" 0 0

    let expected = RegexParseResult.Failure { Message = "Selection is empty" }

    result |> should equal expected

[<Test>]
let ``Parse 1`` () =
    let result = getRegexParts "abcdefghij" 2 3

    let expected =
        RegexParseResult.Success {
            Before = "ab"
            Selected = "cde"
            After = @"fghij"
        }

    result |> should equal expected

[<Test>]
let ``Full replacement no match`` () =
    let result = substitute "^abcdefghij$" 2 3 ".." (Some "GroupName") "abcdefghij"

    let expected =
        SubstitutionResult.Failure { Message = "Substitution “..” doesn't match “bcd”." }

    result |> should equal expected

[<Test>]
let ``Full replacement with group`` () =
    let result = substitute "^abcdefghij$" 2 3 ".+" (Some "GroupName") "abcdefghij"

    let expected = SubstitutionResult.Success { NewRegex = "^a(?<GroupName>.+)efghij$" }

    result |> should equal expected

[<Test>]
let ``Full replacement without group`` () =
    let result = substitute "^abcdefghij$" 2 3 ".+" (None) "abcdefghij"

    let expected = SubstitutionResult.Success { NewRegex = "^a(.+)efghij$" }

    result |> should equal expected

()
