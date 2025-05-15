#!/usr/bin/env bash
set -e
set -x
mkdir -p 2-new_project
cd 2-new_project
dotnet new console
dotnet restore
