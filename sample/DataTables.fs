module App.DataTables

open Feliz
open Feliz.PrimeReact

[<ReactComponent>]
let DataTables () =
    let (activeIndex, setActiveIndex) = React.useState (3)

    Html.div [
        Prime.tabView [
            tabView.activeIndex activeIndex
            tabView.onTabChange setActiveIndex
            tabView.children [
                Prime.tabPanel [
                    tabPanel.header "Documentation"
                    tabPanel.children [
                        DataTableDocumentation.DataTableDocumentation()
                    ]
                ]
                Prime.tabPanel [
                    tabPanel.header "Data Table 1"
                    tabPanel.children [
                        DataTable1.DataTable1()
                    ]
                ]
                Prime.tabPanel [
                    tabPanel.header "ColGroup"
                    tabPanel.children [
                        DataTableColGroup.DataTableColGroup()
                    ]
                ]
                Prime.tabPanel [
                    tabPanel.header "RowGroup"
                    tabPanel.children [
                        DataTableRowGroup.DataTableRowGroup()
                    ]
                ]
                Prime.tabPanel [
                    tabPanel.header "Edit"
                    tabPanel.children [
                        DataTableEdit.DataTableEdit()
                    ]
                ]
            ]
        ]
    ]