namespace FSharp.NinetyNineProblems

// https://johncrane.gitbooks.io/ninety-nine-elm-problems/content/p/p25.html

module RandomPermutation =

    let private rnd = System.Random()

    let rec private randomPermutationRec inputList outputList =
        match inputList with
        | [] -> outputList
        | x::xs ->  randomPermutationRec xs (ItemInserter.insertAt outputList (rnd.Next(0, (ListLength.countElements outputList))) x)

    let randomPermutation inputList = 
        randomPermutationRec inputList []

        
        