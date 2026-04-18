# Final recovery pass - scan ALL remaining dirs with correct regex
$ErrorActionPreference = 'SilentlyContinue'
$targetRoot = "C:\work\prtask.com"

# The regex issue: [/\] doesn't work in PS. Use alternation instead.
$pathPattern = 'prtask\.com(?:/|\\)(.+)$'

function StripLineNumbers($content) {
    $lines = $content -split "`n"
    $stripped = foreach ($line in $lines) {
        $line = $line -replace "`r$", ""
        if ($line -match '^\s+\d+\t(.*)$') { $matches[1] } else { $line }
    }
    return ($stripped -join "`n").TrimEnd()
}

$scanDirs = @(
    "C:\Users\user\.claude\projects\C--Users-user",
    "C:\Users\user\.claude\projects\C--work",
    "C:\Users\user\.claude\projects\C--work-claudecode",
    "C:\Users\user\.claude\projects\C--work-hobbylandgroup",
    "C:\Users\user\.claude\projects\C--work-Scripts"
)

$recovered = @{}
$totalScanned = 0

foreach ($scanDir in $scanDirs) {
    if (-not (Test-Path $scanDir)) { continue }
    $jsonlFiles = Get-ChildItem $scanDir -Recurse -Filter "*.jsonl" -ErrorAction SilentlyContinue
    if (-not $jsonlFiles) { continue }

    Write-Host "Scanning: $scanDir ($($jsonlFiles.Count) files)"

    foreach ($f in $jsonlFiles) {
        $totalScanned++
        if ($f.Length -lt 200) { continue }
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
                if ($item.type -eq "tool_use" -and $item.name -eq "Write" -and $item.input) {
                    $fp = $item.input.file_path
                    $ct = $item.input.content
                    if ($fp -and $ct -and $fp -match $pathPattern) {
                        $relPath = $matches[1].Replace("/", "\")
                        if ($ct.Length -gt 10) {
                            if (-not $recovered.ContainsKey($relPath) -or $ct.Length -gt $recovered[$relPath].Size) {
                                $recovered[$relPath] = @{ Content = $ct; Size = $ct.Length; Source = "Write:$($f.Name)" }
                            }
                        }
                    }
                }

                if ($item.type -eq "tool_use" -and $item.name -eq "Read" -and $item.input) {
                    $fp = $item.input.file_path
                    if ($fp -and $fp -match $pathPattern) {
                        $relPath = $matches[1].Replace("/", "\")
                        $ext = [System.IO.Path]::GetExtension($relPath)
                        if ($ext -notmatch '^\.(dll|exe|pdb|wasm|png|jpg|gif|ico|br|gz|dat|bin)$') {
                            $pendingReads[$item.id] = $relPath
                        }
                    }
                }

                if ($item.type -eq "tool_result" -and $pendingReads.ContainsKey($item.tool_use_id)) {
                    $relPath = $pendingReads[$item.tool_use_id]
                    $pendingReads.Remove($item.tool_use_id)
                    $resultText = $null
                    if ($item.content -is [string]) { $resultText = $item.content }
                    elseif ($item.content -is [array]) {
                        foreach ($c in $item.content) { if ($c.type -eq "text") { $resultText = $c.text; break } }
                    }
                    if ($resultText -and $resultText.Length -gt 20 -and -not $item.is_error) {
                        $stripped = $resultText
                        if ($resultText -match '^\s+\d+\t') { $stripped = StripLineNumbers $resultText }
                        if ($stripped.Length -gt 10 -and (-not $recovered.ContainsKey($relPath) -or ($stripped.Length -gt $recovered[$relPath].Size -and $recovered[$relPath].Source -match '^Read'))) {
                            $recovered[$relPath] = @{ Content = $stripped; Size = $stripped.Length; Source = "Read:$($f.Name)" }
                        }
                    }
                }
            }
        }
    }
    Write-Host "  Recovered: $($recovered.Count)"
}

Write-Host "`nTotal scanned: $totalScanned"
Write-Host "Total recovered: $($recovered.Count)"

$newCount = 0
$newFiles = @()
foreach ($relPath in $recovered.Keys) {
    $entry = $recovered[$relPath]
    if ($relPath.Contains("publish-output") -or $relPath.Contains("node_modules") -or $relPath.Contains("recovery-wasm")) { continue }
    if ($relPath -match "\.(dll|exe|pdb|wasm|png|jpg|gif|ico|br|gz|dat|bin|lock)$") { continue }
    if ($entry.Content.Length -lt 15) { continue }

    $targetPath = Join-Path $targetRoot $relPath

    if (-not (Test-Path $targetPath)) {
        $dir = Split-Path $targetPath -Parent
        if (Test-Path $dir -PathType Container) {
            # dir exists
        } elseif (Test-Path $dir -PathType Leaf) {
            # Path component is a file, skip
            continue
        } else {
            New-Item -ItemType Directory -Path $dir -Force | Out-Null
        }
        try {
            [System.IO.File]::WriteAllText($targetPath, $entry.Content)
            $newFiles += $relPath
            $newCount++
        } catch {}
    }
}

Write-Host "`nNew files from other dirs: $newCount"
if ($newFiles.Count -gt 0) {
    $newFiles | Sort-Object | ForEach-Object { Write-Host "  + $_" -ForegroundColor Green }
}
