foreach ($lang in @('ar','hi','ja','ko','ru','fil')) {
    $Path = "C:\work\prtask.com\src\PrTask.SharedUI\Resources\SharedResource.$lang.resx"
    if (-not (Test-Path $Path)) { Write-Host "$lang: file not found"; continue }
    $Resx = [xml](Get-Content $Path -Encoding UTF8)
    $Keys = @{}
    foreach ($d in $Resx.root.data) { $Keys[$d.name] = $true }
    $CheckKeys = @('BrandTagline','CategoryPlatform','FooterCopyrightText','LoginLabel')
    $Missing = $CheckKeys | Where-Object { -not $Keys.ContainsKey($_) }
    Write-Host "${lang}: missing $($Missing.Count): $($Missing -join ',')"
}
