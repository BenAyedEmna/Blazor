#pragma checksum "C:\Users\ASUS\Desktop\Emna\stage\Blazor\SwitchColors\SwitchColors\Pages\Texte.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83c727b67305c768304fff4683067fa7a7b84afc"
// <auto-generated/>
#pragma warning disable 1591
namespace SwitchColors.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ASUS\Desktop\Emna\stage\Blazor\SwitchColors\SwitchColors\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\Emna\stage\Blazor\SwitchColors\SwitchColors\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\Emna\stage\Blazor\SwitchColors\SwitchColors\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ASUS\Desktop\Emna\stage\Blazor\SwitchColors\SwitchColors\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ASUS\Desktop\Emna\stage\Blazor\SwitchColors\SwitchColors\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ASUS\Desktop\Emna\stage\Blazor\SwitchColors\SwitchColors\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ASUS\Desktop\Emna\stage\Blazor\SwitchColors\SwitchColors\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ASUS\Desktop\Emna\stage\Blazor\SwitchColors\SwitchColors\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ASUS\Desktop\Emna\stage\Blazor\SwitchColors\SwitchColors\_Imports.razor"
using SwitchColors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ASUS\Desktop\Emna\stage\Blazor\SwitchColors\SwitchColors\_Imports.razor"
using SwitchColors.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Texte")]
    public partial class Texte : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Texte</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div class=\"texte1\">hello word</div>\r\n");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\ASUS\Desktop\Emna\stage\Blazor\SwitchColors\SwitchColors\Pages\Texte.razor"
                  afficher1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, "1");
            __builder.CloseElement();
#nullable restore
#line 6 "C:\Users\ASUS\Desktop\Emna\stage\Blazor\SwitchColors\SwitchColors\Pages\Texte.razor"
 if (affiche1 == true)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<style>\r\n        .texte1 {\r\n            visibility: visible;\r\n        }\r\n    </style>");
#nullable restore
#line 13 "C:\Users\ASUS\Desktop\Emna\stage\Blazor\SwitchColors\SwitchColors\Pages\Texte.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<div class=\"texte2\">hello word</div>\r\n\r\n");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\ASUS\Desktop\Emna\stage\Blazor\SwitchColors\SwitchColors\Pages\Texte.razor"
                  afficher2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(9, "2");
            __builder.CloseElement();
#nullable restore
#line 17 "C:\Users\ASUS\Desktop\Emna\stage\Blazor\SwitchColors\SwitchColors\Pages\Texte.razor"
 if (affiche2 == true)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(10, "<style>\r\n        .texte2 {\r\n            visibility: visible;\r\n        }\r\n    </style>");
#nullable restore
#line 24 "C:\Users\ASUS\Desktop\Emna\stage\Blazor\SwitchColors\SwitchColors\Pages\Texte.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\ASUS\Desktop\Emna\stage\Blazor\SwitchColors\SwitchColors\Pages\Texte.razor"
       
    static bool affiche1 = false;
    static bool affiche2 = false;

    public void afficher1()
    {
        affiche1 = true;
        if (affiche2 == true)
            affiche2 = false;
    }

    public void afficher2()
    {
        affiche2 = true;
        if (affiche1 == true)
            affiche1 = false;

    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
