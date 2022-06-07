module DataTableEdit

open Browser.Dom
open Feliz
open Feliz.PrimeReact

[<ReactComponent>]
let DataTableEdit () =
    let (rows, setRows) = React.useState (Data.products)

    let updateRow (o: CellOnEditCompleteEvent<Data.Product>) =
        rows
        |> List.map (fun r ->
            if r.Id = o.rowData.Id then
                o.newRowData
            else
                r)
        |> setRows

    let textEditor (opt: CellEditorOptions<string>) =
        Prime.inputText [
            inputText.value opt.value
            inputText.onChange opt.editorCallback
        ]

    let quantityEditor (opt: CellEditorOptions<int>) =
        Prime.inputNumber [
            inputNumber.value opt.value
            inputNumber.onValueChange opt.editorCallback
        ]

    let priceEditor (opt: CellEditorOptions<int>) =
        Prime.inputNumber [
            inputNumber.value opt.value
            inputNumber.onValueChange opt.editorCallback
            inputNumber.mode Currency
            inputNumber.currency "USD"
            inputNumber.locale "en-US"
        ]

    Html.div [
        prop.className "datatable-editing-demo"
        prop.children [
            Html.h3 "Cell Editing"
            Prime.dataTable [
                dataTable.value rows
                dataTable.dataKey "Id"
                dataTable.editMode Cell
                dataTable.className "editable-cells-table"
                dataTable.children [
                    Prime.column [
                        column.field "Code"
                        column.header "Code"
                        column.editor textEditor
                        column.onCellEditComplete updateRow
                        column.style [
                            style.width (length.percent 25)
                        ]
                    ]
                    Prime.column [
                        column.field "Name"
                        column.header "Name"
                        column.editor textEditor
                        column.onCellEditComplete updateRow
                        column.style [
                            style.width (length.percent 25)
                        ]
                    ]
                    Prime.column [
                        column.field "Quantity"
                        column.header "Quantity"
                        column.editor quantityEditor
                        column.onCellEditComplete updateRow
                        column.style [
                            style.width (length.percent 25)
                        ]
                    ]
                    Prime.column [
                        column.field "Price"
                        column.header "Price"
                        column.editor priceEditor
                        column.onCellEditComplete updateRow
                        column.style [
                            style.width (length.percent 25)
                        ]
                    ]
                ]
            ]
        ]
    ]