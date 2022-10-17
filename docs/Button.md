# Button

Button provides bindings for [Button](https://www.primefaces.org/primereact/button/)

Below is a sample of how to use the Button bindings

```fsharp
open Feliz
open Feliz.PrimeReact

[<ReactComponent>]
let Index () =
    let (isDialogVisible, setIsDialogVisible) = React.useState (false)
    let showDialog () = setIsDialogVisible true
    let hideDialog () = setIsDialogVisible false

    Html.div [
        Prime.button [
            button.className [
                buttonClass.rounded
                buttonClass.outlined
                buttonClass.help
            ]
            button.label "Add Row"
            button.onClick showDialog
        ]
        Prime.button [
            button.className [
                buttonClass.rounded
                buttonClass.outlined
                buttonClass.info
            ]
            button.label "Cancel"
            button.disabled true
        ]
    ]
```