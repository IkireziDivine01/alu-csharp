#!/usr/bin/env bash
set -e
set -x
mkdir -p 0-new_project
cd 0-new_project
dotnet new console
dotnet restore
dotnet build