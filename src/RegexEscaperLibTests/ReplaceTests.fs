module RegexEscaperLibTests.ReplaceTests

open NUnit.Framework
open FsUnit
open RegexEscaperLib

[<Test>]
let ``Simple escape`` () =
    let input =
        @" Profile image for : Vincent Rémond vremond@d-edge.com Member Sep 9, 2019"

    let regex =
        " ([\\w+\\s]+ :) (?<Name>.+?)[\\s\\t\\r\\n]+(?<Email>\\w+@d-edge\\.com)[\\s\\t\\r\\n]+(?<Role>.+?)[\\s\\t\\r\\n]+(?<EntryDate>.+?\\d\\d\\d\\d)"

    let replacement = @"""${Name}"" <${Email}>"

    ReplacementConverter.visualStudioCode input regex replacement
    |> should equal @"""$2"" <$3>"
