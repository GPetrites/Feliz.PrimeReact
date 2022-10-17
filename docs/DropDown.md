# DropDown

DropDown provides bindings for [DropDown](https://www.primefaces.org/primereact/dropdown/)

Below is a sample of how to use the DropDown bindings

```fsharp
open Feliz
open Feliz.PrimeReact

type row = { Id: int; Name: string; Amt: int }

let data =
    [ 1..200 ]
    |> List.map (fun i ->
        { Id = i
          Name = (sprintf "Name %i" i)
          Amt = i * 42 })

let initialSelection: Option<row> = None

[<ReactComponent>]
let Index () =
    let (selectedOption, setSelectedOption) = React.useState (Some 3)

    Html.div [
        Prime.dropDown [
            dropDown.options data
            dropDown.optionLabel "Name"
            dropDown.optionValue "Id"
            dropDown.placeholder "Select option"
            dropDown.showClear true
            dropDown.onChange setSelectedOption
            dropDown.value selectedOption
        ]
    ]
```