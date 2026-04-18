$Cert = New-SelfSignedCertificate -DnsName 'localhost','0.0.0.0' -CertStoreLocation 'Cert:\CurrentUser\My' -NotAfter (Get-Date).AddYears(5) -FriendlyName 'Backoffice Dev'
$Pwd = ConvertTo-SecureString -String 'backoffice' -Force -AsPlainText
$PfxPath = 'C:\work\prtask.com\src\Companion.Backoffice\wwwroot\cert.pfx'
Export-PfxCertificate -Cert $Cert -FilePath $PfxPath -Password $Pwd | Out-Null
Write-Output "PFX created at $PfxPath"
