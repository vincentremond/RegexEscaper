namespace RegexEscaperLib

open System.Text.RegularExpressions

module RegexEscape =

    type private SpecialReplace = {
        Pattern: Regex
        Replacement: string
    }

    type private SplitPart =
        | Escaped of string
        | Raw of string

    let private explodeAsParts (replacements: SpecialReplace list) (parts: seq<SplitPart>) : seq<SplitPart> =

        let explodeAsParts' (replacement: SpecialReplace) (str: string) : seq<SplitPart> =
            replacement.Pattern.Split(str)
            |> Seq.map (fun x -> Raw x)
            |> Common.sandwich (Escaped replacement.Replacement)

        let rec temp h parts =
            seq {
                for part in parts do
                    match part with
                    | Escaped e -> yield Escaped e
                    | Raw r -> yield! explodeAsParts' h r
            }

        let rec explodeAsParts'' (replacements: SpecialReplace list) (parts: seq<SplitPart>) : seq<SplitPart> =
            match replacements with
            | head :: tail -> explodeAsParts'' tail (temp head parts)
            | [] -> parts

        explodeAsParts'' replacements parts

    let private renderPart part =
        match part with
        | Escaped e -> e
        | Raw r -> Regex.Escape r

    let simpleEscape fullMatch originalText =
        let replacements = [
            {
                Pattern = Regex "[\\s\\t\\r\\n]{2,}"
                Replacement = "[\\s\\t\\r\\n]+"
            }
            {
                Pattern = Regex @"\]"
                Replacement = @"\]"
            }
            {
                Pattern = Regex @"\)"
                Replacement = @"\)"
            }
            {
                Pattern = Regex @"\}"
                Replacement = @"\}"
            }
            {
                Pattern = Regex " "
                Replacement = " "
            }
        ]

        let x = explodeAsParts replacements [| Raw originalText |]

        x
        |> Seq.map renderPart
        |> String.concat ""
        |> Common.cond fullMatch (sprintf "^%s$")
