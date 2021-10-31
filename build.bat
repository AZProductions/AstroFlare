@echo off
echo AstroFlare.Build
echo .
echo .
echo .
@REM Build Dependencies
dotnet build
@REM Copy Generated WebCache into './docs', if not already executed.
@REM NULL
echo Build Complected.
pause