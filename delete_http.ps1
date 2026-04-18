Get-ChildItem "C:\work\prtask.com\src\PrTask.Client\Services\Http*Service.cs" | ForEach-Object {
    Remove-Item $_.FullName -Force
    Write-Host "Deleted $($_.Name)"
}
