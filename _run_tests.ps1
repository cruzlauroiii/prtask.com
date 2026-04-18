$output = dotnet test tests/PrTask.E2E/PrTask.E2E.csproj --no-build -v n 2>&1 | Out-String
$lines = $output -split "`n"
$lines | Where-Object { $_ -match '^\s+Failed\s+' -or $_ -match 'Error Message' -or $_ -match 'Assert\.' -or $_ -match 'Expected' -or $_ -match 'Stack Trace' }
