namespace Feliz.PrimeReact

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Feliz.ReactApi

[<Erase; RequireQualifiedAccess>]
module Interop =
    let inline mkButtonAttr (key: string) (value: obj) : IButtonProperty = unbox (key, value)
    let inline mkColumnAttr (key: string) (value: obj) : IColumnProperty = unbox (key, value)
    let inline mkDataTableAttr (key: string) (value: obj) : IDataTableProperty = unbox (key, value)
    let inline mkDialogAttr (key: string) (value: obj) : IDialogProperty = unbox (key, value)
    let inline mkDropDownAttr (key: string) (value: obj) : IDropDownProperty = unbox (key, value)
    let inline mkInputNumberAttr (key: string) (value: obj) : IInputNumberProperty = unbox (key, value)
    let inline mkInputTextAttr (key: string) (value: obj) : IInputTextProperty = unbox (key, value)
    let inline mkTabPanelAttr (key: string) (value: obj) : ITabPanelProperty = unbox (key, value)
    let inline mkTabViewAttr (key: string) (value: obj) : ITabViewProperty = unbox (key, value)

    let inline reactElementWithChildren (name: string) (children: #seq<ReactElement>) =
        let reactApi: IReactApi = importDefault "react"
        let reactElement (name: string) (props: 'a) : ReactElement = import "createElement" "react"

        reactElement
            name
            (createObj [
                "children"
                ==> reactApi.Children.toArray (Array.ofSeq children)
             ])