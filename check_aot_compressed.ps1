$dir = "C:\work\prtask.com\src\PrTask.Client\bin\Release\net10.0\wwwroot\_framework"
$gzItems = Get-ChildItem -Path $dir -Recurse -File -Filter "*.gz"
$brItems = Get-ChildItem -Path $dir -Recurse -File -Filter "*.br"
$gzTotal = $gzItems | Measure-Object -Property Length -Sum
$brTotal = $brItems | Measure-Object -Property Length -Sum
Write-Host "Compressed .gz files: $($gzTotal.Count), total: $([math]::Round($gzTotal.Sum / 1MB, 2)) MB"
Write-Host "Compressed .br files: $($brTotal.Count), total: $([math]::Round($brTotal.Sum / 1MB, 2)) MB"

# DLL count (should be 0 or minimal with WasmStripILAfterAOT)
$dlls = Get-ChildItem -Path $dir -Recurse -File -Filter "*.dll"
Write-Host "DLL files remaining: $($dlls.Count)"
$wasmFiles = Get-ChildItem -Path $dir -Recurse -File -Filter "*.wasm"
Write-Host "WASM files: $($wasmFiles.Count)"
