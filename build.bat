@echo off
@cls
@rmdir .\bin /s/q
cd Console
dotnet build --nologo
cd ..\WinForms
dotnet build --nologo
cd ..
