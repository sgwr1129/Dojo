module FizzBuzz

let fizzbuzz x =
    match (x % 3, x % 5) with
    |(0, 0) -> "FizzBuzz"
    |(0, _) -> "Fizz"
    |(_, 0) -> "Buzz"
    | _ -> string x