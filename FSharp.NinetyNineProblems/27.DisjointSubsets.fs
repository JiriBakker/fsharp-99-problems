namespace FSharp.NinetyNineProblems

// https://johncrane.gitbooks.io/ninety-nine-elm-problems/content/p/p27.html

module DisjointSubsets =    

    let rec getPermutations maxSize (initial:'a list) (remaining:'a list) =
        match maxSize with
        | 0 -> [initial]
        | _ when maxSize > remaining.Length -> []
        | _ -> List.mapFoldBack (fun item acc -> ((getPermutations (maxSize - 1) (item :: initial) acc), item :: acc)) remaining [] 
               |> (fun (perms, acc) -> List.concat perms)
    

    let group divisions (inputList:'a list) = 
        getPermutations 2 [] inputList
        |> List.map (fun set -> (set, (List.except set inputList)))
        |> List.collect (fun (set, allExcept) -> (getPermutations 2 [] allExcept) |> List.map (fun secondSet -> [set; secondSet; (List.except secondSet allExcept)]))

                