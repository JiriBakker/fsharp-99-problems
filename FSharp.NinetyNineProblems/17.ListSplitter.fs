namespace FSharp.NinetyNineProblems

// https://johncrane.gitbooks.io/ninety-nine-elm-problems/content/p/p17.html

module ListSplitter =

    let private splitWithRecursion inputList splitAtIndex =
        let rec splitRec list1 list2 counter =
            match counter with
            | 0 -> (list1, list2)
            | _ -> 
                match list2 with 
                | [] -> (list1, list2)
                | [x] -> (list1 @ list2, [])
                | x::xs -> splitRec (list1 @ [x]) xs (counter - 1)

        let splitAtIndexSafe = min (max 0 splitAtIndex) (List.length inputList)
        splitRec [] inputList splitAtIndexSafe
    
    let private splitWithListFunctions inputList splitAtIndex =
        let splitAtIndexSafe = min (max 0 splitAtIndex) (List.length inputList)
        (
            inputList |> List.take splitAtIndexSafe,
            inputList |> List.skip splitAtIndexSafe
        )        

    let split inputList splitAtIndex =
        splitWithRecursion inputList splitAtIndex
        //splitWithListFunctions inputList splitAtIndex
