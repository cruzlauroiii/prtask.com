cd C:\work\prtask.com\src\PrTask.Transpiler
$Output = dotnet build 2>&1
$Errors = $Output | Select-String 'error ' | ForEach-Object { $_.Line.Trim() } | Select-Object -Unique
Write-Output "Unique errors: $($Errors.Count)"
foreach ($E in $Errors | Select-Object -First 10) {
    if ($E.Length -gt 150) { $E = $E.Substring(0, 150) }
    Write-Output $E
}
