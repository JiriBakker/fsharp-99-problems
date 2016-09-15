namespace FSharp.NinetyNineProblems

// https://johncrane.gitbooks.io/ninety-nine-elm-problems/content/p/p03.html

module ElementAt =

    let elementAt (inputList:'a list) index = 
        Some(inputList.Head) // TODO