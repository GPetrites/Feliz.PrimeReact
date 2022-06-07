module Main

open Feliz
open App
open Browser.Dom
open Fable.Core.JsInterop

importSideEffects "./styles/global.scss"

importAll "../node_modules/primereact/resources/themes/fluent-light/theme.css"
importAll "../node_modules/primereact/resources/primereact.min.css"
importAll "../node_modules/primeicons/primeicons.css"

ReactDOM.render (Index.Index(), document.getElementById "feliz-app")