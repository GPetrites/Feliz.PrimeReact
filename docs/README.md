# Feliz.PrimeReact
Feliz style bindings for [PrimReact](https://www.primefaces.org/primereact/)

Here's how it looks:

```fs
module App

open Feliz
open Feliz.PrimeReact

[<ReactComponent>]
let MyComponent () =
    let (textValue, setTextValue) = React.useState ("my text")

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

`NOTE:` This is very much an early release which includes just a small subset of the PrimeReact controls and properties, It should be a solid foundation for extending into the other controls. Issue requesting new features are very much welcome.

## Installation

Run `femto install Feliz.PrimeReact` from inside your project directory.

## Source code

Found in `./Feliz.PrimeReact`

## Samples

Samples are found in `./sample`. Samples will align to the samples found in the PrimeReact documentation.

## Contributing

In root folder:
- Run `yarn` to install npm packages
- Run `yarn start` to start the sample application to test changes