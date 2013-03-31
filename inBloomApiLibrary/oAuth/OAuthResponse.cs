using System.Collections.Generic;

namespace inBloomApiLibrary
{
    public class OAuthResponse
    {
        public bool Success { get; internal set; }

        public string Message { get; internal set; }

        public string AuthorizationUrl { get; internal set; }

        public string AccessToken { get; internal set; }

        public string UserFullName { get; internal set; }
        
        public IEnumerable<string> UserSLIRoles { get; internal set; }
        
        public string UserId { get; internal set; }
    }
}