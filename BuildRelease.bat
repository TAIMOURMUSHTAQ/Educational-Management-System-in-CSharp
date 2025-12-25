@echo off
echo ================================================================
echo     Educational Management System - Build Release Package
echo ================================================================
echo.

:: Set variables
set PROJECT_NAME=EducationalManagementSystem
set OUTPUT_DIR=Deployment
set RELEASE_DIR=bin\Release

:: Check if MSBuild is available
where msbuild >nul 2>nul
if %ERRORLEVEL% NEQ 0 (
    echo MSBuild not found in PATH.
    echo.
    echo Please run this script from "Developer Command Prompt for VS"
    echo OR add MSBuild to your PATH.
    echo.
    echo Alternative: Open the solution in Visual Studio, select Release
    echo mode, and build manually (Ctrl+Shift+B).
    echo.
    pause
    exit /b 1
)

echo [1/4] Cleaning previous build...
if exist "%RELEASE_DIR%" rmdir /s /q "%RELEASE_DIR%"
if exist "%OUTPUT_DIR%" rmdir /s /q "%OUTPUT_DIR%"

echo [2/4] Building Release version...
msbuild %PROJECT_NAME%.csproj /p:Configuration=Release /p:Platform=AnyCPU /t:Rebuild /v:minimal

if %ERRORLEVEL% NEQ 0 (
    echo.
    echo BUILD FAILED! Check errors above.
    pause
    exit /b 1
)

echo [3/4] Creating deployment package...
mkdir "%OUTPUT_DIR%"
mkdir "%OUTPUT_DIR%\%PROJECT_NAME%_v1.0"

:: Copy main files
copy "%RELEASE_DIR%\%PROJECT_NAME%.exe" "%OUTPUT_DIR%\%PROJECT_NAME%_v1.0\"
copy "%RELEASE_DIR%\%PROJECT_NAME%.exe.config" "%OUTPUT_DIR%\%PROJECT_NAME%_v1.0\"

:: Copy documentation
copy "DatabaseSetup.sql" "%OUTPUT_DIR%\%PROJECT_NAME%_v1.0\"
copy "DEPLOYMENT_README.txt" "%OUTPUT_DIR%\%PROJECT_NAME%_v1.0\"
copy "README.md" "%OUTPUT_DIR%\%PROJECT_NAME%_v1.0\" 2>nul

echo [4/4] Package created successfully!
echo.
echo ================================================================
echo     BUILD COMPLETE!
echo ================================================================
echo.
echo Deployment package location:
echo   %CD%\%OUTPUT_DIR%\%PROJECT_NAME%_v1.0\
echo.
echo Contents:
dir /b "%OUTPUT_DIR%\%PROJECT_NAME%_v1.0\"
echo.
echo You can now zip this folder and distribute it.
echo ================================================================
echo.
pause
