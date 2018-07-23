# Pre-requisites:
1. .net core 2.1 SDK https://www.microsoft.com/net/download 
2. Visual Studio (community edition is fine)
    1. Make sure to choose the Xamarin components during installation (“Mobile Development with .NET” workload)
# Start with a clean new Xamarin Elmish app
1. Follow https://fsprojects.github.io/Elmish.XamarinForms/index.html#getting=started
    1. dotnet new -i Elmish.XamarinForms.Templates 
    2. In your command line, navigate to an empty folder you will use for this tutorial
    3. dotnet new elmish-forms-app -lang F# -n SqueakyApp 
    4. open SqueakyApp/SqueakyApp.sln in Visual Studio and run it (to make sure the base template works)
We will be adding the Syncfusion’s SfMaskedEdit  control to our elmish app.
# Do the steps required for using the SfMaskedEdit control in a normalxamarin forms app. 
The steps are described in https://help.syncfusion.com/xamarin/sfmaskededit/getting-started 
1. add syncfusion.xamarin.sfmaskededit to all 3 projects
2. add syncfusion.xamarin.sfmaskededit.android to the Android project and the “.IOS” to the ios project.
3. Follow the “additional steps for IOS” described in https://help.syncfusion.com/xamarin/sfmaskededit/getting-started
    1. in appDelegate.fs
        1. Add to the open statements: open Syncfusion.Xforms.iOS.MaskedEdit
        2. Add to the FinishedLaunching function right below “this.LoadApplication (appcore)”: SfMaskedEditRenderer.Init()
# Do the steps listed in https://github.com/fsprojects/Elmish.XamarinForms/blob/master/docs/views-extending.md for adding an extended view to Xamarin Elmish
1. Create new fsharp file in the SqueakyApp project right above “SqueakyApp.fs”
2. name it SfMaskedEdit.fs
3. Set the namespace namespace SqueakyApp
4. add an auto-opened module named SfMaskedEditExtension
5. Open namespaces:
    1.     open Elmish.XamarinForms.DynamicViews
    2.     open Xamarin.Forms
6. Add the following Type inside that module called "View"
7. Add a static memebr function called "SfMaskedEdit" with the following minimum base code to have the control showing. All this code is for the base attibutes of any xamarin forms view, but referencing the .net class of the control we want to use which is SfMaskedEdit:
`
static member inline SfMaskedEdit(
                                 // inherited attributes common to all views
                                 ?horizontalOptions, ?verticalOptions, ?margin, ?gestureRecognizers, ?anchorX, ?anchorY, ?backgroundColor, 
                                 ?heightRequest, ?inputTransparent, ?isEnabled, ?isVisible, ?minimumHeightRequest, ?minimumWidthRequest, ?opacity,
                                 ?rotation, ?rotationX, ?rotationY, ?scale, ?style, ?translationX, ?translationY, ?widthRequest,
                                 ?resources, ?styles, ?styleSheets, ?classId, ?styleId) =

            // Count the number of additional attributes
            let attribCount = 0
            
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

            // The update method
            let update (prevOpt: ViewElement voption) (source: ViewElement) (target: Syncfusion.XForms.MaskedEdit.SfMaskedEdit) =
                View.UpdateView(prevOpt, source, target)
               
            let create () = new Syncfusion.XForms.MaskedEdit.SfMaskedEdit()
            // The element
            ViewElement.Create<Syncfusion.XForms.MaskedEdit.SfMaskedEdit>(create, update, attribs)
`
8. Add attribute wrappers for the mask and value proretery of the control:
    1. Add the keys:
`    
    let SfMaskAttribKey = AttributeKey "SfMaskAttribKey"
    let SfValueAttribKey = AttributeKey "SfValueAttribKey"
` 
    2. Add them as parameters to the SfMaskedEdit function:
`
    SfMaskedEdit(?mask: string, ?value: string,
`
    3. Count them in the attributes
`
let attribCount = match mask with Some _ -> attribCount + 1 | None -> attribCount 
let attribCount = match value with Some _ -> attribCount + 1 | None -> attribCount 
`
    4. Add them to the attributes bag:
`
    match mask with None -> () | Some v -> attribs.Add(SfMaskAttribKey, v) 
    match value with None -> () | Some v -> attribs.Add(SfValueAttribKey, v) 
`
    5. Under the update function, add one line per each attribute to wire up the changes to those props:
`
    source.UpdatePrimitive(prevOpt, target, SfMaskAttribKey, (fun target v -> target.Mask <- v))
    source.UpdatePrimitive(prevOpt, target, SfValueAttribKey, (fun target v -> target.Value <- v))
`

1.  In SqueakyApp.fs, add `View.SfMaskedEdit(value = model.Count.ToString(), mask = "000000" , horizontalOptions = LayoutOptions.CenterAndExpand)` right before `View.Label...`
2.  Debug the Android (or iOS app)
