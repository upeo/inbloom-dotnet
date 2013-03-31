using System.Collections.Generic;

namespace inBloomApiLibrary
{
    /// <summary>
    /// oAuth Response
    /// </summary>
    public class OAuthResponse
    {
        /// <summary>
        /// Boolean value representing whether or not the oAuth login was successful
        /// </summary>
        public bool Success { get; internal set; }

        /// <summary>
        /// Message with details of any errors
        /// </summary>
        public string Message { get; internal set; }

        /// <summary>
        /// The Authorization URL to redirect to for login
        /// </summary>
        public string AuthorizationUrl { get; internal set; }

        /// <summary>
        /// Access token
        /// </summary>
        public string AccessToken { get; internal set; }

        /// <summary>
        /// Users full name
        /// </summary>
        public string UserFullName { get; internal set; }
        
        /// <summary>
        /// User Roles
        /// </summary>
        public IEnumerable<string> UserSLIRoles { get; internal set; }
        
        /// <summary>
        /// User ID
        /// </summary>
        public string UserId { get; internal set; }
    }
}