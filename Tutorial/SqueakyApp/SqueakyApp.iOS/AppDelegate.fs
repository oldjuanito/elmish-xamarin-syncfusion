// Copyright 2018 Elmish.XamarinForms contributors. See LICENSE.md for license.
namespace SqueakyApp.iOS

open System
open UIKit
open Foundation
open Xamarin.Forms
open Xamarin.Forms.Platform.iOS
open Syncfusion.XForms.iOS.MaskedEdit

[<Register ("AppDelegate")>]
type AppDelegate () =
    inherit FormsApplicationDelegate ()

    override this.FinishedLaunching (app, options) =
        Forms.Init()
        let appcore = new SqueakyApp.App()
        this.LoadApplication (appcore)
        SfMaskedEditRenderer.Init()

        base.FinishedLaunching(app, options)

module Main =
    [<EntryPoint>]
    let main args =
        UIApplication.Main(args, null, "AppDelegate")
        0

