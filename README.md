inBloom .NET Library and Sample Application
---

This is a .NET-based library intended to simplify the development of inBloom-compatible applications, along with a sample application that demonstrates the use of the data store API.


The API reference documentation can be by viewed by loading Documentation/index.html file in your web browser. You can browse the documentation by the individual classes and methods.


Requirements
---
To use the inBloom .NET Library, you must have a registered account with inBloom.org and obtain a Client ID and Secret Share for OAuth authentication.  Create an inBloom account here: https://www.inbloom.org/getting-started.


Objectives
---
The inBloom .NET library aims to achieve the following:

 - Ease communication with the inBloom REST API and ensure that all data is transferred securely (using SSL)
 - Facilitate OAuth 2.0 session establishment
 - Gracefully handle session timeouts and errors returned from the inBloom REST API
 - Provide methods to create, read, update and delete data to and from the inBloom REST API
 - Provide a strong-typed class representation of data returned by the inBloom API *
 - Provide methods to extract aggregated views from the inBloom API (a view returned from the inBloom API can contain multiple object types in one call to reduce the number of round trips required) *
 - Provide a HATEOAS links collection to provide further navigating within the data model
 - Provide methods for other operational API calls such as session check and logout.

Note, items marked with an asterisk (*) are not yet implemented or only implemented partially and are planned future enhancements.


Future Enhancements
---
The following features are planned for future release of the .NET library:

 - Change objects returned by API calls from JArray to strongly typed objects
 - Add support for performing partial updates ("patch")
 - Convert test web application to ASP.NET MVC 4 and expand to make more comprehensive use of the library
 - Add full set of unit tests


Contributing
---
We welcome your enhancements!

The inBloom .NET Library is open source and licensed under the Apache License, Version 2.0.

  - Fork it
  - Create your feature branch (git checkout -b my-new-feature)
  - Commit your changes (git commit -am 'Added some feature')
  - Push your changes to the upstream branch (git push origin my-new-feature)
  - Create new Pull Request (make sure you describe what you did and why your mod is needed)


Comments / Questions
---
Please feel free to send comments or questions:

email: dev at upeo.com
