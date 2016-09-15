namespace FSharp.NinetyNineProblems

// https://johncrane.gitbooks.io/ninety-nine-elm-problems/content/p/p27.html

module DisjointSubsets =    

    let rec getPermutations maxSize initial (remaining:'a list) =
        match maxSize with
        | 0                                 -> [initial]
        | _ when maxSize > remaining.Length -> []
        | _                                 -> List.mapFoldBack (fun item acc -> ((getPermutations (maxSize - 1) (item :: initial) acc), item :: acc)) remaining [] 
                                               |> fst |> List.concat    

    let group divisions inputList =
        let inputListExcept except = 
            List.except (List.concat except) inputList

        divisions
        |> List.fold 
            (fun acc division -> 
                acc
                |> List.collect
                    (fun existingSubsets -> 
                        getPermutations division [] (inputListExcept existingSubsets)
                        |> List.map (fun generatedSubset -> generatedSubset :: existingSubsets)
                    )
            )
            [[]]
