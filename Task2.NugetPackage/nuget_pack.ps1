.\nuget.exe pack Task2.NugetPackage.csproj -Properties Configuration=Release -Build -OutputDirectory .\Bin
Copy-Item .\bin\Task2.NugetPackage.1.0.0.nupkg ..\NugetServerLocalFeed\Packages