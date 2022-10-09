namespace Feliz.PrimeReact

open Feliz
open Fable.Core
open Fable.Core.JsInterop
open Fable.Core.DynamicExtensions
open System

[<StringEnum>]
type ColumnSelection =
    | Single
    | Multiple

[<StringEnum>]
type ColumnAlign =
    | Left
    | Right
    | Center

[<StringEnum>]
type ColumnDataType =
    | Date
    | Numeric

type BodyColumnDefinition = { field: string; rowIndex: int }

type CellEditorOptions<'T> =
    { value: 'T
      editorCallback: 'T -> unit }

type CellOnEditCompleteEvent<'T> =
    { cellIndex: int
      rowIndex: int
      originalEvent: Browser.Types.Event
      field: string
      value: string
      newValue: string
      rowData: 'T
      newRowData: 'T }

[<Erase>]
type column =
    static member inline align(value: ColumnAlign) = Interop.mkColumnAttr "align" value

    static member inline alignFooter(value: ColumnAlign) =
        Interop.mkColumnAttr "alignFooter" value

    static member inline alignHeader(value: ColumnAlign) =
        Interop.mkColumnAttr "alignHeader" value

    static member inline body(value: string) = Interop.mkColumnAttr "body" value
    static member inline body<'T>(rowData: 'T -> string) = Interop.mkColumnAttr<'T> "body" rowData
    static member inline body<'T>(rowData: 'T -> ReactElement) = Interop.mkColumnAttr<'T> "body" rowData

    static member inline bodyClassName(value: string) =
        Interop.mkColumnAttr "bodyClassName" value

    static member inline bodyClassName(names: seq<string>) =
        Interop.mkColumnAttr "bodyClassName" (String.concat " " names)

    static member inline bodyStyle(properties: #Feliz.IStyleAttribute list) =
        Interop.mkColumnAttr "bodyStyle" (createObj !!properties)

    static member inline className(value: string) = Interop.mkColumnAttr "className" value

    static member inline className(names: seq<string>) =
        Interop.mkColumnAttr "className" (String.concat " " names)

    static member inline colSpan(value: int) = Interop.mkColumnAttr "colSpan" value
    static member inline dataType(value: ColumnDataType) = Interop.mkColumnAttr "dataType" value

    static member inline field<'T, 'D>(value: ('T -> 'D)) =
        Experimental.namesofLambda (value)
        |> String.concat "."
        |> Interop.mkColumnAttr<'T> "field"

    static member inline fieldName(value: string) = Interop.mkColumnAttr<'T> "field" value

    static member inline filter(value: bool) = Interop.mkColumnAttr "filter" value
    static member inline footer(value: string) = Interop.mkColumnAttr "footer" value

    static member inline footerClassName(value: string) =
        Interop.mkColumnAttr "footerClassName" value

    static member inline footerClassName(names: seq<string>) =
        Interop.mkColumnAttr "footerClassName" (String.concat " " names)

    static member inline footerStyle(properties: #Feliz.IStyleAttribute list) =
        Interop.mkColumnAttr "footerStyle" (createObj !!properties)

    /// <summary>
    /// A template similar to body, but receives just the value of the cell
    /// </summary>
    /// <param name="names"></param>
    static member inline format(cellValue: 'T -> string) =
        let template rowData (column: BodyColumnDefinition) = cellValue !!rowData.[column.field]
        let uncurriedTemplate = Func<obj, BodyColumnDefinition, string> template
        Interop.mkColumnAttr "body" uncurriedTemplate

    /// <summary>
    /// A template similar to body, but receives just the value of the cell
    /// </summary>
    /// <param name="names"></param>
    static member inline format(cellValue: 'T -> ReactElement) =
        let template rowData (column: BodyColumnDefinition) = cellValue !!rowData.[column.field]
        let uncurriedTemplate = Func<obj, BodyColumnDefinition, ReactElement> template
        Interop.mkColumnAttr "body" uncurriedTemplate

    static member inline editor(value: CellEditorOptions<'T> -> ReactElement) = Interop.mkColumnAttr "editor" value

    static member inline frozen(value: bool) = Interop.mkColumnAttr "frozen" value
    static member inline header(value: string) = Interop.mkColumnAttr "header" value

    static member inline headerclassName(value: string) =
        Interop.mkColumnAttr "headerclassName" value

    static member inline headerclassName(names: seq<string>) =
        Interop.mkColumnAttr "headerclassName" (String.concat " " names)

    static member inline headerStyle(properties: #Feliz.IStyleAttribute list) =
        Interop.mkColumnAttr "headerStyle" (createObj !!properties)

    static member inline resizeable(value: bool) = Interop.mkColumnAttr "resizeable" value
    static member inline rowSpan(value: int) = Interop.mkColumnAttr "rowSpan" value

    static member inline selectionMode(value: ColumnSelection) =
        Interop.mkColumnAttr "selectionMode" value

    static member inline sortable(value: bool) = Interop.mkColumnAttr "sortable" value

    static member inline style(properties: #Feliz.IStyleAttribute list) =
        Interop.mkColumnAttr "style" (createObj !!properties)

    static member inline onCellEditComplete(handler: CellOnEditCompleteEvent<'T> -> unit) =
        Interop.mkColumnAttr "onCellEditComplete" handler