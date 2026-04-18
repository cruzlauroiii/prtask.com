# Full recovery v2 - Correct JSONL parsing:
# entries are {"message":{"content":[{"type":"tool_use",...},{"type":"tool_result",...}]}}

$ErrorActionPreference = 'SilentlyContinue'
$targetRoot = "C:\work\prtask.com"

$newFiles = [System.Collections.Generic.List[string]]::new()
$updatedFiles = [System.Collections.Generic.List[string]]::new()
$identicalFiles = [System.Collections.Generic.List[string]]::new()
$totalScanned = 0
$totalSizeMB = 0

# recovered: relPath -> {Content, Source, Size}
$recovered = @{}

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

$scanDirs = @(
    "C:\Users\user\.claude\projects\C--work-prtask-com"
    "C:\Users\user\.claude\projects\C--work-prtask-com-src"
    "C:\Users\user\.claude\projects\C--work-prtask-com-src-PrTask-Git"
    "C:\Users\user\.claude\projects\C--Users-user"
    "C:\Users\user\.claude\projects\C--work"
    "C:\Users\user\.claude\projects\C--work-claudecode"
    "C:\Users\user\.claude\projects\C--work-hobbylandgroup"
    "C:\Users\user\.claude\projects\C--work-Scripts"
)

Write-Host "=== FULL RECOVERY v2 (correct JSONL parsing) ===" -ForegroundColor Cyan

foreach ($scanDir in $scanDirs) {
    if (-not (Test-Path $scanDir)) { continue }
    $jsonlFiles = Get-ChildItem $scanDir -Recurse -Filter "*.jsonl" -ErrorAction SilentlyContinue
    if (-not $jsonlFiles) { continue }

    $dirSize = ($jsonlFiles | Measure-Object Length -Sum).Sum
    $totalSizeMB += [Math]::Round($dirSize/1MB, 1)
    Write-Host "`nScanning: $scanDir" -ForegroundColor Green
    Write-Host "  Files: $($jsonlFiles.Count), Size: $([Math]::Round($dirSize/1MB,1))MB"

    $fileNum = 0
    foreach ($jsonlFile in $jsonlFiles) {
        $totalScanned++
        $fileNum++
        if ($jsonlFile.Length -lt 200) { continue }

        if ($fileNum % 100 -eq 0) {
            Write-Host "  Progress: $fileNum/$($jsonlFiles.Count), recovered: $($recovered.Count)" -ForegroundColor DarkGray
        }

        try {
            $rawContent = [System.IO.File]::ReadAllText($jsonlFile.FullName)
        } catch { continue }

        if ($rawContent -notmatch "prtask") { continue }

        $jsonLines = $rawContent -split "`n"

        # Track tool_use IDs to file paths across all lines in this file
        $toolIdToPath = @{}

        foreach ($jsonLine in $jsonLines) {
            $jsonLine = $jsonLine.Trim()
            if ($jsonLine.Length -lt 50) { continue }

            try {
                $entry = $jsonLine | ConvertFrom-Json -ErrorAction Stop
            } catch { continue }

            # The actual message content is in $entry.message.content[]
            $msgContent = $null
            if ($entry.message -and $entry.message.content) {
                $msgContent = $entry.message.content
            } elseif ($entry.content) {
                $msgContent = $entry.content
            }

            if (-not $msgContent) { continue }

            foreach ($item in $msgContent) {
                # === WRITE TOOL CALLS ===
                if ($item.type -eq "tool_use" -and $item.name -eq "Write" -and $item.input) {
                    $fp = $item.input.file_path
                    $ct = $item.input.content
                    if ($fp -and $ct -and $fp -match "prtask\.com") {
                        if ($fp -match "prtask\.com[/\\](.+)$") {
                            $relPath = $matches[1].Replace("/", "\")
                            if ($ct.Length -gt 10) {
                                # Always take the latest Write (last one wins)
                                $recovered[$relPath] = @{
                                    Content = $ct
                                    Source = "Write:$($jsonlFile.Name)"
                                    Size = $ct.Length
                                }
                            }
                        }
                    }
                }

                # === READ TOOL CALLS - track the ID ===
                if ($item.type -eq "tool_use" -and $item.name -eq "Read" -and $item.input) {
                    $fp = $item.input.file_path
                    if ($fp -and $fp -match "prtask\.com") {
                        if ($fp -match "prtask\.com[/\\](.+)$") {
                            $relPath = $matches[1].Replace("/", "\")
                            # Skip binary/build output
                            if ($relPath -notmatch "\.(dll|exe|pdb|wasm|png|jpg|gif|ico|br|gz|dat|bin|nupkg|lock|trx|log)$" -and
                                $relPath -notmatch "(publish-output|deploy[/\\]|output[/\\]|node_modules|\.git[/\\]|bin[/\\]|obj[/\\])") {
                                $toolIdToPath[$item.id] = $relPath
                            }
                        }
                    }
                }

                # === TOOL RESULTS - match to Read calls ===
                if ($item.type -eq "tool_result" -and $item.tool_use_id) {
                    if ($toolIdToPath.ContainsKey($item.tool_use_id)) {
                        $relPath = $toolIdToPath[$item.tool_use_id]
                        $toolIdToPath.Remove($item.tool_use_id)

                        $resultText = $null
                        if ($item.content -is [string]) {
                            $resultText = $item.content
                        } elseif ($item.content -is [array]) {
                            foreach ($c in $item.content) {
                                if ($c.type -eq "text") { $resultText = $c.text; break }
                            }
                        }

                        if ($resultText -and $resultText.Length -gt 20) {
                            # Check for error responses
                            if ($resultText -match "^Error|does not exist|not found|Permission denied") { continue }

                            # Strip line numbers if present
                            $stripped = $resultText
                            if ($resultText -match "^\s+\d+\t") {
                                $stripped = StripLineNumbers $resultText
                            }

                            if ($stripped.Length -gt 10) {
                                # Only store if we don't already have a Write version or if Read is larger
                                if (-not $recovered.ContainsKey($relPath)) {
                                    $recovered[$relPath] = @{
                                        Content = $stripped
                                        Source = "Read:$($jsonlFile.Name)"
                                        Size = $stripped.Length
                                    }
                                } elseif ($recovered[$relPath].Source -match "^Read" -and $stripped.Length -gt $recovered[$relPath].Size) {
                                    $recovered[$relPath] = @{
                                        Content = $stripped
                                        Source = "Read:$($jsonlFile.Name)"
                                        Size = $stripped.Length
                                    }
                                }
                                # Don't overwrite Write-recovered content with Read content
                            }
                        }
                    }
                }

                # === EDIT TOOL CALLS ===
                if ($item.type -eq "tool_use" -and $item.name -eq "Edit" -and $item.input) {
                    $fp = $item.input.file_path
                    if ($fp -and $fp -match "prtask\.com") {
                        if ($fp -match "prtask\.com[/\\](.+)$") {
                            $relPath = $matches[1].Replace("/", "\")
                            # We can't fully reconstruct from edits alone
                            # But if the file doesn't exist and we have old_string + new_string, note it
                        }
                    }
                }
            }
        }
    }

    Write-Host "  Recovered so far: $($recovered.Count) files" -ForegroundColor Yellow
}

# === WRITE RECOVERED FILES ===
Write-Host "`n=== WRITING RECOVERED FILES ===" -ForegroundColor Cyan

$writeCount = @{ Read = 0; Write = 0 }
$sourceBreakdown = @{}

foreach ($relPath in $recovered.Keys) {
    $entry = $recovered[$relPath]
    $targetPath = Join-Path $targetRoot $relPath
    $content = $entry.Content
    $source = $entry.Source.Split(":")[0]

    # Track source breakdown
    if (-not $sourceBreakdown.ContainsKey($source)) { $sourceBreakdown[$source] = 0 }
    $sourceBreakdown[$source]++

    # Skip non-source paths
    if ($relPath -match "(publish-output|deploy[/\\]|output[/\\]|node_modules|\.git[/\\]|bin[/\\]|obj[/\\])") { continue }
    if ($relPath -match "^(publish|deploy|output|build|recovery-wasm)[/\\]") { continue }
    if ($relPath -match "\.(dll|exe|pdb|wasm|png|jpg|gif|ico|br|gz|dat|bin|nupkg|lock)$") { continue }
    if ($content.Length -lt 15) { continue }

    if (Test-Path $targetPath) {
        try {
            $existing = [System.IO.File]::ReadAllText($targetPath)
            # Normalize line endings for comparison
            $existNorm = $existing -replace "`r`n", "`n"
            $contentNorm = $content -replace "`r`n", "`n"

            if ($existNorm -eq $contentNorm) {
                $identicalFiles.Add($relPath)
                continue
            }

            # Different content
            if ($content.Length -gt $existing.Length * 1.05) {
                # Recovered version is significantly larger
                $updatedFiles.Add("$relPath (${source}, $($existing.Length)->$($content.Length) bytes)")
                $dir = Split-Path $targetPath -Parent
                if (-not (Test-Path $dir)) { New-Item -ItemType Directory -Path $dir -Force | Out-Null }
                [System.IO.File]::WriteAllText($targetPath, $content)
            } else {
                $identicalFiles.Add($relPath)
            }
        } catch {
            Write-Host "  ERROR: $relPath - $_" -ForegroundColor Red
        }
    } else {
        # New file!
        $newFiles.Add("$relPath (${source}, $($content.Length) bytes)")
        $dir = Split-Path $targetPath -Parent
        if (-not (Test-Path $dir)) { New-Item -ItemType Directory -Path $dir -Force | Out-Null }
        try {
            [System.IO.File]::WriteAllText($targetPath, $content)
        } catch {
            Write-Host "  ERROR writing: $relPath - $_" -ForegroundColor Red
        }
    }
}

# === REPORT ===
Write-Host "`n========================================" -ForegroundColor Cyan
Write-Host "  FULL C: DRIVE RECOVERY v2 REPORT" -ForegroundColor Cyan
Write-Host "========================================" -ForegroundColor Cyan
Write-Host ""
Write-Host "SCAN STATISTICS:" -ForegroundColor Yellow
Write-Host "  Total JSONL files scanned: $totalScanned"
Write-Host "  Total MB scanned: $totalSizeMB"
Write-Host "  Total unique files recovered: $($recovered.Count)"
Write-Host ""
Write-Host "SOURCE BREAKDOWN:" -ForegroundColor Yellow
foreach ($k in $sourceBreakdown.Keys) {
    Write-Host "  $k : $($sourceBreakdown[$k]) files"
}
Write-Host ""
Write-Host "RESULTS:" -ForegroundColor Yellow
Write-Host "  New files written: $($newFiles.Count)" -ForegroundColor Green
Write-Host "  Updated files: $($updatedFiles.Count)" -ForegroundColor Blue
Write-Host "  Identical (skipped): $($identicalFiles.Count)" -ForegroundColor DarkGray
Write-Host ""

if ($newFiles.Count -gt 0) {
    Write-Host "NEW FILES:" -ForegroundColor Green
    $newFiles | Sort-Object | ForEach-Object { Write-Host "  + $_" -ForegroundColor Green }
}

if ($updatedFiles.Count -gt 0) {
    Write-Host "`nUPDATED FILES:" -ForegroundColor Blue
    $updatedFiles | Sort-Object | ForEach-Object { Write-Host "  ~ $_" -ForegroundColor Blue }
}

# Save report
$report = @"
FULL C: DRIVE RECOVERY v2
Date: $(Get-Date -Format 'yyyy-MM-dd HH:mm:ss')
JSONL scanned: $totalScanned
MB scanned: $totalSizeMB
Unique recovered: $($recovered.Count)
New: $($newFiles.Count)
Updated: $($updatedFiles.Count)
Identical: $($identicalFiles.Count)

NEW FILES:
$($newFiles | Sort-Object | ForEach-Object { "  + $_" } | Out-String)
UPDATED:
$($updatedFiles | Sort-Object | ForEach-Object { "  ~ $_" } | Out-String)
"@
$report | Out-File "C:\work\prtask.com\recovery-full-cdrive-v2-report.txt" -Encoding UTF8
