@echo off
echo AstroFlare.Build
@REM Build Dependencies
dotnet build .\AstroFlare.Generator\AstroFlare.Generator.csproj
dotnet build .\AstroFlare.Compiler\AstroFlare.Compiler.csproj
@REM Copy Generated WebCache into './docs', if not already executed.
@REM NULL
echo Build Complected.
pause