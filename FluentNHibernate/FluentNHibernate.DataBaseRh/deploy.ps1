Write-Output "Starting updating scripts in database"
$buildType = $OctopusParameters["RoundhouseBuildType"]
Write-Host "Updating Datbase with buildType: $buildType"
C:\Windows\Microsoft.NET\Framework\v4.0.30319\msbuild DBDeploy_MSBuild.proj /p:BuildType=$buildType
Write-Output "Finishing running scripts against database"