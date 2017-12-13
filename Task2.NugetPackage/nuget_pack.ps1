.\nuget.exe pack Task2.NugetPackage.csproj -Properties Configuration=Release -Build -OutputDirectory .\Bin
Copy-Item .\bin\Task2.NugetPackage.2.0.2.nupkg ..\NugetServerLocalFeed\Packages