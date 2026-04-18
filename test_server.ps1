$proc = Start-Process -FilePath 'dotnet' -ArgumentList 'run','--project','C:\work\prtask.com\src\PrTask.Server\PrTask.Server.csproj','--no-build' -NoNewWindow -PassThru
Write-Output "Server PID: $($proc.Id)"
Start-Sleep -Seconds 10
try {
    $r = Invoke-WebRequest -Uri 'http://localhost:5000' -UseBasicParsing -TimeoutSec 5 -ErrorAction Stop
    Write-Output "StatusCode: $($r.StatusCode)"
} catch {
    Write-Output "Request error: $($_.Exception.Message)"
}
Stop-Process -Id $proc.Id -Force -ErrorAction SilentlyContinue
