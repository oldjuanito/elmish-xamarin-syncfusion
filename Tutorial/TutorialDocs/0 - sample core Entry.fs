/// Builds the attributes for a Entry in the view

    [<System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)>]

    static member inline BuildEntry(attribCount: int, ?text: string, ?placeholder: string, ?horizontalTextAlignment: Xamarin.Forms.TextAlignment, 
    ?fontSize: obj, ?fontFamily: string, ?fontAttributes: Xamarin.Forms.FontAttributes, ?textColor: Xamarin.Forms.Color, 
    ?placeholderColor: Xamarin.Forms.Color, ?isPassword: bool, ?completed: string -> unit, ?textChanged: Xamarin.Forms.TextChangedEventArgs -> unit, 
    ?keyboard: Xamarin.Forms.Keyboard, ?horizontalOptions: Xamarin.Forms.LayoutOptions, ?verticalOptions: Xamarin.Forms.LayoutOptions, ?margin: obj, 
    ?gestureRecognizers: ViewElement list, ?anchorX: double, ?anchorY: double, ?backgroundColor: Xamarin.Forms.Color, ?heightRequest: double, 
    ?inputTransparent: bool, ?isEnabled: bool, ?isVisible: bool, ?minimumHeightRequest: double, ?minimumWidthRequest: double, ?opacity: double, 
    ?rotation: double, ?rotationX: double, ?rotationY: double, ?scale: double, ?style: Xamarin.Forms.Style, ?translationX: double, ?translationY: double, 
    ?widthRequest: double, ?resources: (string * obj) list, ?styles: Xamarin.Forms.Style list, ?styleSheets: Xamarin.Forms.StyleSheets.StyleSheet list, 
    ?classId: string, ?styleId: string) = 



        let attribCount = match text with Some _ -> attribCount + 1 | None -> attribCount

        let attribCount = match placeholder with Some _ -> attribCount + 1 | None -> attribCount

        let attribCount = match horizontalTextAlignment with Some _ -> attribCount + 1 | None -> attribCount

        let attribCount = match fontSize with Some _ -> attribCount + 1 | None -> attribCount

        let attribCount = match fontFamily with Some _ -> attribCount + 1 | None -> attribCount

        let attribCount = match fontAttributes with Some _ -> attribCount + 1 | None -> attribCount

        let attribCount = match textColor with Some _ -> attribCount + 1 | None -> attribCount

        let attribCount = match placeholderColor with Some _ -> attribCount + 1 | None -> attribCount

        let attribCount = match isPassword with Some _ -> attribCount + 1 | None -> attribCount

        let attribCount = match completed with Some _ -> attribCount + 1 | None -> attribCount

        let attribCount = match textChanged with Some _ -> attribCount + 1 | None -> attribCount



        let attribBuilder = View.BuildInputView(attribCount, ?keyboard=keyboard, ?horizontalOptions=horizontalOptions, ?verticalOptions=verticalOptions, ?margin=margin, ?gestureRecognizers=gestureRecognizers, ?anchorX=anchorX, ?anchorY=anchorY, ?backgroundColor=backgroundColor, ?heightRequest=heightRequest, ?inputTransparent=inputTransparent, ?isEnabled=isEnabled, ?isVisible=isVisible, ?minimumHeightRequest=minimumHeightRequest, ?minimumWidthRequest=minimumWidthRequest, ?opacity=opacity, ?rotation=rotation, ?rotationX=rotationX, ?rotationY=rotationY, ?scale=scale, ?style=style, ?translationX=translationX, ?translationY=translationY, ?widthRequest=widthRequest, ?resources=resources, ?styles=styles, ?styleSheets=styleSheets, ?classId=classId, ?styleId=styleId)

        match text with None -> () | Some v -> attribBuilder.Add(View._TextAttribKey, (v)) 

        match placeholder with None -> () | Some v -> attribBuilder.Add(View._PlaceholderAttribKey, (v)) 

        match horizontalTextAlignment with None -> () | Some v -> attribBuilder.Add(View._HorizontalTextAlignmentAttribKey, (v)) 

        match fontSize with None -> () | Some v -> attribBuilder.Add(View._FontSizeAttribKey, makeFontSize(v)) 

        match fontFamily with None -> () | Some v -> attribBuilder.Add(View._FontFamilyAttribKey, (v)) 

        match fontAttributes with None -> () | Some v -> attribBuilder.Add(View._FontAttributesAttribKey, (v)) 

        match textColor with None -> () | Some v -> attribBuilder.Add(View._TextColorAttribKey, (v)) 

        match placeholderColor with None -> () | Some v -> attribBuilder.Add(View._PlaceholderColorAttribKey, (v)) 

        match isPassword with None -> () | Some v -> attribBuilder.Add(View._IsPasswordAttribKey, (v)) 

        match completed with None -> () | Some v -> attribBuilder.Add(View._EntryCompletedAttribKey, (fun f -> System.EventHandler(fun sender args -> f (sender :?> Xamarin.Forms.Entry).Text))(v)) 

        match textChanged with None -> () | Some v -> attribBuilder.Add(View._TextChangedAttribKey, 
            (fun f -> System.EventHandler<Xamarin.Forms.TextChangedEventArgs>(fun _sender args -> f args))(v)) 

        attribBuilder



    [<System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)>]

    static member val CreateFuncEntry : (unit -> Xamarin.Forms.Entry) = (fun () -> View.CreateEntry())



    [<System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)>]

    static member CreateEntry () : Xamarin.Forms.Entry = 

            upcast (new Xamarin.Forms.Entry())



    [<System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)>]

    static member val UpdateFuncEntry = (fun (prevOpt: ViewElement voption) (curr: ViewElement) (target: Xamarin.Forms.Entry) -> View.UpdateEntry (prevOpt, curr, target)) 



    [<System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)>]

    static member UpdateEntry (prevOpt: ViewElement voption, curr: ViewElement, target: Xamarin.Forms.Entry) = 

        // update the inherited InputView element

        let baseElement = (if View.ProtoInputView.IsNone then View.ProtoInputView <- Some (View.InputView())); View.ProtoInputView.Value

        baseElement.UpdateInherited (prevOpt, curr, target)

        let mutable prevTextOpt = ValueNone

        let mutable currTextOpt = ValueNone

        let mutable prevPlaceholderOpt = ValueNone

        let mutable currPlaceholderOpt = ValueNone

        let mutable prevHorizontalTextAlignmentOpt = ValueNone

        let mutable currHorizontalTextAlignmentOpt = ValueNone

        let mutable prevFontSizeOpt = ValueNone

        let mutable currFontSizeOpt = ValueNone

        let mutable prevFontFamilyOpt = ValueNone

        let mutable currFontFamilyOpt = ValueNone

        let mutable prevFontAttributesOpt = ValueNone

        let mutable currFontAttributesOpt = ValueNone

        let mutable prevTextColorOpt = ValueNone

        let mutable currTextColorOpt = ValueNone

        let mutable prevPlaceholderColorOpt = ValueNone

        let mutable currPlaceholderColorOpt = ValueNone

        let mutable prevIsPasswordOpt = ValueNone

        let mutable currIsPasswordOpt = ValueNone

        let mutable prevEntryCompletedOpt = ValueNone

        let mutable currEntryCompletedOpt = ValueNone

        let mutable prevTextChangedOpt = ValueNone

        let mutable currTextChangedOpt = ValueNone

        for kvp in curr.AttributesKeyed do

            if kvp.Key = View._TextAttribKey.KeyValue then 

                currTextOpt <- ValueSome (kvp.Value :?> string)

            if kvp.Key = View._PlaceholderAttribKey.KeyValue then 

                currPlaceholderOpt <- ValueSome (kvp.Value :?> string)

            if kvp.Key = View._HorizontalTextAlignmentAttribKey.KeyValue then 

                currHorizontalTextAlignmentOpt <- ValueSome (kvp.Value :?> Xamarin.Forms.TextAlignment)

            if kvp.Key = View._FontSizeAttribKey.KeyValue then 

                currFontSizeOpt <- ValueSome (kvp.Value :?> double)

            if kvp.Key = View._FontFamilyAttribKey.KeyValue then 

                currFontFamilyOpt <- ValueSome (kvp.Value :?> string)

            if kvp.Key = View._FontAttributesAttribKey.KeyValue then 

                currFontAttributesOpt <- ValueSome (kvp.Value :?> Xamarin.Forms.FontAttributes)

            if kvp.Key = View._TextColorAttribKey.KeyValue then 

                currTextColorOpt <- ValueSome (kvp.Value :?> Xamarin.Forms.Color)

            if kvp.Key = View._PlaceholderColorAttribKey.KeyValue then 

                currPlaceholderColorOpt <- ValueSome (kvp.Value :?> Xamarin.Forms.Color)

            if kvp.Key = View._IsPasswordAttribKey.KeyValue then 

                currIsPasswordOpt <- ValueSome (kvp.Value :?> bool)

            if kvp.Key = View._EntryCompletedAttribKey.KeyValue then 

                currEntryCompletedOpt <- ValueSome (kvp.Value :?> System.EventHandler)

            if kvp.Key = View._TextChangedAttribKey.KeyValue then 

                currTextChangedOpt <- ValueSome (kvp.Value :?> System.EventHandler<Xamarin.Forms.TextChangedEventArgs>)

        match prevOpt with

        | ValueNone -> ()

        | ValueSome prev ->

            for kvp in prev.AttributesKeyed do

                if kvp.Key = View._TextAttribKey.KeyValue then 

                    prevTextOpt <- ValueSome (kvp.Value :?> string)

                if kvp.Key = View._PlaceholderAttribKey.KeyValue then 

                    prevPlaceholderOpt <- ValueSome (kvp.Value :?> string)

                if kvp.Key = View._HorizontalTextAlignmentAttribKey.KeyValue then 

                    prevHorizontalTextAlignmentOpt <- ValueSome (kvp.Value :?> Xamarin.Forms.TextAlignment)

                if kvp.Key = View._FontSizeAttribKey.KeyValue then 

                    prevFontSizeOpt <- ValueSome (kvp.Value :?> double)

                if kvp.Key = View._FontFamilyAttribKey.KeyValue then 

                    prevFontFamilyOpt <- ValueSome (kvp.Value :?> string)

                if kvp.Key = View._FontAttributesAttribKey.KeyValue then 

                    prevFontAttributesOpt <- ValueSome (kvp.Value :?> Xamarin.Forms.FontAttributes)

                if kvp.Key = View._TextColorAttribKey.KeyValue then 

                    prevTextColorOpt <- ValueSome (kvp.Value :?> Xamarin.Forms.Color)

                if kvp.Key = View._PlaceholderColorAttribKey.KeyValue then 

                    prevPlaceholderColorOpt <- ValueSome (kvp.Value :?> Xamarin.Forms.Color)

                if kvp.Key = View._IsPasswordAttribKey.KeyValue then 

                    prevIsPasswordOpt <- ValueSome (kvp.Value :?> bool)

                if kvp.Key = View._EntryCompletedAttribKey.KeyValue then 

                    prevEntryCompletedOpt <- ValueSome (kvp.Value :?> System.EventHandler)

                if kvp.Key = View._TextChangedAttribKey.KeyValue then 

                    prevTextChangedOpt <- ValueSome (kvp.Value :?> System.EventHandler<Xamarin.Forms.TextChangedEventArgs>)

        match prevTextOpt, currTextOpt with

        | ValueSome prevValue, ValueSome currValue when prevValue = currValue -> ()

        | _, ValueSome currValue -> target.Text <-  currValue

        | ValueSome _, ValueNone -> target.Text <- null

        | ValueNone, ValueNone -> ()

        match prevPlaceholderOpt, currPlaceholderOpt with

        | ValueSome prevValue, ValueSome currValue when prevValue = currValue -> ()

        | _, ValueSome currValue -> target.Placeholder <-  currValue

        | ValueSome _, ValueNone -> target.Placeholder <- null

        | ValueNone, ValueNone -> ()

        match prevHorizontalTextAlignmentOpt, currHorizontalTextAlignmentOpt with

        | ValueSome prevValue, ValueSome currValue when prevValue = currValue -> ()

        | _, ValueSome currValue -> target.HorizontalTextAlignment <-  currValue

        | ValueSome _, ValueNone -> target.HorizontalTextAlignment <- Xamarin.Forms.TextAlignment.Start

        | ValueNone, ValueNone -> ()

        match prevFontSizeOpt, currFontSizeOpt with

        | ValueSome prevValue, ValueSome currValue when prevValue = currValue -> ()

        | _, ValueSome currValue -> target.FontSize <-  currValue

        | ValueSome _, ValueNone -> target.FontSize <- -1.0

        | ValueNone, ValueNone -> ()

        match prevFontFamilyOpt, currFontFamilyOpt with

        | ValueSome prevValue, ValueSome currValue when prevValue = currValue -> ()

        | _, ValueSome currValue -> target.FontFamily <-  currValue

        | ValueSome _, ValueNone -> target.FontFamily <- null

        | ValueNone, ValueNone -> ()

        match prevFontAttributesOpt, currFontAttributesOpt with

        | ValueSome prevValue, ValueSome currValue when prevValue = currValue -> ()

        | _, ValueSome currValue -> target.FontAttributes <-  currValue

        | ValueSome _, ValueNone -> target.FontAttributes <- Xamarin.Forms.FontAttributes.None

        | ValueNone, ValueNone -> ()

        match prevTextColorOpt, currTextColorOpt with

        | ValueSome prevValue, ValueSome currValue when prevValue = currValue -> ()

        | _, ValueSome currValue -> target.TextColor <-  currValue

        | ValueSome _, ValueNone -> target.TextColor <- Xamarin.Forms.Color.Default

        | ValueNone, ValueNone -> ()

        match prevPlaceholderColorOpt, currPlaceholderColorOpt with

        | ValueSome prevValue, ValueSome currValue when prevValue = currValue -> ()

        | _, ValueSome currValue -> target.PlaceholderColor <-  currValue

        | ValueSome _, ValueNone -> target.PlaceholderColor <- Xamarin.Forms.Color.Default

        | ValueNone, ValueNone -> ()

        match prevIsPasswordOpt, currIsPasswordOpt with

        | ValueSome prevValue, ValueSome currValue when prevValue = currValue -> ()

        | _, ValueSome currValue -> target.IsPassword <-  currValue

        | ValueSome _, ValueNone -> target.IsPassword <- false

        | ValueNone, ValueNone -> ()

        match prevEntryCompletedOpt, currEntryCompletedOpt with

        | ValueSome prevValue, ValueSome currValue when identical prevValue currValue -> ()

        | ValueSome prevValue, ValueSome currValue -> target.Completed.RemoveHandler(prevValue); target.Completed.AddHandler(currValue)

        | ValueNone, ValueSome currValue -> target.Completed.AddHandler(currValue)

        | ValueSome prevValue, ValueNone -> target.Completed.RemoveHandler(prevValue)

        | ValueNone, ValueNone -> ()

        match prevTextChangedOpt, currTextChangedOpt with

        | ValueSome prevValue, ValueSome currValue when identical prevValue currValue -> ()

        | ValueSome prevValue, ValueSome currValue -> target.TextChanged.RemoveHandler(prevValue); target.TextChanged.AddHandler(currValue)

        | ValueNone, ValueSome currValue -> target.TextChanged.AddHandler(currValue)

        | ValueSome prevValue, ValueNone -> target.TextChanged.RemoveHandler(prevValue)

        | ValueNone, ValueNone -> ()



    /// Describes a Entry in the view

    static member inline Entry(?text: string, ?placeholder: string, ?horizontalTextAlignment: Xamarin.Forms.TextAlignment, ?fontSize: obj, ?fontFamily: string, ?fontAttributes: Xamarin.Forms.FontAttributes, ?textColor: Xamarin.Forms.Color, ?placeholderColor: Xamarin.Forms.Color, ?isPassword: bool, ?completed: string -> unit, ?textChanged: Xamarin.Forms.TextChangedEventArgs -> unit, ?keyboard: Xamarin.Forms.Keyboard, ?horizontalOptions: Xamarin.Forms.LayoutOptions, ?verticalOptions: Xamarin.Forms.LayoutOptions, ?margin: obj, ?gestureRecognizers: ViewElement list, ?anchorX: double, ?anchorY: double, ?backgroundColor: Xamarin.Forms.Color, ?heightRequest: double, ?inputTransparent: bool, ?isEnabled: bool, ?isVisible: bool, ?minimumHeightRequest: double, ?minimumWidthRequest: double, ?opacity: double, ?rotation: double, ?rotationX: double, ?rotationY: double, ?scale: double, ?style: Xamarin.Forms.Style, ?translationX: double, ?translationY: double, ?widthRequest: double, ?resources: (string * obj) list, ?styles: Xamarin.Forms.Style list, ?styleSheets: Xamarin.Forms.StyleSheets.StyleSheet list, ?classId: string, ?styleId: string) = 



        let attribBuilder = View.BuildEntry(0, ?text=text, ?placeholder=placeholder, ?horizontalTextAlignment=horizontalTextAlignment, ?fontSize=fontSize, ?fontFamily=fontFamily, ?fontAttributes=fontAttributes, ?textColor=textColor, ?placeholderColor=placeholderColor, ?isPassword=isPassword, ?completed=completed, ?textChanged=textChanged, ?keyboard=keyboard, ?horizontalOptions=horizontalOptions, ?verticalOptions=verticalOptions, ?margin=margin, ?gestureRecognizers=gestureRecognizers, ?anchorX=anchorX, ?anchorY=anchorY, ?backgroundColor=backgroundColor, ?heightRequest=heightRequest, ?inputTransparent=inputTransparent, ?isEnabled=isEnabled, ?isVisible=isVisible, ?minimumHeightRequest=minimumHeightRequest, ?minimumWidthRequest=minimumWidthRequest, ?opacity=opacity, ?rotation=rotation, ?rotationX=rotationX, ?rotationY=rotationY, ?scale=scale, ?style=style, ?translationX=translationX, ?translationY=translationY, ?widthRequest=widthRequest, ?resources=resources, ?styles=styles, ?styleSheets=styleSheets, ?classId=classId, ?styleId=styleId)



        ViewElement.Create<Xamarin.Forms.Entry>(View.CreateFuncEntry, View.UpdateFuncEntry, attribBuilder)