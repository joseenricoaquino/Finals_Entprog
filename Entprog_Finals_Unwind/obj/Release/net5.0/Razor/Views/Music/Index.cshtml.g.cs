#pragma checksum "C:\Users\cocoy\Desktop\Unwind finalsss\joseenricoaquino\Finals_Entprog\Entprog_Finals_Unwind\Views\Music\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a877d2f14ec8f83c0499eb471772dc7690d5bac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Music_Index), @"mvc.1.0.view", @"/Views/Music/Index.cshtml")]
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
#line 1 "C:\Users\cocoy\Desktop\Unwind finalsss\joseenricoaquino\Finals_Entprog\Entprog_Finals_Unwind\Views\_ViewImports.cshtml"
using Entprog_Finals_Unwind;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cocoy\Desktop\Unwind finalsss\joseenricoaquino\Finals_Entprog\Entprog_Finals_Unwind\Views\_ViewImports.cshtml"
using Entprog_Finals_Unwind.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a877d2f14ec8f83c0499eb471772dc7690d5bac", @"/Views/Music/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2553d316d5442ebc816f49dbe31e16a1c8df360e", @"/Views/_ViewImports.cshtml")]
    public class Views_Music_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Entprog_Finals_Unwind.Models.Music>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\cocoy\Desktop\Unwind finalsss\joseenricoaquino\Finals_Entprog\Entprog_Finals_Unwind\Views\Music\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Play Music</h1>
<p>Just Relax</p>
<audio controls>

    <source src=""https://cdn.pixabay.com/download/audio/2021/11/23/audio_64b2dd1bce.mp3?filename=just-relax-11157.mp3"" type=""audio/mpeg"">
    Your browser does not support the audio element.
</audio>

<p>Ambient Piano & Strings</p>
<audio controls>

    <source src=""https://cdn.pixabay.com/download/audio/2021/11/13/audio_cb4f1212a9.mp3?filename=ambient-piano-amp-strings-10711.mp3"" type=""audio/mpeg"">

</audio>

<p>Piano Moment</p>
<audio controls>

    <source src=""https://cdn.pixabay.com/download/audio/2021/10/25/audio_05570f2464.mp3?filename=piano-moment-9835.mp3"" type=""audio/mpeg"">

</audio>

<p>Cali</p>
<audio controls>

    <source src=""https://cdn.pixabay.com/download/audio/2020/10/11/audio_fe4d3bcac9.mp3?filename=cali-1171.mp3"" type=""audio/mpeg"">

</audio>

<p>Acoustic Motivation</p>
<audio controls>

    <source src=""https://cdn.pixabay.com/download/audio/2021/11/26/audio_e20882e29d.mp3?filename=acoustic-motivatio");
            WriteLiteral("n-11290.mp3\" type=\"audio/mpeg\">\r\n\r\n</audio>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Entprog_Finals_Unwind.Models.Music>> Html { get; private set; }
    }
}
#pragma warning restore 1591
