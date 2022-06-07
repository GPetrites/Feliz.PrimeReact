module App.DataTableDocumentation

open Feliz
open Feliz.PrimeReact

[<ReactComponent>]
let DataTableDocumentation () =
    let formatDate (d: System.DateTime) = d.ToString("MM/dd/yyyy")

    Html.div [
        Prime.dataTable [
            dataTable.value Data.customers
            dataTable.paginator true
            dataTable.rows 10
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
                    column.field "Representative.Name"
                    column.header "Agent"
                ]
                Prime.column [
                    column.field "Date"
                    column.header "Date"
                    column.dataType Date
                    column.format formatDate
                ]
                Prime.column [
                    column.field "Balance"
                    column.header "Balance"
                ]
                Prime.column [
                    column.field "Status"
                    column.header "Status"
                ]
                Prime.column [
                    column.field "Activity"
                    column.header "Activity"
                ]
            ]
        ]
    ]