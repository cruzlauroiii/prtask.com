## recover-complete2.ps1 — Comprehensive source-code recovery using regex-based parsing
## Handles Write, Read, Edit tool calls from Claude JSONL conversation logs
## Uses regex extraction on raw text to avoid ConvertFrom-Json depth/size issues

$ErrorActionPreference = 'Continue'
$logDir   = 'C:/Users/user/.claude/projects/C--work-prtask-com'
$outRoot  = 'C:/work/prtask.com'
$reportPath = "$outRoot/recovery-report2.txt"

# Gather all JSONL files sorted by last write time (chronological)
$jsonlFiles = Get-ChildItem $logDir -Filter '*.jsonl' -Recurse |
              Sort-Object LastWriteTime |
              Select-Object -ExpandProperty FullName
Write-Host "Found $($jsonlFiles.Count) JSONL files to scan"

# State
$recovered = @{}   # relative path → content string
$recoveredSeq = @{} # relative path → sequence number
$edits = [System.Collections.Generic.List[psobject]]::new()
$seq = 0
$writeHits = 0
$readHits = 0
$editHits = 0
$totalLines = 0

# Path normalization
function Normalize-RelPath([string]$p) {
    $p = $p.Replace('\\\\', '/').Replace('\\', '/').Replace('//', '/')
    # Strip prefix variants
    foreach ($pfx in @('C:/work/prtask.com/','c:/work/prtask.com/','/c/work/prtask.com/')) {
        if ($p.StartsWith($pfx, [System.StringComparison]::OrdinalIgnoreCase)) {
            return $p.Substring($pfx.Length)
        }
    }
    return $null
}

# Unescape JSON string value (handle \n, \t, \r, \\, \", \uXXXX)
function Unescape-JsonString([string]$s) {
    # Use .NET JSON deserializer for correctness
    try {
        return [System.Text.Json.JsonSerializer]::Deserialize[string]("`"$s`"")
    } catch {
        # Fallback: manual unescape
        $s = $s.Replace('\\n', "`n").Replace('\\t', "`t").Replace('\\r', "`r")
        $s = $s.Replace('\\"', '"').Replace('\\\\', '\')
        return $s
    }
}

# Strip Read tool line number prefix from content
# Input is already unescaped text with actual newlines
# Format per line: "     1→content" where → is U+2192
function Strip-ReadPrefix([string]$text) {
    $lines = $text -split "`n"
    $result = [System.Text.StringBuilder]::new($text.Length)
    $first = $true
    foreach ($line in $lines) {
        # Match: optional spaces, digits, → (U+2192), then content
        $arrowIdx = $line.IndexOf([char]0x2192)
        if ($arrowIdx -ge 0) {
            # Verify everything before arrow is spaces and digits
            $prefix = $line.Substring(0, $arrowIdx).Trim()
            if ($prefix -match '^\d+$') {
                if (-not $first) { [void]$result.Append("`n") }
                [void]$result.Append($line.Substring($arrowIdx + 1))
                $first = $false
                continue
            }
        }
        # Also handle tab separator (char 9)
        if ($line -match '^\s*(\d+)\t(.*)$') {
            if (-not $first) { [void]$result.Append("`n") }
            [void]$result.Append($Matches[2])
            $first = $false
            continue
        }
        # If line is empty or doesn't match, include as-is if we already started
        if (-not $first) {
            [void]$result.Append("`n")
            [void]$result.Append($line)
        }
    }
    return $result.ToString()
}

# Regex to find Write tool calls
# Pattern: "name":"Write" ... "input":{"file_path":"...","content":"..."}
# We need to handle the content which can contain escaped quotes
$writePattern = [regex]'"name"\s*:\s*"Write"'
$readPattern = [regex]'"name"\s*:\s*"Read"'
$editPattern = [regex]'"name"\s*:\s*"Edit"'

# Extract a JSON string value starting at a given position (after the opening quote)
function Extract-JsonStringValue([string]$text, [int]$startAfterQuote) {
    $sb = [System.Text.StringBuilder]::new(4096)
    $i = $startAfterQuote
    $len = $text.Length
    while ($i -lt $len) {
        $c = $text[$i]
        if ($c -eq '\') {
            # Escaped character
            $i++
            if ($i -ge $len) { break }
            $nc = $text[$i]
            switch ($nc) {
                'n' { [void]$sb.Append("`n"); break }
                't' { [void]$sb.Append("`t"); break }
                'r' { [void]$sb.Append("`r"); break }
                '"' { [void]$sb.Append('"'); break }
                '\' { [void]$sb.Append('\'); break }
                '/' { [void]$sb.Append('/'); break }
                'b' { [void]$sb.Append("`b"); break }
                'f' { [void]$sb.Append([char]12); break }
                'u' {
                    # Unicode escape \uXXXX
                    if ($i + 4 -lt $len) {
                        $hex = $text.Substring($i + 1, 4)
                        try {
                            $cp = [Convert]::ToInt32($hex, 16)
                            [void]$sb.Append([char]$cp)
                        } catch {
                            [void]$sb.Append('\u')
                            [void]$sb.Append($hex)
                        }
                        $i += 4
                    }
                    break
                }
                default { [void]$sb.Append('\'); [void]$sb.Append($nc); break }
            }
        }
        elseif ($c -eq '"') {
            # End of string
            return @{ Value = $sb.ToString(); EndPos = $i + 1 }
        }
        else {
            [void]$sb.Append($c)
        }
        $i++
    }
    return $null  # Unterminated string
}

# Find the next JSON string value after a key like "file_path":"
function Find-StringAfterKey([string]$text, [string]$key, [int]$searchStart) {
    $keyPattern = "`"${key}`"`s*:`s*`""
    $idx = $text.IndexOf("`"${key}`"", $searchStart)
    if ($idx -lt 0) { return $null }

    # Find the colon then the opening quote
    $colonIdx = $text.IndexOf(':', $idx + $key.Length + 2)
    if ($colonIdx -lt 0) { return $null }

    # Find opening quote
    $quoteIdx = $text.IndexOf('"', $colonIdx + 1)
    if ($quoteIdx -lt 0) { return $null }

    # Extract the string value
    return Extract-JsonStringValue $text ($quoteIdx + 1)
}

# Process each JSONL file
$fileNum = 0
$skipPatterns = @('publish-output/', 'publish/', 'deploy/', 'deploy-public/', 'output/', 'node_modules/', '.vs/', 'bin/', 'obj/')
$skipExtensions = @('.png', '.jpg', '.jpeg', '.gif', '.ico', '.woff', '.woff2', '.ttf', '.eot', '.dll', '.exe', '.pdb', '.nupkg', '.snk', '.pfx', '.p12', '.wasm', '.br', '.gz')

foreach ($jf in $jsonlFiles) {
    $fileNum++
    $fname = [System.IO.Path]::GetFileName($jf)
    $sizeMB = [math]::Round((Get-Item $jf).Length / 1MB, 1)

    if ($fileNum % 50 -eq 0 -or $sizeMB -gt 5) {
        Write-Host "[$fileNum/$($jsonlFiles.Count)] $fname ($sizeMB MB) | Files so far: $($recovered.Count)"
    }

    $reader = [System.IO.StreamReader]::new($jf, [System.Text.Encoding]::UTF8)
    try {
        while ($null -ne ($line = $reader.ReadLine())) {
            $totalLines++
            if ($line.Length -lt 30) { continue }

            # ═══════════════════════════════════════════════════════════
            # WRITE TOOL CALLS
            # ═══════════════════════════════════════════════════════════
            if ($line.Contains('"Write"') -and $line.Contains('file_path') -and $line.Contains('prtask.com')) {
                # Find all Write tool_use blocks in this line
                $searchPos = 0
                while ($true) {
                    $wIdx = $line.IndexOf('"Write"', $searchPos)
                    if ($wIdx -lt 0) { break }
                    $searchPos = $wIdx + 7

                    # Verify this is a tool_use name
                    # Look backwards for "name":
                    $before = $line.Substring([Math]::Max(0, $wIdx - 20), [Math]::Min(20, $wIdx))
                    if ($before -notmatch '"name"\s*:\s*$') { continue }

                    # Find file_path after this point
                    $fpResult = Find-StringAfterKey $line 'file_path' $wIdx
                    if (-not $fpResult) { continue }
                    $filePath = $fpResult.Value

                    $rel = Normalize-RelPath $filePath
                    if (-not $rel) { continue }

                    # Skip build output, binary files
                    $skip = $false
                    foreach ($sp in $skipPatterns) {
                        if ($rel.StartsWith($sp)) { $skip = $true; break }
                    }
                    if ($skip) { continue }
                    $ext = [System.IO.Path]::GetExtension($rel).ToLower()
                    if ($ext -in $skipExtensions) { continue }

                    # Find content after file_path
                    $ctResult = Find-StringAfterKey $line 'content' $fpResult.EndPos
                    if (-not $ctResult) { continue }
                    $content = $ctResult.Value

                    if ($content.Length -gt 0) {
                        $seq++
                        $recovered[$rel] = $content
                        $recoveredSeq[$rel] = $seq
                        $writeHits++
                    }
                }
            }

            # ═══════════════════════════════════════════════════════════
            # READ TOOL RESULTS
            # ═══════════════════════════════════════════════════════════
            if ($line.Contains('tool_result') -and $line.Contains('prtask.com')) {
                # Read results appear in "user" type lines with tool_result content
                # The tool_use_id links to a previous Read call, but we need to find the file_path
                # from the same or previous line. Alternative: look for file_path in the same JSON.

                # Strategy: Find tool_result blocks and look for Read tool_use blocks nearby
                # Or find tool_result with content that has line-number format (→ character)

                # Check if this line contains the → character (U+2192) which indicates Read output
                $hasArrow = $line.Contains([char]0x2192)
                if (-not $hasArrow) {
                    # Check for escaped form \u2192
                    $hasArrow = $line.Contains('\u2192')
                }

                if ($hasArrow) {
                    # Find all tool_result blocks with content
                    $trSearchPos = 0
                    while ($true) {
                        $trIdx = $line.IndexOf('"tool_result"', $trSearchPos)
                        if ($trIdx -lt 0) { break }
                        $trSearchPos = $trIdx + 13

                        # Find tool_use_id to match with Read call
                        $tuIdResult = Find-StringAfterKey $line 'tool_use_id' ([Math]::Max(0, $trIdx - 200))
                        if (-not $tuIdResult) { continue }
                        $toolUseId = $tuIdResult.Value

                        # Find the content of this tool_result
                        $contentResult = Find-StringAfterKey $line 'content' $trIdx
                        if (-not $contentResult) { continue }
                        $resultContent = $contentResult.Value

                        # Check if content looks like Read output (has line numbers with arrows)
                        if ($resultContent.Length -lt 5) { continue }
                        if (-not ($resultContent.Contains([char]0x2192) -or $resultContent -match '^\s*\d+\t')) { continue }

                        # Now find the corresponding Read tool_use to get file_path
                        # Search the ENTIRE line for a tool_use with matching id and name "Read"
                        $fp = $null

                        # Look for: "id":"<toolUseId>"..."name":"Read"..."file_path":"..."
                        # Or: "name":"Read"..."id":"<toolUseId>"..."file_path":"..."
                        $idPattern = "`"$toolUseId`""
                        $idSearchPos = 0
                        while ($true) {
                            $idIdx = $line.IndexOf($idPattern, $idSearchPos)
                            if ($idIdx -lt 0) { break }
                            $idSearchPos = $idIdx + $idPattern.Length

                            # Check if "Read" appears within +-500 chars
                            $regionStart = [Math]::Max(0, $idIdx - 500)
                            $regionEnd = [Math]::Min($line.Length, $idIdx + 500)
                            $region = $line.Substring($regionStart, $regionEnd - $regionStart)
                            if ($region.Contains('"Read"')) {
                                # Found the Read tool_use block. Find file_path near it.
                                $fpSearch = [Math]::Max(0, $idIdx - 500)
                                $fpResult2 = Find-StringAfterKey $line 'file_path' $fpSearch
                                if ($fpResult2) {
                                    $fp = $fpResult2.Value
                                    break
                                }
                            }
                        }

                        if (-not $fp) { continue }

                        $rel = Normalize-RelPath $fp
                        if (-not $rel) { continue }

                        # Skip build output, binary files
                        $skip = $false
                        foreach ($sp in $skipPatterns) {
                            if ($rel.StartsWith($sp)) { $skip = $true; break }
                        }
                        if ($skip) { continue }
                        $ext = [System.IO.Path]::GetExtension($rel).ToLower()
                        if ($ext -in $skipExtensions) { continue }

                        # Strip line number prefixes
                        $stripped = Strip-ReadPrefix $resultContent

                        if ($stripped.Length -gt 0) {
                            $seq++
                            # Read results: only use if we don't have a newer Write
                            if (-not $recovered.ContainsKey($rel) -or $recoveredSeq[$rel] -lt $seq) {
                                $recovered[$rel] = $stripped
                                $recoveredSeq[$rel] = $seq
                                $readHits++
                            }
                        }
                    }
                }
            }

            # ═══════════════════════════════════════════════════════════
            # Also handle Read results where file_path is NOT on the same line
            # We track Read tool_use IDs and match them on subsequent lines
            # ═══════════════════════════════════════════════════════════

            # ═══════════════════════════════════════════════════════════
            # EDIT TOOL CALLS
            # ═══════════════════════════════════════════════════════════
            if ($line.Contains('"Edit"') -and $line.Contains('file_path') -and $line.Contains('prtask.com')) {
                $searchPos = 0
                while ($true) {
                    $eIdx = $line.IndexOf('"Edit"', $searchPos)
                    if ($eIdx -lt 0) { break }
                    $searchPos = $eIdx + 6

                    $before = $line.Substring([Math]::Max(0, $eIdx - 20), [Math]::Min(20, $eIdx))
                    if ($before -notmatch '"name"\s*:\s*$') { continue }

                    $fpResult = Find-StringAfterKey $line 'file_path' $eIdx
                    if (-not $fpResult) { continue }
                    $filePath = $fpResult.Value

                    $rel = Normalize-RelPath $filePath
                    if (-not $rel) { continue }

                    # Skip build output, binary
                    $skip = $false
                    foreach ($sp in $skipPatterns) {
                        if ($rel.StartsWith($sp)) { $skip = $true; break }
                    }
                    if ($skip) { continue }

                    $oldResult = Find-StringAfterKey $line 'old_string' $fpResult.EndPos
                    if (-not $oldResult) { continue }

                    $newResult = Find-StringAfterKey $line 'new_string' $oldResult.EndPos
                    if (-not $newResult) { continue }

                    # Check for replace_all
                    $replAll = $false
                    $raIdx = $line.IndexOf('"replace_all"', $newResult.EndPos)
                    if ($raIdx -gt 0 -and $raIdx -lt $newResult.EndPos + 100) {
                        $raSub = $line.Substring($raIdx, [Math]::Min(40, $line.Length - $raIdx))
                        if ($raSub -match 'true') { $replAll = $true }
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

Write-Host "`nFirst pass complete."
Write-Host "  Write hits: $writeHits"
Write-Host "  Read hits: $readHits"
Write-Host "  Edit hits: $editHits"
Write-Host "  Files recovered: $($recovered.Count)"
Write-Host "  Total lines: $totalLines"

# ═══════════════════════════════════════════════════════════════════════════
# Second pass: track Read tool_use IDs across lines
# The Read tool_use (with file_path) and tool_result (with content) are
# on SEPARATE lines. We need to correlate them.
# ═══════════════════════════════════════════════════════════════════════════
Write-Host "`n=== Second pass: Cross-line Read result matching ==="

$readToolUseMap = @{}  # tool_use_id → file_path
$readResultsRecovered = 0

foreach ($jf in $jsonlFiles) {
    $reader = [System.IO.StreamReader]::new($jf, [System.Text.Encoding]::UTF8)
    try {
        while ($null -ne ($line = $reader.ReadLine())) {
            if ($line.Length -lt 30) { continue }

            # Track Read tool_use calls (assistant lines)
            if ($line.Contains('"Read"') -and $line.Contains('file_path') -and $line.Contains('prtask.com')) {
                # Find Read tool_use blocks and extract id + file_path
                $searchPos = 0
                while ($true) {
                    $rIdx = $line.IndexOf('"Read"', $searchPos)
                    if ($rIdx -lt 0) { break }
                    $searchPos = $rIdx + 6

                    $before = $line.Substring([Math]::Max(0, $rIdx - 20), [Math]::Min(20, $rIdx))
                    if ($before -notmatch '"name"\s*:\s*$') { continue }

                    # Find "id" field for this tool_use block (usually before "name")
                    $idSearchStart = [Math]::Max(0, $rIdx - 300)
                    $idResult = Find-StringAfterKey $line 'id' $idSearchStart
                    if (-not $idResult) { continue }
                    $toolId = $idResult.Value
                    if ($toolId.Length -lt 5) { continue }

                    # Find file_path
                    $fpResult = Find-StringAfterKey $line 'file_path' $rIdx
                    if (-not $fpResult) { continue }
                    $filePath = $fpResult.Value

                    $rel = Normalize-RelPath $filePath
                    if (-not $rel) { continue }

                    $readToolUseMap[$toolId] = $rel
                }
            }

            # Match tool_result lines
            if ($line.Contains('tool_result') -and ($line.Contains([char]0x2192) -or $line.Contains('\u2192'))) {
                $trSearchPos = 0
                while ($true) {
                    $trIdx = $line.IndexOf('tool_use_id', $trSearchPos)
                    if ($trIdx -lt 0) { break }
                    $trSearchPos = $trIdx + 11

                    $tuIdResult = Find-StringAfterKey $line 'tool_use_id' $trIdx
                    if (-not $tuIdResult) { continue }
                    $toolUseId = $tuIdResult.Value

                    # Look up in our map
                    if (-not $readToolUseMap.ContainsKey($toolUseId)) { continue }
                    $rel = $readToolUseMap[$toolUseId]

                    # Skip build output, binary
                    $skip = $false
                    foreach ($sp in $skipPatterns) {
                        if ($rel.StartsWith($sp)) { $skip = $true; break }
                    }
                    if ($skip) { continue }
                    $ext = [System.IO.Path]::GetExtension($rel).ToLower()
                    if ($ext -in $skipExtensions) { continue }

                    # Find the content
                    $contentResult = Find-StringAfterKey $line 'content' $tuIdResult.EndPos
                    if (-not $contentResult) {
                        # Content might be before tool_use_id
                        $contentResult = Find-StringAfterKey $line 'content' $trIdx
                        if (-not $contentResult) { continue }
                    }
                    $resultContent = $contentResult.Value

                    if ($resultContent.Length -lt 3) { continue }
                    if (-not ($resultContent.Contains([char]0x2192))) { continue }

                    $stripped = Strip-ReadPrefix $resultContent
                    if ($stripped.Length -gt 0) {
                        $seq++
                        # For Read: use it if we don't already have a Write version
                        # or if this is more recent
                        if (-not $recovered.ContainsKey($rel)) {
                            $recovered[$rel] = $stripped
                            $recoveredSeq[$rel] = $seq
                            $readResultsRecovered++
                        }
                    }
                }
            }
        }
    }
    finally {
        $reader.Close()
        $reader.Dispose()
    }
}

Write-Host "Cross-line Read results recovered: $readResultsRecovered"
Write-Host "Total files after Read pass: $($recovered.Count)"

# ═══════════════════════════════════════════════════════════════════════════
# Apply edits in chronological order
# ═══════════════════════════════════════════════════════════════════════════
Write-Host "`n=== Applying $($edits.Count) edits... ==="
$editsApplied = 0
$editsFailed = 0
$editsNoFile = 0

$sortedEdits = $edits | Sort-Object Seq
foreach ($edit in $sortedEdits) {
    $rel = $edit.RelPath
    if (-not $recovered.ContainsKey($rel)) {
        $editsNoFile++
        continue
    }
    $content = $recovered[$rel]
    $oldStr = $edit.OldString
    $newStr = $edit.NewString

    if ($edit.ReplaceAll) {
        if ($content.Contains($oldStr)) {
            $recovered[$rel] = $content.Replace($oldStr, $newStr)
            $editsApplied++
        } else {
            $editsFailed++
        }
    } else {
        $idx = $content.IndexOf($oldStr)
        if ($idx -ge 0) {
            $recovered[$rel] = $content.Substring(0, $idx) + $newStr + $content.Substring($idx + $oldStr.Length)
            $editsApplied++
        } else {
            $editsFailed++
        }
    }
}

Write-Host "Edits applied: $editsApplied"
Write-Host "Edits failed (no match): $editsFailed"
Write-Host "Edits skipped (no file): $editsNoFile"

# ═══════════════════════════════════════════════════════════════════════════
# Write recovered files to disk
# ═══════════════════════════════════════════════════════════════════════════
Write-Host "`n=== Writing $($recovered.Count) recovered files... ==="
$written = 0
$skippedBuild = 0

foreach ($kv in $recovered.GetEnumerator()) {
    $rel = $kv.Key
    $content = $kv.Value

    # Skip build outputs
    $skip = $false
    foreach ($sp in $skipPatterns) {
        if ($rel.StartsWith($sp)) { $skip = $true; break }
    }
    if ($skip) { $skippedBuild++; continue }

    $ext = [System.IO.Path]::GetExtension($rel).ToLower()
    if ($ext -in $skipExtensions) { $skippedBuild++; continue }

    $fullPath = Join-Path $outRoot $rel.Replace('/', '\')
    $dir = [System.IO.Path]::GetDirectoryName($fullPath)
    if (-not (Test-Path $dir)) {
        New-Item -ItemType Directory -Path $dir -Force | Out-Null
    }

    try {
        [System.IO.File]::WriteAllText($fullPath, $content, [System.Text.UTF8Encoding]::new($false))
        $written++
    } catch {
        Write-Host "  ERROR writing ${rel}: $_"
    }
}

# ═══════════════════════════════════════════════════════════════════════════
# Generate report
# ═══════════════════════════════════════════════════════════════════════════
Write-Host "`n=== Generating report... ==="

$allFiles = Get-ChildItem $outRoot -Recurse -File |
            Where-Object {
                $_.FullName -notmatch '\\(publish-output|publish|deploy|deploy-public|output|\.vs|node_modules|bin|obj)\\' -and
                $_.FullName -notmatch '\\(build-output|build_output)' -and
                $_.Name -ne 'recovery-report.txt' -and
                $_.Name -ne 'recovery-report2.txt' -and
                $_.Name -ne 'recover-complete.ps1' -and
                $_.Name -ne 'recover-complete2.ps1'
            }

$csFiles      = @($allFiles | Where-Object { $_.Extension -eq '.cs' })
$gcsFiles     = @($allFiles | Where-Object { $_.Name -like '*.g.cs' })
$csprojFiles  = @($allFiles | Where-Object { $_.Extension -eq '.csproj' })
$razorFiles   = @($allFiles | Where-Object { $_.Extension -eq '.razor' })
$htmlFiles    = @($allFiles | Where-Object { $_.Extension -eq '.html' })
$resxFiles    = @($allFiles | Where-Object { $_.Extension -eq '.resx' })
$xamlFiles    = @($allFiles | Where-Object { $_.Extension -eq '.xaml' })
$scssFiles    = @($allFiles | Where-Object { $_.Extension -in '.scss','.css' })
$tsJsFiles    = @($allFiles | Where-Object { $_.Extension -in '.ts','.js' })
$jsonFiles    = @($allFiles | Where-Object { $_.Extension -eq '.json' })
$slnFiles     = @($allFiles | Where-Object { $_.Extension -eq '.sln' })
$ymlFiles     = @($allFiles | Where-Object { $_.Extension -in '.yml','.yaml' })
$ps1Files     = @($allFiles | Where-Object { $_.Extension -eq '.ps1' })
$mdFiles      = @($allFiles | Where-Object { $_.Extension -eq '.md' })

$report = @"
================================================================
   RECOVERY REPORT v2  -  $(Get-Date -Format 'yyyy-MM-dd HH:mm:ss')
================================================================

INPUT:
  JSONL files scanned    : $($jsonlFiles.Count)
  Total lines parsed     : $totalLines

TOOL HITS:
  Write tool extractions : $writeHits
  Read  tool extractions : $readHits  (same-line) + $readResultsRecovered (cross-line)
  Edit  tool calls       : $editHits  (applied: $editsApplied, failed: $editsFailed, no-file: $editsNoFile)

OUTPUT:
  Files written (source) : $written
  Files skipped (build)  : $skippedBuild
  Total unique paths     : $($recovered.Count)

FILE TYPE BREAKDOWN:
  .cs files      : $($csFiles.Count)
  .g.cs files    : $($gcsFiles.Count)
  .csproj files  : $($csprojFiles.Count)
  .razor files   : $($razorFiles.Count)
  .html files    : $($htmlFiles.Count)
  .resx files    : $($resxFiles.Count)
  .xaml files    : $($xamlFiles.Count)
  .scss/.css     : $($scssFiles.Count)
  .ts/.js files  : $($tsJsFiles.Count)
  .json files    : $($jsonFiles.Count)
  .sln files     : $($slnFiles.Count)
  .yml/.yaml     : $($ymlFiles.Count)
  .ps1 files     : $($ps1Files.Count)
  .md files      : $($mdFiles.Count)

ALL RECOVERED SOURCE FILES (by directory):
"@

$grouped = $allFiles | Group-Object {
    $_.DirectoryName.Replace($outRoot + '\', '').Split('\')[0]
} | Sort-Object Name

foreach ($g in $grouped) {
    $report += "`n  === $($g.Name) === ($($g.Count) files)`n"
    foreach ($f in ($g.Group | Sort-Object FullName)) {
        $report += "    $($f.FullName.Replace($outRoot + '\', ''))`n"
    }
}

$report | Out-File $reportPath -Encoding utf8
Write-Host $report
Write-Host "`nReport saved to: $reportPath"
