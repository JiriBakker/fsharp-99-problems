namespace FSharp.NinetyNineProblems

// https://johncrane.gitbooks.io/ninety-nine-elm-problems/content/p/p04.html

module ListLength =

    let rec private countRec inputList runningTotal =
        match inputList with
        | [] -> runningTotal
        | x::xs -> countRec xs (runningTotal + 1)

    let countElements inputList = 
        countRec inputList 0