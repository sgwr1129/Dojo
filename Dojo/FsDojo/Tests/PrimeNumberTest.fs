module PrimeNumberTest

open PrimeNumber
open NUnit.Framework

[<TestCase(0, false)>]
[<TestCase(1, false)>]
[<TestCase(2, true)>]
[<TestCase(3, true)>]
[<TestCase(4, false)>]
[<TestCase(5, true)>]
[<TestCase(6, false)>]
[<TestCase(7, true)>]
[<TestCase(8, false)>]
[<TestCase(9, false)>]
[<TestCase(10, false)>]
[<TestCase(11, true)>]
let IsPrimeNumberTest(n: int, expected: bool) :unit =
    Assert.AreEqual(IsPrimeNumber(n), expected)