namespace FSharp.NinetyNineProblems.Tests

open NUnit.Framework
open FsUnit

open FSharp.NinetyNineProblems

// https://johncrane.gitbooks.io/ninety-nine-elm-problems/content/p/p28b.html

[<TestFixture>]
type LengthFrequencySorterTests() = 

    [<Test>]
    member this.sort_by_length_frequency_on_regular_list_of_lists_returns_sorted_output() = 
        let testList =  [[1; 2; 3]; [6; 7; 8]; [0]; [2; 3; 5]]
        LengthFrequencySorter.sortByLengthFrequency testList              
        |> should equal [1; 3; 3; 3]

    [<Test>]
    member this.sort_by_length_frequency_on_list_of_lists_also_containing_an_empty_list_returns_sorted_output() = 
        let testList = [[1]; [2]; [3]; [6; 7; 8]; [2; 34; 5]; []]
        LengthFrequencySorter.sortByLengthFrequency testList              
        |> should equal [0; 3; 3; 1; 1; 1]

    [<Test>]
    member this.sort_by_length_frequency_on_list_of_list_containing_very_long_list_returns_sorted_output() = 
        let testList = [[1]; [2]; [3]; [6]; [2]; [1..100000]]
        LengthFrequencySorter.sortByLengthFrequency testList              
        |> should equal [100000; 1; 1; 1; 1; 1]

    [<Test>]
    member this.sort_by_length_frequency_on_list_containing_only_an_empty_list_returns_list_with_only_0() = 
        let testList = [[]]
        LengthFrequencySorter.sortByLengthFrequency testList              
        |> should equal [0] 