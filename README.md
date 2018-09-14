# An attemp to load plugin at run time

Plugins are implemeted using Razor UI as Class Library

## Notes

- In the .csproj of every plugin have to add `<PreserveCompilationContext>false</PreserveCompilationContext>` to support view compilation at run time (with ViewModel).
- In the Host. We have to add

```xml
    <Content Remove="Areas\**\*.*" />
    <Compile Remove="Areas\**\*.*" />
```
To exclude Views which used to override Views in plugins to make the WebHost can complie. Because the plugins are loaded at runtime. No information of plugins can found during complie time

## Problem to need to resolve

The view engine cannot find the precompiled view in modules. I reason I think is that because of dynamic loading at run time although I have added by using AddApplicationPart
