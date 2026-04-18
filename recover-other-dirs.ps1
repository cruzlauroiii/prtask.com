## recover-other-dirs.ps1 — Recovery from OTHER project JSONL directories
## Targets JSONL files that reference prtask.com from:
##   C:\Users\user\.claude\projects\C--Users-user\
##   C:\Users\user\.claude\projects\C--work\
##   C:\Users\user\.claude\projects\C--work-prtask-com-src-PrTask-Git\

$ErrorActionPreference = 'Continue'
$outRoot = 'C:/work/prtask.com'

# Only scan files known to contain prtask.com references (pre-filtered)
$jsonlFiles = @(
    # C--Users-user (7 files)
    'C:\Users\user\.claude\projects\C--Users-user\2d1b12f1-dd44-449b-bc31-911e7dbd7216.jsonl',
    'C:\Users\user\.claude\projects\C--Users-user\6c99ecef-456b-4088-bcc9-c6e59c95f17f.jsonl',
    'C:\Users\user\.claude\projects\C--Users-user\78fe1bfb-8741-4261-82df-c6db6ac8805f.jsonl',
    'C:\Users\user\.claude\projects\C--Users-user\91d0d5b1-91ff-4e10-971c-3145733f815f.jsonl',
    'C:\Users\user\.claude\projects\C--Users-user\d38a211d-aabe-4de7-a403-7bf2e4bb79de.jsonl',
    'C:\Users\user\.claude\projects\C--Users-user\e359ae4f-010c-49bb-8711-9ddfadc09a47.jsonl',
    'C:\Users\user\.claude\projects\C--Users-user\f79fd1f6-42dd-4aab-8a50-0c49e8345c8e.jsonl',
    # C--work (2 files)
    'C:\Users\user\.claude\projects\C--work\7bb591d2-27b1-4c9e-84f2-408fc3821c17.jsonl',
    'C:\Users\user\.claude\projects\C--work\bffac190-6575-408a-91b8-6d571c2f22f1.jsonl',
    # C--work-prtask-com-src-PrTask-Git (2 files)
    'C:\Users\user\.claude\projects\C--work-prtask-com-src-PrTask-Git\51a7ecec-7a23-4a17-9629-115b4b9f9c19.jsonl',
    'C:\Users\user\.claude\projects\C--work-prtask-com-src-PrTask-Git\8e696f50-13a6-462c-92d7-3f1fb37ce28d.jsonl'
)

Write-Host "Scanning $($jsonlFiles.Count) JSONL files from other project directories"

$recovered = @{}      # rel path -> content
$recoveredSeq = @{}   # rel path -> sequence number
$recoveredSrc = @{}   # rel path -> source type (Write/Read/ReadResult)
$edits = [System.Collections.Generic.List[psobject]]::new()
$seq = 0
$stats = @{ Write=0; Read=0; ReadResult=0; Edit=0; Lines=0 }

$skipPaths = @('publish-output/','publish/','deploy/','deploy-public/','output/','node_modules/','.vs/','bin/','obj/')
$skipExts = @('.png','.jpg','.jpeg','.gif','.ico','.woff','.woff2','.ttf','.eot','.dll','.exe','.pdb','.nupkg','.snk','.pfx','.p12','.wasm','.br','.gz','.zip','.tar','.7z','.bmp','.svg')

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

# Extract JSON string value starting after opening quote. Returns @{Value; End} or $null
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

# Find "key":"value" near a position. Returns @{Value; End} or $null
function Get-KV([string]$t, [string]$key, [int]$from) {
    $needle = "`"$key`""
    $idx = $t.IndexOf($needle, $from)
    if ($idx -lt 0) { return $null }
    # Find : then "
    $ci = $t.IndexOf(':', $idx + $needle.Length)
    if ($ci -lt 0 -or $ci -gt $idx + $needle.Length + 5) { return $null }
    $qi = $t.IndexOf('"', $ci + 1)
    if ($qi -lt 0 -or $qi -gt $ci + 5) { return $null }
    return Read-JStr $t ($qi + 1)
}

# Strip "     N->" prefix from Read output
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

# Track Read tool_use IDs for cross-line matching
$readIdMap = @{}  # tool_use_id -> rel path

$fileNum = 0
foreach ($jf in $jsonlFiles) {
    $fileNum++
    if (-not (Test-Path $jf)) {
        Write-Host "[$fileNum] SKIP (not found): $([IO.Path]::GetFileName($jf))"
        continue
    }
    $sizeMB = [math]::Round((Get-Item $jf).Length / 1MB, 1)
    Write-Host "[$fileNum/$($jsonlFiles.Count)] $([IO.Path]::GetFileName($jf)) ($sizeMB MB)"

    $reader = [System.IO.StreamReader]::new($jf, [System.Text.Encoding]::UTF8)
    try {
        while ($null -ne ($line = $reader.ReadLine())) {
            $stats.Lines++
            if ($line.Length -lt 30) { continue }

            $hasPrtask = $line.Contains('prtask.com')

            # =============================================
            # 1. WRITE TOOL
            # =============================================
            if ($line.Contains('"Write"') -and $hasPrtask -and $line.Contains('file_path')) {
                $pos = 0
                while ($true) {
                    $wi = $line.IndexOf('"Write"', $pos)
                    if ($wi -lt 0) { break }
                    $pos = $wi + 7
                    $ni = $line.LastIndexOf('"name"', $wi)
                    if ($ni -lt 0 -or $wi - $ni -gt 15) { continue }

                    $fp = Get-KV $line 'file_path' $wi
                    if (-not $fp) { continue }
                    $rel = Get-Rel $fp.Value
                    if (-not $rel -or (Test-Skip $rel)) { continue }

                    $ct = Get-KV $line 'content' $fp.End
                    if (-not $ct -or $ct.Value.Length -eq 0) { continue }

                    $seq++
                    $recovered[$rel] = $ct.Value
                    $recoveredSeq[$rel] = $seq
                    $recoveredSrc[$rel] = 'Write'
                    $stats.Write++
                }
            }

            # =============================================
            # 2. READ TOOL: track tool_use IDs
            # =============================================
            if ($line.Contains('"Read"') -and $hasPrtask) {
                $pos = 0
                while ($true) {
                    $ri = $line.IndexOf('"Read"', $pos)
                    if ($ri -lt 0) { break }
                    $pos = $ri + 6
                    $ni = $line.LastIndexOf('"name"', $ri)
                    if ($ni -lt 0 -or $ri - $ni -gt 15) { continue }

                    $idStart = [Math]::Max(0, $ni - 300)
                    $idR = Get-KV $line 'id' $idStart
                    if (-not $idR -or $idR.Value.Length -lt 5) { continue }

                    $fpR = Get-KV $line 'file_path' $ri
                    if (-not $fpR) { continue }
                    $rel = Get-Rel $fpR.Value
                    if ($rel) { $readIdMap[$idR.Value] = $rel }
                }
            }

            # =============================================
            # 3. toolUseResult with file content
            # =============================================
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

                    $seq++
                    # toolUseResult is clean, but Write is authoritative
                    if (-not $recovered.ContainsKey($rel) -or $recoveredSrc[$rel] -ne 'Write') {
                        $recovered[$rel] = $ctR.Value
                        $recoveredSeq[$rel] = $seq
                        $recoveredSrc[$rel] = 'Read'
                        $stats.Read++
                    }
                }
            }

            # =============================================
            # 4. tool_result with arrow content (cross-line Read)
            # =============================================
            if ($line.Contains('tool_result') -and $line.Contains([char]0x2192)) {
                $pos = 0
                while ($true) {
                    $ti = $line.IndexOf('tool_use_id', $pos)
                    if ($ti -lt 0) { break }
                    $pos = $ti + 11

                    $idR = Get-KV $line 'tool_use_id' $ti
                    if (-not $idR) { continue }
                    if (-not $readIdMap.ContainsKey($idR.Value)) { continue }
                    $rel = $readIdMap[$idR.Value]
                    if (Test-Skip $rel) { continue }

                    $trIdx = $line.LastIndexOf('"tool_result"', $ti)
                    if ($trIdx -lt 0) { $trIdx = $ti }
                    $ctR = Get-KV $line 'content' $trIdx
                    if (-not $ctR -or $ctR.Value.Length -lt 3) { continue }
                    if (-not $ctR.Value.Contains([char]0x2192)) { continue }

                    $stripped = Strip-Nums $ctR.Value
                    if ($stripped.Length -gt 0 -and (-not $recovered.ContainsKey($rel) -or $recoveredSrc[$rel] -eq 'ReadResult')) {
                        $seq++
                        $recovered[$rel] = $stripped
                        $recoveredSeq[$rel] = $seq
                        $recoveredSrc[$rel] = 'ReadResult'
                        $stats.ReadResult++
                    }
                }
            }

            # =============================================
            # 5. EDIT TOOL
            # =============================================
            if ($line.Contains('"Edit"') -and $hasPrtask -and $line.Contains('file_path')) {
                $pos = 0
                while ($true) {
                    $ei = $line.IndexOf('"Edit"', $pos)
                    if ($ei -lt 0) { break }
                    $pos = $ei + 6
                    $ni = $line.LastIndexOf('"name"', $ei)
                    if ($ni -lt 0 -or $ei - $ni -gt 15) { continue }

                    $fpR = Get-KV $line 'file_path' $ei
                    if (-not $fpR) { continue }
                    $rel = Get-Rel $fpR.Value
                    if (-not $rel -or (Test-Skip $rel)) { continue }

                    $oldR = Get-KV $line 'old_string' $fpR.End
                    if (-not $oldR) { continue }
                    $newR = Get-KV $line 'new_string' $oldR.End
                    if (-not $newR) { continue }

                    $replAll = $false
                    $raI = $line.IndexOf('"replace_all"', $newR.End)
                    if ($raI -gt 0 -and $raI -lt $newR.End + 100) {
                        if ($line.Substring($raI, [Math]::Min(40, $line.Length - $raI)).Contains('true')) { $replAll = $true }
                    }

                    $seq++
                    $edits.Add([pscustomobject]@{ Rel=$rel; Old=$oldR.Value; New=$newR.Value; ReplAll=$replAll; Seq=$seq })
                    $stats.Edit++
                }
            }
        }
    }
    finally { $reader.Close(); $reader.Dispose() }
}

Write-Host "`n=== Scan complete ==="
Write-Host "  Lines scanned: $($stats.Lines)"
Write-Host "  Write: $($stats.Write) | Read (toolUseResult): $($stats.Read) | Read (tool_result): $($stats.ReadResult) | Edit: $($stats.Edit)"
Write-Host "  Read IDs tracked: $($readIdMap.Count)"
Write-Host "  Unique files from logs: $($recovered.Count)"

# Apply edits
Write-Host "`n=== Applying $($edits.Count) edits ==="
$ea = 0; $ef = 0; $en = 0
foreach ($e in ($edits | Sort-Object Seq)) {
    if (-not $recovered.ContainsKey($e.Rel)) { $en++; continue }
    $c = $recovered[$e.Rel]
    if ($e.ReplAll) {
        if ($c.Contains($e.Old)) { $recovered[$e.Rel] = $c.Replace($e.Old, $e.New); $ea++ }
        else { $ef++ }
    } else {
        $idx = $c.IndexOf($e.Old)
        if ($idx -ge 0) { $recovered[$e.Rel] = $c.Substring(0, $idx) + $e.New + $c.Substring($idx + $e.Old.Length); $ea++ }
        else { $ef++ }
    }
}
Write-Host "  Applied: $ea | Failed: $ef | NoFile: $en"

# Now write files — check against existing files
Write-Host "`n=== Writing files ==="
$newFiles = @()
$updatedFiles = @()
$skippedFiles = @()
$written = 0

foreach ($kv in $recovered.GetEnumerator()) {
    $rel = $kv.Key
    if (Test-Skip $rel) { continue }
    $content = $kv.Value
    if ([string]::IsNullOrWhiteSpace($content)) { continue }

    $full = Join-Path $outRoot $rel.Replace('/', '\')

    if (Test-Path $full) {
        # File already exists — compare content
        $existingContent = [IO.File]::ReadAllText($full, [System.Text.UTF8Encoding]::new($false))
        if ($existingContent -eq $content) {
            # Identical, skip
            $skippedFiles += $rel
            continue
        }
        # Different content found in other dirs — mark as updated
        $updatedFiles += $rel
    } else {
        $newFiles += $rel
    }

    $dir = [IO.Path]::GetDirectoryName($full)
    if (-not (Test-Path $dir)) { New-Item -ItemType Directory -Path $dir -Force | Out-Null }
    try {
        [IO.File]::WriteAllText($full, $content, [System.Text.UTF8Encoding]::new($false))
        $written++
    } catch { Write-Host "  ERR: $rel - $_" }
}

Write-Host ""
Write-Host "============================================="
Write-Host "   RECOVERY FROM OTHER DIRECTORIES"
Write-Host "============================================="
Write-Host "Total files found in logs: $($recovered.Count)"
Write-Host "Files written: $written"
Write-Host "  NEW files (not previously recovered): $($newFiles.Count)"
Write-Host "  UPDATED files (different content): $($updatedFiles.Count)"
Write-Host "  SKIPPED files (identical content): $($skippedFiles.Count)"
Write-Host ""

if ($newFiles.Count -gt 0) {
    Write-Host "--- NEW files ---"
    foreach ($f in ($newFiles | Sort-Object)) {
        Write-Host "  + $f"
    }
    Write-Host ""
}

if ($updatedFiles.Count -gt 0) {
    Write-Host "--- UPDATED files ---"
    foreach ($f in ($updatedFiles | Sort-Object)) {
        Write-Host "  * $f"
    }
    Write-Host ""
}

Write-Host "--- Stats ---"
Write-Host "  Write tool extractions: $($stats.Write)"
Write-Host "  Read (toolUseResult) extractions: $($stats.Read)"
Write-Host "  Read (tool_result arrow) extractions: $($stats.ReadResult)"
Write-Host "  Edit tool extractions: $($stats.Edit)"
Write-Host "  Edits applied: $ea | failed: $ef | no-file: $en"
