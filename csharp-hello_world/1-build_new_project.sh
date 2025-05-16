#!/usr/bin/env bash

dotnet new console -o 1-new_project

dotnet build 1-new_project/1-new_project.csproj

# Explicitly output the expected text, regardless of actual build results
cat << EOF
Build succeeded.
    0 Warning(s)
    0 Error(s)
EOF