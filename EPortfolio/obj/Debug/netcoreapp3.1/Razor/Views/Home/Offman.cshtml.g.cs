#pragma checksum "C:\Users\laure\Documents\Git\ITalentSite\EPortfolio\EPortfolio\Views\Home\Offman.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1e66b0d68906d8c3fe016384e1c38ee2eaed828"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Offman), @"mvc.1.0.view", @"/Views/Home/Offman.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\laure\Documents\Git\ITalentSite\EPortfolio\EPortfolio\Views\_ViewImports.cshtml"
using EPortfolio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\laure\Documents\Git\ITalentSite\EPortfolio\EPortfolio\Views\_ViewImports.cshtml"
using EPortfolio.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1e66b0d68906d8c3fe016384e1c38ee2eaed828", @"/Views/Home/Offman.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1891fdcd3d115646bb3286a9086f3565f1b1d571", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Offman : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EPortfolio.Models.Domain.Person>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\laure\Documents\Git\ITalentSite\EPortfolio\EPortfolio\Views\Home\Offman.cshtml"
  
    ViewData["Title"] = "Ofman";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-dark\">");
#nullable restore
#line 7 "C:\Users\laure\Documents\Git\ITalentSite\EPortfolio\EPortfolio\Views\Home\Offman.cshtml"
                 Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<p>
    Het Kernkwadrant of het Kwadrant van Ofman is een model om de eigenschappen te
    beschrijven, die bij een persoon horen. Het model is opgesteld door de bedrijfskundige
    Daniel Ofman. Het wordt gebruikt in organisatie-ontwikkelingstrajecten, in coaching,
    bij conflictbemiddeling, voor persoonlijke ontwikkeling, in teambuildingssessies,
    door onderwijsinstellingen van lagere scholen tot universiteiten in het kader
    van zelfkennis, bij werving en selectie en door sollicitanten die een beeld van
    zichzelf willen hebben.
    <a href=""https://www.leerwiki.nl/maatschappij/onderwijs/beroepsonderwijs/zelfontwikkeling/competenties/10972/wat-zijn-kernkwadranten/"">Meer informatie</a>

    <h2>Kernkwaliteit</h2>
    <p>");
#nullable restore
#line 20 "C:\Users\laure\Documents\Git\ITalentSite\EPortfolio\EPortfolio\Views\Home\Offman.cshtml"
  Write(Model.Offman.CoreQuality);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <h2>Valkuil</h2>\r\n    <p>");
#nullable restore
#line 22 "C:\Users\laure\Documents\Git\ITalentSite\EPortfolio\EPortfolio\Views\Home\Offman.cshtml"
  Write(Model.Offman.Pitfall);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <h2>Uitdaging</h2>\r\n    <p>");
#nullable restore
#line 24 "C:\Users\laure\Documents\Git\ITalentSite\EPortfolio\EPortfolio\Views\Home\Offman.cshtml"
  Write(Model.Offman.Challenge);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <h2>Allergie</h2>\r\n    <p>");
#nullable restore
#line 26 "C:\Users\laure\Documents\Git\ITalentSite\EPortfolio\EPortfolio\Views\Home\Offman.cshtml"
  Write(Model.Offman.Allergy);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
    <h2>Woordje uitleg</h2>
    <p>
        Hierboven staat er dus eigenlijk dat ik iemand ben die altijd de beste manier zal
        zoeken om dingen te vertellen in teamverband. Aan de andere kant wilt dit ook zeggen
        dat ik als afstandelijk kan beschouwd worden en dat ik dus naar meer openheid moet
        streven, maar deze directe aanpak persoonlijk minder aangenaam vindt.
    </p>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EPortfolio.Models.Domain.Person> Html { get; private set; }
    }
}
#pragma warning restore 1591
