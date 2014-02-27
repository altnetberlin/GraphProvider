namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("GraphProvider")>]
[<assembly: AssemblyProductAttribute("GraphProvider")>]
[<assembly: AssemblyDescriptionAttribute("Various type providers for management of the machine.")>]
[<assembly: AssemblyVersionAttribute("0.1.0")>]
[<assembly: AssemblyFileVersionAttribute("0.1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.1.0"
