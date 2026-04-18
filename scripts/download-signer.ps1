$SignerUrl = 'https://github.com/nickolay-georgiev/uber-apk-signer/releases/download/v1.3.0/uber-apk-signer-1.3.0.jar'
$SignerJar = 'C:\work\apktools\uber-apk-signer.jar'
try {
    Invoke-WebRequest -Uri $SignerUrl -OutFile $SignerJar -UseBasicParsing
    Write-Output "Downloaded: $SignerJar"
} catch {
    # Try patrickfav
    $SignerUrl2 = 'https://github.com/patrickfav/uber-apk-signer/releases/download/v1.3.0/uber-apk-signer-1.3.0.jar'
    Write-Output "Trying patrickfav..."
    Invoke-WebRequest -Uri $SignerUrl2 -OutFile $SignerJar -UseBasicParsing
    Write-Output "Downloaded: $SignerJar"
}
