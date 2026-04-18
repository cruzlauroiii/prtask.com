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
            # Resolve relative URL properly
            $baseUri = [System.Uri]::new($url)
            $resolvedUri = [System.Uri]::new($baseUri, $redirectUrl)
            $resp = Invoke-WebRequest -Uri $resolvedUri.AbsoluteUri -UseBasicParsing -SkipCertificateCheck -TimeoutSec 15
            $html = $resp.Content

            # Check for another meta refresh (double redirect)
            if ($html -match $pattern) {
                $redirectUrl2 = $Matches[1]
                $baseUri2 = [System.Uri]::new($resolvedUri)
                $resolvedUri2 = [System.Uri]::new($baseUri2, $redirectUrl2)
                $resp = Invoke-WebRequest -Uri $resolvedUri2.AbsoluteUri -UseBasicParsing -SkipCertificateCheck -TimeoutSec 15
                $html = $resp.Content
            }
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

$locales = @("en", "es", "ar", "de", "fr", "hi", "id", "it", "ja", "ko", "nl", "pt", "ru", "tr", "fil", "zh")

$pageNames = @(
    "index",
    "About",
    "Tasks",
    "Dashboard",
    "Login",
    "Pricing",
    "HowItWorks",
    "Download",
    "Leaderboard",
    "Sprints",
    "Boards",
    "Settings",
    "Legal/Terms",
    "Legal/Privacy",
    "Legal/Refund",
    "Legal/AcceptableUse",
    "Legal/CookiePolicy",
    "Legal/Licenses",
    "Legal/Accessibility",
    "Legal/Dmca",
    "Client/CreateTask",
    "Client/Payments",
    "Client/Repository"
)

$prodBase = "https://prtask.com"
$localBase = "https://localhost:61553"

$matchCount = 0
$differCount = 0
$prodErrorCount = 0
$localErrorCount = 0
$differList = @()
$prodErrorList = @()
$localErrorList = @()

$totalPages = $locales.Count * $pageNames.Count
$current = 0

Write-Host "================================================================" -ForegroundColor White
Write-Host "  FULL PAGE TEXT COMPARISON: PROD vs LOCALHOST" -ForegroundColor White
Write-Host "  $($locales.Count) locales x $($pageNames.Count) pages = $totalPages comparisons" -ForegroundColor White
Write-Host "================================================================" -ForegroundColor White
Write-Host ""

foreach ($locale in $locales) {
    Write-Host "--- LOCALE: $locale ---" -ForegroundColor Cyan

    foreach ($pageName in $pageNames) {
        $current++
        $key = "$locale/$pageName"

        # Build paths
        if ($pageName -eq "index") {
            $prodPath = "$locale/index.html"
            $localPath = "$locale/index.html"
        } else {
            $prodPath = "$locale/$pageName"
            $localPath = "$locale/$pageName.html"
        }

        $prodText = Get-PageText $prodBase $prodPath
        $localText = Get-PageText $localBase $localPath

        $isProdError = $prodText.StartsWith("ERROR:")
        $isLocalError = $localText.StartsWith("ERROR:")

        if ($isProdError) {
            $prodErrorCount++
            $prodErrorList += "$key : $prodText"
            Write-Host "  [$current/$totalPages] $key - PROD ERROR" -ForegroundColor Red
            continue
        }
        if ($isLocalError) {
            $localErrorCount++
            $localErrorList += "$key : $localText"
            Write-Host "  [$current/$totalPages] $key - LOCAL ERROR" -ForegroundColor Red
            continue
        }

        if ($prodText -eq $localText) {
            $matchCount++
            Write-Host "  [$current/$totalPages] $key - MATCH ($($prodText.Length) chars)" -ForegroundColor Green
        } else {
            $differCount++

            # Find first difference details
            $diffDetail = ""
            $minLen = [Math]::Min($prodText.Length, $localText.Length)
            $diffPos = -1
            for ($i = 0; $i -lt $minLen; $i++) {
                if ($prodText[$i] -ne $localText[$i]) {
                    $diffPos = $i
                    break
                }
            }
            if ($diffPos -eq -1) { $diffPos = $minLen }

            $start = [Math]::Max(0, $diffPos - 40)
            if ($diffPos -lt $prodText.Length) {
                $pSnip = $prodText.Substring($start, [Math]::Min(120, $prodText.Length - $start))
            } else {
                $pSnip = "(text ends here)"
            }
            if ($diffPos -lt $localText.Length) {
                $lSnip = $localText.Substring($start, [Math]::Min(120, $localText.Length - $start))
            } else {
                $lSnip = "(text ends here)"
            }

            $differList += @{
                Key = $key
                ProdLen = $prodText.Length
                LocalLen = $localText.Length
                DiffPos = $diffPos
                ProdSnippet = $pSnip
                LocalSnippet = $lSnip
            }

            Write-Host "  [$current/$totalPages] $key - DIFFER (prod=$($prodText.Length), local=$($localText.Length), firstDiff@$diffPos)" -ForegroundColor Yellow
        }
    }
    Write-Host ""
}

Write-Host ""
Write-Host "================================================================" -ForegroundColor White
Write-Host "  SUMMARY" -ForegroundColor White
Write-Host "================================================================" -ForegroundColor White
Write-Host "Total pages compared: $totalPages"
Write-Host "Identical text:       $matchCount" -ForegroundColor Green
Write-Host "Different text:       $differCount" -ForegroundColor Yellow
Write-Host "Prod fetch errors:    $prodErrorCount" -ForegroundColor Red
Write-Host "Local fetch errors:   $localErrorCount" -ForegroundColor Red
Write-Host ""

if ($differCount -gt 0) {
    Write-Host "================================================================" -ForegroundColor Yellow
    Write-Host "  DETAILED DIFFERENCES ($differCount pages)" -ForegroundColor Yellow
    Write-Host "================================================================" -ForegroundColor Yellow
    Write-Host ""

    foreach ($d in $differList) {
        Write-Host "[$($d.Key)] prod=$($d.ProdLen) chars, local=$($d.LocalLen) chars, diff@$($d.DiffPos)" -ForegroundColor Yellow
        Write-Host "  PROD:  ...$($d.ProdSnippet)..." -ForegroundColor Cyan
        Write-Host "  LOCAL: ...$($d.LocalSnippet)..." -ForegroundColor Magenta
        Write-Host ""
    }
}

if ($prodErrorCount -gt 0) {
    Write-Host "================================================================" -ForegroundColor Red
    Write-Host "  PROD FETCH ERRORS ($prodErrorCount)" -ForegroundColor Red
    Write-Host "================================================================" -ForegroundColor Red
    foreach ($e in $prodErrorList) {
        Write-Host "  $e" -ForegroundColor Red
    }
    Write-Host ""
}

if ($localErrorCount -gt 0) {
    Write-Host "================================================================" -ForegroundColor Red
    Write-Host "  LOCAL FETCH ERRORS ($localErrorCount)" -ForegroundColor Red
    Write-Host "================================================================" -ForegroundColor Red
    foreach ($e in $localErrorList) {
        Write-Host "  $e" -ForegroundColor Red
    }
    Write-Host ""
}
