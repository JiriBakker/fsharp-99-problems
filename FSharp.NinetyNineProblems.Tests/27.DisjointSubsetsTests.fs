namespace FSharp.NinetyNineProblems.Tests

open NUnit.Framework
open FsUnit

open FSharp.NinetyNineProblems

// https://johncrane.gitbooks.io/ninety-nine-elm-problems/content/p/p27.html

[<TestFixture>]
type DisjointSubsetsTests() = 

    let sortDisjointSubsetsList disjointSubsets =
        disjointSubsets
        |> List.map (fun subset -> List.map (fun subsubset -> List.sort subsubset) subset)
        |> List.sortBy (fun subset -> List.concat subset)

    [<Test>]
    member this.disjoint_subsets_of_2_2_2_items_returns_expected_output() =         
        DisjointSubsets.group [2,2,2] ["Al"; "Bae"; "Cal"; "Dee"; "Ed"; "Flip"]
        |> sortDisjointSubsetsList
        |> should equal 
                (sortDisjointSubsetsList 
                [[["Al"; "Bae"]; ["Cal"; "Dee"]; ["Ed"; "Flip"]];
                [["Al"; "Bae"]; ["Ed"; "Flip"]; ["Cal"; "Dee"]];
                [["Ed"; "Flip"]; ["Al"; "Bae"]; ["Cal"; "Dee"]];
                [["Ed"; "Flip"]; ["Cal"; "Dee"]; ["Al"; "Bae"]];
                [["Cal"; "Dee"]; ["Al"; "Bae"]; ["Ed"; "Flip"]];
                [["Cal"; "Dee"]; ["Ed"; "Flip"]; ["Al"; "Bae"]];

                [["Al"; "Bae"]; ["Cal"; "Ed"]; ["Dee"; "Flip"]];
                [["Al"; "Bae"]; ["Dee"; "Flip"]; ["Cal"; "Ed"]];
                [["Cal"; "Ed"]; ["Al"; "Bae"]; ["Dee"; "Flip"]];
                [["Cal"; "Ed"]; ["Dee"; "Flip"]; ["Al"; "Bae"]];
                [["Dee"; "Flip"]; ["Al"; "Bae"]; ["Cal"; "Ed"]];
                [["Dee"; "Flip"]; ["Cal"; "Ed"]; ["Al"; "Bae"]];

                [["Al"; "Bae"]; ["Cal"; "Flip"]; ["Ed"; "Dee"]];
                [["Al"; "Bae"]; ["Ed"; "Dee"]; ["Cal"; "Flip"]];
                [["Cal"; "Flip"]; ["Al"; "Bae"]; ["Ed"; "Dee"]];
                [["Cal"; "Flip"]; ["Ed"; "Dee"]; ["Al"; "Bae"]];
                [["Ed"; "Dee"]; ["Al"; "Bae"]; ["Cal"; "Flip"]];
                [["Ed"; "Dee"]; ["Cal"; "Flip"]; ["Al"; "Bae"]];

                [["Al"; "Cal"]; ["Bae"; "Dee"]; ["Ed"; "Flip"]];
                [["Al"; "Cal"]; ["Ed"; "Flip"]; ["Bae"; "Dee"]];
                [["Bae"; "Dee"]; ["Al"; "Cal"]; ["Ed"; "Flip"]];
                [["Bae"; "Dee"]; ["Ed"; "Flip"]; ["Al"; "Cal"]];
                [["Ed"; "Flip"]; ["Al"; "Cal"]; ["Bae"; "Dee"]];
                [["Ed"; "Flip"]; ["Bae"; "Dee"]; ["Al"; "Cal"]];

                [["Al"; "Cal"]; ["Bae"; "Ed"]; ["Dee"; "Flip"]];
                [["Al"; "Cal"]; ["Dee"; "Flip"]; ["Bae"; "Ed"]];
                [["Bae"; "Ed"]; ["Al"; "Cal"]; ["Dee"; "Flip"]];
                [["Bae"; "Ed"]; ["Dee"; "Flip"]; ["Al"; "Cal"]];
                [["Dee"; "Flip"]; ["Al"; "Cal"]; ["Bae"; "Ed"]];
                [["Dee"; "Flip"]; ["Bae"; "Ed"]; ["Al"; "Cal"]];

                [["Al"; "Cal"]; ["Bae"; "Flip"]; ["Ed"; "Dee"]];
                [["Al"; "Cal"]; ["Ed"; "Dee"]; ["Bae"; "Flip"]];
                [["Bae"; "Flip"]; ["Al"; "Cal"]; ["Ed"; "Dee"]];
                [["Bae"; "Flip"]; ["Ed"; "Dee"]; ["Al"; "Cal"]];
                [["Ed"; "Dee"]; ["Bae"; "Flip"]; ["Al"; "Cal"]];
                [["Ed"; "Dee"]; ["Al"; "Cal"]; ["Bae"; "Flip"]];

                [["Al"; "Dee"]; ["Bae"; "Cal"]; ["Ed"; "Flip"]];
                [["Al"; "Dee"]; ["Ed"; "Flip"]; ["Bae"; "Cal"]];
                [["Bae"; "Cal"]; ["Al"; "Dee"]; ["Ed"; "Flip"]];
                [["Bae"; "Cal"]; ["Ed"; "Flip"]; ["Al"; "Dee"]];
                [["Ed"; "Flip"]; ["Al"; "Dee"]; ["Bae"; "Cal"]];
                [["Ed"; "Flip"]; ["Bae"; "Cal"]; ["Al"; "Dee"]];


                [["Al"; "Dee"]; ["Bae"; "Ed"]; ["Cal"; "Flip"]];
                [["Al"; "Dee"]; ["Cal"; "Flip"]; ["Bae"; "Ed"]];
                [["Bae"; "Ed"]; ["Al"; "Dee"]; ["Cal"; "Flip"]];
                [["Bae"; "Ed"]; ["Cal"; "Flip"]; ["Al"; "Dee"]];
                [["Cal"; "Flip"]; ["Al"; "Dee"]; ["Bae"; "Ed"]];
                [["Cal"; "Flip"]; ["Bae"; "Ed"]; ["Al"; "Dee"]];

                [["Al"; "Dee"]; ["Bae"; "Flip"]; ["Ed"; "Cal"]];
                [["Al"; "Dee"]; ["Ed"; "Cal"]; ["Bae"; "Flip"]];
                [["Bae"; "Flip"]; ["Al"; "Dee"]; ["Ed"; "Cal"]];
                [["Bae"; "Flip"]; ["Ed"; "Cal"]; ["Al"; "Dee"]];
                [["Ed"; "Cal"]; ["Al"; "Dee"]; ["Bae"; "Flip"]];
                [["Ed"; "Cal"]; ["Bae"; "Flip"]; ["Al"; "Dee"]];

                [["Al"; "Ed"]; ["Bae"; "Cal"]; ["Dee"; "Flip"]];
                [["Al"; "Ed"]; ["Dee"; "Flip"]; ["Bae"; "Cal"]];
                [["Bae"; "Cal"]; ["Al"; "Ed"]; ["Dee"; "Flip"]];
                [["Bae"; "Cal"]; ["Dee"; "Flip"]; ["Al"; "Ed"]];
                [["Dee"; "Flip"]; ["Al"; "Ed"]; ["Bae"; "Cal"]];
                [["Dee"; "Flip"]; ["Bae"; "Cal"]; ["Al"; "Ed"]];

                [["Al"; "Ed"]; ["Bae"; "Dee"]; ["Cal"; "Flip"]];
                [["Al"; "Ed"]; ["Cal"; "Flip"]; ["Bae"; "Dee"]];
                [["Bae"; "Dee"]; ["Al"; "Ed"]; ["Cal"; "Flip"]];
                [["Bae"; "Dee"]; ["Cal"; "Flip"]; ["Al"; "Ed"]];
                [["Cal"; "Flip"]; ["Al"; "Ed"]; ["Bae"; "Dee"]];
                [["Cal"; "Flip"]; ["Bae"; "Dee"]; ["Al"; "Ed"]];

                [["Al"; "Ed"]; ["Bae"; "Flip"]; ["Dee"; "Cal"]];
                [["Al"; "Ed"]; ["Dee"; "Cal"]; ["Bae"; "Flip"]];
                [["Bae"; "Flip"]; ["Al"; "Ed"]; ["Dee"; "Cal"]];
                [["Bae"; "Flip"]; ["Dee"; "Cal"]; ["Al"; "Ed"]];
                [["Dee"; "Cal"]; ["Al"; "Ed"]; ["Bae"; "Flip"]];
                [["Dee"; "Cal"]; ["Bae"; "Flip"]; ["Al"; "Ed"]];

                [["Al"; "Flip"]; ["Bae"; "Cal"]; ["Dee"; "Ed"]];
                [["Al"; "Flip"]; ["Dee"; "Ed"]; ["Bae"; "Cal"]];
                [["Bae"; "Cal"]; ["Al"; "Flip"]; ["Dee"; "Ed"]];
                [["Bae"; "Cal"]; ["Dee"; "Ed"]; ["Al"; "Flip"]];
                [["Dee"; "Ed"]; ["Al"; "Flip"]; ["Bae"; "Cal"]];
                [["Dee"; "Ed"]; ["Bae"; "Cal"]; ["Al"; "Flip"]];

                [["Al"; "Flip"]; ["Bae"; "Dee"]; ["Cal"; "Ed"]];
                [["Al"; "Flip"]; ["Cal"; "Ed"]; ["Bae"; "Dee"]];
                [["Bae"; "Dee"]; ["Al"; "Flip"]; ["Cal"; "Ed"]];
                [["Bae"; "Dee"]; ["Cal"; "Ed"]; ["Al"; "Flip"]];
                [["Cal"; "Ed"]; ["Al"; "Flip"]; ["Bae"; "Dee"]];
                [["Cal"; "Ed"]; ["Bae"; "Dee"]; ["Al"; "Flip"]];

                [["Al"; "Flip"]; ["Bae"; "Ed"]; ["Dee"; "Cal"]];
                [["Al"; "Flip"]; ["Dee"; "Cal"]; ["Bae"; "Ed"]];
                [["Bae"; "Ed"]; ["Al"; "Flip"]; ["Dee"; "Cal"]];
                [["Bae"; "Ed"]; ["Dee"; "Cal"]; ["Al"; "Flip"]];
                [["Dee"; "Cal"]; ["Al"; "Flip"]; ["Bae"; "Ed"]];
                [["Dee"; "Cal"]; ["Bae"; "Ed"]; ["Al"; "Flip"]]])
