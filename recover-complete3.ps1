## recover-complete3.ps1 — Final comprehensive recovery
## Combines ConvertFrom-Json for Write/Edit + regex for Read results

$ErrorActionPreference = 'Continue'
$logDir   = 'C:/Users/user/.claude/projects/C--work-prtask-com'
$outRoot  = 'C:/work/prtask.com'
$reportPath = "$outRoot/recovery-report3.txt"

$jsonlFiles = Get-ChildItem $logDir -Filter '*.jsonl' -Recurse |
              Sort-Object LastWriteTime |
              Select-Object -ExpandProperty FullName
Write-Host "Found $($jsonlFiles.Count) JSONL files"

$recovered = @{}
$recoveredSeq = @{}
$edits = [System.Collections.Generic.List[psobject]]::new()
$seq = 0
$writeHits = 0
$readHits = 0
$editHits = 0
$totalLines = 0
$readToolUseMap = @{}  # tool_use_id -> file_path (across lines)

$skipPaths = @('publish-output/','publish/','deploy/','deploy-public/','output/','node_modules/','.vs/','bin/','obj/')
$skipExts = @('.png','.jpg','.jpeg','.gif','.ico','.woff','.woff2','.ttf','.eot','.dll','.exe','.pdb','.nupkg','.snk','.pfx','.p12','.wasm','.br','.gz','.zip','.tar','.7z')

function Get-RelPath([string]$p) {
    $p = $p.Replace('\', '/')
    foreach ($pfx in @('C:/work/prtask.com/','c:/work/prtask.com/','/c/work/prtask.com/')) {
        if ($p.StartsWith($pfx, [System.StringComparison]::OrdinalIgnoreCase)) {
            return $p.Substring($pfx.Length)
        }
    }
    return $null
}

function Test-SkipPath([string]$rel) {
    foreach ($sp in $skipPaths) { if ($rel.StartsWith($sp)) { return $true } }
    $ext = [System.IO.Path]::GetExtension($rel).ToLower()
    if ($ext -in $skipExts) { return $true }
    return $false
}

# Extract string value from raw JSON text starting just after the opening quote
function Get-JsonString([string]$text, [int]$afterQuote) {
    $sb = [System.Text.StringBuilder]::new(8192)
    $i = $afterQuote
    $len = $text.Length
    while ($i -lt $len) {
        $c = $text[$i]
        if ($c -eq '\') {
            $i++
            if ($i -ge $len) { break }
            $nc = $text[$i]
            switch ($nc) {
                'n'  { [void]$sb.Append("`n"); break }
                't'  { [void]$sb.Append("`t"); break }
                'r'  { [void]$sb.Append("`r"); break }
                '"'  { [void]$sb.Append('"'); break }
                '\'  { [void]$sb.Append('\'); break }
                '/'  { [void]$sb.Append('/'); break }
                'b'  { [void]$sb.Append("`b"); break }
                'f'  { [void]$sb.Append([char]12); break }
                'u'  {
                    if ($i + 4 -lt $len) {
                        $hex = $text.Substring($i+1, 4)
                        try { [void]$sb.Append([char][Convert]::ToInt32($hex,16)) } catch { [void]$sb.Append("\u$hex") }
                        $i += 4
                    }
                    break
                }
                default { [void]$sb.Append('\'); [void]$sb.Append($nc); break }
            }
        }
        elseif ($c -eq '"') {
            return @{ Value = $sb.ToString(); End = $i + 1 }
        }
        else {
            [void]$sb.Append($c)
        }
        $i++
    }
    return $null
}

# Find "key":"value" after a given position
function Get-KeyValue([string]$text, [string]$key, [int]$from) {
    $needle = "`"$key`""
    $idx = $text.IndexOf($needle, $from)
    if ($idx -lt 0) { return $null }
    $colonIdx = $text.IndexOf(':', $idx + $needle.Length)
    if ($colonIdx -lt 0 -or $colonIdx -gt $idx + $needle.Length + 5) { return $null }
    $quoteIdx = $text.IndexOf('"', $colonIdx + 1)
    if ($quoteIdx -lt 0 -or $quoteIdx -gt $colonIdx + 5) { return $null }
    return Get-JsonString $text ($quoteIdx + 1)
}

# Strip Read line-number prefix
function Strip-LineNums([string]$text) {
    $lines = $text -split "`n"
    $out = [System.Text.StringBuilder]::new($text.Length)
    $first = $true
    foreach ($line in $lines) {
        $arrowIdx = $line.IndexOf([char]0x2192)
        if ($arrowIdx -ge 0) {
            $prefix = $line.Substring(0, $arrowIdx).Trim()
            if ($prefix -match '^\d+$') {
                if (-not $first) { [void]$out.Append("`n") }
                [void]$out.Append($line.Substring($arrowIdx + 1))
                $first = $false
                continue
            }
        }
        if ($line -match '^\s*(\d+)\t(.*)$') {
            if (-not $first) { [void]$out.Append("`n") }
            [void]$out.Append($Matches[2])
            $first = $false
            continue
        }
        if (-not $first) {
            [void]$out.Append("`n")
            [void]$out.Append($line)
        }
    }
    return $out.ToString()
}

$fileNum = 0
foreach ($jf in $jsonlFiles) {
    $fileNum++
    $sizeMB = [math]::Round((Get-Item $jf).Length / 1MB, 1)
    if ($fileNum % 100 -eq 0 -or $sizeMB -gt 5) {
        Write-Host "[$fileNum/$($jsonlFiles.Count)] $([System.IO.Path]::GetFileName($jf)) ($sizeMB MB) | Files: $($recovered.Count) | W:$writeHits R:$readHits E:$editHits"
    }

    $reader = [System.IO.StreamReader]::new($jf, [System.Text.Encoding]::UTF8)
    try {
        while ($null -ne ($line = $reader.ReadLine())) {
            $totalLines++
            if ($line.Length -lt 30) { continue }

            $hasPrtask = $line.Contains('prtask.com')
            $hasWrite = $line.Contains('"Write"')
            $hasRead = $line.Contains('"Read"')
            $hasEdit = $line.Contains('"Edit"')
            $hasToolResult = $line.Contains('tool_result')
            $hasArrow = $line.Contains([char]0x2192)

            # ═══ WRITE TOOL ═══
            if ($hasWrite -and $hasPrtask -and $line.Contains('file_path')) {
                # Find all "name":"Write" occurrences with nearby file_path + content
                $pos = 0
                while ($true) {
                    $wIdx = $line.IndexOf('"Write"', $pos)
                    if ($wIdx -lt 0) { break }
                    $pos = $wIdx + 7

                    # Verify "name": precedes "Write"
                    $nameIdx = $line.LastIndexOf('"name"', $wIdx)
                    if ($nameIdx -lt 0 -or $wIdx - $nameIdx -gt 15) { continue }

                    # Extract file_path (search forward from Write)
                    $fpResult = Get-KeyValue $line 'file_path' $wIdx
                    if (-not $fpResult) { continue }
                    $rel = Get-RelPath $fpResult.Value
                    if (-not $rel -or (Test-SkipPath $rel)) { continue }

                    # Extract content
                    $ctResult = Get-KeyValue $line 'content' $fpResult.End
                    if (-not $ctResult) { continue }

                    $seq++
                    $recovered[$rel] = $ctResult.Value
                    $recoveredSeq[$rel] = $seq
                    $writeHits++
                }
            }

            # ═══ READ TOOL: Track tool_use IDs ═══
            if ($hasRead -and $hasPrtask -and $line.Contains('file_path')) {
                $pos = 0
                while ($true) {
                    $rIdx = $line.IndexOf('"Read"', $pos)
                    if ($rIdx -lt 0) { break }
                    $pos = $rIdx + 6

                    $nameIdx = $line.LastIndexOf('"name"', $rIdx)
                    if ($nameIdx -lt 0 -or $rIdx - $nameIdx -gt 15) { continue }

                    # Get tool_use ID (search backwards from "name")
                    $idStart = [Math]::Max(0, $nameIdx - 300)
                    $idResult = Get-KeyValue $line 'id' $idStart
                    if (-not $idResult -or $idResult.Value.Length -lt 5) { continue }

                    # Get file_path
                    $fpResult = Get-KeyValue $line 'file_path' $rIdx
                    if (-not $fpResult) { continue }
                    $rel = Get-RelPath $fpResult.Value
                    if (-not $rel) { continue }

                    $readToolUseMap[$idResult.Value] = $rel
                }
            }

            # ═══ READ TOOL RESULTS (tool_result with arrow content) ═══
            if ($hasToolResult -and $hasArrow) {
                $pos = 0
                while ($true) {
                    $trIdx = $line.IndexOf('"tool_result"', $pos)
                    if ($trIdx -lt 0) { break }
                    $pos = $trIdx + 13

                    # Find tool_use_id
                    $tuIdResult = Get-KeyValue $line 'tool_use_id' ([Math]::Max(0, $trIdx - 100))
                    if (-not $tuIdResult) {
                        $tuIdResult = Get-KeyValue $line 'tool_use_id' $trIdx
                    }
                    if (-not $tuIdResult) { continue }
                    $toolUseId = $tuIdResult.Value

                    # Look up file path from our map
                    if (-not $readToolUseMap.ContainsKey($toolUseId)) { continue }
                    $rel = $readToolUseMap[$toolUseId]
                    if (Test-SkipPath $rel) { continue }

                    # Extract content
                    $contentResult = Get-KeyValue $line 'content' $trIdx
                    if (-not $contentResult) { continue }
                    $rawContent = $contentResult.Value
                    if ($rawContent.Length -lt 3) { continue }
                    if (-not $rawContent.Contains([char]0x2192)) { continue }

                    # Strip line number prefixes
                    $stripped = Strip-LineNums $rawContent
                    if ($stripped.Length -gt 0) {
                        $seq++
                        # Only use Read if we do NOT have a Write for this file
                        if (-not $recovered.ContainsKey($rel)) {
                            $recovered[$rel] = $stripped
                            $recoveredSeq[$rel] = $seq
                            $readHits++
                        }
                    }
                }
            }

            # ═══ EDIT TOOL ═══
            if ($hasEdit -and $hasPrtask -and $line.Contains('file_path')) {
                $pos = 0
                while ($true) {
                    $eIdx = $line.IndexOf('"Edit"', $pos)
                    if ($eIdx -lt 0) { break }
                    $pos = $eIdx + 6

                    $nameIdx = $line.LastIndexOf('"name"', $eIdx)
                    if ($nameIdx -lt 0 -or $eIdx - $nameIdx -gt 15) { continue }

                    $fpResult = Get-KeyValue $line 'file_path' $eIdx
                    if (-not $fpResult) { continue }
                    $rel = Get-RelPath $fpResult.Value
                    if (-not $rel -or (Test-SkipPath $rel)) { continue }

                    $oldResult = Get-KeyValue $line 'old_string' $fpResult.End
                    if (-not $oldResult) { continue }

                    $newResult = Get-KeyValue $line 'new_string' $oldResult.End
                    if (-not $newResult) { continue }

                    $replAll = $false
                    $raIdx = $line.IndexOf('"replace_all"', $newResult.End)
                    if ($raIdx -gt 0 -and $raIdx -lt $newResult.End + 100) {
                        if ($line.Substring($raIdx, [Math]::Min(40, $line.Length - $raIdx)).Contains('true')) {
                            $replAll = $true
                        }
                    }

                    $seq++
                    $edits.Add([pscustomobject]@{
                        RelPath    = $rel
                        OldString  = $oldResult.Value
                        NewString  = $newResult.Value
                        ReplaceAll = $replAll
                        Seq        = $seq
                    })
                    $editHits++
                }
            }
        }
    }
    finally {
        $reader.Close()
        $reader.Dispose()
    }
}

Write-Host "`n=== Pass complete ==="
Write-Host "Write: $writeHits | Read: $readHits | Edit: $editHits | Files: $($recovered.Count)"
Write-Host "Read tool_use IDs tracked: $($readToolUseMap.Count)"

# Apply edits
Write-Host "`n=== Applying $($edits.Count) edits ==="
$editsApplied = 0; $editsFailed = 0; $editsNoFile = 0
foreach ($edit in ($edits | Sort-Object Seq)) {
    if (-not $recovered.ContainsKey($edit.RelPath)) { $editsNoFile++; continue }
    $content = $recovered[$edit.RelPath]
    if ($edit.ReplaceAll) {
        if ($content.Contains($edit.OldString)) {
            $recovered[$edit.RelPath] = $content.Replace($edit.OldString, $edit.NewString)
            $editsApplied++
        } else { $editsFailed++ }
    } else {
        $idx = $content.IndexOf($edit.OldString)
        if ($idx -ge 0) {
            $recovered[$edit.RelPath] = $content.Substring(0, $idx) + $edit.NewString + $content.Substring($idx + $edit.OldString.Length)
            $editsApplied++
        } else { $editsFailed++ }
    }
}
Write-Host "Applied: $editsApplied | Failed: $editsFailed | NoFile: $editsNoFile"

# Write files
Write-Host "`n=== Writing files ==="
$written = 0
foreach ($kv in $recovered.GetEnumerator()) {
    $rel = $kv.Key
    if (Test-SkipPath $rel) { continue }
    $fullPath = Join-Path $outRoot $rel.Replace('/', '\')
    $dir = [System.IO.Path]::GetDirectoryName($fullPath)
    if (-not (Test-Path $dir)) { New-Item -ItemType Directory -Path $dir -Force | Out-Null }
    try {
        [System.IO.File]::WriteAllText($fullPath, $kv.Value, [System.Text.UTF8Encoding]::new($false))
        $written++
    } catch {
        Write-Host "  ERROR: ${rel}"
    }
}
Write-Host "Written: $written"

# Count all source files now on disk
$allFiles = Get-ChildItem $outRoot -Recurse -File |
    Where-Object {
        $_.FullName -notmatch '\\(publish-output|publish|deploy|deploy-public|output|\.vs|node_modules|bin|obj)\\' -and
        $_.Name -notmatch '^(build-output|build_output|recover-complete|recovery-report)'
    }

$counts = @{
    'cs'      = @($allFiles | Where-Object { $_.Extension -eq '.cs' }).Count
    'g.cs'    = @($allFiles | Where-Object { $_.Name -like '*.g.cs' }).Count
    'csproj'  = @($allFiles | Where-Object { $_.Extension -eq '.csproj' }).Count
    'razor'   = @($allFiles | Where-Object { $_.Extension -eq '.razor' }).Count
    'html'    = @($allFiles | Where-Object { $_.Extension -eq '.html' }).Count
    'resx'    = @($allFiles | Where-Object { $_.Extension -eq '.resx' }).Count
    'xaml'    = @($allFiles | Where-Object { $_.Extension -eq '.xaml' }).Count
    'scss_css'= @($allFiles | Where-Object { $_.Extension -in '.scss','.css' }).Count
    'ts_js'   = @($allFiles | Where-Object { $_.Extension -in '.ts','.js' }).Count
    'json'    = @($allFiles | Where-Object { $_.Extension -eq '.json' }).Count
    'sln'     = @($allFiles | Where-Object { $_.Extension -eq '.sln' }).Count
    'yml'     = @($allFiles | Where-Object { $_.Extension -in '.yml','.yaml' }).Count
    'ps1'     = @($allFiles | Where-Object { $_.Extension -eq '.ps1' }).Count
    'md'      = @($allFiles | Where-Object { $_.Extension -eq '.md' }).Count
}

$report = @"
================================================================
   RECOVERY REPORT v3  -  $(Get-Date -Format 'yyyy-MM-dd HH:mm:ss')
================================================================

JSONL files: $($jsonlFiles.Count) | Lines: $totalLines
Write: $writeHits | Read: $readHits | Edit: $editHits (applied $editsApplied)
Read tool IDs tracked: $($readToolUseMap.Count)
Files written this pass: $written
Total unique recovered: $($recovered.Count)

TOTAL FILES ON DISK: $($allFiles.Count)
  .cs       : $($counts['cs'])
  .g.cs     : $($counts['g.cs'])
  .csproj   : $($counts['csproj'])
  .razor    : $($counts['razor'])
  .html     : $($counts['html'])
  .resx     : $($counts['resx'])
  .xaml     : $($counts['xaml'])
  .scss/.css: $($counts['scss_css'])
  .ts/.js   : $($counts['ts_js'])
  .json     : $($counts['json'])
  .sln      : $($counts['sln'])
  .yml/.yaml: $($counts['yml'])
  .ps1      : $($counts['ps1'])
  .md       : $($counts['md'])
"@

$report | Tee-Object -FilePath $reportPath
