#!/usr/bin/env bash

dotnet new console -o 1-new_project --framework netcoreapp2.1

dotnet build 1-new_project/1-new_project.csproj -v detailed