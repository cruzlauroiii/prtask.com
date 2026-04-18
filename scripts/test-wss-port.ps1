try {
    $Tcp = New-Object System.Net.Sockets.TcpClient
    $Tcp.Connect('192.168.100.175', 8771)
    Write-Output 'WSS port 8771 OPEN'
    $Tcp.Close()
} catch {
    Write-Output "WSS port 8771 CLOSED: $($_.Exception.InnerException.Message)"
}
