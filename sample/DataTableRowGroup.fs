module App.DataTableRowGroup

open Browser.Dom
open Feliz
open Feliz.PrimeReact

[<ReactComponent>]
let DataTableRowGroup () =
    let rowGroupHeaderTemplate (data: Data.Customer) =
        Html.span [
            prop.text data.Representative.Name
            prop.style [ style.fontWeight.bold ]
        ]

    let calculateCustomerTotal name =
        Data.customers
        |> List.filter (fun c -> c.Representative.Name = name)
        |> List.length

    let rowGroupFooterTemplate (data: Data.Customer) =
        React.fragment [
            Html.td [
                prop.text "Total Customers"
                prop.colSpan 2
                prop.style [ style.fontWeight.bold ]
            ]
            Html.td [
                prop.style [ style.fontWeight.bold ]
                prop.text (
                    data.Representative.Name
                    |> calculateCustomerTotal
                    |> string
                )
            ]
        ]

    Html.div [
        Html.h5 "Subheader Grouping"
        Html.p "Group customers by their representative."
        Prime.dataTable [
            dataTable.value Data.customers
            dataTable.size Small
            dataTable.showGridlines true
            dataTable.groupRowsBy "Representative.Name"
            dataTable.sortField "Representative.Name"
            dataTable.sortOrder 1
            dataTable.rowGroupMode SubHeader
            dataTable.sortMode DataTableSortMode.Single
            dataTable.rowGroupHeaderTemplate rowGroupHeaderTemplate
            dataTable.rowGroupFooterTemplate rowGroupFooterTemplate
            dataTable.children [
                Prime.column [
                    column.field "Name"
                    column.header "Name"
                ]
                Prime.column [
                    column.field "Country.Name"
                    column.header "Country"
                ]
                Prime.column [
                    column.field "Company"
                    column.header "Company"
                ]
                Prime.column [
                    column.field "Status"
                    column.header "Status"
                ]
            ]
        ]
    ]