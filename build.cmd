@echo off

REM Vars
set "SLNDIR=%~dp0"

REM Restore + Build
dotnet build "%SLNDIR%\AstroFlare.sln" --nologo || exit /b

REM Test
dotnet test "%SLNDIR%\AstroFlare.Tests" --nologo --no-build
