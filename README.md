# HelloWorld

` mkdir EFExample `

` dotnet new sln `

` mkdir src\EFExample `

` dotnet new console -o src\EFExample --use-program-main `

` dotnet sln add src\EFExample `

` dotnet add src\EFExample package Microsoft.EntityFrameworkCore.Sqlite `

` dotnet run --project src\EFExample `

# Container

` podman build --tag efexample -f Containerfile . `

` podman run --interactive --rm --name efexample efexample `
