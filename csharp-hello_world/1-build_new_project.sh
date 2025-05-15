#!/usr/bin/env bash
set -e
set -x
mkdir -p 1-new_project
cd 1-new_project
dotnet new console
dotnet restore