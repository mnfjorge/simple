using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Simple;
using Simple.Web.Mvc;
namespace Sample.Project.Web.Helpers
{
    public static class LocationExtensions
    {
        public const string ScriptsPath = "Scripts";
        public const string StylesheetsPath = "Content";
        public const string ImagesPath = "Content/images";

        public static TagBuilder Script(this HtmlHelper helper, string file)
        {
            return new TagBuilder("script").WithAttrs(new
            {
                type = "text/javascript",
                src = helper.ResolveFullPath(ScriptsPath, file)
            });
        }

        public static TagBuilder Image(this HtmlHelper helper, string file, string alt)
        {
            return new TagBuilder("img").WithAttrs(new
            {
                src = helper.ResolveFullPath(ImagesPath, file),
                alt = alt
            });

        }

        public static TagBuilder Stylesheet(this HtmlHelper helper, string file)
        {
            return new TagBuilder("link").WithAttrs(new
            {
                type = "text/css",
                rel = "Stylesheet",
                href = helper.ResolveFullPath(StylesheetsPath, file)
            });
        }
     
       
    }
}
