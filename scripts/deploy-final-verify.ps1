Write-Host "=== Final Verification ==="
Write-Host ""

$ts = Get-Date -Format 'HHmmss'
$routes = @(
    @{url="https://prtask.com?_t=$ts"; desc='Home'},
    @{url="https://prtask.com/Dashboard?_t=$ts"; desc='Dashboard'},
    @{url="https://prtask.com/Tasks?_t=$ts"; desc='Tasks'},
    @{url="https://prtask.com/Login?_t=$ts"; desc='Login'},
    @{url="https://prtask.com/Leaderboard?_t=$ts"; desc='Leaderboard'},
    @{url="https://prtask.com/HowItWorks?_t=$ts"; desc='HowItWorks'},
    @{url="https://prtask.com/Pricing?_t=$ts"; desc='Pricing'},
    @{url="https://prtask.com/About?_t=$ts"; desc='About'},
    @{url="https://prtask.com/Download?_t=$ts"; desc='Download'},
    @{url="https://prtask.com/Settings?_t=$ts"; desc='Settings'},
    @{url="https://prtask.com/Sprints?_t=$ts"; desc='Sprints'},
    @{url="https://prtask.com/Boards?_t=$ts"; desc='Boards'},
    @{url="https://prtask.com/Legal/Terms?_t=$ts"; desc='Legal/Terms'},
    @{url="https://prtask.com/Legal/Privacy?_t=$ts"; desc='Legal/Privacy'},
    @{url="https://prtask.com/Legal/CookiePolicy?_t=$ts"; desc='Legal/CookiePolicy'},
    @{url="https://prtask.com/Legal/Dmca?_t=$ts"; desc='Legal/Dmca'},
    @{url="https://prtask.com/Framework/blazor.webassembly.66stpp682q.js?_t=$ts"; desc='Blazor boot JS'},
    @{url="https://prtask.com/service-worker-assets.js?_t=$ts"; desc='SW assets'},
    @{url="https://prtask.com/Css/app.min.css?_t=$ts"; desc='CSS'},
    @{url="https://prtask.com/Js/opfs-store.min.js?_t=$ts"; desc='Js/opfs-store'},
    @{url="https://prtask.com/Content/Js/circuit-manager.min.js?_t=$ts"; desc='Content/Js/circuit-manager'},
    @{url="https://prtask.com/icon-192.png?_t=$ts"; desc='Icon'}
)

$ok = 0; $fail = 0
foreach ($r in $routes) {
    $status = curl.exe --insecure -s -o /dev/null -w "%{http_code}" $r.url 2>&1
    if ($status -eq '200') {
        Write-Host "[OK]   $($r.desc)"
        $ok++
    } else {
        Write-Host "[FAIL] $status $($r.desc) $($r.url)"
        $fail++
    }
}

Write-Host ""
Write-Host "Results: $ok OK, $fail FAIL out of $($routes.Count) routes"

# Check no .json files exist
Write-Host ""
Write-Host "=== Structure checks ==="
$jsonFiles = curl.exe --insecure -s -o /dev/null -w "%{http_code}" "https://prtask.com/manifest.json?_t=$ts" 2>&1
Write-Host "manifest.json: $jsonFiles (should be 404)"
$appSettings = curl.exe --insecure -s -o /dev/null -w "%{http_code}" "https://prtask.com/appsettings.json?_t=$ts" 2>&1
Write-Host "appsettings.json: $appSettings (should be 404)"
$oldFw = curl.exe --insecure -s -o /dev/null -w "%{http_code}" "https://prtask.com/_framework/blazor.webassembly.66stpp682q.js?_t=$ts" 2>&1
Write-Host "_framework/ (old path): $oldFw (should be 404)"
