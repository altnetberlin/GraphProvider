﻿module GraphProvider.TypeProviders.Graph.Tests.BinaryGraphTests

open NUnit.Framework
open GraphProvider
open GraphProvider.TypeProviders

type BinaryGraph = Graph<"Binary.dgml"> 

[<Test>]
let ``Empty string should be even``() =   
    let state = BinaryGraph.StartFromEven()
    Assert.AreEqual(state.Name,"Even")

[<Test>]
let ``Single 1 should be even``() =   
    let state = BinaryGraph.StartFromEven().``1``()
    Assert.AreEqual(state.Name,"Even")

[<Test>]
let ``10 should be odd``() =   
    let state = BinaryGraph.StartFromEven().``1``().``0``()
    Assert.AreEqual(state.Name,"Odd")

[<Test>]
let ``101010 should be odd``() =   
    let state = 
      BinaryGraph.StartFromEven()
        .``1``().``0``().``1``().``0``().``1``().``0``()
    Assert.AreEqual(state.Name,"Odd")

[<Test>]
let ``101011 should be even``() =   
    let state = 
      BinaryGraph.StartFromEven()
        .``1``().``0``().``1``().``0``().``1``().``1``()
    Assert.AreEqual(state.Name,"Even")