#pragma checksum "D:\Repos-Demo\Blazor\QuizApp\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fad664406edfa27959dd12c100428b1a0cc32a11"
// <auto-generated/>
#pragma warning disable 1591
namespace QuizApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Repos-Demo\Blazor\QuizApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Repos-Demo\Blazor\QuizApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Repos-Demo\Blazor\QuizApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Repos-Demo\Blazor\QuizApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Repos-Demo\Blazor\QuizApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Repos-Demo\Blazor\QuizApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Repos-Demo\Blazor\QuizApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Repos-Demo\Blazor\QuizApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Repos-Demo\Blazor\QuizApp\_Imports.razor"
using QuizApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Repos-Demo\Blazor\QuizApp\_Imports.razor"
using QuizApp.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "PageTitle");
            __builder.AddAttribute(1, "b-njcyzynmkr");
            __builder.AddContent(2, "QuizApp");
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "page");
            __builder.AddAttribute(6, "b-njcyzynmkr");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "sidebar");
            __builder.AddAttribute(9, "b-njcyzynmkr");
            __builder.OpenComponent<QuizApp.Shared.NavMenu>(10);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n    ");
            __builder.OpenElement(12, "main");
            __builder.AddAttribute(13, "b-njcyzynmkr");
            __builder.AddMarkupContent(14, "<div class=\"top-row px-4\" b-njcyzynmkr><a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\" b-njcyzynmkr>About</a></div>\r\n\r\n        ");
            __builder.OpenElement(15, "article");
            __builder.AddAttribute(16, "class", "content px-4");
            __builder.AddAttribute(17, "b-njcyzynmkr");
            __builder.AddContent(18, 
#nullable restore
#line 16 "D:\Repos-Demo\Blazor\QuizApp\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591