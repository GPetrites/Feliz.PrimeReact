namespace Feliz.PrimeReact

open Feliz
open Fable.Core
open Fable.Core.JsInterop

type InputTextOnChangeTarget = { value: string }
type InputTextOnChangeEvent = { target: InputTextOnChangeTarget }

[<Erase>]
type inputText =
    static member inline className(value: string) =
        Interop.mkInputTextAttr "className" value

    static member inline className(names: seq<string>) =
        Interop.mkInputTextAttr "className" (String.concat " " names)

    static member inline placeholder(value: string) =
        Interop.mkInputTextAttr "placeholder" value

    static member inline style(properties: #Feliz.IStyleAttribute list) =
        Interop.mkInputTextAttr "style" (createObj !!properties)

    static member inline value(value: string) = Interop.mkInputTextAttr "value" value

    static member inline onChange(handler: string -> unit) =
        Interop.mkInputTextAttr "onChange" (fun (e: InputTextOnChangeEvent) -> handler e.target.value)

[<Erase>]
type inputTextClass =
    static member inline small = "p-inputtext-sm"
    static member inline large = "p-inputtext-lg"
    static member inline error e = if e then "p-invalid" else ""