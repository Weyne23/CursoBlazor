#pragma checksum "C:\Users\GSD_TI_009\Documents\Estudo\Blazor\BlazorApp_Razor_Classes\BlazorApp_Razor_Classes\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85f5bc25cc0085e9caa876ca6c5f51596839b31f"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp_Razor_Classes.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\GSD_TI_009\Documents\Estudo\Blazor\BlazorApp_Razor_Classes\BlazorApp_Razor_Classes\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\GSD_TI_009\Documents\Estudo\Blazor\BlazorApp_Razor_Classes\BlazorApp_Razor_Classes\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\GSD_TI_009\Documents\Estudo\Blazor\BlazorApp_Razor_Classes\BlazorApp_Razor_Classes\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\GSD_TI_009\Documents\Estudo\Blazor\BlazorApp_Razor_Classes\BlazorApp_Razor_Classes\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\GSD_TI_009\Documents\Estudo\Blazor\BlazorApp_Razor_Classes\BlazorApp_Razor_Classes\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\GSD_TI_009\Documents\Estudo\Blazor\BlazorApp_Razor_Classes\BlazorApp_Razor_Classes\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\GSD_TI_009\Documents\Estudo\Blazor\BlazorApp_Razor_Classes\BlazorApp_Razor_Classes\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\GSD_TI_009\Documents\Estudo\Blazor\BlazorApp_Razor_Classes\BlazorApp_Razor_Classes\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\GSD_TI_009\Documents\Estudo\Blazor\BlazorApp_Razor_Classes\BlazorApp_Razor_Classes\Client\_Imports.razor"
using BlazorApp_Razor_Classes.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\GSD_TI_009\Documents\Estudo\Blazor\BlazorApp_Razor_Classes\BlazorApp_Razor_Classes\Client\_Imports.razor"
using BlazorApp_Razor_Classes.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\GSD_TI_009\Documents\Estudo\Blazor\BlazorApp_Razor_Classes\BlazorApp_Razor_Classes\Client\_Imports.razor"
using Classes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\GSD_TI_009\Documents\Estudo\Blazor\BlazorApp_Razor_Classes\BlazorApp_Razor_Classes\Client\_Imports.razor"
using BlazorApp_Razor_Classes.Shared.Entidades;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddMarkupContent(2, "<h2>Pizza</h2>\r\n    ");
            __builder.OpenElement(3, "h2");
            __builder.AddContent(4, "Pizza: ");
            __builder.AddContent(5, 
#nullable restore
#line 6 "C:\Users\GSD_TI_009\Documents\Estudo\Blazor\BlazorApp_Razor_Classes\BlazorApp_Razor_Classes\Client\Pages\Index.razor"
                Pizza.Nome

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "h2");
            __builder.AddContent(8, "Nome: ");
            __builder.AddContent(9, 
#nullable restore
#line 7 "C:\Users\GSD_TI_009\Documents\Estudo\Blazor\BlazorApp_Razor_Classes\BlazorApp_Razor_Classes\Client\Pages\Index.razor"
               Pizza.Cadastro.ToString("dd MM yy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n<hr>\r\n");
            __builder.AddMarkupContent(11, "<h1>Pizza(Foreach)</h1>");
#nullable restore
#line 11 "C:\Users\GSD_TI_009\Documents\Estudo\Blazor\BlazorApp_Razor_Classes\BlazorApp_Razor_Classes\Client\Pages\Index.razor"
 foreach (var produto in GetProdutos())
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "div");
            __builder.OpenElement(13, "h2");
            __builder.AddContent(14, "Pizza : ");
            __builder.AddContent(15, 
#nullable restore
#line 14 "C:\Users\GSD_TI_009\Documents\Estudo\Blazor\BlazorApp_Razor_Classes\BlazorApp_Razor_Classes\Client\Pages\Index.razor"
                     produto.Nome

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "h2");
            __builder.AddContent(18, "Pizza : ");
            __builder.AddContent(19, 
#nullable restore
#line 15 "C:\Users\GSD_TI_009\Documents\Estudo\Blazor\BlazorApp_Razor_Classes\BlazorApp_Razor_Classes\Client\Pages\Index.razor"
                     produto.Cadastro.ToString("dd MM yy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 17 "C:\Users\GSD_TI_009\Documents\Estudo\Blazor\BlazorApp_Razor_Classes\BlazorApp_Razor_Classes\Client\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(20, "<h1>Pizza(For)</h1>");
#nullable restore
#line 19 "C:\Users\GSD_TI_009\Documents\Estudo\Blazor\BlazorApp_Razor_Classes\BlazorApp_Razor_Classes\Client\Pages\Index.razor"
 for (int i = 0; i < GetProdutos().Count; i++)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "div");
            __builder.OpenElement(22, "h2");
            __builder.AddContent(23, "Pizza : ");
            __builder.AddContent(24, 
#nullable restore
#line 22 "C:\Users\GSD_TI_009\Documents\Estudo\Blazor\BlazorApp_Razor_Classes\BlazorApp_Razor_Classes\Client\Pages\Index.razor"
                     GetProdutos()[i].Nome

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenElement(26, "h2");
            __builder.AddContent(27, "Pizza : ");
            __builder.AddContent(28, 
#nullable restore
#line 23 "C:\Users\GSD_TI_009\Documents\Estudo\Blazor\BlazorApp_Razor_Classes\BlazorApp_Razor_Classes\Client\Pages\Index.razor"
                     GetProdutos()[i].Cadastro.ToString("dd MM yy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 25 "C:\Users\GSD_TI_009\Documents\Estudo\Blazor\BlazorApp_Razor_Classes\BlazorApp_Razor_Classes\Client\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\GSD_TI_009\Documents\Estudo\Blazor\BlazorApp_Razor_Classes\BlazorApp_Razor_Classes\Client\Pages\Index.razor"
       
    public List<Produto> Produtos { get { return GetProdutos(); } }
    public Produto Pizza { get { return GetProduto(); } }

    private List<Produto> GetProdutos()
    {
        return new List<Produto>
{
            new Produto()
            {
                Nome = "Pizza Mussarela",
                Cadastro = new DateTime(2021, 11, 19)
            },
            new Produto()
            {
                Nome = "Pizza Calabreza",
                Cadastro = new DateTime(2021, 11, 20)
            },
            new Produto()
            {
                Nome = "Pizza Portuguesa",
                Cadastro = new DateTime(2021, 11, 21)
            },

        };

    }
    private Produto GetProduto()
    {
        return new Produto
        {
            Nome = "Pizza Mussarela",
            Cadastro = new DateTime(2021, 11, 19)
        };

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
