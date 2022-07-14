namespace Feliz.PrimeReact

open Feliz
open Fable.Core
open Fable.Core.JsInterop

[<StringEnum>]
type DataTableFilterDisplayType =
    | Menu
    | Row

[<StringEnum>]
type DataTableSizeType =
    | Small
    | Normal
    | Large

[<StringEnum>]
type DataTableSelection =
    | Single
    | Multiple
    | Checkbox
    | Radiobutton

[<StringEnum>]
type ColumnResizeMode =
    | Fit
    | Expand

[<StringEnum>]
type DataTableEditMode =
    | Cell
    | Row

type DataTableSelectionChangeParams<'T> = { value: 'T option }

type DataTableVirtualScrollingOptions =
    | ItemSize of int
    | ShowLoader of bool

[<StringEnum>]
type DataTableRowGroupMode =
    | [<CompiledName("subheader")>] SubHeader
    | [<CompiledName("rowgroup")>] RowGroup

[<StringEnum>]
type DataTableSortMode =
    | Single
    | Multiple

[<Erase>]
type dataTable =
    static member inline className(value: string) =
        Interop.mkDataTableAttr "className" value

    static member inline className(names: seq<string>) =
        Interop.mkDataTableAttr "className" (String.concat " " names)

    static member inline columnResizeMode(value: ColumnResizeMode) =
        Interop.mkDataTableAttr "columnResizeMode" value

    static member inline dataKey(value: string) = Interop.mkDataTableAttr "dataKey" value

    static member inline editMode(value: DataTableEditMode) =
        Interop.mkDataTableAttr "editMode" value

    static member inline filterDisplay(value: DataTableFilterDisplayType) =
        Interop.mkDataTableAttr "filterDisplay" value

    static member inline footerColumnGroup(value: ReactElement) =
        Interop.mkDataTableAttr "footerColumnGroup" value

    static member inline groupRowsBy(value: string) =
        Interop.mkDataTableAttr "groupRowsBy" value

    static member inline headerColumnGroup(value: ReactElement) =
        Interop.mkDataTableAttr "headerColumnGroup" value

    static member inline loading(value: bool) = Interop.mkDataTableAttr "loading" value

    static member inline paginator(value: bool) =
        Interop.mkDataTableAttr "paginator" value

    static member inline removableSort(value: bool) =
        Interop.mkDataTableAttr "removableSort" value

    static member inline resizableColumns(value: bool) =
        Interop.mkDataTableAttr "resizableColumns" value

    static member inline rowGroupFooterTemplate(rowData: 'T -> ReactElement) =
        Interop.mkDataTableAttr "rowGroupFooterTemplate" rowData

    static member inline rowGroupHeaderTemplate(rowData: 'T -> string) =
        Interop.mkDataTableAttr "rowGroupHeaderTemplate" rowData

    static member inline rowGroupHeaderTemplate(rowData: 'T -> ReactElement) =
        Interop.mkDataTableAttr "rowGroupHeaderTemplate" rowData

    static member inline rowGroupMode(value: DataTableRowGroupMode) =
        Interop.mkDataTableAttr "rowGroupMode" value

    static member inline rows(value: int) = Interop.mkDataTableAttr "rows" value

    static member inline scrollable(value: bool) =
        Interop.mkDataTableAttr "scrollable" value

    static member inline scrollHeight(value: string) =
        Interop.mkDataTableAttr "scrollHeight" value

    static member inline selection(value: 'T option) =
        Interop.mkDataTableAttr "selection" value

    static member inline selectionMode(value: DataTableSelection) =
        Interop.mkDataTableAttr "selectionMode" value

    static member inline showGridlines(value: bool) =
        Interop.mkDataTableAttr "showGridlines" value

    static member inline size(value: DataTableSizeType) = Interop.mkDataTableAttr "size" value

    static member inline sortField(value: string) =
        Interop.mkDataTableAttr "sortField" value

    static member inline sortMode(value: DataTableSortMode) =
        Interop.mkDataTableAttr "sortMode" value

    static member inline sortOrder(value: int) =
        Interop.mkDataTableAttr "sortOrder" value

    static member inline style(properties: #Feliz.IStyleAttribute list) =
        Interop.mkDataTableAttr "style" (createObj !!properties)

    static member inline value(value: 'T seq) =
        Interop.mkDataTableAttr "value" (Seq.toArray value)

    static member inline virtualScrollerOptions(value: DataTableVirtualScrollingOptions list) =
        Interop.mkDataTableAttr "virtualScrollerOptions" (keyValueList CaseRules.LowerFirst value)

    static member inline children<'T>(elements: IDataTableChild<'T> list) =
        let elem: ReactElement list = !!elements
        unbox<IDataTableProperty<'T>> (prop.children elem)

    static member inline onSelectionChange(handler: 'T option -> unit) =
        Interop.mkDataTableAttr "onSelectionChange" (fun (e: DataTableSelectionChangeParams<'T>) -> handler e.value)