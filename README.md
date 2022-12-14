[![downloads](https://img.shields.io/nuget/dt/avalonia.templates)](https://www.nuget.org/packages/Spice86.Templates/)

# Spice86 templates for `dotnet new`

For more information about `dotnet new` templates see [here](https://blogs.msdn.microsoft.com/dotnet/2017/04/02/how-to-create-your-own-templates-for-dotnet-new/).

## Installing the templates

Run from a command line:

```powershell
dotnet new install Spice86.Templates
```

The templates should now be available in `dotnet`:

```
Templates                              Short Name                 Language    Tags
---------------------------------------------------------------------------------------------------------
Spice86 Project                     spice86.project               [C#]        reverseengineering/spice86
```

Use it to generate a new reverse engineering project:

```
dotnet new spice86.project
```
