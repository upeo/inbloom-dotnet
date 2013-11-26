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
using System.Net;
using Newtonsoft.Json.Linq;
using System.Collections.Specialized;
using System.Diagnostics;

namespace inBloomApiLibrary
{
    internal class ApiHelper
    {
        public string ApiUrl = "https://api.sandbox.inbloom.org/api";
        public string BaseUrl = "https://api.sandbox.inbloom.org/api/rest/v1.2";

        public JArray CallApiForGet(string apiEndPoint, string accessToken)
        {
            Uri endPoint = new Uri(apiEndPoint);
            Trace.TraceInformation(string.Format("CallApiForGet: {0}", apiEndPoint));
            var request = ApiClient.Request(apiEndPoint, accessToken);
            return request.ResponseObject;
        }

        public string CallApiForPost(string apiEndPoint, string accessToken, string data)
        {
            var webClient = new ExtendedWebClient();
            Trace.TraceInformation(string.Format("CallApiForPost: {0}", apiEndPoint));
            webClient.Headers.Add("Authorization", string.Format("bearer {0}", accessToken));
            webClient.Headers.Add("Content-Type", "application/vnd.slc+json");
            webClient.Headers.Add("Accept", "application/vnd.slc+json");
            return webClient.UploadString(apiEndPoint, "POST", data);
        }

        public string CallApiForPut(string apiEndPoint, string accessToken, string data)
        {
            var webClient = new ExtendedWebClient();
            Trace.TraceInformation(string.Format("CallApiForPut: {0}", apiEndPoint));
            webClient.Headers.Add("Authorization", string.Format("bearer {0}", accessToken));
            webClient.Headers.Add("Content-Type", "application/vnd.inbloom+json");
            webClient.Headers.Add("Accept", "application/vnd.inbloom+json");
            return webClient.UploadString(apiEndPoint, "PUT", data);
        }

        public string CallApiForDelete(String apiEndPoint, string accessToken)
        {
            var webClient = new ExtendedWebClient();
            Trace.TraceInformation(string.Format("CallApiForDelete: {0}", apiEndPoint));
            webClient.Headers.Add("Authorization", string.Format("bearer {0}", accessToken));
            webClient.Headers.Add("Content-Type", "application/vnd.inbloom+json");
            webClient.Headers.Add("Accept", "application/vnd.inbloom+json");
            return webClient.UploadString(apiEndPoint, "DELETE");
        }

        public string CallApiWithParameter(String apiEndPoint, string accessToken)
        {
            var webClient = new WebClient();
            Trace.TraceInformation(string.Format("CallApiWithParameter: {0}", apiEndPoint));
            webClient.Headers.Add("Authorization", string.Format("bearer {0}", accessToken));
            webClient.Headers.Add("Content-Type", "application/vnd.slc+json");
            webClient.Headers.Add("Accept", "application/vnd.slc+json");
            return webClient.DownloadString(apiEndPoint);
        }
    }
}