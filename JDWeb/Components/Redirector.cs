using System.ComponentModel.Composition;
using System.Web;
using JDWeb.Interfaces;

namespace JDWeb.Components
{
    [Export(typeof(IRedirector))]
    public class Redirector : IRedirector
    {
        public void GoToHomePage()
        {
            Redirect("~/Default.aspx");
        }

        public void GoToErrorPage()
        {
            Redirect("~/Error.aspx");
        }

        private void Redirect(string path)
        {
            HttpContext.Current.Response.Redirect(path);
        }
    }
}
