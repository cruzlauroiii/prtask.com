$secrets = Get-Content (Join-Path ([Environment]::GetFolderPath('ApplicationData')) 'Microsoft\UserSecrets\prtask-server-secrets\secrets.json') | ConvertFrom-Json
$env:CLOUDFLARE_API_KEY = $secrets.'Cloudflare:GlobalApiKey'
$env:CLOUDFLARE_EMAIL = $secrets.'Cloudflare:Email'
$env:CLOUDFLARE_ACCOUNT_ID = $secrets.'Cloudflare:AccountId'
$env:CI = 'true'
$sw = [System.Diagnostics.Stopwatch]::StartNew()
& npx.cmd wrangler pages deploy 'C:\work\prtask.com\publish-output\wwwroot' --project-name=prtask --commit-dirty=true 2>&1
$sw.Stop()
Write-Output "Deploy took: $($sw.Elapsed.TotalSeconds) seconds"
Write-Output "Exit code: $LASTEXITCODE"
