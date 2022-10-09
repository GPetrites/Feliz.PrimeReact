module DataTable

open Feliz
open Feliz.PrimeReact

[<ReactComponent>]
let Index () =
    let (activeIndex, setActiveIndex) = React.useState (3)

    Html.div [
        Prime.tabView [
            tabView.activeIndex activeIndex
            tabView.onTabChange setActiveIndex
            tabView.children [
                Prime.tabPanel [
                    tabPanel.header "Documentation"
                    tabPanel.children [
                        DataTableDocumentation.Component()
                    ]
                ]
                Prime.tabPanel [
                    tabPanel.header "Data Table 1"
                    tabPanel.children [
                        DataTable1.Component()
                    ]
                ]
                Prime.tabPanel [
                    tabPanel.header "ColGroup"
                    tabPanel.children [
                        DataTableColGroup.Component()
                    ]
                ]
                Prime.tabPanel [
                    tabPanel.header "RowGroup"
                    tabPanel.children [
                        DataTableRowGroup.Component()
                    ]
                ]
                Prime.tabPanel [
                    tabPanel.header "Edit"
                    tabPanel.children [
                        DataTableEdit.Component()
                    ]
                ]
            ]
        ]
    ]