module InputNumber

open Feliz
open Feliz.PrimeReact

[<ReactComponent>]
let Index () =
    let (value1, setValue1) = React.useState (42723)
    let (value2, setValue2) = React.useState (58151)
    let (value3, setValue3) = React.useState (2351.35)
    let (value4, setValue4) = React.useState (50)
    let (value5, setValue5) = React.useState (151351)
    let (value6, setValue6) = React.useState (115744)
    let (value7, setValue7) = React.useState (635524)
    let (value8, setValue8) = React.useState (732762)
    let (value9, setValue9) = React.useState (1500)
    let (value10, setValue10) = React.useState (2500)
    let (value11, setValue11) = React.useState (4250)
    let (value12, setValue12) = React.useState (5002)
    let (value13, setValue13) = React.useState (20)
    let (value14, setValue14) = React.useState (50)
    let (value15, setValue15) = React.useState (10)
    let (value16, setValue16) = React.useState (20)
    let (value17, setValue17) = React.useState (20)
    let (value18, setValue18) = React.useState (10.50)
    let (value19, setValue19) = React.useState (25)
    let (value20, setValue20) = React.useState (50)

    Html.div [
        Html.table [
            Html.tableBody [
                Html.tr [ Html.th "Numerals" ]
                Html.tr [
                    Html.td "Numerals"
                    Html.td "Without Grouping"
                    Html.td "Min-Max Fraction Digits"
                    Html.td "Min-Max Boundaries"
                ]
                Html.tr [
                    Html.td [
                        Prime.inputNumber [
                            inputNumber.value value1
                            inputNumber.onValueChange setValue1
                        ]
                    ]
                    Html.td [
                        Prime.inputNumber [
                            inputNumber.value value2
                            inputNumber.onValueChange setValue2
                            inputNumber.mode Decimal
                            inputNumber.useGrouping false
                        ]
                    ]
                    Html.td [
                        Prime.inputNumber [
                            inputNumber.value value3
                            inputNumber.onValueChange setValue3
                            inputNumber.mode Decimal
                            inputNumber.minFractionDigits 2
                            inputNumber.maxFractionDigits 5
                        ]
                    ]
                    Html.td [
                        Prime.inputNumber [
                            inputNumber.value value4
                            inputNumber.onValueChange setValue4
                            inputNumber.mode Decimal
                            inputNumber.min 0
                            inputNumber.max 100
                        ]
                    ]
                ]
                Html.tr [
                    Html.td "User Locale"
                    Html.td "United States Locale"
                    Html.td "German Locale"
                    Html.td "India Locale"
                ]
                Html.tr [
                    Html.td [
                        Prime.inputNumber [
                            inputNumber.value value5
                            inputNumber.onValueChange setValue5
                            inputNumber.mode Decimal
                            inputNumber.minFractionDigits 2
                        ]
                    ]
                    Html.td [
                        Prime.inputNumber [
                            inputNumber.value value6
                            inputNumber.onValueChange setValue6
                            inputNumber.mode Decimal
                            inputNumber.minFractionDigits 2
                            inputNumber.locale "en-US"
                        ]
                    ]
                    Html.td [
                        Prime.inputNumber [
                            inputNumber.value value7
                            inputNumber.onValueChange setValue7
                            inputNumber.mode Decimal
                            inputNumber.minFractionDigits 2
                            inputNumber.locale "de-DE"
                        ]
                    ]
                    Html.td [
                        Prime.inputNumber [
                            inputNumber.value value8
                            inputNumber.onValueChange setValue8
                            inputNumber.mode Decimal
                            inputNumber.minFractionDigits 2
                            inputNumber.locale "en-IN"
                        ]
                    ]
                ]
                Html.tr [ Html.th "Currency" ]
                Html.tr [
                    Html.td "United States"
                    Html.td "Germany"
                    Html.td "India"
                    Html.td "Japan"
                ]
                Html.tr [
                    Html.td [
                        Prime.inputNumber [
                            inputNumber.value value9
                            inputNumber.onValueChange setValue9
                            inputNumber.mode Currency
                            inputNumber.currency "USD"
                            inputNumber.locale "en-US"
                        ]
                    ]
                    Html.td [
                        Prime.inputNumber [
                            inputNumber.value value10
                            inputNumber.onValueChange setValue10
                            inputNumber.mode Currency
                            inputNumber.currency "EUR"
                            inputNumber.locale "de-DE"
                        ]
                    ]
                    Html.td [
                        Prime.inputNumber [
                            inputNumber.value value11
                            inputNumber.onValueChange setValue11
                            inputNumber.mode Currency
                            inputNumber.currency "INR"
                            inputNumber.locale "en-IN"
                            inputNumber.currencyDisplay Code
                        ]
                    ]
                    Html.td [
                        Prime.inputNumber [
                            inputNumber.value value12
                            inputNumber.onValueChange setValue12
                            inputNumber.mode Currency
                            inputNumber.currency "JPY"
                            inputNumber.locale "jp-JP"
                        ]
                    ]
                ]
                Html.tr [ Html.th "Prefix and suffix" ]
                Html.tr [
                    Html.td "Mile"
                    Html.td "Percent"
                    Html.td "Expiry"
                    Html.td "Temperature"
                ]
                Html.tr [
                    Html.td [
                        Prime.inputNumber [
                            inputNumber.value value13
                            inputNumber.onValueChange setValue13
                            inputNumber.suffix " mi"
                        ]
                    ]
                    Html.td [
                        Prime.inputNumber [
                            inputNumber.value value14
                            inputNumber.onValueChange setValue14
                            inputNumber.prefix "%"
                        ]
                    ]
                    Html.td [
                        Prime.inputNumber [
                            inputNumber.value value15
                            inputNumber.onValueChange setValue15
                            inputNumber.prefix "Expires in "
                            inputNumber.suffix " days"
                        ]
                    ]
                    Html.td [
                        Prime.inputNumber [
                            inputNumber.value value16
                            inputNumber.onValueChange setValue16
                            //TODO: Resolve how to use &
                            //inputNumber.prefix "&uarr; "
                            inputNumber.suffix "C"
                            inputNumber.min 0
                            inputNumber.max 40
                        ]
                    ]
                ]
                Html.tr [ Html.th "Buttons" ]
                Html.tr [
                    Html.td "Stacked"
                    Html.td "Horizontal with Step"
                    Html.td "Min-Max Boundaries"
                    Html.td ""
                ]
                Html.tr [
                    Html.td [
                        Prime.inputNumber [
                            inputNumber.value value17
                            inputNumber.onValueChange setValue17
                            inputNumber.mode Currency
                            inputNumber.currency "USD"
                            inputNumber.locale "en-US"
                            inputNumber.showButtons true
                        ]
                    ]
                    Html.td [
                        Prime.inputNumber [
                            inputNumber.value value18
                            inputNumber.onValueChange setValue18
                            inputNumber.mode Currency
                            inputNumber.currency "USD"
                            inputNumber.locale "en-US"
                            inputNumber.showButtons true
                            inputNumber.buttonLayout Horizontal
                            inputNumber.step 0.25
                            inputNumber.decrementButtonClassName buttonClass.danger
                            inputNumber.decrementButtonIcon iconClass.minus
                            inputNumber.incrementButtonClassName buttonClass.success
                            inputNumber.incrementButtonIcon iconClass.plus
                        ]
                    ]
                    Html.td [
                        Prime.inputNumber [
                            inputNumber.value value19
                            inputNumber.onValueChange setValue19
                            inputNumber.mode Decimal
                            inputNumber.showButtons true
                            inputNumber.min 0
                            inputNumber.max 100
                        ]
                    ]
                ]
                Html.tr [ Html.td "Vertical" ]
                Html.tr [
                    Html.td [
                        Prime.inputNumber [
                            inputNumber.value value20
                            inputNumber.onValueChange setValue20
                            inputNumber.showButtons true
                            inputNumber.buttonLayout Vertical
                            inputNumber.decrementButtonClassName buttonClass.secondary
                            inputNumber.incrementButtonClassName buttonClass.secondary
                            inputNumber.style [
                                style.width (length.rem 4)
                            ]
                        ]
                    ]
                ]
            ]
        ]
    ]