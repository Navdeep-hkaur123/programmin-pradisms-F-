// For more information see https://aka.ms/fsharp-console-apps

let calculatePower exponent baseValue =
    pown baseValue exponent

let square = calculatePower 2
let cube = calculatePower 3


let result1 = square 4 
let result2 = square 5 

let result3 = cube 2  
let result4 = cube 3  


printfn "4 squared is %d" result1
printfn "5 squared is %d" result2
printfn "2 cubed is %d" result3
printfn "3 cubed is %d" result4






