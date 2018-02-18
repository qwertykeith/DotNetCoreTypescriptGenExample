# Nswag C#->Typescript generator

This is a quick and dirty example of a .net core react app that will generate a typescript clients for your api when you save anything, not need to build.  I'm this could be improved a lot.. but felt the need to share the awesomeness.

Note: I haven't tested this on any external build servers yet.. not sure what will happen there

To run and watch for front and back-end changes

```
dotnet restore
dotnet watch run
```

Then add an action to a controller and watch the changes in ClientApp/api/services.ts

## How?

### NSwag CLI

This needs to be installed

https://github.com/RSuter/NSwag/wiki/CommandLine

### Nuget

You need these packages

* NSwag.AspNetCore
* NSwag.MSBuild

### Nswag.json

Have a look at `nswag.json`

There's not much going on.  NSwag generates a swagger file somewhere using the swaggerGenerator settings.  Then swaggerToTypeScriptClient settings to generate the typescript client from that.

The assemblyPaths setting needs to change to point to the dll(s) for the web application. 

The output setting points to where you want the scripts

### Build step

Edit the project file and add this build step

```
  <Target Name="NSwag" AfterTargets="Build">
    <Copy SourceFiles="@(Reference)" DestinationFolder="$(OutDir)References" />
    <Exec Command="$(NSwagExe_Core20) run nswag.json /variables:Configuration=$(Configuration)" />
    <RemoveDir Directories="$(OutDir)References" />
  </Target>

```

### Watching backend changes

this does the watching thing for .net (front end is taken care of by webpack)

```
  <ItemGroup>
    <DotNetCliToolReference Include="Microsoft.DotNet.Watcher.Tools" Version="2.0.0" />
  </ItemGroup>

```
