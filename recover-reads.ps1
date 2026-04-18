## recover-reads.ps1 — Focused recovery of Read tool results
## Fixes the ID matching issue and extracts from toolUseResult + tool_result

$ErrorActionPreference = 'Continue'
$logDir   = 'C:/Users/user/.claude/projects/C--work-prtask-com'
$outRoot  = 'C:/work/prtask.com'

$jsonlFiles = Get-ChildItem $logDir -Filter '*.jsonl' -Recurse |
              Sort-Object LastWriteTime |
              Select-Object -ExpandProperty FullName
Write-Host "Found $($jsonlFiles.Count) JSONL files"

$recovered = @{}
$seq = 0
$stats = @{ ToolUseResult=0; ToolResult=0; ReadIds=0 }

$skipPaths = @('publish-output/','publish/','deploy/','deploy-public/','output/','node_modules/','.vs/')
$skipExts = @('.png','.jpg','.jpeg','.gif','.ico','.woff','.woff2','.ttf','.eot','.dll','.exe','.pdb','.nupkg','.snk','.pfx','.p12','.wasm','.br','.gz','.zip','.tar','.7z')

function Get-Rel([string]$p) {
    $p = $p.Replace('\', '/')
    foreach ($pfx in @('C:/work/prtask.com/','c:/work/prtask.com/','/c/work/prtask.com/')) {
        if ($p.StartsWith($pfx, [System.StringComparison]::OrdinalIgnoreCase)) { return $p.Substring($pfx.Length) }
    }
    return $null
}

function Test-Skip([string]$rel) {
    foreach ($sp in $skipPaths) { if ($rel.StartsWith($sp)) { return $true } }
    $ext = [System.IO.Path]::GetExtension($rel).ToLower()
    return ($ext -in $skipExts)
}

function Read-JStr([string]$t, [int]$pos) {
    $sb = [System.Text.StringBuilder]::new(8192)
    $i = $pos; $len = $t.Length
    while ($i -lt $len) {
        $c = $t[$i]
        if ($c -eq '\') {
            $i++; if ($i -ge $len) { break }
            switch ($t[$i]) {
                'n'  { [void]$sb.Append("`n") }
                't'  { [void]$sb.Append("`t") }
                'r'  { [void]$sb.Append("`r") }
                '"'  { [void]$sb.Append('"') }
                '\'  { [void]$sb.Append('\') }
                '/'  { [void]$sb.Append('/') }
                'b'  { [void]$sb.Append("`b") }
                'f'  { [void]$sb.Append([char]12) }
                'u'  {
                    if ($i + 4 -lt $len) {
                        try { [void]$sb.Append([char][Convert]::ToInt32($t.Substring($i+1,4),16)) } catch {}
                        $i += 4
                    }
                }
                default { [void]$sb.Append('\'); [void]$sb.Append($t[$i]) }
            }
        }
        elseif ($c -eq '"') { return @{ Value=$sb.ToString(); End=$i+1 } }
        else { [void]$sb.Append($c) }
        $i++
    }
    return $null
}

function Get-KV([string]$t, [string]$key, [int]$from) {
    $needle = "`"$key`""
    $idx = $t.IndexOf($needle, $from)
    if ($idx -lt 0) { return $null }
    $ci = $t.IndexOf(':', $idx + $needle.Length)
    if ($ci -lt 0 -or $ci -gt $idx + $needle.Length + 5) { return $null }
    $qi = $t.IndexOf('"', $ci + 1)
    if ($qi -lt 0 -or $qi -gt $ci + 5) { return $null }
    return Read-JStr $t ($qi + 1)
}

function Strip-Nums([string]$text) {
    $lines = $text -split "`n"
    $sb = [System.Text.StringBuilder]::new($text.Length)
    $first = $true
    foreach ($ln in $lines) {
        $ai = $ln.IndexOf([char]0x2192)
        if ($ai -ge 0 -and $ln.Substring(0, $ai).Trim() -match '^\d+$') {
            if (-not $first) { [void]$sb.Append("`n") }
            [void]$sb.Append($ln.Substring($ai + 1))
            $first = $false
            continue
        }
        if ($ln -match '^\s*(\d+)\t(.*)$') {
            if (-not $first) { [void]$sb.Append("`n") }
            [void]$sb.Append($Matches[2])
            $first = $false
            continue
        }
        if (-not $first) { [void]$sb.Append("`n"); [void]$sb.Append($ln) }
    }
    return $sb.ToString()
}

# Track Read tool_use IDs: both "toolu_..." and "tool_use_id" values
# The structure is: {"type":"tool_use","id":"toolu_XXX","name":"Read","input":{"file_path":"..."}}
# On a SEPARATE line: {"type":"tool_result","tool_use_id":"toolu_XXX","content":"     1→..."}
$readIdMap = @{}  # toolu_XXX -> rel path

$fileNum = 0
foreach ($jf in $jsonlFiles) {
    $fileNum++
    $sizeMB = [math]::Round((Get-Item $jf).Length / 1MB, 1)
    if ($fileNum % 100 -eq 0 -or $sizeMB -gt 5) {
        Write-Host "[$fileNum/$($jsonlFiles.Count)] $([IO.Path]::GetFileName($jf)) ($sizeMB MB) | F:$($recovered.Count)"
    }

    $reader = [System.IO.StreamReader]::new($jf, [System.Text.Encoding]::UTF8)
    try {
        while ($null -ne ($line = $reader.ReadLine())) {
            if ($line.Length -lt 30) { continue }
            $hasPrtask = $line.Contains('prtask.com')

            # ═══ Track Read tool_use calls ═══
            # Look for: "type":"tool_use","id":"toolu_XXX","name":"Read","input":{"file_path":"C:\work\prtask.com\..."}
            if ($line.Contains('"Read"') -and $hasPrtask -and $line.Contains('file_path')) {
                $pos = 0
                while ($true) {
                    $ri = $line.IndexOf('"Read"', $pos)
                    if ($ri -lt 0) { break }
                    $pos = $ri + 6

                    # Verify this is a tool_use name
                    $ni = $line.LastIndexOf('"name"', $ri)
                    if ($ni -lt 0 -or $ri - $ni -gt 15) { continue }

                    # Get file_path (AFTER "Read")
                    $fpR = Get-KV $line 'file_path' $ri
                    if (-not $fpR) { continue }
                    $rel = Get-Rel $fpR.Value
                    if (-not $rel) { continue }

                    # Get tool_use ID - search NEAR "name" for "id":"toolu_..."
                    # The "id" field can be before OR after "name"
                    # Search in a window around the name field
                    $searchStart = [Math]::Max(0, $ni - 200)
                    $searchEnd = [Math]::Min($line.Length, $ri + 200)
                    $window = $line.Substring($searchStart, $searchEnd - $searchStart)

                    # Find all "id":"..." in this window
                    $idPos = 0
                    while ($true) {
                        $idIdx = $window.IndexOf('"id"', $idPos)
                        if ($idIdx -lt 0) { break }
                        $idPos = $idIdx + 4
                        $idR = Get-KV $window 'id' $idIdx
                        if (-not $idR) { continue }
                        if ($idR.Value.StartsWith('toolu_')) {
                            $readIdMap[$idR.Value] = $rel
                            $stats.ReadIds++
                            break
                        }
                    }
                }
            }

            # ═══ Extract from toolUseResult ═══
            # Format: "toolUseResult":{"type":"text","file":{"filePath":"C:\work\prtask.com\...","content":"..."}}
            if ($line.Contains('toolUseResult') -and $hasPrtask -and $line.Contains('filePath')) {
                $pos = 0
                while ($true) {
                    $ti = $line.IndexOf('toolUseResult', $pos)
                    if ($ti -lt 0) { break }
                    $pos = $ti + 13

                    $fpR = Get-KV $line 'filePath' $ti
                    if (-not $fpR) { continue }
                    $rel = Get-Rel $fpR.Value
                    if (-not $rel -or (Test-Skip $rel)) { continue }

                    $ctR = Get-KV $line 'content' $fpR.End
                    if (-not $ctR -or $ctR.Value.Length -eq 0) { continue }

                    # Check if file already exists on disk and is from Write (skip)
                    $fullPath = Join-Path $outRoot $rel.Replace('/', '\')
                    if (Test-Path $fullPath) { continue }

                    if (-not $recovered.ContainsKey($rel)) {
                        $recovered[$rel] = $ctR.Value
                        $stats.ToolUseResult++
                    }
                }
            }

            # ═══ Extract from tool_result content (cross-line Read) ═══
            if ($line.Contains('tool_use_id') -and $line.Contains([char]0x2192)) {
                $pos = 0
                while ($true) {
                    $ti = $line.IndexOf('"tool_use_id"', $pos)
                    if ($ti -lt 0) { break }
                    $pos = $ti + 13

                    $idR = Get-KV $line 'tool_use_id' $ti
                    if (-not $idR) { continue }
                    if (-not $readIdMap.ContainsKey($idR.Value)) { continue }
                    $rel = $readIdMap[$idR.Value]
                    if (Test-Skip $rel) { continue }

                    # Check if already exists
                    $fullPath = Join-Path $outRoot $rel.Replace('/', '\')
                    if (Test-Path $fullPath) { continue }
                    if ($recovered.ContainsKey($rel)) { continue }

                    # Find content - search after tool_use_id
                    $ctR = Get-KV $line 'content' $idR.End
                    if (-not $ctR -or $ctR.Value.Length -lt 3) {
                        # Try searching before
                        $trIdx = [Math]::Max(0, $ti - 50)
                        $ctR = Get-KV $line 'content' $trIdx
                    }
                    if (-not $ctR -or $ctR.Value.Length -lt 3) { continue }
                    if (-not $ctR.Value.Contains([char]0x2192)) { continue }

                    $stripped = Strip-Nums $ctR.Value
                    if ($stripped.Length -gt 0) {
                        $recovered[$rel] = $stripped
                        $stats.ToolResult++
                    }
                }
            }
        }
    }
    finally { $reader.Close(); $reader.Dispose() }
}

Write-Host "`n=== Results ==="
Write-Host "  Read IDs tracked: $($stats.ReadIds)"
Write-Host "  From toolUseResult: $($stats.ToolUseResult)"
Write-Host "  From tool_result: $($stats.ToolResult)"
Write-Host "  New files to write: $($recovered.Count)"

# Write only NEW files (don't overwrite existing)
$written = 0
foreach ($kv in $recovered.GetEnumerator()) {
    $rel = $kv.Key
    $full = Join-Path $outRoot $rel.Replace('/', '\')
    if (Test-Path $full) { continue }  # Don't overwrite
    $dir = [IO.Path]::GetDirectoryName($full)
    if (-not (Test-Path $dir)) { New-Item -ItemType Directory -Path $dir -Force | Out-Null }
    try {
        [IO.File]::WriteAllText($full, $kv.Value, [System.Text.UTF8Encoding]::new($false))
        $written++
    } catch {}
}
Write-Host "  New files written: $written"

# Final total count
$allSrc = Get-ChildItem $outRoot -Recurse -File |
    Where-Object {
        $_.FullName -notmatch '\\(publish-output|publish|deploy|deploy-public|output|\.vs|node_modules|bin|obj)\\' -and
        $_.Name -notmatch '^(build-output|build_output|recover-|recovery-)'
    }

Write-Host "`n=== TOTAL FILES ON DISK: $($allSrc.Count) ==="
$exts = $allSrc | Group-Object Extension | Sort-Object Count -Descending | Select-Object -First 20
foreach ($e in $exts) {
    Write-Host ("  {0,-10}: {1}" -f $e.Name, $e.Count)
}
