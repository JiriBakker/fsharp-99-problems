namespace FSharp.NinetyNineProblems.Tests

open NUnit.Framework
open FsUnit

open FSharp.NinetyNineProblems

// https://johncrane.gitbooks.io/ninety-nine-elm-problems/content/p/p21.html

[<TestFixture>]
type ItemInserterTests() =
    
    [<Test>]
    member this.insert_at_index_2_works() =
        ItemInserter.insertAt [1; 2; 5; 5; 2; 1] 2 99
        |> should equal [1; 99; 2; 5; 5; 2; 1] 

    [<Test>]
    member this.insert_at_index_3_works() =
        ItemInserter.insertAt [1 .. 14] 3 99
        |> should equal [1; 2; 99; 3; 4; 5; 6; 7; 8; 9; 10; 11; 12; 13; 14]

    [<Test>]
    member this.insert_at_index_higher_than_list_length_appends_item_to_list() =
        ItemInserter.insertAt [1 .. 5] 7 99
        |> should equal [1; 2; 3; 4; 5; 99]

    [<Test>]
    member this.insert_at_index_0_prepents_item_to_list() =
        ItemInserter.insertAt [1 .. 5] 0 99
        |> should equal [99; 1; 2; 3; 4; 5]

    [<Test>]
    member this.insert_at_index_minus_1_prepends_item_to_list() =
        ItemInserter.insertAt [1 .. 5] -1 99
        |> should equal [99; 1; 2; 3; 4; 5]

    [<Test>]
    member this.insert_at_index_1_prepends_item_to_list() =
        ItemInserter.insertAt [1 .. 5] 1 99
        |> should equal [99; 1; 2; 3; 4; 5]

    [<Test>]
    member this.insert_at_on_empty_list_works() =
        ItemInserter.insertAt [] 1 99
        |> should equal [99]

    [<Test>]
    member this.insert_at_index_2_on_list_with_strings_works() =
        ItemInserter.insertAt ["1"; "2"; "3"; "4"; "5"] 2 "x"
        |> should equal ["1"; "x"; "2"; "3"; "4"; "5"] 