$CertDir = "$env:USERPROFILE\.mitmproxy"
Write-Output "Cert dir: $CertDir"
Get-ChildItem $CertDir -Filter 'mitmproxy*' | ForEach-Object { Write-Output "  $($_.Name) ($($_.Length) bytes)" }

# Push the PEM format
$Pem = "$CertDir\mitmproxy-ca-cert.pem"
if (Test-Path $Pem) {
    adb -s 192.168.100.103:43619 push $Pem /sdcard/Download/mitmproxy-ca.pem 2>&1
    Write-Output "Pushed PEM"
}

# Also push the CER but convert to DER format
$Cer = "$CertDir\mitmproxy-ca-cert.cer"
if (Test-Path $Cer) {
    # Read cert, re-export as proper DER
    $Cert = New-Object System.Security.Cryptography.X509Certificates.X509Certificate2($Cer)
    $DerBytes = $Cert.Export([System.Security.Cryptography.X509Certificates.X509ContentType]::Cert)
    $DerPath = "$CertDir\mitmproxy-ca-der.crt"
    [System.IO.File]::WriteAllBytes($DerPath, $DerBytes)
    adb -s 192.168.100.103:43619 push $DerPath /sdcard/Download/mitmproxy-ca-der.crt 2>&1
    Write-Output "Pushed DER format as mitmproxy-ca-der.crt"
}
