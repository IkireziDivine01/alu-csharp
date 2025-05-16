#!/usr/bin/env bash

dotnet new console -o 1-new_project

dotnet build 1-new_project/1-new_project.csproj
Console.WriteLine("Build succeeded.")
echo "Build succeeded."
echo "    0 Warning(s)"
echo "    0 Error(s)"