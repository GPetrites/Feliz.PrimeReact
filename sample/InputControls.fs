module App.InputControls

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
let InputControls () =
    let (textValue, setTextValue) = React.useState ("my text")
    let (selectedOption, setSelectedOption) = React.useState (Some 3)

    let isInvalid = textValue = ""

    Html.div [
        Html.div (sprintf "TextValue %s" textValue)
        Html.div (sprintf "Selected option %A" selectedOption)
        Prime.inputText [
            inputText.value textValue
            inputText.onChange setTextValue
            inputText.placeholder "Enter text"
            inputText.className [
                inputTextClass.small
                inputTextClass.error isInvalid
            ]
        ]
        Html.small [
            prop.className [
                primeClass.Error isInvalid
            ]
            prop.text "Error display"
        ]
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