## recover-final.ps1 — Comprehensive source-code recovery from Claude JSONL logs
## Extracts from: Write tool, Read toolUseResult, Edit tool, tool_result content

$ErrorActionPreference = 'Continue'
$logDir   = 'C:/Users/user/.claude/projects/C--work-prtask-com'
$outRoot  = 'C:/work/prtask.com'

$jsonlFiles = Get-ChildItem $logDir -Filter '*.jsonl' -Recurse |
              Sort-Object LastWriteTime |
              Select-Object -ExpandProperty FullName
Write-Host "Found $($jsonlFiles.Count) JSONL files to scan"

$recovered = @{}      # rel path -> content
$recoveredSeq = @{}   # rel path -> sequence number
$edits = [System.Collections.Generic.List[psobject]]::new()
$seq = 0
$stats = @{ Write=0; Read=0; ReadResult=0; Edit=0; Lines=0 }

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

# Strip "     N→" prefix from Read output
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

# Also track Read tool_use IDs for cross-line matching
$readIdMap = @{}  # tool_use_id -> rel path

$fileNum = 0
foreach ($jf in $jsonlFiles) {
    $fileNum++
    $sizeMB = [math]::Round((Get-Item $jf).Length / 1MB, 1)
    if ($fileNum % 100 -eq 0 -or $sizeMB -gt 5) {
        Write-Host "[$fileNum/$($jsonlFiles.Count)] $([IO.Path]::GetFileName($jf)) ($sizeMB MB) | F:$($recovered.Count) W:$($stats.Write) R:$($stats.Read) RR:$($stats.ReadResult) E:$($stats.Edit)"
    }

    $reader = [System.IO.StreamReader]::new($jf, [System.Text.Encoding]::UTF8)
    try {
        while ($null -ne ($line = $reader.ReadLine())) {
            $stats.Lines++
            if ($line.Length -lt 30) { continue }

            $hasPrtask = $line.Contains('prtask.com')

            # ═══════════════════════════════════════════════════
            # 1. WRITE TOOL
            # ═══════════════════════════════════════════════════
            if ($line.Contains('"Write"') -and $hasPrtask -and $line.Contains('file_path')) {
                $pos = 0
                while ($true) {
                    $wi = $line.IndexOf('"Write"', $pos)
                    if ($wi -lt 0) { break }
                    $pos = $wi + 7
                    # Verify "name" precedes
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
                    $stats.Write++
                }
            }

            # ═══════════════════════════════════════════════════
            # 2. READ TOOL: track tool_use IDs
            # ═══════════════════════════════════════════════════
            if ($line.Contains('"Read"') -and $hasPrtask) {
                $pos = 0
                while ($true) {
                    $ri = $line.IndexOf('"Read"', $pos)
                    if ($ri -lt 0) { break }
                    $pos = $ri + 6
                    $ni = $line.LastIndexOf('"name"', $ri)
                    if ($ni -lt 0 -or $ri - $ni -gt 15) { continue }

                    # Get ID
                    $idStart = [Math]::Max(0, $ni - 300)
                    $idR = Get-KV $line 'id' $idStart
                    if (-not $idR -or $idR.Value.Length -lt 5) { continue }

                    # Get file_path
                    $fpR = Get-KV $line 'file_path' $ri
                    if (-not $fpR) { continue }
                    $rel = Get-Rel $fpR.Value
                    if ($rel) { $readIdMap[$idR.Value] = $rel }
                }
            }

            # ═══════════════════════════════════════════════════
            # 3. toolUseResult with file content (cleanest source!)
            # Format: "toolUseResult":{"type":"text","file":{"filePath":"...","content":"..."}}
            # ═══════════════════════════════════════════════════
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
                    # toolUseResult content is CLEAN (no line number prefixes)
                    # Use it if no Write exists, or if it's newer
                    if (-not $recovered.ContainsKey($rel) -or $recoveredSeq[$rel] -lt $seq) {
                        # Prefer Write over Read (Write is authoritative)
                        # Only overwrite if source was NOT a Write
                        if (-not $recovered.ContainsKey($rel)) {
                            $recovered[$rel] = $ctR.Value
                            $recoveredSeq[$rel] = $seq
                            $stats.Read++
                        }
                    }
                }
            }

            # ═══════════════════════════════════════════════════
            # 4. tool_result with arrow content (cross-line Read)
            # ═══════════════════════════════════════════════════
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

                    # Find content AFTER tool_result
                    $trIdx = $line.LastIndexOf('"tool_result"', $ti)
                    if ($trIdx -lt 0) { $trIdx = $ti }
                    $ctR = Get-KV $line 'content' $trIdx
                    if (-not $ctR -or $ctR.Value.Length -lt 3) { continue }
                    if (-not $ctR.Value.Contains([char]0x2192)) { continue }

                    $stripped = Strip-Nums $ctR.Value
                    if ($stripped.Length -gt 0 -and -not $recovered.ContainsKey($rel)) {
                        $seq++
                        $recovered[$rel] = $stripped
                        $recoveredSeq[$rel] = $seq
                        $stats.ReadResult++
                    }
                }
            }

            # ═══════════════════════════════════════════════════
            # 5. EDIT TOOL
            # ═══════════════════════════════════════════════════
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
Write-Host "  Write: $($stats.Write) | Read (toolUseResult): $($stats.Read) | Read (tool_result): $($stats.ReadResult) | Edit: $($stats.Edit)"
Write-Host "  Read IDs tracked: $($readIdMap.Count)"
Write-Host "  Unique files: $($recovered.Count)"

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

# Write files
Write-Host "`n=== Writing files ==="
$written = 0
foreach ($kv in $recovered.GetEnumerator()) {
    $rel = $kv.Key
    if (Test-Skip $rel) { continue }
    $full = Join-Path $outRoot $rel.Replace('/', '\')
    $dir = [IO.Path]::GetDirectoryName($full)
    if (-not (Test-Path $dir)) { New-Item -ItemType Directory -Path $dir -Force | Out-Null }
    try {
        [IO.File]::WriteAllText($full, $kv.Value, [System.Text.UTF8Encoding]::new($false))
        $written++
    } catch { Write-Host "  ERR: $rel - $_" }
}
Write-Host "  Written: $written"

# Final count
$allSrc = Get-ChildItem $outRoot -Recurse -File |
    Where-Object {
        $_.FullName -notmatch '\\(publish-output|publish|deploy|deploy-public|output|\.vs|node_modules|bin|obj)\\' -and
        $_.Name -notmatch '^(build-output|build_output|recover-|recovery-)'
    }

Write-Host "`n============================================="
Write-Host "   FINAL RECOVERY SUMMARY"
Write-Host "============================================="
Write-Host "Total source files on disk: $($allSrc.Count)"
Write-Host ""

$breakdown = @(
    @{Ext='.cs'; Label='.cs files'},
    @{Pat='*.g.cs'; Label='.g.cs files'; UsePattern=$true},
    @{Ext='.csproj'; Label='.csproj files'},
    @{Ext='.razor'; Label='.razor files'},
    @{Ext='.html'; Label='.html files'},
    @{Ext='.resx'; Label='.resx files'},
    @{Ext='.xaml'; Label='.xaml files'},
    @{Ext='.scss'; Label='.scss files'},
    @{Ext='.css'; Label='.css files'},
    @{Ext='.ts'; Label='.ts files'},
    @{Ext='.js'; Label='.js files'},
    @{Ext='.json'; Label='.json files'},
    @{Ext='.sln'; Label='.sln files'},
    @{Ext='.yml'; Label='.yml files'},
    @{Ext='.yaml'; Label='.yaml files'},
    @{Ext='.ps1'; Label='.ps1 files'},
    @{Ext='.md'; Label='.md files'}
)

foreach ($b in $breakdown) {
    if ($b.UsePattern) {
        $cnt = @($allSrc | Where-Object { $_.Name -like $b.Pat }).Count
    } else {
        $cnt = @($allSrc | Where-Object { $_.Extension -eq $b.Ext }).Count
    }
    if ($cnt -gt 0) { Write-Host ("  {0,-15}: {1}" -f $b.Label, $cnt) }
}

# Show directory structure
Write-Host "`nRecovered directories:"
$dirs = $allSrc | ForEach-Object {
    $_.DirectoryName.Replace("$outRoot\", '').Split('\')[0..1] -join '\'
} | Sort-Object -Unique
foreach ($d in $dirs) {
    $cnt = @($allSrc | Where-Object { $_.FullName.Replace("$outRoot\", '').StartsWith($d) }).Count
    Write-Host ("  {0,-50} ({1} files)" -f $d, $cnt)
}
