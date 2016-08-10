namespace FSharp.NinetyNineProblems

// https://johncrane.gitbooks.io/ninety-nine-elm-problems/content/p/p17.html

module Sublist =

    let sublist inputList startFromItem endAtItem =
        inputList
        |> List.skip (startFromItem - 1)
        |> List.take (endAtItem - startFromItem + 1)