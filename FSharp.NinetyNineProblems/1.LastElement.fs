namespace FSharp.NinetyNineProblems

// https://johncrane.gitbooks.io/ninety-nine-elm-problems/content/p/p01.html

module LastElement =

    let last (inputList:'a list) = 
        Some(inputList.Head) // TODO