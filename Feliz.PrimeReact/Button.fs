namespace Feliz.PrimeReact

open Feliz
open Fable.Core
open Fable.Core.JsInterop

[<Erase>]
type button =

    static member inline className(value: string) = Interop.mkButtonAttr "className" value

    static member inline className(names: seq<string>) =
        Interop.mkButtonAttr "className" (String.concat " " names)

    static member inline disabled(value: bool) = Interop.mkButtonAttr "disabled" value
    static member inline label(value: string) = Interop.mkButtonAttr "label" value

    static member inline style(properties: #Feliz.IStyleAttribute list) =
        Interop.mkButtonAttr "style" (createObj !!properties)

    static member inline onClick(value: Browser.Types.Event -> unit) = Interop.mkButtonAttr "onClick" value
    static member inline onClick(value: unit -> unit) = Interop.mkButtonAttr "onClick" value

[<Erase>]
type buttonClass =
    static member inline secondary = "p-button-secondary"
    static member inline success = "p-button-success"
    static member inline info = "p-button-info"
    static member inline warning = "p-button-warning"
    static member inline help = "p-button-help"
    static member inline danger = "p-button-danger"
    static member inline raised = "p-button-raised"
    static member inline rounded = "p-button-rounded"
    static member inline text = "p-button-text"
    static member inline outlined = "p-button-outlined"