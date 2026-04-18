$content = Get-Content "C:\work\prtask.com\src\PrTask.SharedUI\Resources\SharedResource.zh.resx" -Encoding UTF8 -Raw
$pattern = '<data name="(Home[^"]*)"[^>]*>\s*<value>([^<]*)</value>'
$matches2 = [regex]::Matches($content, $pattern)
foreach ($m in $matches2) {
    Write-Host "$($m.Groups[1].Value) = $($m.Groups[2].Value)"
}
