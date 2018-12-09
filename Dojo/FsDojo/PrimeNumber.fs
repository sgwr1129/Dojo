module PrimeNumber

let IsPrimeNumber = function
    | 1 -> false
    | n when n < 1 -> false
    | n -> 
        let rec isPrime = function
        | x when n = x -> true
        | x when (n%x) = 0 -> false
        | x -> isPrime (x+1)
        isPrime 2
