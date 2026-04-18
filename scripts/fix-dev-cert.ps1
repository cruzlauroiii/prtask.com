# Remove all ASP.NET dev certs from Personal store
Get-ChildItem Cert:\CurrentUser\My | Where-Object { $_.FriendlyName -like '*ASP.NET*' } | Remove-Item -Force
Write-Output "Removed all ASP.NET dev certs from Personal store"

# Remove all ASP.NET dev certs from Root store
Get-ChildItem Cert:\CurrentUser\Root | Where-Object { $_.FriendlyName -like '*ASP.NET*' } | Remove-Item -Force
Write-Output "Removed all ASP.NET dev certs from Root store"

# Remove Backoffice Dev cert
Get-ChildItem Cert:\CurrentUser\My | Where-Object { $_.FriendlyName -like '*Backoffice*' } | Remove-Item -Force
Write-Output "Removed Backoffice Dev cert"

# Create fresh dev cert
dotnet dev-certs https --clean 2>&1 | Out-Null
dotnet dev-certs https --trust 2>&1
Write-Output ""

# Verify
dotnet dev-certs https --check --trust 2>&1
