theidentityhub-aspnetcore-demo
===========================

Demo ASP.NET CORE Application for The Identity Hub. The Identity Hub makes it easy to connect your app to all major identity providers like Microsoft, Facebook, Google, Twitter, Linked In and more. For more information see https://www.theidentityhub.com

Getting Started
===============

Download or Clone the repository. 

Find the startup.cs file in the 2.2/AspNetCoreWebApp folder and locate the following code fragment:

````cs
 .AddTheIdentityHubAuthentication(options =>
            {
                options.TheIdentityHubUrl = new Uri("[YOUR BASE URL]");
                options.Tenant = "[YOUR TENANT URL SEGMENT]";
                options.ClientId = "[YOUR CLIENT ID]";
                options.ClientSecret = "[YOUR CLIENT SECRET]";
            });
````

Change the configuration as follows

1. Replace [YOUR CLIENT ID] with the client id from your App configured in The Identity Hub.
2. Replace [YOUR CLIENT SECRET] with the client secret from your App configured in The Identity Hub.
3. Replace [YOUR BASE URL] with the url of the The Identity Hub (https://www.theidentityhub.com for SAAS version).
4. Replace [YOUR TENANT URL SEGMENT] with the url segment of your Tenant.
5. Start the application

If you do not have already created an App see https://docs.theidentityhub.com/doc/Apps/Create-an-App.html.
