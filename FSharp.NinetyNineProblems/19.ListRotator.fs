namespace FSharp.NinetyNineProblems

// https://johncrane.gitbooks.io/ninety-nine-elm-problems/content/p/p19.html

module ListRotatorInefficient =

    let private rotateWithRecursion inputList rotateAtIndex =
        let rec rotateRec inputList counter =
            match counter with
            | 0 -> inputList
            | _ -> 
                match inputList with
                | []    -> []
                | [x]   -> [x]
                | x::xs -> rotateRec (xs @ [x]) (counter - 1)

        let rec safeIndex index =
            match index with
            | x when x >= 0 -> x
            | x -> safeIndex (index + (List.length inputList))

        rotateRec inputList (safeIndex rotateAtIndex)

    let private rotateWithListFunctions inputList rotateAtIndex =
        let listLength = List.length inputList

        let rec safeIndex index =
            match index with
            | x when x >= 0 -> x % listLength
            | x -> safeIndex (index + listLength)

        let rotateAtIndexSafe = safeIndex rotateAtIndex

        (inputList |> List.skip rotateAtIndexSafe)
        @
        (inputList |> List.take rotateAtIndexSafe)
        

    let rotate inputList rotateAtIndex =
        //rotateWithRecursion inputList rotateAtIndex
        rotateWithListFunctions inputList rotateAtIndex