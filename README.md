# Repo to demonstrate migration/build issue in dotnet 8

Build error after migrations

```
vscode ➜ /workspaces/bd-dotnet7-vs-dotnet8/BuberDinner-dotnet8 (main) $ make demo
 ---Running Demo Case--- 
 ---Installing tools--- 
dotnet tool install --global csharp-ls
Tool 'csharp-ls' is already installed.
make: [makefile:3: tools] Error 1 (ignored)
dotnet tool install --global dotnet-ef --version 8.0.0
Tool 'dotnet-ef' is already installed.
make: [makefile:4: tools] Error 1 (ignored)
dotnet tool install --global roslynator.dotnet.cli
Tool 'roslynator.dotnet.cli' is already installed.
make: [makefile:5: tools] Error 1 (ignored)
 ---Deleting existing migrations--- 
rm -r BuberDinner.Infrastructure/Migrations/
 ---Building Project Before Migrations--- 
dotnet build
MSBuild version 17.8.3+195e7f5a3 for .NET
  Determining projects to restore...
  Restored /workspaces/bd-dotnet7-vs-dotnet8/BuberDinner-dotnet8/BuberDinner.Infrastructure/BuberDinner.Infrastructure.csproj (in 244 ms).
  Restored /workspaces/bd-dotnet7-vs-dotnet8/BuberDinner-dotnet8/BuberDinner.Api/BuberDinner.Api.csproj (in 244 ms).
  3 of 5 projects are up-to-date for restore.
  BuberDinner.Domain -> /workspaces/bd-dotnet7-vs-dotnet8/BuberDinner-dotnet8/BuberDinner.Domain/bin/Debug/net8.0/BuberDinner.Domain.dll
  BuberDinner.Contracts -> /workspaces/bd-dotnet7-vs-dotnet8/BuberDinner-dotnet8/BuberDinner.Contracts/bin/Debug/net8.0/BuberDinner.Contracts.dll
  BuberDinner.Application -> /workspaces/bd-dotnet7-vs-dotnet8/BuberDinner-dotnet8/BuberDinner.Application/bin/Debug/net8.0/BuberDinner.Application.dll
  BuberDinner.Infrastructure -> /workspaces/bd-dotnet7-vs-dotnet8/BuberDinner-dotnet8/BuberDinner.Infrastructure/bin/Debug/net8.0/BuberDinner.Infrastructure.dll
  BuberDinner.Api -> /workspaces/bd-dotnet7-vs-dotnet8/BuberDinner-dotnet8/BuberDinner.Api/bin/Debug/net8.0/BuberDinner.Api.dll

Build succeeded.
    0 Warning(s)
    0 Error(s)

Time Elapsed 00:00:01.28
 ---Running new migrations--- 
dotnet ef migrations add InitialCreate --project BuberDinner.Infrastructure/ --startup-project BuberDinner.Api/
Build started...
Build succeeded.
Done. To undo this action, use 'ef migrations remove'
 ---Building Project After Migrations--- 
dotnet build
MSBuild version 17.8.3+195e7f5a3 for .NET
  Determining projects to restore...
  All projects are up-to-date for restore.
  BuberDinner.Contracts -> /workspaces/bd-dotnet7-vs-dotnet8/BuberDinner-dotnet8/BuberDinner.Contracts/bin/Debug/net8.0/BuberDinner.Contracts.dll
  BuberDinner.Domain -> /workspaces/bd-dotnet7-vs-dotnet8/BuberDinner-dotnet8/BuberDinner.Domain/bin/Debug/net8.0/BuberDinner.Domain.dll
  BuberDinner.Application -> /workspaces/bd-dotnet7-vs-dotnet8/BuberDinner-dotnet8/BuberDinner.Application/bin/Debug/net8.0/BuberDinner.Application.dll
/workspaces/bd-dotnet7-vs-dotnet8/BuberDinner-dotnet8/BuberDinner.Infrastructure/Migrations/BuberDinnerDbContextModelSnapshot.cs(414,32): error CS1061: 'OwnedNavigationBuilder' does not contain a definition for 'HasDiscriminator' and no accessible extension method 'HasDiscriminator' accepting a first argument of type 'OwnedNavigationBuilder' could be found (are you missing a using directive or an assembly reference?) [/workspaces/bd-dotnet7-vs-dotnet8/BuberDinner-dotnet8/BuberDinner.Infrastructure/BuberDinner.Infrastructure.csproj]
/workspaces/bd-dotnet7-vs-dotnet8/BuberDinner-dotnet8/BuberDinner.Infrastructure/Migrations/BuberDinnerDbContextModelSnapshot.cs(656,32): error CS1061: 'OwnedNavigationBuilder' does not contain a definition for 'HasDiscriminator' and no accessible extension method 'HasDiscriminator' accepting a first argument of type 'OwnedNavigationBuilder' could be found (are you missing a using directive or an assembly reference?) [/workspaces/bd-dotnet7-vs-dotnet8/BuberDinner-dotnet8/BuberDinner.Infrastructure/BuberDinner.Infrastructure.csproj]
/workspaces/bd-dotnet7-vs-dotnet8/BuberDinner-dotnet8/BuberDinner.Infrastructure/Migrations/20231230191142_InitialCreate.Designer.cs(417,32): error CS1061: 'OwnedNavigationBuilder' does not contain a definition for 'HasDiscriminator' and no accessible extension method 'HasDiscriminator' accepting a first argument of type 'OwnedNavigationBuilder' could be found (are you missing a using directive or an assembly reference?) [/workspaces/bd-dotnet7-vs-dotnet8/BuberDinner-dotnet8/BuberDinner.Infrastructure/BuberDinner.Infrastructure.csproj]
/workspaces/bd-dotnet7-vs-dotnet8/BuberDinner-dotnet8/BuberDinner.Infrastructure/Migrations/20231230191142_InitialCreate.Designer.cs(659,32): error CS1061: 'OwnedNavigationBuilder' does not contain a definition for 'HasDiscriminator' and no accessible extension method 'HasDiscriminator' accepting a first argument of type 'OwnedNavigationBuilder' could be found (are you missing a using directive or an assembly reference?) [/workspaces/bd-dotnet7-vs-dotnet8/BuberDinner-dotnet8/BuberDinner.Infrastructure/BuberDinner.Infrastructure.csproj]

Build FAILED.

/workspaces/bd-dotnet7-vs-dotnet8/BuberDinner-dotnet8/BuberDinner.Infrastructure/Migrations/BuberDinnerDbContextModelSnapshot.cs(414,32): error CS1061: 'OwnedNavigationBuilder' does not contain a definition for 'HasDiscriminator' and no accessible extension method 'HasDiscriminator' accepting a first argument of type 'OwnedNavigationBuilder' could be found (are you missing a using directive or an assembly reference?) [/workspaces/bd-dotnet7-vs-dotnet8/BuberDinner-dotnet8/BuberDinner.Infrastructure/BuberDinner.Infrastructure.csproj]
/workspaces/bd-dotnet7-vs-dotnet8/BuberDinner-dotnet8/BuberDinner.Infrastructure/Migrations/BuberDinnerDbContextModelSnapshot.cs(656,32): error CS1061: 'OwnedNavigationBuilder' does not contain a definition for 'HasDiscriminator' and no accessible extension method 'HasDiscriminator' accepting a first argument of type 'OwnedNavigationBuilder' could be found (are you missing a using directive or an assembly reference?) [/workspaces/bd-dotnet7-vs-dotnet8/BuberDinner-dotnet8/BuberDinner.Infrastructure/BuberDinner.Infrastructure.csproj]
/workspaces/bd-dotnet7-vs-dotnet8/BuberDinner-dotnet8/BuberDinner.Infrastructure/Migrations/20231230191142_InitialCreate.Designer.cs(417,32): error CS1061: 'OwnedNavigationBuilder' does not contain a definition for 'HasDiscriminator' and no accessible extension method 'HasDiscriminator' accepting a first argument of type 'OwnedNavigationBuilder' could be found (are you missing a using directive or an assembly reference?) [/workspaces/bd-dotnet7-vs-dotnet8/BuberDinner-dotnet8/BuberDinner.Infrastructure/BuberDinner.Infrastructure.csproj]
/workspaces/bd-dotnet7-vs-dotnet8/BuberDinner-dotnet8/BuberDinner.Infrastructure/Migrations/20231230191142_InitialCreate.Designer.cs(659,32): error CS1061: 'OwnedNavigationBuilder' does not contain a definition for 'HasDiscriminator' and no accessible extension method 'HasDiscriminator' accepting a first argument of type 'OwnedNavigationBuilder' could be found (are you missing a using directive or an assembly reference?) [/workspaces/bd-dotnet7-vs-dotnet8/BuberDinner-dotnet8/BuberDinner.Infrastructure/BuberDinner.Infrastructure.csproj]
    0 Warning(s)
    4 Error(s)

Time Elapsed 00:00:00.75
make: *** [makefile:21: post-build] Error 1
```

The difference between dotnet-ef v7.0.1 and dotnet-ef v8.0.0 is that dotnet-ef v8.0.0 adds `.HasDiscriminator` on line 417 and 659 of `/workspaces/bd-dotnet7-vs-dotnet8/BuberDinner-dotnet8/BuberDinner.Infrastructure/Migrations/20231230190557_InitialCreate.Designer.cs`

This .HasDiscriminator then causes the build to fail.
