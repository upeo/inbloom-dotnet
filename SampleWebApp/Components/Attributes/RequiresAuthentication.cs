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

using System.Web.Mvc;

namespace SampleWebApp.Components
{
    public class RequiresAuthenticationAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var sessionInfo = SessionInfo.ForSession(filterContext.HttpContext.Session);

            if (sessionInfo == null || string.IsNullOrEmpty(sessionInfo.AccessToken))
            {
                // Store the return url
                if (sessionInfo != null && filterContext.HttpContext != null && filterContext.HttpContext.Request != null && filterContext.HttpContext.Request.Url != null)
                    sessionInfo.PostLoginRedirectUrl = filterContext.HttpContext.Request.Url.ToString();

                // Redirect to the authorize handler which in turn will send user to inBloom
                filterContext.Result = new RedirectResult("~/Authorize");
            }
        }
    }
}