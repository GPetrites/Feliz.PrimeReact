namespace Feliz.PrimeReact

open Feliz
open Fable.Core

[<StringEnum>]
type DialogPosition =
    | Center
    | Top
    | Bottom
    | Left
    | Right
    | [<CompiledName("top-left")>] TopLeft
    | [<CompiledName("top-right")>] TopRight
    | [<CompiledName("bottom-left")>] BottomLeft
    | [<CompiledName("bottom-right")>] BottomRight

[<Erase>]
type dialog =

    static member inline draggable(value: DialogPosition) = Interop.mkDialogAttr "draggable" value
    static member inline footer(value: string) = Interop.mkDialogAttr "footer" value
    static member inline footer(value: Fable.React.ReactElement) = Interop.mkDialogAttr "footer" value
    static member inline header(value: string) = Interop.mkDialogAttr "header" value
    static member inline header(value: Fable.React.ReactElement) = Interop.mkDialogAttr "header" value

    static member inline maximizable(value: bool) =
        Interop.mkDialogAttr "maximizable" value

    static member inline maximized(value: bool) = Interop.mkDialogAttr "maximized" value

    static member inline modal(value: bool) = Interop.mkDialogAttr "modal" value
    static member inline position(value: DialogPosition) = Interop.mkDialogAttr "position" value
    static member inline resizable(value: bool) = Interop.mkDialogAttr "resizable" value
    static member inline visible(value: bool) = Interop.mkDialogAttr "visible" value

    static member inline children(elements: ReactElement list) =
        unbox<IDialogProperty> (prop.children elements)

    static member inline style xs = unbox<IDialogProperty> (prop.style xs)

    static member inline style(value: string) =
        unbox<IDialogProperty> (Interop.reactElementWithChild "style" value)

    static member inline onHide(value: unit -> unit) = Interop.mkDialogAttr "onHide" value