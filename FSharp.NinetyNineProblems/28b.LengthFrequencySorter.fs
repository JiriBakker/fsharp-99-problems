namespace FSharp.NinetyNineProblems

// https://johncrane.gitbooks.io/ninety-nine-elm-problems/content/p/p28b.html

module LengthFrequencySorter =    

    let sortByLengthFrequency (input:'a list list) =
        input
        |> List.groupBy (fun sublist -> sublist.Length)
        |> List.sortBy  (fun (key, sublists) -> sublists.Length)
        |> List.collect (fun (key, sublists) -> List.replicate sublists.Length key)
