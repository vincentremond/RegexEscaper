module RegexEscaperLibTests.RegexSuggestionsTest

open NUnit.Framework
open RegexEscaperLib
open FsUnit

[<Test>]
let ``Check list`` () =
    RegexSuggestions.checkList () |> should equal ()
