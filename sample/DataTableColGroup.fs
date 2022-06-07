module App.DataTableColGroup

open Feliz
open Feliz.PrimeReact

type Sale =
    { product: string
      lastYearSale: int
      thisYearSale: int
      lastYearProfit: int
      thisYearProfit: int }

let sales =
    [ { product = "Bamboo Watch"
        lastYearSale = 51
        thisYearSale = 40
        lastYearProfit = 54406
        thisYearProfit = 43342 }
      { product = "Black Watch"
        lastYearSale = 83
        thisYearSale = 9
        lastYearProfit = 423132
        thisYearProfit = 312122 }
      { product = "Blue Band"
        lastYearSale = 38
        thisYearSale = 5
        lastYearProfit = 12321
        thisYearProfit = 8500 }
      { product = "Blue T-Shirt"
        lastYearSale = 49
        thisYearSale = 22
        lastYearProfit = 745232
        thisYearProfit = 65323 }
      { product = "Brown Purse"
        lastYearSale = 17
        thisYearSale = 79
        lastYearProfit = 643242
        thisYearProfit = 500332 }
      { product = "Chakra Bracelet"
        lastYearSale = 52
        thisYearSale = 65
        lastYearProfit = 421132
        thisYearProfit = 150005 }
      { product = "Galaxy Earrings"
        lastYearSale = 82
        thisYearSale = 12
        lastYearProfit = 131211
        thisYearProfit = 100214 }
      { product = "Game Controller"
        lastYearSale = 44
        thisYearSale = 45
        lastYearProfit = 66442
        thisYearProfit = 53322 }
      { product = "Gaming Set"
        lastYearSale = 90
        thisYearSale = 56
        lastYearProfit = 765442
        thisYearProfit = 296232 }
      { product = "Gold Phone Case"
        lastYearSale = 75
        thisYearSale = 54
        lastYearProfit = 21212
        thisYearProfit = 12533 } ]

let initialSelection: Option<Sale> = None

[<ReactComponent>]
let DataTableColGroup () =
    let headerGroup =
        Prime.columnGroup [
            Prime.row [
                Prime.column [
                    column.header "Product"
                    column.rowSpan 3
                ]
                Prime.column [
                    column.header "Sale Rate"
                    column.colSpan 4
                ]
            ]
            Prime.row [
                Prime.column [
                    column.header "Sales"
                    column.colSpan 2
                ]
                Prime.column [
                    column.header "Profits"
                    column.colSpan 2
                ]
            ]
            Prime.row [
                Prime.column [
                    column.header "Last Year"
                    column.sortable true
                ]
                Prime.column [
                    column.header "This Year"
                    column.sortable true
                ]
                Prime.column [
                    column.header "Last Year"
                    column.sortable true
                ]
                Prime.column [
                    column.header "This Year"
                    column.sortable true
                ]
            ]
        ]

    let lastYearTotal =
        sales
        |> List.map (fun s -> s.lastYearSale)
        |> List.sum
        |> string

    let thisYearTotal =
        sales
        |> List.map (fun s -> s.thisYearSale)
        |> List.sum
        |> string

    let footerGroup =
        Prime.columnGroup [
            Prime.row [
                Prime.column [
                    column.footer "Totals:"
                    column.footerStyle [
                        style.textAlign.right
                    ]
                    column.colSpan 3
                ]
                Prime.column [
                    column.footer lastYearTotal
                ]
                Prime.column [
                    column.footer thisYearTotal
                ]
            ]
        ]

    Html.div [
        Prime.dataTable [
            dataTable.headerColumnGroup headerGroup
            dataTable.footerColumnGroup footerGroup
            dataTable.value sales
            dataTable.children [
                Prime.column [ column.field "product" ]
                Prime.column [
                    column.field "lastYearSale"
                ]
                Prime.column [
                    column.field "thisYearSale"
                ]
                Prime.column [
                    column.field "lastYearProfit"
                ]
                Prime.column [
                    column.field "thisYearProfit"
                ]
            ]
        ]
    ]