# MultiProjectTemplate
Create multi-project template in .NET Core 3.1

This project helps to quickly create specific Api-s for your organization.

In order to install a new template run the following command:

dotnet new --install C:\Projects\MultiProjectTemplate //template source path

Create a new app named Order:

dotnet new demoapp -n Order

Create a new app named Order that includes Service project:

dotnet new demoapp -n Order -s true //include Service project

******************************
Template.json file:

.template.config folder should be at the root of the template project. 
It should contain a template.json file.

shortName field - short app name specified in the command above (demopp)

sourceName field - value that will be replaced with the app name specified in the command above (MultiProjectTemplate -> Order)

symbols field - parameter with a specific condition
