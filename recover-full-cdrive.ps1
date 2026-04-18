# Full C: drive recovery of prtask.com source code from ALL Claude conversation logs
# Scans ALL project directories for Write, Read, and Edit tool calls

$ErrorActionPreference = 'SilentlyContinue'
$targetRoot = "C:\work\prtask.com"
$logFile = "C:\work\prtask.com\recovery-full-cdrive-report.txt"

# Stats
$totalScanned = 0
$totalSizeMB = 0
$newFiles = [System.Collections.Generic.List[string]]::new()
$updatedFiles = [System.Collections.Generic.List[string]]::new()
$identicalFiles = [System.Collections.Generic.List[string]]::new()
$errorFiles = [System.Collections.Generic.List[string]]::new()

# Track recovered content: path -> {content, source, timestamp}
$recovered = @{}

# All project directories to scan (those with prtask refs + prtask dirs themselves)
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

function NormalizePath($p) {
    # Normalize various path formats to Windows-style relative path under prtask.com
    $p = $p -replace '\\\\', '\'
    $p = $p -replace '/', '\'

    # Extract relative path from various prefixes
    $patterns = @(
        'C:\\work\\prtask\.com\\',
        'C:\\work\\prtask.com\\',
        '/c/work/prtask.com/',
        'c:\\work\\prtask\.com\\',
        'c:\\work\\prtask.com\\'
    )
    foreach ($pat in $patterns) {
        if ($p -match $pat) {
            $p = $p -replace [regex]::Escape(($p -replace "(?i)$pat.*", ($p.Substring(0, ($p -replace "(?i)$pat").Length + ($pat -replace '\\\\','\').Length))).Substring(0,0)), ''
            # simpler approach
            $idx = $p.ToLower().IndexOf('prtask.com\')
            if ($idx -ge 0) {
                $p = $p.Substring($idx + 'prtask.com\'.Length)
            }
            $idx = $p.ToLower().IndexOf('prtask.com/')
            if ($idx -ge 0) {
                $p = $p.Substring($idx + 'prtask.com/'.Length)
            }
            break
        }
    }

    # If path still has C:\work\prtask.com prefix
    $lower = $p.ToLower()
    foreach ($prefix in @('c:\work\prtask.com\', 'c:/work/prtask.com/', '/c/work/prtask.com/')) {
        if ($lower.StartsWith($prefix)) {
            $p = $p.Substring($prefix.Length)
            break
        }
    }

    return $p.Replace('/', '\')
}

function ExtractPrtaskPath($text) {
    # Extract prtask.com file path from text
    if ($text -match '(?i)(?:C:[/\\]+work[/\\]+prtask\.com[/\\]+|/c/work/prtask\.com/)([^\s"'']+)') {
        return $matches[1].Replace('/', '\')
    }
    return $null
}

function StripLineNumbers($content) {
    # Strip "   123\t" style line number prefixes from Read tool output
    $lines = $content -split "`n"
    $stripped = foreach ($line in $lines) {
        if ($line -match '^\s+\d+\t(.*)$') {
            $matches[1]
        } else {
            $line
        }
    }
    return ($stripped -join "`n").TrimEnd()
}

Write-Host "=== FULL C: DRIVE PRTASK.COM RECOVERY ===" -ForegroundColor Cyan
Write-Host "Scanning $(($scanDirs).Count) project directories..." -ForegroundColor Yellow

foreach ($scanDir in $scanDirs) {
    if (-not (Test-Path $scanDir)) {
        Write-Host "  SKIP (not found): $scanDir" -ForegroundColor DarkGray
        continue
    }

    $jsonlFiles = Get-ChildItem $scanDir -Recurse -Filter "*.jsonl" -ErrorAction SilentlyContinue
    if (-not $jsonlFiles) { continue }

    $dirSize = ($jsonlFiles | Measure-Object Length -Sum).Sum
    Write-Host "`nScanning: $scanDir" -ForegroundColor Green
    Write-Host "  Files: $($jsonlFiles.Count), Size: $([Math]::Round($dirSize/1MB,1))MB"

    $totalSizeMB += [Math]::Round($dirSize/1MB, 1)
    $fileNum = 0

    foreach ($jsonlFile in $jsonlFiles) {
        $totalScanned++
        $fileNum++

        if ($jsonlFile.Length -lt 100) { continue }

        # Quick check if file mentions prtask
        try {
            $rawContent = [System.IO.File]::ReadAllText($jsonlFile.FullName)
        } catch {
            continue
        }

        if ($rawContent -notmatch 'prtask') { continue }

        if ($fileNum % 50 -eq 0) {
            Write-Host "  Progress: $fileNum / $($jsonlFiles.Count)..." -ForegroundColor DarkGray
        }

        # Parse each line as JSON
        $lines = $rawContent -split "`n"
        foreach ($line in $lines) {
            $line = $line.Trim()
            if ($line.Length -lt 50) { continue }
            if ($line -notmatch 'prtask') { continue }

            try {
                $obj = $line | ConvertFrom-Json -ErrorAction Stop
            } catch {
                continue
            }

            # === WRITE TOOL CALLS ===
            # Look for Write tool calls with prtask file paths
            if ($obj.type -eq 'tool_use' -or $obj.type -eq 'assistant') {
                $jsonStr = $line

                # Pattern: "name":"Write" ... "file_path":"...prtask..." ... "content":"..."
                $writeMatches = [regex]::Matches($jsonStr, '"name"\s*:\s*"Write"')
                if ($writeMatches.Count -gt 0) {
                    # Extract file_path and content from the tool call
                    $fpMatches = [regex]::Matches($jsonStr, '"file_path"\s*:\s*"((?:[^"\\]|\\.)*)prtask\.com(?:[^"\\]|\\.)*"')
                    foreach ($fpm in $fpMatches) {
                        $fullPath = $fpm.Value -replace '"file_path"\s*:\s*"', '' -replace '"$', ''
                        $fullPath = $fullPath -replace '\\\\', '\' -replace '\\/', '/'

                        if ($fullPath -match 'prtask\.com[/\\](.+)$') {
                            $relPath = $matches[1].Replace('/', '\')

                            # Find the corresponding content
                            $contentStart = $jsonStr.IndexOf('"content"', $fpm.Index)
                            if ($contentStart -gt 0) {
                                # Extract content value - find the opening quote after "content":
                                $colonPos = $jsonStr.IndexOf(':', $contentStart + 8)
                                if ($colonPos -gt 0) {
                                    $quoteStart = $jsonStr.IndexOf('"', $colonPos)
                                    if ($quoteStart -gt 0) {
                                        # Find matching end quote (handle escapes)
                                        $pos = $quoteStart + 1
                                        $depth = 0
                                        while ($pos -lt $jsonStr.Length) {
                                            if ($jsonStr[$pos] -eq '\') { $pos += 2; continue }
                                            if ($jsonStr[$pos] -eq '"') { break }
                                            $pos++
                                        }
                                        if ($pos -lt $jsonStr.Length) {
                                            $rawVal = $jsonStr.Substring($quoteStart, $pos - $quoteStart + 1)
                                            try {
                                                $contentVal = ($rawVal | ConvertFrom-Json -ErrorAction Stop)
                                                if ($contentVal -and $contentVal.Length -gt 5) {
                                                    $recovered[$relPath] = @{
                                                        Content = $contentVal
                                                        Source = "Write:$($jsonlFile.Name)"
                                                        Size = $contentVal.Length
                                                    }
                                                }
                                            } catch {}
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            # === Also try parsing structured tool calls ===
            if ($obj.type -eq 'tool_use' -and $obj.name -eq 'Write') {
                $input = $obj.input
                if ($input -and $input.file_path -match 'prtask\.com') {
                    $fp = $input.file_path
                    $content = $input.content
                    if ($fp -match 'prtask\.com[/\\](.+)$' -and $content) {
                        $relPath = $matches[1].Replace('/', '\')
                        $recovered[$relPath] = @{
                            Content = $content
                            Source = "Write-Structured:$($jsonlFile.Name)"
                            Size = $content.Length
                        }
                    }
                }
            }

            # === EDIT TOOL CALLS ===
            if ($obj.type -eq 'tool_use' -and $obj.name -eq 'Edit') {
                $input = $obj.input
                if ($input -and $input.file_path -match 'prtask\.com') {
                    $fp = $input.file_path
                    if ($fp -match 'prtask\.com[/\\](.+)$') {
                        $relPath = $matches[1].Replace('/', '\')
                        # We can't fully reconstruct from edits alone, but we track them
                        # If we don't have a Write for this file, note the edit
                        if (-not $recovered.ContainsKey($relPath)) {
                            # Store edit info but mark as partial
                            # We'll handle edits separately
                        }
                    }
                }
            }

            # === TOOL RESULTS (Read outputs) ===
            if ($obj.type -eq 'tool_result' -or $obj.role -eq 'tool') {
                $resultText = $null
                if ($obj.content -is [string]) {
                    $resultText = $obj.content
                } elseif ($obj.content -is [array]) {
                    foreach ($c in $obj.content) {
                        if ($c.type -eq 'text' -and $c.text) {
                            $resultText = $c.text
                            break
                        }
                    }
                }

                if ($resultText -and $resultText.Length -gt 50 -and $resultText -match '^\s+1\t') {
                    # This looks like Read output with line numbers
                    # But we need the file path - check previous tool_use
                    # We'll handle this in the second pass
                }
            }
        }

        # Second pass: match tool_use Read calls with their results
        # Parse the JSONL more carefully for Read tool chains
        $parsedLines = @()
        foreach ($line in $lines) {
            $line = $line.Trim()
            if ($line.Length -lt 50 -or $line -notmatch 'prtask') { continue }
            try {
                $obj = $line | ConvertFrom-Json -ErrorAction Stop
                $parsedLines += $obj
            } catch { continue }
        }

        for ($i = 0; $i -lt $parsedLines.Count; $i++) {
            $obj = $parsedLines[$i]

            # Find Read tool_use calls
            if (($obj.type -eq 'tool_use' -and $obj.name -eq 'Read') -or
                ($obj.type -eq 'tool_use' -and $obj.name -eq 'read')) {
                $input = $obj.input
                if (-not $input) { continue }
                $fp = $input.file_path
                if (-not $fp -or $fp -notmatch 'prtask\.com') { continue }

                if ($fp -match 'prtask\.com[/\\](.+)$') {
                    $relPath = $matches[1].Replace('/', '\')

                    # Skip binary/non-source files
                    if ($relPath -match '\.(dll|exe|pdb|wasm|png|jpg|gif|ico|br|gz|dat|bin|nupkg)$') { continue }
                    if ($relPath -match '(publish-output|deploy|output|node_modules|\.git)[/\\]') { continue }
                    if ($relPath -match '^(publish|deploy|output)[/\\]') { continue }

                    # Already have this from Write (Write is more authoritative)
                    if ($recovered.ContainsKey($relPath) -and $recovered[$relPath].Source -match '^Write') { continue }

                    # Look for the tool_result in subsequent lines
                    $toolUseId = $obj.id
                    for ($j = $i + 1; $j -lt [Math]::Min($i + 5, $parsedLines.Count); $j++) {
                        $result = $parsedLines[$j]
                        if ($result.type -eq 'tool_result' -and $result.tool_use_id -eq $toolUseId) {
                            $resultText = $null
                            if ($result.content -is [string]) {
                                $resultText = $result.content
                            } elseif ($result.content -is [array]) {
                                foreach ($c in $result.content) {
                                    if ($c.type -eq 'text') { $resultText = $c.text; break }
                                }
                            }

                            if ($resultText -and $resultText.Length -gt 20) {
                                # Strip line numbers
                                $stripped = StripLineNumbers $resultText
                                if ($stripped.Length -gt 10) {
                                    # Only store if we don't have a Write version
                                    if (-not $recovered.ContainsKey($relPath) -or $recovered[$relPath].Source -match '^Read') {
                                        $recovered[$relPath] = @{
                                            Content = $stripped
                                            Source = "Read:$($jsonlFile.Name)"
                                            Size = $stripped.Length
                                        }
                                    }
                                }
                            }
                            break
                        }
                    }
                }
            }
        }
    }

    Write-Host "  Recovered so far: $($recovered.Count) files" -ForegroundColor Yellow
}

Write-Host "`n=== CHECKING TEMP TASK OUTPUT FILES ===" -ForegroundColor Cyan
$tempDir = "C:\Users\user\AppData\Local\Temp\claude\C--work-prtask-com"
if (Test-Path $tempDir) {
    $taskFiles = Get-ChildItem $tempDir -Recurse -File -ErrorAction SilentlyContinue
    Write-Host "  Found $($taskFiles.Count) task output files"
} else {
    Write-Host "  No temp directory found"
}

# === WRITE RECOVERED FILES ===
Write-Host "`n=== WRITING RECOVERED FILES ===" -ForegroundColor Cyan

foreach ($relPath in $recovered.Keys) {
    $entry = $recovered[$relPath]
    $targetPath = Join-Path $targetRoot $relPath
    $content = $entry.Content

    # Skip non-source paths
    if ($relPath -match '(publish-output|deploy|output|node_modules|\.git)[/\\]') { continue }
    if ($relPath -match '^(publish|deploy|output|build)[/\\]') { continue }
    if ($relPath -match '\.(dll|exe|pdb|wasm|png|jpg|gif|ico|br|gz|dat|bin|nupkg|lock)$') { continue }

    # Skip very small content (likely errors or empty reads)
    if ($content.Length -lt 15) { continue }

    if (Test-Path $targetPath) {
        # Compare with existing
        try {
            $existing = [System.IO.File]::ReadAllText($targetPath)
            if ($existing -eq $content) {
                $identicalFiles.Add($relPath)
                continue
            }

            # Different - only update if recovered is longer (more complete)
            if ($content.Length -gt $existing.Length * 1.1) {
                # Recovered version is significantly larger - might be more complete
                $updatedFiles.Add($relPath)
                $dir = Split-Path $targetPath -Parent
                if (-not (Test-Path $dir)) { New-Item -ItemType Directory -Path $dir -Force | Out-Null }
                [System.IO.File]::WriteAllText($targetPath, $content)
            } else {
                $identicalFiles.Add($relPath)
            }
        } catch {
            $errorFiles.Add("$relPath : $_")
        }
    } else {
        # New file!
        $newFiles.Add($relPath)
        $dir = Split-Path $targetPath -Parent
        if (-not (Test-Path $dir)) { New-Item -ItemType Directory -Path $dir -Force | Out-Null }
        try {
            [System.IO.File]::WriteAllText($targetPath, $content)
        } catch {
            $errorFiles.Add("$relPath : $_")
        }
    }
}

# === REPORT ===
$report = @"
====================================
FULL C: DRIVE RECOVERY REPORT
Date: $(Get-Date -Format 'yyyy-MM-dd HH:mm:ss')
====================================

SCAN STATISTICS:
  Total JSONL files scanned: $totalScanned
  Total MB scanned: $totalSizeMB
  Total unique files recovered: $($recovered.Count)

RESULTS:
  New files written: $($newFiles.Count)
  Updated files: $($updatedFiles.Count)
  Identical (skipped): $($identicalFiles.Count)
  Errors: $($errorFiles.Count)

NEW FILES:
$($newFiles | Sort-Object | ForEach-Object { "  + $_" } | Out-String)

UPDATED FILES:
$($updatedFiles | Sort-Object | ForEach-Object { "  ~ $_" } | Out-String)

ERRORS:
$($errorFiles | ForEach-Object { "  ! $_" } | Out-String)

SOURCE BREAKDOWN:
$($recovered.GetEnumerator() | Group-Object { $_.Value.Source.Split(':')[0] } | ForEach-Object { "  $($_.Name): $($_.Count) files" } | Out-String)
"@

Write-Host $report
$report | Out-File -FilePath $logFile -Encoding UTF8
Write-Host "`nReport saved to: $logFile" -ForegroundColor Green
