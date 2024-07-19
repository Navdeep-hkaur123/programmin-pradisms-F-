// For more information see https://aka.ms/fsharp-console-apps

let rec calculateProductHelper (numbers: int list) (product: int) =
    match numbers with
    | [] -> product
    | number :: rest -> calculateProductHelper rest (product * number)

let calculateProduct (numbers: int list) =
    calculateProductHelper numbers 1

let factorsList = [3; 6; 2; 7]

let productResult = calculateProduct factorsList

printfn "The product of all factors in the list is %d" productResult






