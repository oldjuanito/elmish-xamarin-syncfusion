namespace SqueakyApp

[<AutoOpen>]
module SfMaskedEditExtension =
    open Elmish.XamarinForms.DynamicViews
    open Xamarin.Forms

    //Step 1
    let SfMaskAttribKey = AttributeKey "SfMaskAttribKey"
    let SfValueAttribKey = AttributeKey "SfValueAttribKey"
    let SfValueChangedAttribKey = AttributeKey "SfValueChangedAttribKey"

    type View with
        /// Describes a Map in the view
        static member inline SfMaskedEdit(?mask: string, ?value: string, ?valueChg: (Syncfusion.XForms.MaskedEdit.ValueChangedEventArgs -> unit), //Step 2

                                 // inherited attributes common to all views
                                 ?horizontalOptions, ?verticalOptions, ?margin, ?gestureRecognizers, ?anchorX, ?anchorY, ?backgroundColor, 
                                 ?heightRequest, ?inputTransparent, ?isEnabled, ?isVisible, ?minimumHeightRequest, ?minimumWidthRequest, ?opacity,
                                 ?rotation, ?rotationX, ?rotationY, ?scale, ?style, ?translationX, ?translationY, ?widthRequest,
                                 ?resources, ?styles, ?styleSheets, ?classId, ?styleId) =

            // Count the number of additional attributes
            let attribCount = 0
            //Step 3
            let attribCount = match mask with Some _ -> attribCount + 1 | None -> attribCount 
            let attribCount = match value with Some _ -> attribCount + 1 | None -> attribCount 
            let attribCount = match valueChg with Some _ -> attribCount + 1 | None -> attribCount 

            // Count and populate the inherited attributes
            let attribs =
                View.BuildView(attribCount, ?horizontalOptions=horizontalOptions, ?verticalOptions=verticalOptions,
                               ?margin=margin, ?gestureRecognizers=gestureRecognizers, ?anchorX=anchorX, ?anchorY=anchorY,
                               ?backgroundColor=backgroundColor, ?heightRequest=heightRequest, ?inputTransparent=inputTransparent,
                               ?isEnabled=isEnabled, ?isVisible=isVisible, ?minimumHeightRequest=minimumHeightRequest,
                               ?minimumWidthRequest=minimumWidthRequest, ?opacity=opacity, ?rotation=rotation,
                               ?rotationX=rotationX, ?rotationY=rotationY, ?scale=scale, ?style=style,
                               ?translationX=translationX, ?translationY=translationY, ?widthRequest=widthRequest,
                               ?resources=resources, ?styles=styles, ?styleSheets=styleSheets, ?classId=classId, ?styleId=styleId)
                               
            // Add our own attributes. They must have unique names which must match the names below.
            //Step 4
            match mask with None -> () | Some v -> attribs.Add(SfMaskAttribKey, v) 
            match value with None -> () | Some v -> attribs.Add(SfValueAttribKey, v) 
            match valueChg with 
            | None -> () 
            | Some v -> 
                let v2 = new Syncfusion.XForms.MaskedEdit.ValueChangedEventHandler(fun _sender args -> v args)
                attribs.Add(SfValueChangedAttribKey, v2)
                //attribs.Add(SfValueChangedAttribKey, 
                //    (fun f -> System.EventHandler<Syncfusion.XForms.MaskedEdit.ValueChangedEventArgs>(fun _sender args -> f args))(v))
                

            // The update method
            let update (prevOpt: ViewElement voption) (source: ViewElement) (target: Syncfusion.XForms.MaskedEdit.SfMaskedEdit) =
                View.UpdateView(prevOpt, source, target)
                let dyummy = target.ValueChanged
                target.ValueChanged.AddHandler(fun _sender args -> ())
                //Step 5
                source.UpdatePrimitive(prevOpt, target, SfMaskAttribKey, (fun target v -> target.Mask <- v))
                source.UpdatePrimitive(prevOpt, target, SfValueAttribKey, (fun target v -> target.Value <- v))
                // Step 6 events (they are slighty different when it comes to the update method
                source.UpdateEvent(prevOpt, SfValueChangedAttribKey, target.ValueChanged)

               
            let create () = new Syncfusion.XForms.MaskedEdit.SfMaskedEdit()
            // The element
            ViewElement.Create<Syncfusion.XForms.MaskedEdit.SfMaskedEdit>(create, update, attribs)