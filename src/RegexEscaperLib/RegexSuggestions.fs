module RegexEscaperLib.RegexSuggestions

open System.Text.RegularExpressions

type SuggestionItem = { Regex: string; Replacement: string }

// 02/03/2021

let private regs =
    [|
        (@"public (?<FieldType>\S+) (?<FieldName>\S+) \{ get; set; \}", "public readonly ${FieldType} ${FieldName};", "", "")
        (@"(?<Day>\d\d)/(?<Month>\d\d)/(?<Year>\d\d\d\d)", "${Year}-${Month}-${Day}", "", "")
        (@"\d\d\d\d", "", "", "")
        (@"\d\d", "", "", "")
        (@"\d+", "", "", "")
        (".+?", "", "", "")
        (".+", "", "", "")
        (".*", "", "", "")
        ("%(?<VariableName>.+?)%", "$$${VariableName}", "%CI_JOB_TOKEN%", "$CI_JOB_TOKEN")
        ("[0-9A-Fa-f]{8}[-][0-9A-Fa-f]{4}[-][0-9A-Fa-f]{4}[-][0-9A-Fa-f]{4}[-][0-9A-Fa-f]{12}", "", "c70b0839-56f4-46c7-9871-46ec8d9cdbb1", "")
    |]
    |> Array.map (fun (regex, replacement, sampleInput, sampleReplaced) -> (regex, replacement, new Regex(regex, RegexOptions.Compiled)))

let get (input: string): SuggestionItem array =
    regs
    |> Seq.filter (fun (_, _, r) -> r.IsMatch(input))
    |> Seq.map (fun (s, r, _) -> { Regex = s; Replacement = r })
    |> Seq.toArray
