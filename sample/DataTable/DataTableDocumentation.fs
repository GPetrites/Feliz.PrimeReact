module DataTableDocumentation

open Feliz
open Feliz.PrimeReact

[<ReactComponent>]
let Component () =
    let formatDate (d: System.DateTime) = d.ToString("MM/dd/yyyy")

    Html.div [
        Prime.dataTable
            Data.customers
            [ dataTable.paginator true
              dataTable.rows 10
              dataTable.children [
                  Prime.column [
                      column.field (fun r -> r.Name)
                      column.header "Name"
                  ]
                  Prime.column [
                      column.field (fun r -> r.Country.Name)
                      column.header "Country"
                  ]
                  Prime.column [
                      column.field (fun r -> r.Representative.Name)
                      column.header "Agent"
                  ]
                  Prime.column [
                      column.field (fun r -> r.Date)
                      column.header "Date"
                      column.dataType Date
                      column.format formatDate
                  ]
                  Prime.column [
                      column.field (fun r -> r.Balance)
                      column.header "Balance"
                  ]
                  Prime.column [
                      column.field (fun r -> r.Status)
                      column.header "Status"
                  ]
                  Prime.column [
                      column.field (fun r -> r.Activity)
                      column.header "Activity"
                  ]
              ] ]
    ]