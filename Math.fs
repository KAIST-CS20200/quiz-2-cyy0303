module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let collatz (n: int32) =
    if n <= 0 then invalidArg "n" "Input must be a positive integer"
    else
        let mutable count = 0
        let mutable num = int64 n
        while num <> 1L do
            num <- if num &&& 1L = 0L then num >>> 1 else 3L * num + 1L
            count <- count + 1
        count