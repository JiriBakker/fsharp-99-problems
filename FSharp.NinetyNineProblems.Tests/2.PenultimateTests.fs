namespace FSharp.NinetyNineProblems.Tests

open NUnit.Framework
open FsUnit

open FSharp.NinetyNineProblems

// https://johncrane.gitbooks.io/ninety-nine-elm-problems/content/p/p02.html

[<TestFixture>]
type PenultimateTests() =
    
    [<Test>]
    member this.penultimate_of_1_to_4_returns_3() =
        Penultimate.penultimate [1 .. 4] 
        |> should equal (Some(3))

    [<Test>]
    member this.penultimate_of_list_with_only_1_and_2_returns_1() =
        Penultimate.penultimate [1; 2] 
        |> should equal (Some(1))

    [<Test>]
    member this.penultimate_of_list_with_only_1_returns_none() =
        Penultimate.penultimate [1] 
        |> should equal None

    [<Test>]
    member this.penultimate_of_empty_list_returns_none() =
        Penultimate.penultimate [] 
        |> should equal None

    [<Test>]
    member this.penultimate_of_a_b_c_returns_b() =
        Penultimate.penultimate ['a'; 'b'; 'c'] 
        |> should equal (Some('b'))

    [<Test>]
    member this.penultimate_of_only_a_returns_b() =
        Penultimate.penultimate ['a'] 
        |> should equal None
