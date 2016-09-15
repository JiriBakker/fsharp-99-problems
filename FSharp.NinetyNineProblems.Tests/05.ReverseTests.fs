namespace FSharp.NinetyNineProblems.Tests

open NUnit.Framework
open FsUnit

open FSharp.NinetyNineProblems

// https://johncrane.gitbooks.io/ninety-nine-elm-problems/content/p/p05.html

[<TestFixture>]
type ReverseTests() = 

    [<Test>]
    member this.list_of_1_to_4_is_reversed_to_4_to_1() = 
        Reverse.myReverse [1 .. 4]
        |> should equal [4; 3; 2; 1]

    [<Test>]
    member this.list_of_1_to_2_is_reversed_to_2_to_1() = 
        Reverse.myReverse [1; 2]
        |> should equal [2; 1]

    [<Test>]
    member this.list_of_1_is_reversed_to_1() = 
        Reverse.myReverse [1]
        |> should equal [1]

    [<Test>]
    member this.empty_list_is_reversed_to_empty_list() = 
        Reverse.myReverse []
        |> should equal []

    [<Test>]
    member this.list_of_a_to_c_is_reversed_to_c_to_a() = 
        Reverse.myReverse ['a'; 'b'; 'c']
        |> should equal ['c'; 'b'; 'a']


           