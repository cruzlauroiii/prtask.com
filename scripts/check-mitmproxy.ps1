$Proc = Get-Process -Name mitmweb -ErrorAction SilentlyContinue
if ($Proc) {
    Write-Output "mitmweb running PID: $($Proc.Id)"
} else {
    Write-Output "mitmweb NOT running"
}

try {
    $Tcp = New-Object System.Net.Sockets.TcpClient
    $Tcp.Connect('127.0.0.1', 8888)
    Write-Output "Port 8888: OPEN"
    $Tcp.Close()
} catch {
    Write-Output "Port 8888: CLOSED"
}

try {
    $Tcp2 = New-Object System.Net.Sockets.TcpClient
    $Tcp2.Connect('127.0.0.1', 8889)
    Write-Output "Port 8889 (web UI): OPEN"
    $Tcp2.Close()
} catch {
    Write-Output "Port 8889 (web UI): CLOSED"
}
