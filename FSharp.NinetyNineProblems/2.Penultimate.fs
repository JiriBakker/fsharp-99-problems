namespace FSharp.NinetyNineProblems

// https://johncrane.gitbooks.io/ninety-nine-elm-problems/content/p/p02.html

module Penultimate =

    let rec penultimate (inputList:'a list) = 
        match inputList with
        | []    -> None
        | [x]   -> None
        | [x;_] -> Some(x)
        | x::xs -> penultimate xs