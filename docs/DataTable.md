# DataTable

DataTable provides bindings for [DataTable](https://www.primefaces.org/primereact/datatable/)

Below is a sample of how to use the DataTable bindings. Refer to the code samples in the repository for more examples.

```fsharp
open Feliz
open Feliz.PrimeReact

type row = { Id: int; Name: string; Amt: int }

let data =
    [ 1..20000 ]
    |> List.map (fun i ->
        { Id = i
          Name = (sprintf "Name %i" i)
          Amt = i * 42 })

[<ReactComponent>]
let Component () =
    let (selection, setSelection) = React.useState (initialSelection)

    let idFormat (id: int) =
        Html.header [
            prop.text (sprintf "ID: %i" id)
        ]

    Html.div [
        Prime.dataTable
            data
            [ dataTable.resizableColumns true
              dataTable.size Small
              dataTable.selectionMode DataTableSelection.Single
              dataTable.selection selection
              dataTable.onSelectionChange setSelection
              dataTable.filterDisplay Menu
              dataTable.dataKey "Id"
              dataTable.rows 10
              dataTable.showGridlines true
              dataTable.columnResizeMode Expand
              dataTable.scrollHeight "450px"
              dataTable.scrollable true
              dataTable.virtualScrollerOptions [
                  ItemSize 50
              ]
              dataTable.children [
                  Prime.column [
                      column.selectionMode ColumnSelection.Single
                      column.frozen true
                      column.style [ style.width 40 ]
                  ]
                  Prime.column [
                      column.field (fun r -> r.Id)
                      column.header "#"
                      column.align ColumnAlign.Right
                      column.filter true
                      column.frozen true
                      column.format idFormat
                      column.style [ style.width 80 ]
                  ]
                  Prime.column [
                      column.field (fun r -> r.Name)
                      column.header "Name"
                      column.alignHeader ColumnAlign.Center
                      column.sortable true
                      column.style [
                          style.backgroundColor color.aqua
                      ]
                  ]
                  Prime.column [
                      column.header "Amount"
                      column.field (fun r -> r.Amt)
                      column.body lastYear
                  ]
              ] ]
    ]
```