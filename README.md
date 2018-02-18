run

```
dotnet watch run
```

* edit project file to see nswag build step
* have nswag command line running
* look at nswag.json

this does the watching thing for .net (front end is taken care of by webpack)

```
  <ItemGroup>
    <DotNetCliToolReference Include="Microsoft.DotNet.Watcher.Tools" Version="2.0.0" />
  </ItemGroup>

```
