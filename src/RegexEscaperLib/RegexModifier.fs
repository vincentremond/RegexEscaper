namespace RegexEscaperLib

open System.Text.RegularExpressions

module RegexModifier =
    type GenericFailure = { Message: string }

    type ParseSuccess =
        { Before: string
          Selected: string
          After: string }

    type SubstitutionSuccess = { NewRegex: string }

    type RegexParseResult =
        | Success of ParseSuccess
        | Failure of GenericFailure

    type SubstitutionResult =
        | Success of SubstitutionSuccess
        | Failure of GenericFailure

    let internal getRegexParts (originalRegex: string) (startIndex: int) (selectionLength: int): RegexParseResult =
        if selectionLength = 0 then
            RegexParseResult.Failure { Message = "Selection is empty" }
        else
            let before = originalRegex.Substring(0, startIndex)

            let selected =
                originalRegex.Substring(startIndex, selectionLength)

            let after =
                originalRegex.Substring(startIndex + selectionLength)

            RegexParseResult.Success
                { Before = before
                  Selected = selected
                  After = after }

    let private tryGetNewRegex (parseResult: ParseSuccess) (replacement: string) (groupName: string option) (sampleValue: string): SubstitutionResult =
        let unescaped = Regex.Unescape(parseResult.Selected)
        let tempRegex = sprintf "^%s$" replacement
        let matchResult = Regex(tempRegex).Match(unescaped)
        if not matchResult.Success then
            SubstitutionResult.Failure { Message = sprintf "Substitution “%s” doesn't match “%s”." replacement unescaped }
        else

            let group =
                match groupName with
                | Some (x) -> (sprintf "(?<%s>%s)" x replacement)
                | None -> (sprintf "(%s)" replacement)

            let newRegex =
                sprintf "%s%s%s" parseResult.Before group parseResult.After

            if Regex.IsMatch(sampleValue, newRegex) then
                SubstitutionResult.Success { NewRegex = newRegex }
            else
                SubstitutionResult.Failure
                    { Message =
                          sprintf "Hum something unexpected happened, the final value does not match\nSample value : %s\nNew regex : %s" sampleValue newRegex }

    let substitute (originalRegex: string)
                   (startIndex: int)
                   (selectionLength: int)
                   (replacement: string)
                   (groupName: string option)
                   (sampleValue: string)
                   : SubstitutionResult =
        let parsed =
            getRegexParts originalRegex startIndex selectionLength

        match parsed with
        | RegexParseResult.Success s -> tryGetNewRegex s replacement groupName sampleValue
        | RegexParseResult.Failure f -> SubstitutionResult.Failure { Message = f.Message }
