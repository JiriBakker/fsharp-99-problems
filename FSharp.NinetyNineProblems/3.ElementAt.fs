namespace FSharp.NinetyNineProblems

// https://johncrane.gitbooks.io/ninety-nine-elm-problems/content/p/p03.html

module ElementAt =

    let rec elementAt (inputList:'a list) index = 
        match (inputList, index) with
        | ([], _)    -> None
        | (x::xs, 1) -> Some(x)
        | (x::xs, _) -> elementAt xs (index - 1)