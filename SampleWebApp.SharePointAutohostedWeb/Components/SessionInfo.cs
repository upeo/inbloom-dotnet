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
using System.Collections.Generic;
using System.Diagnostics;
using System.Web;
using System.Web.Routing;

namespace SampleWebApp.Components
{
    /// <summary>
    /// This class is used for storing all information which needs to be 
    /// maintained at Session Scope. If more items need to be stored in 
    /// Session later in the project, add a property to this class.
    /// </summary>
    [Serializable]
    public class SessionInfo
    {
        public const string SessionKey = "SessionInfo";

        #region Accessors

        public string UserId { get; set; }
        public string AccessToken { get; set; }
        public string FullName { get; set; }
        public IEnumerable<string> Roles { get; set; }
        public string PostLoginRedirectUrl { get; set; }
        public SharePointContext SPContext { get; set; }

        public RouteValueDictionary SPContextRouteValues
        {
            get
            {
                SharePointContext spCont = SessionInfo.Current.SPContext;
                RouteValueDictionary routeVals = new RouteValueDictionary();
                if (spCont != null)
                {
                    routeVals.Add("SPAppWebUrl", spCont.SPAppWebUrl.ToString());
                    routeVals.Add("SPHostUrl", spCont.SPHostUrl.ToString());
                    routeVals.Add("SPLanguage", spCont.SPHostUrl.ToString());
                    routeVals.Add("SPClientTag", spCont.SPClientTag);
                    routeVals.Add("SPProductNumber", spCont.SPProductNumber);
                }
                return routeVals;
            }
        }

        #endregion

        #region Static Accessors

        /// <summary>
        /// Returns a SessionInfo instance for the current user session
        /// </summary>
        /// 
        public static SessionInfo Current
        {
            get
            {
                if (HttpContext.Current == null || HttpContext.Current.Session == null)
                {
                    Debug.WriteLine("SessionInfo.Current : No HttpContext, so session info will not be saved");
                    return new SessionInfo();
                }

                return ForSession(new HttpSessionStateWrapper(HttpContext.Current.Session));
            }
        }

        public static SessionInfo Empty
        {
            get
            {
                return new SessionInfo();
            }
        }

        #endregion

        /// <summary>
        /// Reset all session settings to default values
        /// </summary>
        public void Reset()
        {
            UserId = string.Empty;
            AccessToken = string.Empty;
            FullName = string.Empty;
            Roles = new List<string>();
            PostLoginRedirectUrl = string.Empty;
            SPContext = null;
        }

        #region Helper Methods

        // Instances of SessionInfo should only be created by 
        // the Current property, so make the constructor private
        private SessionInfo()
        {
            Reset();
        }

        /// <summary>
        /// Gets the SessionInfo for the specified session
        /// </summary>
        public static SessionInfo ForSession(HttpSessionStateBase session)
        {
            var sessionInfo = session[SessionKey] as SessionInfo;
            if (sessionInfo == null)
            {
                sessionInfo = new SessionInfo();
                session.Add(SessionKey, sessionInfo);
            }
            return sessionInfo;
        }

        

        #endregion
    }
}