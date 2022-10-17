# InputText

InputText provides bindings for [InputText](https://www.primefaces.org/primereact/inputtext/)

Below is a sample of how to use the InputText bindings

```fsharp
open Feliz
open Feliz.PrimeReact

[<ReactComponent>]
let Index () =
    let (textValue, setTextValue) = React.useState ("my text")

    let isInvalid = textValue = ""

    Html.div [
        Prime.inputText [
            inputText.value textValue
            inputText.onChange setTextValue
            inputText.placeholder "Enter text"
            inputText.className [
                inputTextClass.small
                inputTextClass.error isInvalid
            ]
        ]
    ]
```