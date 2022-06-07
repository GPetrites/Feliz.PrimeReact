namespace Feliz.PrimeReact

open Feliz
open Fable.Core
open Fable.Core.JsInterop

[<StringEnum>]
type InputNumberCurrencyDisplay =
    | Code
    | Name
    | Symbol

[<StringEnum>]
type InputNumberButtonLayout =
    | Horizontal
    | Stacked
    | Vertical

[<StringEnum>]
type InputNumberMode =
    | Decimal
    | Currency

type InputNumberOnValueChangeEvent<'T> = { value: 'T }

[<Erase>]
type inputNumber =
    static member inline buttonLayout(value: InputNumberButtonLayout) =
        Interop.mkInputNumberAttr "buttonLayout" value

    static member inline className(value: string) =
        Interop.mkInputNumberAttr "className" value

    static member inline className(names: seq<string>) =
        Interop.mkInputNumberAttr "className" (String.concat " " names)

    static member inline currency(value: string) =
        Interop.mkInputNumberAttr "currency" value

    static member inline currencyDisplay(value: InputNumberCurrencyDisplay) =
        Interop.mkInputNumberAttr "currencyDisplay" value

    static member inline decrementButtonClassName(value: string) =
        Interop.mkInputNumberAttr "decrementButtonClassName" value

    static member inline decrementButtonClassName(names: seq<string>) =
        Interop.mkInputNumberAttr "decrementButtonClassName" (String.concat " " names)

    static member inline decrementButtonIcon(value: string) =
        Interop.mkInputNumberAttr "decrementButtonIcon" value

    static member inline decrementButtonIcon(names: seq<string>) =
        Interop.mkInputNumberAttr "decrementButtonIcon" (String.concat " " names)

    static member inline incrementButtonClassName(value: string) =
        Interop.mkInputNumberAttr "incrementButtonClassName" value

    static member inline incrementButtonClassName(names: seq<string>) =
        Interop.mkInputNumberAttr "incrementButtonClassName" (String.concat " " names)

    static member inline incrementButtonIcon(value: string) =
        Interop.mkInputNumberAttr "incrementButtonIcon" value

    static member inline incrementButtonIcon(names: seq<string>) =
        Interop.mkInputNumberAttr "incrementButtonIcon" (String.concat " " names)

    static member inline locale(value: string) =
        Interop.mkInputNumberAttr "locale" value

    static member inline max(value: float) = Interop.mkInputNumberAttr "max" value
    static member inline max(value: int) = Interop.mkInputNumberAttr "max" value

    static member inline maxFractionDigits(value: int) =
        Interop.mkInputNumberAttr "maxFractionDigits" value

    static member inline min(value: float) = Interop.mkInputNumberAttr "min" value
    static member inline min(value: int) = Interop.mkInputNumberAttr "min" value

    static member inline minFractionDigits(value: int) =
        Interop.mkInputNumberAttr "minFractionDigits" value

    static member inline mode(value: InputNumberMode) = Interop.mkInputNumberAttr "mode" value

    static member inline prefix(value: string) =
        Interop.mkInputNumberAttr "prefix" value

    static member inline step(value: float) = Interop.mkInputNumberAttr "step" value
    static member inline step(value: int) = Interop.mkInputNumberAttr "step" value

    static member inline style(properties: #Feliz.IStyleAttribute list) =
        Interop.mkInputNumberAttr "style" (createObj !!properties)

    static member inline suffix(value: string) =
        Interop.mkInputNumberAttr "suffix" value

    static member inline showButtons(value: bool) =
        Interop.mkInputNumberAttr "showButtons" value

    static member inline value(value: float) = Interop.mkInputNumberAttr "value" value
    static member inline value(value: int) = Interop.mkInputNumberAttr "value" value

    static member inline useGrouping(value: bool) =
        Interop.mkInputNumberAttr "useGrouping" value

    static member inline onValueChange(handler: float -> unit) =
        Interop.mkInputNumberAttr "onChange" (fun (e: InputNumberOnValueChangeEvent<float>) -> handler e.value)

    static member inline onValueChange(handler: int -> unit) =
        Interop.mkInputNumberAttr "onChange" (fun (e: InputNumberOnValueChangeEvent<int>) -> handler e.value)