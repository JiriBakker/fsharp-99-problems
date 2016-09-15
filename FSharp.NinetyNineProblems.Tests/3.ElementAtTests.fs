namespace FSharp.NinetyNineProblems.Tests

open NUnit.Framework
open FsUnit

open FSharp.NinetyNineProblems

// https://johncrane.gitbooks.io/ninety-nine-elm-problems/content/p/p03.html

[<TestFixture>]
type ElementAtTests() =
    
    [<Test>]
    member this.element_at_2_in_1_to_4_returns_2() =
        ElementAt.elementAt [1 .. 4] 2 
        |> should equal (Some(2))

    [<Test>]
    member this.element_at_2_on_list_with_only_1_item_returns_none() =
        ElementAt.elementAt [1] 2 
        |> should equal None

    [<Test>]
    member this.element_at_on_an_empty_list_returns_none() =
        ElementAt.elementAt [] 2 
        |> should equal None

    [<Test>]
    member this.element_at_with_negative_index_returns_none() =
        ElementAt.elementAt [] -1 
        |> should equal None

    [<Test>]
    member this.element_at_2_on_list_with_a_b_c_returns_b() =
        ElementAt.elementAt ['a'; 'b'; 'c'] 2 
        |> should equal (Some('b'))

    