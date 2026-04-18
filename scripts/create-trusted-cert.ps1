# Create a self-signed cert and add it to both Personal and Root stores
$Cert = New-SelfSignedCertificate `
    -DnsName 'localhost' `
    -CertStoreLocation 'Cert:\CurrentUser\My' `
    -NotAfter (Get-Date).AddYears(5) `
    -FriendlyName 'ASP.NET Core HTTPS development certificate' `
    -KeyUsage DigitalSignature, KeyEncipherment `
    -TextExtension @("2.5.29.37={text}1.3.6.1.5.5.7.3.1") `
    -KeyAlgorithm RSA `
    -KeyLength 2048

# Export and import to Root store (trusted)
$Pwd = ConvertTo-SecureString -String 'dev' -Force -AsPlainText
$TmpPfx = "$env:TEMP\dev-cert.pfx"
Export-PfxCertificate -Cert $Cert -FilePath $TmpPfx -Password $Pwd | Out-Null
Import-PfxCertificate -FilePath $TmpPfx -CertStoreLocation 'Cert:\CurrentUser\Root' -Password $Pwd | Out-Null
Remove-Item $TmpPfx -Force

# Export PFX for Kestrel
$KestrelPfx = 'C:\work\prtask.com\src\Companion.Backoffice\backoffice.pfx'
Export-PfxCertificate -Cert $Cert -FilePath $KestrelPfx -Password $Pwd | Out-Null

Write-Output "Certificate created: $($Cert.Thumbprint)"
Write-Output "PFX exported to: $KestrelPfx"
Write-Output "Cert is in both Personal and Root (trusted) stores"
