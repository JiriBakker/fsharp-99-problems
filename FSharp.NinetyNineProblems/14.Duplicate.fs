namespace FSharp.NinetyNineProblems

// https://johncrane.gitbooks.io/ninety-nine-elm-problems/content/p/p14.html

module Duplicate =

    let rec duplicate inputList = 
        match inputList with
        | [] -> []
        | x::xs -> x :: x :: (duplicate xs)