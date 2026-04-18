$Path = 'C:\Users\user\AppData\Local\Temp\claude\C--work-prtask-com\2fb8afff-8f40-4d6e-8a63-bea5b73f14d9\tasks\aac25a0034283ad59.output'
if (Test-Path $Path) {
    $Size = (Get-Item $Path).Length
    Write-Output "Size: $Size bytes"
} else {
    Write-Output "Not found"
}
