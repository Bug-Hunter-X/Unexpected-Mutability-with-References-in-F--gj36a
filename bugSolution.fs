let mutable x = 10
let y = ref x

//Modify the reference directly
!y <- 20
printfn "%d" !y //Prints 20
printfn "%d" x //Prints 20

//Or, create a copy:
let z = x
x <- 30
printfn "%d" z //Prints 20
printfn "%d" x //Prints 30