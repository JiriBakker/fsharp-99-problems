namespace FSharp.NinetyNineProblems

// https://johncrane.gitbooks.io/ninety-nine-elm-problems/content/p/p20.html

module ItemRemover =
    
    let rec dropAtWithRecursion inputList dropAtIndex =
        match dropAtIndex with
        | 0 -> List.tail inputList
        | _ ->
            match inputList with
            | [] -> []
            | [x] -> [x]
            | x::xs -> x :: dropAtWithRecursion xs (dropAtIndex - 1)

    let private dropAtWithListFunctions inputList dropAtIndex =
        let safeIndex index = 
            min (List.length inputList) (max 0 index)

        (inputList |> List.take (safeIndex (dropAtIndex - 1)))
        @ (inputList |> List.skip (safeIndex dropAtIndex))

    let dropAt inputList dropAtIndex =
        dropAtWithRecursion inputList (dropAtIndex - 1)
        //dropAtWithListFunctions inputList dropAtIndex
