namespace SqueakyApp

[<AutoOpen>]
module SfCalendarExtension =
    open Elmish.XamarinForms.DynamicViews

    open Xamarin.Forms

    //Step 1
    let SfCalendarMinDateAttribKey = AttributeKey "SfCalendar_MinDate"

    type View with
        /// Describes a Map in the view
        static member inline SfCalendar(?minDate: System.DateTime, //Step 2
                                 // inherited attributes common to all views
                                 ?horizontalOptions, ?verticalOptions, ?margin, ?gestureRecognizers, ?anchorX, ?anchorY, ?backgroundColor, 
                                 ?heightRequest, ?inputTransparent, ?isEnabled, ?isVisible, ?minimumHeightRequest, ?minimumWidthRequest, ?opacity,
                                 ?rotation, ?rotationX, ?rotationY, ?scale, ?style, ?translationX, ?translationY, ?widthRequest,
                                 ?resources, ?styles, ?styleSheets, ?classId, ?styleId) =

            // Count the number of additional attributes
            let attribCount = 0
            let attribCount = match minDate with Some _ -> attribCount + 1 | None -> attribCount //Step 3

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
            match minDate with None -> () | Some v -> attribs.Add(SfCalendarMinDateAttribKey, v) //Step 4

            // The update method
            let update (prevOpt: ViewElement voption) (source: ViewElement) (target: Syncfusion.SfCalendar.XForms.SfCalendar) =
                View.UpdateView(prevOpt, source, target)
                //Step 5
                source.UpdatePrimitive(prevOpt, target, SfCalendarMinDateAttribKey, (fun target v -> target.MinDate <- v))

            let create () = new Syncfusion.SfCalendar.XForms.SfCalendar()
            // The element
            ViewElement.Create<Syncfusion.SfCalendar.XForms.SfCalendar>(create, update, attribs)