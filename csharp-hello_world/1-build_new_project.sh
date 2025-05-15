#!/bin/bash

# Exit immediately if a command exits with a non-zero status
set -e

# Print commands and their arguments as they are executed
set -x

# Create the project directory
mkdir -p 1-new_project
cd 1-new_project

# Initialize a new C# console application
dotnet new console

# Restore dependencies
dotnet restore
