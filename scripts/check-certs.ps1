Get-ChildItem Cert:\CurrentUser\My | Where-Object { $_.Subject -like '*localhost*' -or $_.FriendlyName -like '*ASP*' -or $_.FriendlyName -like '*dev*' -or $_.FriendlyName -like '*Backoffice*' } | Format-Table Subject, FriendlyName, NotAfter, Thumbprint -AutoSize

Write-Output "--- Root store ---"
Get-ChildItem Cert:\CurrentUser\Root | Where-Object { $_.Subject -like '*localhost*' -or $_.FriendlyName -like '*ASP*' } | Format-Table Subject, FriendlyName, NotAfter -AutoSize
