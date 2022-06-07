namespace Feliz.PrimeReact

open Feliz
open Fable.Core
open Fable.Core.JsInterop

type TabViewOnTabChangeEvent = { index: int }

[<Erase>]
type tabView =
    static member inline activeIndex(value: int) =
        Interop.mkTabViewAttr "activeIndex" value

    static member inline children(elements: ReactElement list) =
        unbox<ITabViewProperty> (prop.children elements)

    static member inline onTabChange(handler: TabViewOnTabChangeEvent -> unit) =
        Interop.mkTabViewAttr "onChange" handler

    static member inline onTabChange(handler: int -> unit) =
        Interop.mkTabViewAttr "onChange" (fun (e: TabViewOnTabChangeEvent) -> handler e.index)