namespace FSharp.NinetyNineProblems

// https://johncrane.gitbooks.io/ninety-nine-elm-problems/content/p/p06.html

module Palindrome =

    let private last inputList =
        inputList
        |> List.last
    
    let private allExceptLast inputList =
        inputList
        |> List.rev
        |> List.tail
    
    let rec isPalindrome inputList = 
        match inputList with 
        | []                     -> true
        | [x]                    -> true
        | [x;y] when x = y       -> true
        | x::xs when x = last xs -> isPalindrome (allExceptLast xs)
        | _                      -> false