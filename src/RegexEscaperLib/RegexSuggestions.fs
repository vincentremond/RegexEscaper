module RegexEscaperLib.RegexSuggestions

open System
open System.IO
open System.Text.RegularExpressions

type SuggestionItem = {
    Name: string
    Regex: string
    Replacement: string
}

type Sample = {
    Input: string
    Output: string
}

type Replacement = {
    Replacement: string
    Samples: Sample array
}

type RegexDescription = {
    Name: string
    Regex: string
    Examples: string array
    Replacements: Replacement array
}

// 02/03/2021

let private RegList = [
    {
        Name = "C# Property"
        Regex = @"public (?<FieldType>.+) (?<FieldName>\S+) \{ get; set; \}"
        Examples = [| "public Guid Id { get; set; }" |]
        Replacements = [|
            {
                Replacement = "public readonly ${FieldType} ${FieldName};"
                Samples = [|
                    {
                        Input = "public string Bonjour { get; set; }"
                        Output = "public readonly string Bonjour;"
                    }
                |]
            }
            {
                Replacement = "${FieldType} ${FieldName},"
                Samples = [|
                    {
                        Input = "public string Bonjour { get; set; }"
                        Output = "string Bonjour,"
                    }
                |]
            }
        |]
    }
    {
        Name = "French date"
        Regex = @"(?<Day>\d\d)/(?<Month>\d\d)/(?<Year>\d\d\d\d)"
        Examples = [||]
        Replacements = [|
            {
                Replacement = "${Year}-${Month}-${Day}"
                Samples = [|
                    {
                        Input = "30/12/1986"
                        Output = "1986-12-30"
                    }
                |]
            }
        |]
    }
    {
        Name = "Sortable date"
        Regex = @"\d\d\d\d-\d\d-\d\d"
        Examples = [| "1991-04-14" |]
        Replacements = [||]
    }
    {
        Name = "Sortable date (named)"
        Regex = @"(?<Year>\d\d\d\d)-(?<Month>\d\d)-(?<Day>\d\d)"
        Examples = [| "1991-04-14" |]
        Replacements = [||]
    }
    {
        Name = "4 digits number"
        Regex = @"\d\d\d\d"
        Examples = [| "1991" |]
        Replacements = [||]
    }
    {
        Name = "2 digits number"
        Regex = @"\d\d"
        Examples = [| "12" |]
        Replacements = [||]
    }
    {
        Name = "Infinite digits number"
        Regex = @"\d+"
        Examples = [| "12358" |]
        Replacements = [||]
    }
    {
        Name = "Wildcard 1"
        Regex = @".+?"
        Examples = [| "Bonjour" |]
        Replacements = [||]
    }
    {
        Name = "Wildcard 2"
        Regex = @".+"
        Examples = [| "Bonjour" |]
        Replacements = [||]
    }
    {
        Name = "Wildcard 3"
        Regex = @".*?"
        Examples = [| "Bonjour" |]
        Replacements = [||]
    }
    {
        Name = "Wildcard 4"
        Regex = @".*"
        Examples = [|
            ""
            "Bonjour"
        |]
        Replacements = [||]
    }
    {
        Name = "Migrate CMD variable to Powershell variable"
        Regex = "%(?<VariableName>.+?)%"
        Examples = [||]
        Replacements = [|
            {
                Replacement = "$$${VariableName}"
                Samples = [|
                    {
                        Input = "%CI_JOB_TOKEN%"
                        Output = "$CI_JOB_TOKEN"
                    }
                |]
            }
        |]
    }
    {
        Name = "Guid"
        Regex = "[0-9A-Fa-f]{8}[-][0-9A-Fa-f]{4}[-][0-9A-Fa-f]{4}[-][0-9A-Fa-f]{4}[-][0-9A-Fa-f]{12}"
        Examples = [| "c70b0839-56f4-46c7-9871-46ec8d9cdbb1" |]
        Replacements = [||]
    }
]

let checkList () =
    for regexDescription in RegList do
        let regexObject = Regex(regexDescription.Regex)

        if
            Array.isEmpty regexDescription.Examples
            && Array.isEmpty regexDescription.Replacements
            && Array.isEmpty regexDescription.Replacements.[0].Samples
        then
            raise (Exception $"Error on “{regexDescription.Name}” : it should have examples or replacements")

        for example in regexDescription.Examples do
            if false = regexObject.IsMatch(example) then
                raise (
                    Exception
                        $"Error on “{regexDescription.Name}” : “{regexDescription.Regex}” does not match “{example}”"
                )

        for replacement in regexDescription.Replacements do
            for sample in replacement.Samples do
                let replaced = regexObject.Replace(sample.Input, replacement.Replacement)

                if false = String.Equals(replaced, sample.Output) then
                    raise (
                        Exception
                            $"Error on “{regexDescription.Name}” : “{regexDescription.Regex}” replacement “{replacement.Replacement}” on “{sample.Input}” does not match “{sample.Output}” but was “{replaced}”"
                    )

let private regs =
    checkList ()

    let WriteToYaml () =
        let xx = YamlDotNet.Serialization.Serializer()
        use writer = new StreamWriter("test.yaml")
        xx.Serialize(writer, RegList)
    //    WriteToYaml()

    RegList
    |> Seq.map (fun regexSample ->
        let fromReg r =
            (regexSample.Name, regexSample.Regex, r, Regex(regexSample.Regex, RegexOptions.Compiled))

        match regexSample.Replacements with
        | [||] -> Seq.singleton (fromReg String.Empty)
        | _ -> regexSample.Replacements |> Seq.map (fun r -> r.Replacement) |> Seq.map fromReg
    )
    |> Seq.concat
    |> Seq.toArray

let get (input: string) : SuggestionItem array =
    let filter =
        regs |> Seq.filter (fun (_, _, _, r) -> r.IsMatch(input)) |> Seq.toArray

    filter
    |> Seq.map (fun (n, s, r, _) -> {
        Name = n
        Regex = s
        Replacement = r
    })
    |> Seq.toArray
