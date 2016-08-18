namespace FSharp.NinetyNineProblems.Tests

open NUnit.Framework
open FsUnit

open FSharp.NinetyNineProblems

[<TestFixture>]
type ListSplitterTests() = 

    // 'should equal' does not properly compare tuples with an empty list
    let shouldEqual (a:'x*'x) (b:'x*'x) =
        Assert.AreEqual(a, b)

    [<Test>]
    member this.list_split_at_index_0_returns_an_empty_list_and_input_list() = 
        ListSplitter.split [1..5] 0
        |> shouldEqual ([], [1; 2; 3; 4; 5])  
        
    [<Test>]
    member this.list_split_at_index_2_returns_list_of_1_and_2_and_list_of_3_to_5() = 
        ListSplitter.split [1..5] 2
        |> should equal ([1; 2], [3; 4; 5])   
        
    [<Test>]
    member this.list_split_at_index_3_returns_list_of_1_to_3_and_list_of_4_and_5() = 
        ListSplitter.split [1..5] 3
        |> should equal ([1; 2; 3], [4; 5]) 

    [<Test>]
    member this.list_split_at_index_4_returns_list_of_1_to_4_and_list_of_5() = 
        ListSplitter.split [1..5] 4
        |> should equal ([1; 2; 3; 4], [5]) 

    [<Test>]
    member this.list_split_at_index_5_returns_list_of_1_to_5_and_an_empty_list() = 
        ListSplitter.split [1..5] 5
        |> shouldEqual ([1; 2; 3; 4; 5], []) 

    [<Test>]
    member this.list_split_at_index_6_returns_list_of_1_to_5_and_an_empty_list() = 
        ListSplitter.split [1..5] 6
        |> shouldEqual ([1; 2; 3; 4; 5], []) 

    [<Test>]
    member this.list_split_at_index_minus_1_returns_an_empty_list_and_input_list() = 
        ListSplitter.split [1..5] -1
        |> shouldEqual ([], [1; 2; 3; 4; 5])

    [<Test>]
    member this.list_with_strings_splits_as_expected() = 
        ListSplitter.split ["aab"; "b"; "c"; "aa"] 2 
        |> should equal (["aab"; "b"], ["c"; "aa" ])