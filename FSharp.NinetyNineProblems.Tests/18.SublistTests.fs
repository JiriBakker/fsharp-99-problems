namespace FSharp.NinetyNineProblems.Tests

open NUnit.Framework
open FsUnit

open FSharp.NinetyNineProblems

// https://johncrane.gitbooks.io/ninety-nine-elm-problems/content/p/p18.html

[<TestFixture>]
type SublistTests() =
    
    [<Test>]
    member this.sublist_with_first_and_last_of_list_returns_entire_list() =
        Sublist.sublist [1 .. 5] 1 5
        |> should equal [1; 2; 3; 4; 5] 

    [<Test>]
    member this.sublist_with_2_and_4_returns_2_to_4() =
        Sublist.sublist [1 .. 5] 2 4 
        |> should equal [2; 3; 4] 

    [<Test>]
    member this.sublist_with_1_and_3_returns_1_to_3() =
        Sublist.sublist [1 .. 5] 1 3 
        |> should equal [1; 2; 3] 

    [<Test>]
    member this.sublist_with_2_and_last_of_list_returns_2_to_last_of_list() =
        Sublist.sublist [1 .. 5] 2 5 
        |> should equal [2; 3; 4; 5] 
    

