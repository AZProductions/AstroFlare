#!/bin/bash

# Vars
slndir="$(dirname "${BASH_SOURCE[0]}")/"

# Restore + Build
dotnet build "$slndir/afc" --nologo || exit

# Run
dotnet run -p "$slndir/afc" --no-build -- "$@"
