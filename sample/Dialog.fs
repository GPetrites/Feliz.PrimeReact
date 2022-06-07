module App.Dialog

open Feliz
open Feliz.PrimeReact

[<ReactComponent>]
let Dialog () =
    let (isDialogVisible, setIsDialogVisible) = React.useState (false)
    let showDialog () = setIsDialogVisible true
    let hideDialog () = setIsDialogVisible false

    let dialogFooter =
        Html.div [
            Prime.button [
                button.label "Yes"
                button.onClick hideDialog
            ]
            Prime.button [
                button.label "No"
                button.onClick hideDialog
            ]
        ]

    Html.div [
        Prime.button [
            button.className [
                buttonClass.rounded
                buttonClass.outlined
                buttonClass.help
            ]
            button.label "Add Row"
            button.onClick showDialog
        ]
        Prime.button [
            button.className [
                buttonClass.rounded
                buttonClass.outlined
                buttonClass.info
            ]
            button.label "Cancel"
            button.disabled true
        ]
        Prime.dialog [
            dialog.header "Dialog header"
            dialog.footer dialogFooter
            dialog.visible isDialogVisible
            dialog.onHide hideDialog
            dialog.maximizable true
            dialog.maximized true
            dialog.modal true
            dialog.postion DialogPosition.TopLeft
            dialog.children [
                Html.div "Dialog contents"
            ]
            dialog.resizable true
            dialog.style [
                style.width (length.vw 50)
            ]
        ]
    ]