namespace Feliz

open Feliz
open Fable.Core
open Fable.Core.JsInterop
open Feliz.PrimeReact

[<Erase>]
type Prime =
    static member inline button(properties: IButtonProperty list) =
        Interop.reactApi.createElement (import "Button" "primereact/button", createObj !!properties)

    static member inline column(properties: IColumnProperty list) =
        Interop.reactApi.createElement (import "Column" "primereact/column", createObj !!properties)

    static member inline columnGroup(children: ReactElement list) =
        Interop.reactApi.createElement (
            import "ColumnGroup" "primereact/columngroup",
            createObj [ "children" ==> children ]
        )

    static member inline dataTable(properties: IDataTableProperty list) =
        Interop.reactApi.createElement (import "DataTable" "primereact/datatable", createObj !!properties)

    static member inline dialog(properties: IDialogProperty list) =
        Interop.reactApi.createElement (import "Dialog" "primereact/dialog", createObj !!properties)

    static member inline dropDown(properties: IDropDownProperty list) =
        Interop.reactApi.createElement (import "Dropdown" "primereact/dropdown", createObj !!properties)

    static member inline inputNumber(properties: IInputNumberProperty list) =
        Interop.reactApi.createElement (import "InputNumber" "primereact/inputnumber", createObj !!properties)

    static member inline inputText(properties: IInputTextProperty list) =
        Interop.reactApi.createElement (import "InputText" "primereact/inputtext", createObj !!properties)

    static member inline row(children: ReactElement list) =
        Interop.reactApi.createElement (import "Row" "primereact/row", createObj [ "children" ==> children ])

    static member inline tabPanel(properties: ITabPanelProperty list) =
        Interop.reactApi.createElement (import "TabPanel" "primereact/tabview", createObj !!properties)

    static member inline tabView(properties: ITabViewProperty list) =
        Interop.reactApi.createElement (import "TabView" "primereact/tabview", createObj !!properties)

[<Erase>]
type primeClass =
    static member inline Error e = if e then "p-error" else ""