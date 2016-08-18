namespace FSharp.NinetyNineProblems.Tests

open NUnit.Framework
open FsUnit

open FSharp.NinetyNineProblems

// https://johncrane.gitbooks.io/ninety-nine-elm-problems/content/p/p14.html

[<TestFixture>]
type DuplicateTests() = 

    [<Test>]
    member this.duplicate_list_of_6_items_returns_duplicated_list_with_12_items() = 
        Duplicate.duplicate [1; 2; 3; 5; 8; 8]
        |> should equal [1; 1; 2; 2; 3; 3; 5; 5; 8; 8; 8; 8]

    [<Test>]
    member this.duplicate_of_list_with_1_item_returns_duplicated_list_with_2_items() = 
        Duplicate.duplicate [1]
        |> should equal [1; 1]

    [<Test>]
    member this.duplicate_of_empty_list_returns_empty_list() = 
        Duplicate.duplicate []
        |> should equal []

    [<Test>]
    member this.duplicate_list_of_3_strings_returns_duplicated_list_with_6_strings() = 
        Duplicate.duplicate ["1"; "2"; "5"]
        |> should equal ["1"; "1"; "2"; "2"; "5"; "5"]

           