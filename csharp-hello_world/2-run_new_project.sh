#!/usr/bin/env bash

dotnet new console -o 2-new_project --force

dotnet build 2-new_project/2-new_project.csproj

dotnet run --project 2-new_project/2-new_project.csproj