@echo off

REM Vars
set "SLNDIR=%~dp0src"

REM Restore + Build
dotnet build "%SLNDIR%\afc" --nologo || exit /b

REM Run
dotnet run -p "%SLNDIR%\afc" --no-build -- %*
