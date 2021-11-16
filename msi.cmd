@echo off

REM Vars
set "SLNDIR=%~dp0src"

REM Restore + Build
dotnet build "%SLNDIR%\afi" --nologo || exit /b

REM Run
dotnet run -p "%SLNDIR%\afi" --no-build
