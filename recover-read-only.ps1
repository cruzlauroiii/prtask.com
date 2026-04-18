# Recover files that were only Read (never Written) and don't exist on disk
$ErrorActionPreference = 'SilentlyContinue'
$targetRoot = "C:\work\prtask.com"
$pattern = 'prtask\.com[/\\](.+)$'

# Target files to recover (from missing analysis)
$targetFiles = @(
    "src\PrTask.Domain\Models\PullRequest.cs",
    "src\PrTask.Domain\Models\TaskItem.cs",
    "src\PrTask.Domain\Models\DiffLine.cs",
    "src\PrTask.Domain\Models\WssMessage.cs",
    "src\PrTask.Domain\Constants\E2EConstants.cs",
    "src\PrTask.Domain\Constants\E2ETestConstants.cs",
    "src\PrTask.Domain\Entities\PaymentEntity.cs",
    "src\PrTask.Domain\Entities\UserEntity.cs",
    "src\PrTask.Domain\GlobalUsings.cs",
    "src\PrTask.Application\FormatStrings.cs",
    "src\PrTask.Application\Interfaces\IPaymentService.cs",
    "src\PrTask.Infrastructure\AppDbContext.cs",
    "src\PrTask.Infrastructure\DependencyInjection.cs",
    "src\PrTask.Infrastructure\Services\GoogleOAuthService.cs",
    "src\PrTask.Infrastructure\Services\Kyc\DiditKycService.cs",
    "src\PrTask.Client\Pages\Client\ClientEditTaskPage.razor",
    "src\PrTask.Client\Pages\ClientTermsPage.razor",
    "src\PrTask.Server\Components\App.razor",
    "src\PrTask.Server\DevLoginRequest.cs",
    "src\PrTask.Server\Properties\launchSettings.json",
    "src\PrTask.Server\wwwroot\index.html",
    "src\PrTask.SharedUI\App.razor",
    "src\PrTask.SharedUI\Components\_Imports.razor",
    "src\PrTask.SharedUI\css\app.css",
    "src\PrTask.SharedUI\Pages\AcceptableUsePage.razor",
    "src\PrTask.SharedUI\Pages\AccessibilityPage.razor",
    "src\PrTask.SharedUI\Pages\ClientPaymentsPage.razor",
    "src\PrTask.SharedUI\Pages\CookiePolicyPage.razor",
    "src\PrTask.SharedUI\Pages\CreateTaskPage.razor",
    "src\PrTask.SharedUI\Pages\HowItWorksPage.razor",
    "src\PrTask.SharedUI\Pages\PrivacyPage.razor",
    "src\PrTask.SharedUI\Pages\PullRequestsPage.razor",
    "src\PrTask.SharedUI\Pages\RepositoryPage.razor",
    "src\PrTask.SharedUI\Pages\TaskListPage.razor",
    "src\PrTask.SharedUI\Pages\TasksPage.razor",
    "src\PrTask.SharedUI\Pages\TermsPage.razor",
    "src\PrTask.SharedUI\Program.cs",
    "src\PrTask.SharedUI\Routes.razor",
    "src\PrTask.SharedUI\Shared\CookieConsent.razor",
    "src\PrTask.SharedUI\Shared\FooterSection.razor",
    "src\PrTask.SharedUI\Shared\NavMenu.razor",
    "src\PrTask.SharedUI\Shared\SiteFooter.razor",
    "src\PrTask.SharedUI\Styles\variables.scss",
    "src\PrTask.Maui\MauiApp.xaml",
    "src\PrTask.Maui\MauiApp.xaml.cs",
    "src\PrTask.Maui\PrTaskApp.xaml.cs",
    "tests\PrTask.E2E\appsettings.json",
    "tests\PrTask.E2E\RulesTests.T40.cs",
    "tests\PrTask.E2E\RulesTests.Task126to130.cs",
    "tests\PrTask.E2E\RulesTests.Task131to137.cs",
    "tests\PrTask.E2E\RulesTests.Task596to602.cs",
    "tests\PrTask.E2E\RulesTests.Task603to610.cs",
    "tests\PrTask.Tests\RulesTests.Task197to200.cs",
    "tests\PrTask.Tests\RulesTests.Task201to203.cs",
    "tests\PrTask.Tests\RulesTests.Task204to217.cs"
)

function StripLineNumbers($content) {
    $lines = $content -split "`n"
    $stripped = foreach ($line in $lines) {
        $line = $line -replace "`r$", ""
        if ($line -match '^\s+\d+\t(.*)$') {
            $matches[1]
        } else {
            $line
        }
    }
    return ($stripped -join "`n").TrimEnd()
}

$targetSet = @{}
foreach ($t in $targetFiles) { $targetSet[$t] = $true }

$recovered = @{}
$scanDir = "C:\Users\user\.claude\projects\C--work-prtask-com"
$jsonlFiles = Get-ChildItem $scanDir -Recurse -Filter "*.jsonl" -ErrorAction SilentlyContinue

Write-Host "=== RECOVERING READ-ONLY FILES ===" -ForegroundColor Cyan
Write-Host "Target: $($targetFiles.Count) files"
Write-Host "Scanning $($jsonlFiles.Count) JSONL files..."

$count = 0
foreach ($f in $jsonlFiles) {
    $count++
    if ($f.Length -lt 200) { continue }
    if ($count % 200 -eq 0) { Write-Host "  $count / $($jsonlFiles.Count)..." }

    try { $content = [System.IO.File]::ReadAllText($f.FullName) } catch { continue }
    if ($content -notmatch "prtask") { continue }

    $lines = $content -split "`n"
    $pendingReads = @{}

    foreach ($line in $lines) {
        $line = $line.Trim()
        if ($line.Length -lt 50) { continue }
        try { $entry = $line | ConvertFrom-Json -ErrorAction Stop } catch { continue }

        $msgContent = $null
        if ($entry.message -and $entry.message.content) { $msgContent = $entry.message.content }
        if (-not $msgContent) { continue }

        foreach ($item in $msgContent) {
            # Track Read tool calls for target files
            if ($item.type -eq "tool_use" -and $item.name -eq "Read" -and $item.input -and $item.input.file_path) {
                $fp = $item.input.file_path
                if ($fp -match $pattern) {
                    $relPath = $matches[1].Replace("/", "\")
                    if ($targetSet.ContainsKey($relPath)) {
                        $pendingReads[$item.id] = @{
                            Path = $relPath
                            Offset = $item.input.offset
                            Limit = $item.input.limit
                        }
                    }
                }
            }

            # Match tool_result
            if ($item.type -eq "tool_result" -and $item.tool_use_id -and $pendingReads.ContainsKey($item.tool_use_id)) {
                $readInfo = $pendingReads[$item.tool_use_id]
                $relPath = $readInfo.Path
                $pendingReads.Remove($item.tool_use_id)

                $resultText = $null
                if ($item.content -is [string]) { $resultText = $item.content }
                elseif ($item.content -is [array]) {
                    foreach ($c in $item.content) {
                        if ($c.type -eq "text") { $resultText = $c.text; break }
                    }
                }

                if (-not $resultText -or $resultText.Length -lt 10) { continue }
                if ($item.is_error -eq $true) { continue }
                if ($resultText -match "^Error|does not exist|not found") { continue }

                $stripped = $resultText
                if ($resultText -match '^\s+\d+\t') {
                    $stripped = StripLineNumbers $resultText
                }

                # Only non-partial reads (no offset) or largest version
                $isPartial = ($readInfo.Offset -and $readInfo.Offset -gt 0)

                if ($stripped.Length -gt 10) {
                    if (-not $recovered.ContainsKey($relPath) -or ($stripped.Length -gt $recovered[$relPath].Size -and -not $isPartial)) {
                        $recovered[$relPath] = @{
                            Content = $stripped
                            Size = $stripped.Length
                            Source = $f.Name
                        }
                    }
                }
            }
        }
    }
}

Write-Host "`nRecovered $($recovered.Count) of $($targetFiles.Count) target files"

# Write recovered files
$newCount = 0
foreach ($relPath in $recovered.Keys) {
    $entry = $recovered[$relPath]
    $targetPath = Join-Path $targetRoot $relPath

    if (Test-Path $targetPath) {
        $existing = [System.IO.File]::ReadAllText($targetPath)
        $existNorm = $existing -replace "`r`n", "`n"
        $contentNorm = $entry.Content -replace "`r`n", "`n"
        if ($existNorm -eq $contentNorm) {
            Write-Host "  IDENTICAL: $relPath" -ForegroundColor DarkGray
            continue
        }
        if ($entry.Content.Length -gt $existing.Length) {
            Write-Host "  UPDATED: $relPath ($($existing.Length) -> $($entry.Content.Length) bytes)" -ForegroundColor Blue
            [System.IO.File]::WriteAllText($targetPath, $entry.Content)
            $newCount++
        } else {
            Write-Host "  SKIP (existing larger): $relPath" -ForegroundColor DarkGray
        }
    } else {
        $dir = Split-Path $targetPath -Parent
        if (-not (Test-Path $dir)) { New-Item -ItemType Directory -Path $dir -Force | Out-Null }
        [System.IO.File]::WriteAllText($targetPath, $entry.Content)
        Write-Host "  NEW: $relPath ($($entry.Content.Length) bytes)" -ForegroundColor Green
        $newCount++
    }
}

Write-Host "`nTotal new/updated: $newCount"

# List what we couldn't find
$notFound = $targetFiles | Where-Object { -not $recovered.ContainsKey($_) }
Write-Host "`nNOT FOUND in any JSONL ($($notFound.Count)):" -ForegroundColor Yellow
$notFound | ForEach-Object { Write-Host "  ? $_" -ForegroundColor Yellow }
