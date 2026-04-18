$html = Get-Content "C:\work\prtask.com\publish\web\wwwroot\index.html" -Raw
$matches = [regex]::Matches($html, 'src="[^"]*\.js"')
foreach ($m in $matches) {
    Write-Host $m.Value
}
