let mutable x = 10
let y = &x

//This will cause an error if you try to modify x after assigning it to y
x <- 20
printfn "%d" !y //Prints 10 instead of 20