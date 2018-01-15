# Microsoft Laboratory CMS

Microsoft Laboratory CMS is a potential replacement to Supinfo Microsoft Laboratory Website.

## Use on your environment

You can start and launch this project on Windows, Linux and Mac environment.
The `appsettings.json` as been ignored in Git due to security reason.
You need to create it in order to use Entity Framework Core.

```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=xxx;Port=xxx;Database=xxx;Username=xxx;Password=xxx;",
  },
  "Logging": {
    "IncludeScopes": false,
    "LogLevel": {
      "Default": "Warning"
    }
  }
}
```
*You also need of course to create a Postgre database*
