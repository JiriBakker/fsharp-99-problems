namespace FSharp.NinetyNineProblems

// https://johncrane.gitbooks.io/ninety-nine-elm-problems/content/p/p19.html

module ListRotator =

    let rotate inputList rotateAtIndex =
        let listLength = List.length inputList
        
        let rec makeIndexSafe index =
            match index with
            | x when x >= 0 -> x % (max 1 listLength)
            | _             -> makeIndexSafe (index + listLength)

        let rotateAtIndexSafe = makeIndexSafe rotateAtIndex

        let rotateWithRecursion =
            let rec rotateRec inputList counter =
                match counter with
                | 0 -> inputList
                | _ -> 
                    match inputList with
                    | []    -> []
                    | x::xs -> rotateRec (xs @ [x]) (counter - 1)

            rotateRec inputList rotateAtIndexSafe

        let rotateWithListFunctions =
            (inputList |> List.skip rotateAtIndexSafe)
            @
            (inputList |> List.take rotateAtIndexSafe)        

    
        rotateWithRecursion
        //rotateWithListFunctions