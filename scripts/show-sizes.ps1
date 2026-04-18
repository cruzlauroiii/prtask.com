param()
$wwwroot = 'C:\work\prtask.com\publish\web\wwwroot'

Write-Host '=== MINIFICATION RESULTS ==='
Write-Host ''

Write-Host 'CSS:'
Write-Host "  app.css (original):     $((Get-Item "$wwwroot\_content\PrTask.SharedUI\css\app.css").Length) bytes"
Write-Host "  app.min.css (minified): $((Get-Item "$wwwroot\_content\PrTask.SharedUI\css\app.min.css").Length) bytes"
Write-Host "  app.min.css.br:         $((Get-Item "$wwwroot\_content\PrTask.SharedUI\css\app.min.css.br").Length) bytes"
Write-Host "  app.min.css.gz:         $((Get-Item "$wwwroot\_content\PrTask.SharedUI\css\app.min.css.gz").Length) bytes"
Write-Host "  bundle.scp.css:         $((Get-Item "$wwwroot\_content\PrTask.SharedUI\PrTask.SharedUI.58anj8sw7j.bundle.scp.css").Length) bytes"
Write-Host ''

Write-Host 'JS (wwwroot/js):'
Get-ChildItem "$wwwroot\js" -File | Sort-Object Name | ForEach-Object {
    Write-Host "  $($_.Name): $($_.Length) bytes"
}
Write-Host ''

Write-Host 'HTML:'
Write-Host "  index.html:     $((Get-Item "$wwwroot\index.html").Length) bytes"
Write-Host "  index.html.br:  $((Get-Item "$wwwroot\index.html.br").Length) bytes"
Write-Host "  index.html.gz:  $((Get-Item "$wwwroot\index.html.gz").Length) bytes"
Write-Host ''

Write-Host 'Service Worker:'
Write-Host "  service-worker.published.js:    $((Get-Item "$wwwroot\service-worker.published.js").Length) bytes"
Write-Host "  service-worker.published.js.br: $((Get-Item "$wwwroot\service-worker.published.js.br").Length) bytes"
Write-Host "  service-worker.published.js.gz: $((Get-Item "$wwwroot\service-worker.published.js.gz").Length) bytes"
