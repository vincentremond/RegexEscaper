module RegexEscaperLibTests.TestRegexGroups

open NUnit.Framework
open FsUnit
open System.Text.RegularExpressions

[<Test>]
let ``Simple test`` () =
    let input = "02/03/2021"

    let pattern = @"((?<Day>\d\d)/(?<Month>\d\d)/(?<Year>\d\d(\d\d)))"

    let replace = "${Year}-${Month}-${Day}"
    let zematch = Regex.Match(input, pattern)

    let parseInt (i: string) =
        match System.Int32.TryParse i with
        | true, out -> true
        | false, _ -> false

    let r =
        zematch.Groups
        |> Seq.mapi (fun i g -> (i, g))
        |> Seq.skip 1
        |> Seq.filter (fun (i, g) -> g.Name |> parseInt |> not)
        |> Seq.toArray

    zematch |> should equal 1
