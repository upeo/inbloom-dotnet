<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Upeo.inBloomApiLibrary.TestWebApp.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
	<head>
		<title>inBloom API Library - Test Web App</title>
		<link href="Bootstrap/css/bootstrap.min.css" type="text/css" rel="stylesheet" />
		<style type="text/css">
			.btn-large {
				padding: 10px 30px 10px 30px;
			}
			.hero-unit {
				margin-top: 100px;
			}
			.hero-unit p:last-child {
				margin-top:30px;
			}
			small {
				float: left;margin: 20px 0 0 0;
			}
		</style>
	</head>
	<body>
		<form runat="server">
			<div class="container">
				<div class="hero-unit">
					<h1>inBloom API .NET Library</h1>
					<br/>
					<p>This is a .NET library for providing developers a fast track to connecting with the inBloom data store.<br/>You can find further information at any of the links below:</p>
					<ul>
						<li><a href="https://github.com/upeo/inbloom-dotnet">GitHub repository</a></li>
						<li><a href="https://www.inbloom.org/sites/default/files/docs-developer-1.0.68-20130118/index.html">inBloom REST API Documentation</a></li>
					</ul>
					<p>Login below to access the sample application</p>
					<p><asp:Button ID="LoginButton" runat="server" CssClass="btn btn-large btn-primary" Text="Login" OnClick="LoginButton_Click"/></p>
					<small>The inBloom API .NET Library and sample application developed by <a href="http://www.upeo.com/">Upeo, LLC</a></small>
				</div>
			</div>
		</form>
	</body>
</html>