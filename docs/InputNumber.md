# InputNumber

InputNumber provides bindings for [InputNumber](https://www.primefaces.org/primereact/inputnumber/)

Below is a sample of how to use the InputNumber bindings. Refer to the code samples in the repository for more examples.

```fsharp
open Feliz
open Feliz.PrimeReact

[<ReactComponent>]
let Index () =
    let (value3, setValue3) = React.useState (2351.35)

    Html.div [
        Prime.inputNumber [
            inputNumber.value value3
            inputNumber.onValueChange setValue3
            inputNumber.mode Decimal
            inputNumber.minFractionDigits 2
            inputNumber.maxFractionDigits 5
        ]
    ]
```