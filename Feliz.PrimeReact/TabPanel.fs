namespace Feliz.PrimeReact

open Feliz
open Fable.Core

[<Erase>]
type tabPanel =
    static member inline header(value: string) = Interop.mkTabPanelAttr "header" value

    static member inline children(elements: ReactElement list) =
        unbox<ITabPanelProperty> (prop.children elements)