namespace FSharp.NinetyNineProblems

// https://johncrane.gitbooks.io/ninety-nine-elm-problems/content/p/p21.html

module ItemInserter =
   
    let private insertAtWithRecursion inputList insertAtIndex itemToInsert =
        let rec insertAtRec inputList counter =
            match counter with
            | 0 -> itemToInsert :: inputList
            | _ -> 
                match inputList with
                | []    -> [itemToInsert]
                | [x]   -> [x; itemToInsert]
                | x::xs -> x :: (insertAtRec xs (counter - 1))

        let safeIndex = (min (List.length inputList) (max 0 (insertAtIndex - 1)))
        insertAtRec inputList safeIndex

    let private insertAtWithListFunctions inputList insertAtIndex itemToInsert =
        let safeIndex = (min (List.length inputList) (max 0 (insertAtIndex - 1)))
        (inputList |> List.take safeIndex)
        @ [itemToInsert]
        @ (inputList |> List.skip safeIndex)

    let insertAt inputList insertAtIndex itemToInsert =
        insertAtWithRecursion inputList insertAtIndex itemToInsert
        // insertAtWithListFunctions inputList insertAtIndex itemToInsert
