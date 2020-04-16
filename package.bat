del package\*.* /F /Q
dotnet pack src/Mandate.sln -o package -c Release
pause