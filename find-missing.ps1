# Find truly missing files
$ErrorActionPreference = 'SilentlyContinue'
$scanDir = "C:\Users\user\.claude\projects\C--work-prtask-com"
$jsonlFiles = Get-ChildItem $scanDir -Recurse -Filter "*.jsonl" -ErrorAction SilentlyContinue

$allWrittenPaths = @{}
$allReadPaths = @{}
$pattern = 'prtask\.com[/\\](.+)$'

$count = 0
foreach ($f in $jsonlFiles) {
    $count++
    if ($f.Length -lt 200) { continue }
    if ($count % 200 -eq 0) { Write-Host "  $count / $($jsonlFiles.Count)..." }
    try { $content = [System.IO.File]::ReadAllText($f.FullName) } catch { continue }
    if ($content -notmatch "prtask") { continue }

    $lines = $content -split "`n"
    foreach ($line in $lines) {
        $line = $line.Trim()
        if ($line.Length -lt 50) { continue }
        try { $entry = $line | ConvertFrom-Json -ErrorAction Stop } catch { continue }

        $msgContent = $null
        if ($entry.message -and $entry.message.content) { $msgContent = $entry.message.content }
        if (-not $msgContent) { continue }

        foreach ($item in $msgContent) {
            if ($item.type -eq "tool_use" -and $item.input -and $item.input.file_path) {
                $fp = $item.input.file_path
                if ($fp -match $pattern) {
                    $relPath = $matches[1].Replace("/", "\")
                    if ($item.name -eq "Write") { $allWrittenPaths[$relPath] = $true }
                    if ($item.name -eq "Read") { $allReadPaths[$relPath] = $true }
                }
            }
        }
    }
}

Write-Host "Total unique Write paths: $($allWrittenPaths.Count)"
Write-Host "Total unique Read paths: $($allReadPaths.Count)"

# Find source files that were Written but dont exist
$missingWritten = @()
foreach ($p in $allWrittenPaths.Keys) {
    if ($p.Contains("publish-output") -or $p.Contains("node_modules") -or $p.Contains("recovery-wasm")) { continue }
    $full = Join-Path "C:\work\prtask.com" $p
    if (-not (Test-Path $full)) { $missingWritten += $p }
}

$missingWritten = $missingWritten | Sort-Object
Write-Host "`nWritten but MISSING ($($missingWritten.Count)):"
$missingWritten | ForEach-Object { Write-Host "  $_" }

# Find source files that were Read but dont exist (and not Written)
$missingRead = @()
foreach ($p in $allReadPaths.Keys) {
    if ($p.Contains("publish-output") -or $p.Contains("node_modules") -or $p.Contains("recovery-wasm")) { continue }
    $ext = [System.IO.Path]::GetExtension($p)
    if ($ext -match '^\.(dll|exe|pdb|wasm|png|jpg|gif|ico|br|gz|trx|log)$') { continue }
    $full = Join-Path "C:\work\prtask.com" $p
    if (-not (Test-Path $full) -and -not $allWrittenPaths.ContainsKey($p)) { $missingRead += $p }
}

$srcMissingRead = $missingRead | Where-Object { $_.StartsWith("src\") -or $_.StartsWith("tests\") } | Sort-Object -Unique
Write-Host "`nRead (not Written) and MISSING src/tests ($($srcMissingRead.Count)):"
$srcMissingRead | ForEach-Object { Write-Host "  $_" }
