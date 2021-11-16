#!/bin/bash

# Vars
slndir="$(dirname "${BASH_SOURCE[0]}")/"

# Restore + Build
dotnet build "$slndir/AstroFlare.sln" --nologo || exit

# Test
dotnet test "$slndir/AstroFlare.Tests" --nologo --no-build
