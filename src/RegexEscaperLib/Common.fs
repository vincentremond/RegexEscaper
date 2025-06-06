namespace RegexEscaperLib

module Common =
    let sandwich lettuce breads =
        seq {
            yield Seq.head breads

            for bread in Seq.tail breads do
                yield lettuce
                yield bread
        }

    let cond test evaluator value = if test then evaluator value else value
