Overview
----

1. **Install Roundhouse via nuget**

Run the following commands in package manager


    install-package roundhouse

    install-package roundhouse.lib

    install-package roundhouse.msbuild

    install-package roundhouse.refreshdatabas

2. **Modify *DBDeploy_MSBuild.proj* file**, which is created when you install the roundhouse.msbuild nuget package

The stuff created does stuff

3. **Set build event in properties**

Set the *Post-build event command line* to:

    if "$(ConfigurationName)" == "Debug" "$(MSBuildBinPath)\msbuild.exe" "$(TargetDir)DBDeploy_MSBuild.proj" /p:Configuration=$(ConfigurationName) /p:BuildType=$(BuildType)

4. Create deploy.ps1 file (if using Octopus Deploy)

This file is used for stuff

    Write-Output "Starting updating scripts in database"
    $buildType = $OctopusParameters["RoundhouseBuildType"]
    Write-Host "Updating Datbase with buildType: $buildType"
    C:\Windows\Microsoft.NET\Framework\v4.0.30319\msbuild DBDeploy_MSBuild.proj /p:BuildType=$buildType
    Write-Output "Finishing running scripts against database"

5. Set copy of newer for proj and ps1 file

For both deploy.ps1 and *DBDeploy_MSBuild.proj* set the Copy to Output directory to "Copy if Newer"

6. Set *DBDeploy_MSBuild.proj* build action to content 
