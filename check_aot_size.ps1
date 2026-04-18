$dir = "C:\work\prtask.com\src\PrTask.Client\bin\Release\net10.0\wwwroot\_framework"
$items = Get-ChildItem -Path $dir -Recurse -File
$total = $items | Measure-Object -Property Length -Sum
Write-Host "Total files: $($total.Count)"
Write-Host "Total size: $([math]::Round($total.Sum / 1MB, 2)) MB"
Write-Host ""
Write-Host "Largest files:"
$items | Sort-Object Length -Descending | Select-Object -First 15 | ForEach-Object {
    $sizeKB = [math]::Round($_.Length / 1KB, 1)
    Write-Host "$($sizeKB.ToString().PadLeft(10)) KB  $($_.Name)"
}
