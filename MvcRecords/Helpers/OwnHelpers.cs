using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages.Razor.Configuration;

namespace MvcRecords.Helpers
{
    public static class OwnHelpers 
    {
        public static HtmlString Button(string action)
        {
            if (action == "Save")
            {
                return new HtmlString("<input type=\"submit\" class=\"btn btn-warning\" value=\"Zapisz\" />");
            }
            else if (action == "Delete")
            {
                return new HtmlString("<input type=\"submit\" class=\"btn btn-danger\" value=\"Usuń\" />");
            }
            else if (action == "Search")
            {
                return new HtmlString("<input type=\"submit\" value=\"Szukaj\"/>");
            }
            else if (action == "Create")
            {
                return new HtmlString("<input type=\"submit\" class=\"btn btn-priamry\" value=\"Dodaj\"/>");
            }
            return new HtmlString("<input type=\"submit\" class=\"btn btn-primary\" value=\"Klik\" />");
        }
    }
}