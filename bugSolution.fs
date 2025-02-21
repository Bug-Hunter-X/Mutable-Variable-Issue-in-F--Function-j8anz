let x = 10
let y = 20

let add x y = 
    let sum = x + y
    (sum, sum)

let (result1, result2) = add x y
printf "%d %d %d %d" x y result1 result2