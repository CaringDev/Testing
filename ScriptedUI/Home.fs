namespace ScriptedUI

open canopy
open System
open Xunit
open FsUnit.Xunit

type Home() =
    inherit CanopyTest()

    [<Fact>]
    let ``Home page greets user``() =
        url "http://localhost:8080"
        let userName = Environment.UserName
        "#username" << userName
        read "#helloMessage" |> should equal (sprintf "Hello %s" userName)