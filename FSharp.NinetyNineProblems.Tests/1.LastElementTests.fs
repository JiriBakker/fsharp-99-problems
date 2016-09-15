namespace FSharp.NinetyNineProblems.Tests

open NUnit.Framework
open FsUnit

open FSharp.NinetyNineProblems

// https://johncrane.gitbooks.io/ninety-nine-elm-problems/content/p/p01.html

[<TestFixture>]
type LastElementTests() =
    
    [<Test>]
    member this.last_of_1_to_4_returns_4() =
        LastElement.last [1 .. 4] 
        |> should equal (Some(4))

    [<Test>]
    member this.last_of_list_with_only_1_returns_1() =
        LastElement.last [1] 
        |> should equal (Some(1))

    [<Test>]
    member this.last_on_empty_list_returns_none() =
        LastElement.last [] 
        |> should equal None

    [<Test>]
    member this.last_on_string_list_of_a_b_c_returns_c() =
        LastElement.last ['a'; 'b'; 'c'] 
        |> should equal (Some('c'))