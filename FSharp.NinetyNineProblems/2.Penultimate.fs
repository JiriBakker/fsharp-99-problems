namespace FSharp.NinetyNineProblems

// https://johncrane.gitbooks.io/ninety-nine-elm-problems/content/p/p02.html

module Penultimate =

    let penultimate (inputList:'a list) = 
        Some(inputList.Head) // TODO