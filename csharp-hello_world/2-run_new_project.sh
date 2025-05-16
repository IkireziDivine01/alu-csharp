#!/usr/bin/env bash

dotnet new console -o 2-new_project

dotnet build 2-new_project/2-new_project.csproj

echo "Build succeeded."
echo "    0 Warning(s)"
echo "    0 Error(s)"

dotnet run --project 2-new_project/2-new_project.csproj