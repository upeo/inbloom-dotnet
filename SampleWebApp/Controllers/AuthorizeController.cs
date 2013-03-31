/*
 * Copyright 2013 Upeo, LLC
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this software except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Web.Mvc;
using SampleWebApp.Components;
using inBloomApiLibrary;

namespace SampleWebApp.Controllers
{
    public class AuthorizeController : Controller
    {
        public ActionResult Index(string code)
        {
            try
            {
                // Check for a token in the session already, and if found, no action is required
                if (!string.IsNullOrEmpty(SessionInfo.Current.AccessToken))
                    return RedirectToAction("Index", "Home");

                // Init oAuth
                var oAuth = new OAuth();

                // We get a code back from the first leg of OAuth process.  If we don't have one, let's get it.
                if (string.IsNullOrEmpty(code))
                {
                    string authorizationUrl = oAuth.GetAuthorizationUrl();
                    return Redirect(authorizationUrl);
                }

                // Otherwise, we have a code, we can run the second leg of OAuth process.
                var authorization = oAuth.CallAuthorization(null, code);

                // OAuth successful so get values, store in session and continue
                if (authorization.Success)
                {
                    // Authorization successful; set session variables
                    SessionInfo.Current.AccessToken = authorization.AccessToken;
                    SessionInfo.Current.FullName = authorization.UserFullName;
                    SessionInfo.Current.Roles = authorization.UserSLIRoles;
                    SessionInfo.Current.UserId = authorization.UserId;

                    // Redirect to post login URL if one exists
                    if (!string.IsNullOrEmpty(SessionInfo.Current.PostLoginRedirectUrl))
                    {
                        var returnUrl = SessionInfo.Current.PostLoginRedirectUrl;
                        SessionInfo.Current.PostLoginRedirectUrl = null;
                        return Redirect(returnUrl);
                    }

                    // Otherwise, just go to home
                    return RedirectToAction("Index", "Home");
                }

                return Content("Unknown Error authorizing");
            }
            catch (Exception ex)
            {
                return Content("Error authorizing: " + ex.Message);
            }
        }

        public ActionResult LogOut()
        {
            // Init home service
            var service = new HomeDataService();

            // Logout the current token
            service.LogOut(SessionInfo.Current.AccessToken);

            // Clear the session
            Session.Abandon();

            // Redirect back to landing page
            return RedirectToAction("Index", "Home");
        }
    }
}
