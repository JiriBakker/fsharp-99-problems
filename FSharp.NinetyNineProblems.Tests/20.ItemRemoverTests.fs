namespace FSharp.NinetyNineProblems.Tests

open NUnit.Framework
open FsUnit

open FSharp.NinetyNineProblems

// https://johncrane.gitbooks.io/ninety-nine-elm-problems/content/p/p20.html

[<TestFixture>]
type ItemRemoverTests() =
    
    [<Test>]
    member this.drop_at_index_2_works() =
        ItemRemover.dropAt [1; 2; 5; 5; 2; 1] 2
        |> should equal [1; 5; 5; 2; 1]

    [<Test>]
    member this.drop_at_index_3_works() =
        ItemRemover.dropAt [1 .. 14] 3
        |> should equal [1; 2; 4; 5; 6; 7; 8; 9; 10; 11; 12; 13; 14]

    [<Test>]
    member this.drop_at_index_higher_than_list_returns_input_list() =
        ItemRemover.dropAt [1 .. 5] 6
        |> should equal [1; 2; 3; 4; 5]

    [<Test>]
    member this.drop_at_index_0_returns_input_list() =
        ItemRemover.dropAt [1 .. 5] 0
        |> should equal [1; 2; 3; 4; 5]

    [<Test>]
    member this.drop_at_index_minus_1_returns_input_list() =
        ItemRemover.dropAt [1 .. 5] -1
        |> should equal [1; 2; 3; 4; 5]

    [<Test>]
    member this.drop_at_index_1_works() =
        ItemRemover.dropAt [1 .. 5] 1
        |> should equal [2; 3; 4; 5]

    [<Test>]
    member this.drop_at_on_single_item_list_works() =
        ItemRemover.dropAt [1] 1
        |> should equal []

    [<Test>]
    member this.drop_at_index_2_on_list_with_strings_works() =
        ItemRemover.dropAt ["1"; "2"; "3"; "4"; "5"] 2
        |> should equal ["1"; "3"; "4"; "5"]
