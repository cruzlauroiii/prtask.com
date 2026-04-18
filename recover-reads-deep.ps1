# Deep recovery pass 2: Extract Read tool results more carefully
# and scan temp task output files

$ErrorActionPreference = 'SilentlyContinue'
$targetRoot = "C:\work\prtask.com"

$newFiles = [System.Collections.Generic.List[string]]::new()
$updatedFiles = [System.Collections.Generic.List[string]]::new()
$identicalFiles = [System.Collections.Generic.List[string]]::new()
$recovered = @{}
$totalScanned = 0

function StripLineNumbers($content) {
    $lines = $content -split "`n"
    $stripped = foreach ($line in $lines) {
        if ($line -match '^\s+\d+\t(.*)$') {
            $matches[1]
        } elseif ($line -match '^\s+\d+  (.*)$') {
            # Some outputs use spaces instead of tab
            $matches[1]
        } else {
            $line
        }
    }
    return ($stripped -join "`n").TrimEnd()
}

# Scan ALL jsonl files in the main prtask project directory
$scanDir = "C:\Users\user\.claude\projects\C--work-prtask-com"
$jsonlFiles = Get-ChildItem $scanDir -Recurse -Filter "*.jsonl" -ErrorAction SilentlyContinue | Sort-Object LastWriteTime -Descending

Write-Host "=== DEEP READ RECOVERY PASS ===" -ForegroundColor Cyan
Write-Host "Scanning $($jsonlFiles.Count) JSONL files..." -ForegroundColor Yellow

$fileNum = 0
foreach ($jsonlFile in $jsonlFiles) {
    $fileNum++
    $totalScanned++
    if ($jsonlFile.Length -lt 200) { continue }

    if ($fileNum % 100 -eq 0) {
        Write-Host "  Progress: $fileNum / $($jsonlFiles.Count), recovered: $($recovered.Count)..." -ForegroundColor DarkGray
    }

    try {
        $rawContent = [System.IO.File]::ReadAllText($jsonlFile.FullName)
    } catch { continue }

    if ($rawContent -notmatch 'prtask') { continue }

    # Split into JSON objects
    $jsonLines = $rawContent -split "`n"

    # Build a list of parsed objects with their line index
    $pendingReads = @{}  # tool_use_id -> relPath

    foreach ($jsonLine in $jsonLines) {
        $jsonLine = $jsonLine.Trim()
        if ($jsonLine.Length -lt 30) { continue }

        try {
            $obj = $jsonLine | ConvertFrom-Json -ErrorAction Stop
        } catch { continue }

        # Track Read tool_use calls
        if ($obj.type -eq 'tool_use' -and $obj.name -eq 'Read' -and $obj.input.file_path -match 'prtask\.com') {
            $fp = $obj.input.file_path
            if ($fp -match 'prtask\.com[/\\](.+)$') {
                $relPath = $matches[1].Replace('/', '\')
                # Skip binary/build output
                if ($relPath -match '\.(dll|exe|pdb|wasm|png|jpg|gif|ico|br|gz|dat|bin|nupkg|lock|trx|log)$') { continue }
                if ($relPath -match '(publish-output|deploy|output|node_modules|\.git|bin[/\\]|obj[/\\])[/\\]?') { continue }
                if ($relPath -match '^(publish|deploy|output|build|recovery-wasm)[/\\]') { continue }

                $pendingReads[$obj.id] = $relPath
            }
        }

        # Match tool_result to pending Reads
        if ($obj.type -eq 'tool_result' -and $pendingReads.ContainsKey($obj.tool_use_id)) {
            $relPath = $pendingReads[$obj.tool_use_id]
            $pendingReads.Remove($obj.tool_use_id)

            $resultText = $null
            if ($obj.content -is [string]) {
                $resultText = $obj.content
            } elseif ($obj.content -is [array]) {
                foreach ($c in $obj.content) {
                    if ($c.type -eq 'text') { $resultText = $c.text; break }
                }
            }

            if (-not $resultText -or $resultText.Length -lt 20) { continue }
            if ($resultText -match 'Error|error reading|file not found|does not exist') { continue }

            # Check if it has line number format
            if ($resultText -match '^\s+\d+\t') {
                $stripped = StripLineNumbers $resultText
                if ($stripped.Length -gt 10) {
                    # Check if this is a partial read (offset/limit)
                    $isPartial = $false
                    if ($obj.input) {
                        # Can't access input from tool_result, check previous
                    }

                    # Only store if larger than what we have
                    if (-not $recovered.ContainsKey($relPath) -or $stripped.Length -gt $recovered[$relPath].Size) {
                        $recovered[$relPath] = @{
                            Content = $stripped
                            Source = "Read:$($jsonlFile.Name)"
                            Size = $stripped.Length
                        }
                    }
                }
            }
        }
    }
}

# Also scan C--Users-user for Read results
$scanDir2 = "C:\Users\user\.claude\projects\C--Users-user"
$jsonlFiles2 = Get-ChildItem $scanDir2 -Recurse -Filter "*.jsonl" -ErrorAction SilentlyContinue
Write-Host "`nScanning C--Users-user: $($jsonlFiles2.Count) files..." -ForegroundColor Yellow

foreach ($jsonlFile in $jsonlFiles2) {
    $totalScanned++
    if ($jsonlFile.Length -lt 200) { continue }
    try { $rawContent = [System.IO.File]::ReadAllText($jsonlFile.FullName) } catch { continue }
    if ($rawContent -notmatch 'prtask') { continue }

    $jsonLines = $rawContent -split "`n"
    $pendingReads = @{}

    foreach ($jsonLine in $jsonLines) {
        $jsonLine = $jsonLine.Trim()
        if ($jsonLine.Length -lt 30) { continue }
        try { $obj = $jsonLine | ConvertFrom-Json -ErrorAction Stop } catch { continue }

        if ($obj.type -eq 'tool_use' -and $obj.name -eq 'Read' -and $obj.input.file_path -match 'prtask\.com') {
            $fp = $obj.input.file_path
            if ($fp -match 'prtask\.com[/\\](.+)$') {
                $relPath = $matches[1].Replace('/', '\')
                if ($relPath -match '\.(dll|exe|pdb|wasm|png|jpg|gif|ico|br|gz|dat|bin|nupkg|lock|trx|log)$') { continue }
                if ($relPath -match '(publish-output|deploy|output|node_modules|\.git|bin[/\\]|obj[/\\])') { continue }
                $pendingReads[$obj.id] = $relPath
            }
        }

        if ($obj.type -eq 'tool_result' -and $pendingReads.ContainsKey($obj.tool_use_id)) {
            $relPath = $pendingReads[$obj.tool_use_id]
            $pendingReads.Remove($obj.tool_use_id)

            $resultText = $null
            if ($obj.content -is [string]) { $resultText = $obj.content }
            elseif ($obj.content -is [array]) { foreach ($c in $obj.content) { if ($c.type -eq 'text') { $resultText = $c.text; break } } }

            if (-not $resultText -or $resultText.Length -lt 20) { continue }
            if ($resultText -match '^\s+\d+\t') {
                $stripped = StripLineNumbers $resultText
                if ($stripped.Length -gt 10 -and (-not $recovered.ContainsKey($relPath) -or $stripped.Length -gt $recovered[$relPath].Size)) {
                    $recovered[$relPath] = @{ Content = $stripped; Source = "Read:$($jsonlFile.Name)"; Size = $stripped.Length }
                }
            }
        }
    }
}

Write-Host "`nTotal Read-recovered files: $($recovered.Count)" -ForegroundColor Yellow

# === Check temp task output files ===
Write-Host "`n=== SCANNING TEMP TASK OUTPUT FILES ===" -ForegroundColor Cyan
$tempDir = "C:\Users\user\AppData\Local\Temp\claude\C--work-prtask-com"
if (Test-Path $tempDir) {
    $taskFiles = Get-ChildItem $tempDir -Recurse -File -ErrorAction SilentlyContinue
    Write-Host "  Found $($taskFiles.Count) task output files"
    foreach ($tf in $taskFiles) {
        if ($tf.Length -lt 100 -or $tf.Length -gt 10MB) { continue }
        try {
            $content = [System.IO.File]::ReadAllText($tf.FullName)
            # Look for file content patterns
            $writeMatches = [regex]::Matches($content, 'Write.*?file_path.*?prtask\.com[/\\]([^\s"'']+)')
            foreach ($m in $writeMatches) {
                Write-Host "    Task file $($tf.Name) references: $($m.Groups[1].Value)"
            }
        } catch {}
    }
}

# === WRITE RECOVERED FILES ===
Write-Host "`n=== WRITING READ-RECOVERED FILES ===" -ForegroundColor Cyan

foreach ($relPath in $recovered.Keys) {
    $entry = $recovered[$relPath]
    $targetPath = Join-Path $targetRoot $relPath
    $content = $entry.Content

    if ($relPath -match '(publish-output|deploy|output|node_modules|\.git)[/\\]') { continue }
    if ($relPath -match '^(publish|deploy|output|build)[/\\]') { continue }
    if ($content.Length -lt 15) { continue }

    if (Test-Path $targetPath) {
        $existing = [System.IO.File]::ReadAllText($targetPath)
        if ($existing -eq $content) {
            $identicalFiles.Add($relPath)
        } elseif ($content.Length -gt $existing.Length * 1.05) {
            # Read version is significantly larger - could be more complete
            # But be careful - don't overwrite newer Write-recovered content
            # Only update if existing file seems truncated
            $identicalFiles.Add($relPath)
        } else {
            $identicalFiles.Add($relPath)
        }
    } else {
        # New file!
        $newFiles.Add($relPath)
        $dir = Split-Path $targetPath -Parent
        if (-not (Test-Path $dir)) { New-Item -ItemType Directory -Path $dir -Force | Out-Null }
        try {
            [System.IO.File]::WriteAllText($targetPath, $content)
            Write-Host "  NEW: $relPath ($($content.Length) bytes)" -ForegroundColor Green
        } catch {
            Write-Host "  ERROR: $relPath : $_" -ForegroundColor Red
        }
    }
}

Write-Host "`n=== READ RECOVERY RESULTS ===" -ForegroundColor Cyan
Write-Host "  Total files scanned: $totalScanned"
Write-Host "  Files recovered from Read: $($recovered.Count)"
Write-Host "  New files written: $($newFiles.Count)"
Write-Host "  Identical (skipped): $($identicalFiles.Count)"

if ($newFiles.Count -gt 0) {
    Write-Host "`n  NEW FILES:" -ForegroundColor Green
    $newFiles | Sort-Object | ForEach-Object { Write-Host "    + $_" -ForegroundColor Green }
}
