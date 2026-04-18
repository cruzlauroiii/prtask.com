Add-Type -AssemblyName System.Web

function Get-PageText {
    param([string]$BaseUrl, [string]$Path)

    try {
        $url = "$BaseUrl/$Path"
        $resp = Invoke-WebRequest -Uri $url -UseBasicParsing -SkipCertificateCheck -TimeoutSec 15
        $html = $resp.Content

        # Check for meta refresh redirect
        $pattern = 'content="0;url=([^"]+)"'
        if ($html -match $pattern) {
            $redirectUrl = $Matches[1]
            # Build absolute URL from redirect
            $parentPath = $Path -replace '[^/]*$', ''
            $fullRedirectUrl = "$BaseUrl/$parentPath$redirectUrl"
            $resp = Invoke-WebRequest -Uri $fullRedirectUrl -UseBasicParsing -SkipCertificateCheck -TimeoutSec 15
            $html = $resp.Content
        }

        # Strip script and style blocks
        $text = [regex]::Replace($html, '<script[^>]*>[\s\S]*?</script>', ' ')
        $text = [regex]::Replace($text, '<style[^>]*>[\s\S]*?</style>', ' ')
        # Strip HTML tags
        $text = [regex]::Replace($text, '<[^>]+>', ' ')
        # Decode HTML entities
        $text = [System.Web.HttpUtility]::HtmlDecode($text)
        # Normalize whitespace
        $text = [regex]::Replace($text, '\s+', ' ').Trim()

        return $text
    } catch {
        return "ERROR: $_"
    }
}

function Compare-PageText {
    param([string]$ProdText, [string]$LocalText, [string]$PageName)

    if ($ProdText.StartsWith("ERROR:")) {
        Write-Host "  PROD FETCH FAILED: $ProdText" -ForegroundColor Red
        return "PROD_ERROR"
    }
    if ($LocalText.StartsWith("ERROR:")) {
        Write-Host "  LOCAL FETCH FAILED: $LocalText" -ForegroundColor Red
        return "LOCAL_ERROR"
    }

    if ($ProdText -eq $LocalText) {
        Write-Host "  MATCH (${($ProdText.Length)} chars)" -ForegroundColor Green
        return "MATCH"
    } else {
        Write-Host "  DIFFER - Prod: $($ProdText.Length) chars, Local: $($LocalText.Length) chars" -ForegroundColor Yellow

        # Find first difference
        $minLen = [Math]::Min($ProdText.Length, $LocalText.Length)
        for ($i = 0; $i -lt $minLen; $i++) {
            if ($ProdText[$i] -ne $LocalText[$i]) {
                $start = [Math]::Max(0, $i - 40)
                $pSnip = $ProdText.Substring($start, [Math]::Min(100, $ProdText.Length - $start))
                $lSnip = $LocalText.Substring($start, [Math]::Min(100, $LocalText.Length - $start))
                Write-Host "  First diff at char $i" -ForegroundColor Yellow
                Write-Host "    PROD:  ...$pSnip..." -ForegroundColor Cyan
                Write-Host "    LOCAL: ...$lSnip..." -ForegroundColor Magenta
                break
            }
        }
        if ($ProdText.Length -ne $LocalText.Length -and $i -eq $minLen) {
            Write-Host "  Texts match up to char $minLen, but lengths differ ($($ProdText.Length) vs $($LocalText.Length))" -ForegroundColor Yellow
            if ($ProdText.Length -gt $LocalText.Length) {
                Write-Host "    PROD EXTRA: ...$($ProdText.Substring($minLen, [Math]::Min(100, $ProdText.Length - $minLen)))..." -ForegroundColor Cyan
            } else {
                Write-Host "    LOCAL EXTRA: ...$($LocalText.Substring($minLen, [Math]::Min(100, $LocalText.Length - $minLen)))..." -ForegroundColor Magenta
            }
        }

        return "DIFFER"
    }
}

# Define all pages to compare
$pages = @(
    @{ Name = "index";               ProdPath = "en/index.html";               LocalPath = "en/index.html" },
    @{ Name = "About";               ProdPath = "en/About";                    LocalPath = "en/About.html" },
    @{ Name = "Tasks";               ProdPath = "en/Tasks";                    LocalPath = "en/Tasks.html" },
    @{ Name = "Dashboard";           ProdPath = "en/Dashboard";                LocalPath = "en/Dashboard.html" },
    @{ Name = "Login";               ProdPath = "en/Login";                    LocalPath = "en/Login.html" },
    @{ Name = "Pricing";             ProdPath = "en/Pricing";                  LocalPath = "en/Pricing.html" },
    @{ Name = "HowItWorks";          ProdPath = "en/HowItWorks";              LocalPath = "en/HowItWorks.html" },
    @{ Name = "Download";            ProdPath = "en/Download";                LocalPath = "en/Download.html" },
    @{ Name = "Leaderboard";         ProdPath = "en/Leaderboard";             LocalPath = "en/Leaderboard.html" },
    @{ Name = "Sprints";             ProdPath = "en/Sprints";                 LocalPath = "en/Sprints.html" },
    @{ Name = "Boards";              ProdPath = "en/Boards";                  LocalPath = "en/Boards.html" },
    @{ Name = "Settings";            ProdPath = "en/Settings";                LocalPath = "en/Settings.html" },
    @{ Name = "Legal/Terms";         ProdPath = "en/Legal/Terms";             LocalPath = "en/Legal/Terms.html" },
    @{ Name = "Legal/Privacy";       ProdPath = "en/Legal/Privacy";           LocalPath = "en/Legal/Privacy.html" },
    @{ Name = "Legal/Refund";        ProdPath = "en/Legal/Refund";            LocalPath = "en/Legal/Refund.html" },
    @{ Name = "Legal/AcceptableUse"; ProdPath = "en/Legal/AcceptableUse";     LocalPath = "en/Legal/AcceptableUse.html" },
    @{ Name = "Legal/CookiePolicy";  ProdPath = "en/Legal/CookiePolicy";     LocalPath = "en/Legal/CookiePolicy.html" },
    @{ Name = "Legal/Licenses";      ProdPath = "en/Legal/Licenses";         LocalPath = "en/Legal/Licenses.html" },
    @{ Name = "Legal/Accessibility"; ProdPath = "en/Legal/Accessibility";    LocalPath = "en/Legal/Accessibility.html" },
    @{ Name = "Legal/Dmca";          ProdPath = "en/Legal/Dmca";             LocalPath = "en/Legal/Dmca.html" },
    @{ Name = "Client/CreateTask";   ProdPath = "en/Client/CreateTask";      LocalPath = "en/Client/CreateTask.html" },
    @{ Name = "Client/Payments";     ProdPath = "en/Client/Payments";        LocalPath = "en/Client/Payments.html" },
    @{ Name = "Client/Repository";   ProdPath = "en/Client/Repository";     LocalPath = "en/Client/Repository.html" }
)

$prodBase = "https://prtask.com"
$localBase = "https://localhost:61553"

$results = @{}
$matchCount = 0
$differCount = 0
$errorCount = 0

Write-Host "=============================================" -ForegroundColor White
Write-Host "  PAGE TEXT COMPARISON: PROD vs LOCALHOST" -ForegroundColor White
Write-Host "=============================================" -ForegroundColor White
Write-Host ""

foreach ($page in $pages) {
    Write-Host "[$($page.Name)]" -ForegroundColor White

    $prodText = Get-PageText $prodBase $page.ProdPath
    $localText = Get-PageText $localBase $page.LocalPath

    $result = Compare-PageText $prodText $localText $page.Name
    $results[$page.Name] = $result

    switch ($result) {
        "MATCH" { $matchCount++ }
        "DIFFER" { $differCount++ }
        default { $errorCount++ }
    }
    Write-Host ""
}

# Spot-check non-English locales
Write-Host "=============================================" -ForegroundColor White
Write-Host "  NON-ENGLISH LOCALE SPOT-CHECKS" -ForegroundColor White
Write-Host "=============================================" -ForegroundColor White
Write-Host ""

$localePages = @(
    @{ Name = "es/index";    ProdPath = "es/index.html";    LocalPath = "es/index.html" },
    @{ Name = "es/About";    ProdPath = "es/About";         LocalPath = "es/About.html" },
    @{ Name = "ja/index";    ProdPath = "ja/index.html";    LocalPath = "ja/index.html" },
    @{ Name = "ja/About";    ProdPath = "ja/About";         LocalPath = "ja/About.html" },
    @{ Name = "zh/index";    ProdPath = "zh/index.html";    LocalPath = "zh/index.html" },
    @{ Name = "zh/About";    ProdPath = "zh/About";         LocalPath = "zh/About.html" }
)

foreach ($page in $localePages) {
    Write-Host "[$($page.Name)]" -ForegroundColor White

    $prodText = Get-PageText $prodBase $page.ProdPath
    $localText = Get-PageText $localBase $page.LocalPath

    $result = Compare-PageText $prodText $localText $page.Name
    $results[$page.Name] = $result

    switch ($result) {
        "MATCH" { $matchCount++ }
        "DIFFER" { $differCount++ }
        default { $errorCount++ }
    }
    Write-Host ""
}

Write-Host "=============================================" -ForegroundColor White
Write-Host "  SUMMARY" -ForegroundColor White
Write-Host "=============================================" -ForegroundColor White
Write-Host "Total pages compared: $($matchCount + $differCount + $errorCount)"
Write-Host "Identical text:       $matchCount" -ForegroundColor Green
Write-Host "Different text:       $differCount" -ForegroundColor Yellow
Write-Host "Fetch errors:         $errorCount" -ForegroundColor Red
Write-Host ""

if ($differCount -gt 0) {
    Write-Host "Pages with differences:" -ForegroundColor Yellow
    foreach ($key in ($results.Keys | Sort-Object)) {
        if ($results[$key] -eq "DIFFER") {
            Write-Host "  - $key" -ForegroundColor Yellow
        }
    }
}
if ($errorCount -gt 0) {
    Write-Host "Pages with errors:" -ForegroundColor Red
    foreach ($key in ($results.Keys | Sort-Object)) {
        if ($results[$key] -match "ERROR") {
            Write-Host "  - $key" -ForegroundColor Red
        }
    }
}
