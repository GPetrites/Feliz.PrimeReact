namespace Feliz.PrimeReact

open Feliz
open Fable.Core

type DropDownOnChangeEvent<'T> = { value: 'T }

[<Erase>]
type dropDown =

    static member inline disabled(value: bool) = Interop.mkDropDownAttr "disabled" value
    static member inline editable(value: bool) = Interop.mkDropDownAttr "editable" value

    static member inline options<'T>(value: 'T seq) =
        Interop.mkDropDownAttr "options" (Seq.toArray value)

    static member inline optionLabel(value: string) =
        Interop.mkDropDownAttr "optionLabel" value

    static member inline optionValue(value: string) =
        Interop.mkDropDownAttr "optionValue" value

    static member inline placeholder(value: string) =
        Interop.mkDropDownAttr "placeholder" value

    static member inline required(value: bool) = Interop.mkDropDownAttr "required" value

    static member inline showFilterClear(value: bool) =
        Interop.mkDropDownAttr "showFilterClear" value

    static member inline showClear(value: bool) =
        Interop.mkDropDownAttr "showClear" value

    static member inline value<'T>(value: 'T option) = Interop.mkDropDownAttr "value" value

    static member inline onChange<'T>(handler: 'T option -> unit) =
        Interop.mkDropDownAttr "onChange" (fun (e: DropDownOnChangeEvent<'T>) -> handler (Some e.value))