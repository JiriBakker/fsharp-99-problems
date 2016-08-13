namespace FSharp.NinetyNineProblems

// https://johncrane.gitbooks.io/ninety-nine-elm-problems/content/p/p05.html

module Reverse =

    let rec private myReverseRec inputList outputList =
        match inputList with
        | [] -> outputList
        | x::xs -> myReverseRec xs (x::outputList)

    let myReverse inputList = 
        myReverseRec inputList []