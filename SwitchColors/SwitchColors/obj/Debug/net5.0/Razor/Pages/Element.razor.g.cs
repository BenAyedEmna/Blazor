#pragma checksum "C:\Users\ASUS\source\repos\SwitchColors\SwitchColors\Pages\Element.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7befdeaf2b6960c109ef7c394b9278592db4c5e7"
// <auto-generated/>
#pragma warning disable 1591
namespace SwitchColors.Pages
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ASUS\source\repos\SwitchColors\SwitchColors\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\source\repos\SwitchColors\SwitchColors\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\source\repos\SwitchColors\SwitchColors\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ASUS\source\repos\SwitchColors\SwitchColors\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ASUS\source\repos\SwitchColors\SwitchColors\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ASUS\source\repos\SwitchColors\SwitchColors\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ASUS\source\repos\SwitchColors\SwitchColors\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ASUS\source\repos\SwitchColors\SwitchColors\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ASUS\source\repos\SwitchColors\SwitchColors\_Imports.razor"
using SwitchColors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ASUS\source\repos\SwitchColors\SwitchColors\_Imports.razor"
using SwitchColors.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ASUS\source\repos\SwitchColors\SwitchColors\Pages\Element.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/switch")]
    public partial class Element : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Element</h3>");
#nullable restore
#line 6 "C:\Users\ASUS\source\repos\SwitchColors\SwitchColors\Pages\Element.razor"
 for(i=0 ; i< Persons.Count; i++)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "presentation" + (
#nullable restore
#line 8 "C:\Users\ASUS\source\repos\SwitchColors\SwitchColors\Pages\Element.razor"
                          i

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(3, " \r\n    Hello ,it\'s ");
            __builder.AddContent(4, 
#nullable restore
#line 9 "C:\Users\ASUS\source\repos\SwitchColors\SwitchColors\Pages\Element.razor"
                 Persons[i].FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(5, " ");
            __builder.AddContent(6, 
#nullable restore
#line 9 "C:\Users\ASUS\source\repos\SwitchColors\SwitchColors\Pages\Element.razor"
                                       Persons[i].LastName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\ASUS\source\repos\SwitchColors\SwitchColors\Pages\Element.razor"
                      SwitchColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(10, "switch");
            __builder.CloseElement();
#nullable restore
#line 11 "C:\Users\ASUS\source\repos\SwitchColors\SwitchColors\Pages\Element.razor"
     if (Persons[i].ChangeColor == true)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "style");
            __builder.AddMarkupContent(12, "\r\n            .presentation");
            __builder.AddContent(13, 
#nullable restore
#line 14 "C:\Users\ASUS\source\repos\SwitchColors\SwitchColors\Pages\Element.razor"
                           i

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(14, " {\r\n                background-color: fuchsia;\r\n            }\r\n        ");
            __builder.CloseElement();
#nullable restore
#line 18 "C:\Users\ASUS\source\repos\SwitchColors\SwitchColors\Pages\Element.razor"
    }   

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Users\ASUS\source\repos\SwitchColors\SwitchColors\Pages\Element.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\ASUS\source\repos\SwitchColors\SwitchColors\Pages\Element.razor"
       

    public List<Person> Persons = new List<Person>();
    private Person e1 = new Person("Emna", "BenAyed");
    private Person e2 = new Person("Khaldoun", "Aissaoui");
    private Person e3 = new Person("Hedia", "Bouricha");
    private Person e4 = new Person("Salim", "Aissaoui");
    protected override Task OnInitializedAsync()
    {
        Persons.Add(e1);
        Persons.Add(e2);
        Persons.Add(e3);
        Persons.Add(e4);
        return base.OnInitializedAsync();
    }

    static int i;
    void SwitchColor()
    {
        if (i < Persons.Count)
            Persons[i].ChangeColor = true; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\ASUS\source\repos\SwitchColors\SwitchColors\Pages\Element.razor"
      }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591