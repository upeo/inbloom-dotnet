using System.Web;
using System.Web.SessionState;
using inBloomApiLibrary;

namespace Upeo.inBloomApiLibrary.TestWebApp
{
    public class AuthorizationHandler : IHttpHandler, IRequiresSessionState
    {
        #region IHttpHandler Members

        public bool IsReusable
        {
            get { return false; }
        }

        public void ProcessRequest(HttpContext context)
        {
            // Check for a token in the session already, and if found, no action is required
            if (context.Session["access_token"] != null)
                context.Response.Redirect("DataView.aspx");

            // Init oAuth
            var oAuth = new OAuth();

            // We get a code back from the first leg of OAuth process.  If we don't have one, let's get it.
            if (context.Request.QueryString["code"] == null)
            {
                string path = oAuth.CallAuthorization(null, null);
                context.Response.Redirect(path);
            }
            else
            {
                // Now we have a code, we can run the second leg of OAuth process.
                string code = context.Request.QueryString["code"];
                string authorization = oAuth.CallAuthorization(null, code);

                // OAuth successful so get values, store in session and continue
                if (authorization == "OAuthSuccess")
                {
                    if (oAuth.AccessToken != null && oAuth.UserFullName != null && oAuth.UserSLIRoles != null && oAuth.UserId != null)
                    {
                        // Authorization successful; set session variables
                        context.Session.Add("access_token", oAuth.AccessToken);
                        context.Session.Add("user_FullName", oAuth.UserFullName);
                        context.Session.Add("user_SLIRoles", oAuth.UserSLIRoles);
                        context.Session.Add("user_ID", oAuth.UserId);

                        // Redirect to default page
                        context.Response.Redirect("DataView.aspx");
                    }
                }
            }
        }

        #endregion
    }
}
