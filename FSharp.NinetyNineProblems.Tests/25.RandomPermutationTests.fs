namespace FSharp.NinetyNineProblems.Tests

open NUnit.Framework
open FsUnit

open FSharp.NinetyNineProblems

[<TestFixture>]
type RandomPermutationTests() = 

    let rec hasElement inputList element =
        match inputList with
        | [] -> false
        | x::xs when x = element -> true
        | x::xs -> hasElement xs element

    let rec hasSameElements list1 list2 =
        match list1 with
        | [] -> true
        | x::xs when hasElement list2 x -> hasSameElements xs list2
        | _ -> false
        

    [<Test>]
    member this.random_permutation_of_list_returns_list_containing_same_elements() = 
        let testList = [14; 19; 28; 31; 33; 48]
        RandomPermutation.randomPermutation testList
        |> hasSameElements testList |> should be True        


    [<Test>]
    member this.random_permutation_of_list_with_1_item_returns_list_with_1_item() = 
        let testList = [123]
        RandomPermutation.randomPermutation testList
        |> hasSameElements testList |> should be True

    [<Test>]
    member this.random_permutation_of_empty_list_returns_empty_list() = 
        let testList = []
        RandomPermutation.randomPermutation testList
        |> hasSameElements testList |> should be True

    [<Test>]
    member this.random_permutation_of_list_of_strings_returns_list_containing_same_elements() = 
        let testList = ['a'; 'b'; 'c'; 'd'; 'e']
        RandomPermutation.randomPermutation testList
        |> hasSameElements testList |> should be True
