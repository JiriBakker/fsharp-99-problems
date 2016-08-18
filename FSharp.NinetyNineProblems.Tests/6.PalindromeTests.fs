namespace FSharp.NinetyNineProblems.Tests

open NUnit.Framework
open FsUnit

open FSharp.NinetyNineProblems

// https://johncrane.gitbooks.io/ninety-nine-elm-problems/content/p/p06.html

[<TestFixture>]
type PalindromeTests() = 

    [<Test>]
    member this.palindrome_of_integers_is_recognized() = 
        Palindrome.isPalindrome [1; 3; 5; 8; 5; 3; 1]  
        |> should be True    

    [<Test>]
    member this.non_palindrome_of_integers_is_not_recognized_as_palindrome() = 
        Palindrome.isPalindrome [2; 1]                 
        |> should be False   
        
    [<Test>]
    member this.palindrome_of_single_integer_is_recognized() =  
        Palindrome.isPalindrome [1]                    
        |> should be True    

    [<Test>]
    member this.empty_list_is_recognized_as_palindrome() = 
        Palindrome.isPalindrome []                     
        |> should be True  
     
    [<Test>]
    member this.palindrome_of_strings_is_recognized() = 
        Palindrome.isPalindrome [ "aa"; "bb"; "aa" ]   
        |> should be True      

    [<Test>]
    member this.non_palindrome_of_strings_is_not_recognized_as_palindrome() = 
        Palindrome.isPalindrome [ "aab"; "b"; "aa" ]   
        |> should be False   