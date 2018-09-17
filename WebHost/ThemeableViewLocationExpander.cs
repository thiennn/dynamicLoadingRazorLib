using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Razor;

namespace WebHost
{
    public class ThemeableViewLocationExpander : IViewLocationExpander
    {
        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {
            // The "TestTheme" should be got dynamicly. Here I hard code for quick testing. 
            var themeableViewLocations = new string[]
                {
                    "/Themes/TestTheme/Areas/{2}/Views/{1}/{0}.cshtml",
                    "/Themes/TestTheme/Areas/{2}/Views/Shared/{0}.cshtml",
                    "/Themes/TestTheme/Views/{1}/{0}.cshtml",
                    "/Themes/TestTheme/Views/Shared/{0}.cshtml"
                };

            viewLocations = themeableViewLocations.Concat(viewLocations);
            return viewLocations;
        }

        public void PopulateValues(ViewLocationExpanderContext context)
        {
            
        }
    }
}
