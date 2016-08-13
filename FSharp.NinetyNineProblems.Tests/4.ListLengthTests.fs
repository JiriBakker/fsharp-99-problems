namespace FSharp.NinetyNineProblems.Tests

open NUnit.Framework
open FsUnit

open FSharp.NinetyNineProblems

[<TestFixture>]
type ListLengthTests() = 

    [<Test>]
    member this.list_of_4000_elements_is_counted_as_4000() = 
        ListLength.countElements [1 .. 4000]  
        |> should equal 4000    

    [<Test>]
    member this.list_of_1_element_is_counted_as_1() = 
        ListLength.countElements [1]  
        |> should equal 1  

    [<Test>]
    member this.empty_list_is_counted_as_0() = 
        ListLength.countElements []  
        |> should equal 0


    [<Test>]
    member this.list_of_3_string_element_is_counted_as_3() = 
        ListLength.countElements ['a'; 'b'; 'c']  
        |> should equal 3
           