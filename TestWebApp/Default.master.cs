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
using System.Web.UI;
using inBloomApiLibrary;

namespace Upeo.inBloomApiLibrary.TestWebApp
{
    public partial class default_master : MasterPage
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            if (Session["access_token"] == null)
            {
                Response.Redirect("Default.aspx");
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            userFullName.Text = Session["user_FullName"].ToString();
            userRoles.Text = Session["user_SLIRoles"].ToString();
        }

        protected void LogoutButton_Click(object sender, EventArgs e)
        {
            try
            {
                var service = new GetHomeData();
                service.LogOut(Session["access_token"].ToString());
            }
            catch (Exception)
            {
                // Error logging out of inBloom
            }

            Session.Abandon();
            Response.Redirect("Default.aspx");
        }
    }
}