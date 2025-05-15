#!/usr/bin/env bash
set -e
set -x
mkdir -p 1-new_project
cd 1-new_project
dotnet new console
dotnet restore
dotnet build --nologo | grep -E "Build succeeded.|[0-9]+ Warning\(s\)|[0-9]+ Error\(s\)" | tr -d '\n'