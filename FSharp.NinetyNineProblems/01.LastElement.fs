namespace FSharp.NinetyNineProblems

// https://johncrane.gitbooks.io/ninety-nine-elm-problems/content/p/p01.html

module LastElement =

    let rec last (inputList:'a list) = 
        match inputList with
        | []    -> None
        | [x]   -> Some(x)
        | x::xs -> last xs