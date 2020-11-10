namespace RegexEscaperLib

module Common =
    let cond test evaluator value = if test then evaluator value else value
