module Tests

open System
open Xunit
open FsUnit

[<Fact>]
let test1 () =
    1 |> should equal 1

[<Fact>]
let test2 () =
    "Hello" |> should not' (equal "Hi")

[<Fact>]
let test3 () =
    5 + 5 |> should equal 10

