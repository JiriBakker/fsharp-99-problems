namespace FSharp.NinetyNineProblems.Tests

open NUnit.Framework
open FsUnit

open FSharp.NinetyNineProblems

// https://johncrane.gitbooks.io/ninety-nine-elm-problems/content/p/p19.html

[<TestFixture>]
type ListRotatorTests() =

    [<Test>]
    member this.rotate_list_with_duplicates_works() =
        ListRotator.rotate [1; 2; 5; 5; 2; 1] 3
        |> should equal [5; 2; 1; 1; 2; 5] 

    [<Test>]
    member this.rotate_list_with_index_higher_than_list_length_works() =
        ListRotator.rotate [1 .. 10] 13
        |> should equal [4; 5; 6; 7; 8; 9; 10; 1; 2; 3] 

    [<Test>]
    member this.rotate_list_at_index_1_works() =
        ListRotator.rotate [1 .. 5] 1
        |> should equal [2; 3; 4; 5; 1]

    [<Test>]
    member this.rotate_list_at_index_0_returns_input_list() =
        ListRotator.rotate [1 .. 5] 0
        |> should equal [1; 2; 3; 4; 5]
    
    [<Test>]
    member this.rotate_list_at_index_minus_1_works() =
        ListRotator.rotate [1 .. 5] -1
        |> should equal [5; 1; 2; 3; 4]
    
    [<Test>]
    member this.rotate_list_at_index_minus_6_works() =
        ListRotator.rotate [1 .. 5] -6
        |> should equal [5; 1; 2; 3; 4]

    [<Test>]
    member this.rotate_list_at_index_3_works() =
        ListRotator.rotate [1 .. 5] 3
        |> should equal [4; 5; 1; 2; 3]

    [<Test>]
    member this.rotate_on_single_item_list_works() =
        ListRotator.rotate [1] 3
        |> should equal [1]

    [<Test>]
    member this.rotate_on_empty_item_list_works() =
        ListRotator.rotate [] 3
        |> should equal []

    [<Test>]
    member this.rotate_list_with_strings_works() =
        ListRotator.rotate ["1"; "2"; "3"; "4"] 1
        |> should equal ["2"; "3"; "4"; "1"]
