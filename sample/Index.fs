module App.Index

open Browser.Dom
open Feliz
open Feliz.PrimeReact

[<ReactComponent>]
let Index () =
    let (activeIndex, setActiveIndex) = React.useState (0)

    Html.div [
        Prime.tabView [
            tabView.activeIndex activeIndex
            tabView.onTabChange setActiveIndex
            tabView.children [
                Prime.tabPanel [
                    tabPanel.header "Data Tables"
                    tabPanel.children [
                        DataTables.DataTables()
                    ]
                ]
                Prime.tabPanel [
                    tabPanel.header "Dialog"
                    tabPanel.children [ Dialog.Dialog() ]
                ]
                Prime.tabPanel [
                    tabPanel.header "Input Controls"
                    tabPanel.children [
                        InputControls.InputControls()
                    ]
                ]
                Prime.tabPanel [
                    tabPanel.header "Input Number"
                    tabPanel.children [
                        InputNumber.InputNumber()
                    ]
                ]
            ]
        ]
    ]