## recover-complete.ps1  —  Comprehensive source-code recovery from Claude JSONL logs
## Processes Write, Read, and Edit tool interactions from all conversation logs.

$ErrorActionPreference = 'Continue'
$logDir   = 'C:/Users/user/.claude/projects/C--work-prtask-com'
$outRoot  = 'C:/work/prtask.com'
$reportPath = "$outRoot/recovery-report.txt"

# ── Gather all JSONL files ──────────────────────────────────────────────────
$jsonlFiles = Get-ChildItem $logDir -Filter '*.jsonl' -Recurse |
              Sort-Object LastWriteTime |
              Select-Object -ExpandProperty FullName
Write-Host "Found $($jsonlFiles.Count) JSONL files to scan"

# ── State: file_path → { Content, Order, Source } ──────────────────────────
$recovered = @{}   # path → latest content
$order     = @{}   # path → sequence number (for "latest wins")
$edits     = [System.Collections.Generic.List[psobject]]::new()  # deferred edits
$seq = 0
$totalLines = 0
$parseErrors = 0
$writeHits = 0
$readHits  = 0
$editHits  = 0
$bashWriteHits = 0

# We only recover files whose path starts with one of these prefixes
$validPrefixes = @(
    'C:/work/prtask.com/',
    'C:\work\prtask.com\',
    'c:/work/prtask.com/',
    'c:\work\prtask.com\',
    '/c/work/prtask.com/'
)

function Test-ValidPath([string]$p) {
    foreach ($pfx in $validPrefixes) {
        if ($p.StartsWith($pfx, [System.StringComparison]::OrdinalIgnoreCase)) { return $true }
    }
    return $false
}

function Normalize-Path([string]$p) {
    # Convert to forward-slash, strip known prefixes to get relative path
    $p = $p.Replace('\', '/')
    foreach ($pfx in @('C:/work/prtask.com/','c:/work/prtask.com/','/c/work/prtask.com/')) {
        if ($p.StartsWith($pfx, [System.StringComparison]::OrdinalIgnoreCase)) {
            return $p.Substring($pfx.Length)
        }
    }
    return $p
}

function Strip-ReadPrefix([string]$text) {
    # Read tool output format: "     1\tcontent line" where \t is a tab character
    # Each line has optional spaces, a line number, then a tab, then the actual content
    $lines = $text -split "`n"
    $result = [System.Collections.Generic.List[string]]::new($lines.Count)
    foreach ($line in $lines) {
        # Match: optional spaces, digits, tab, then content
        if ($line -match '^\s*\d+\t(.*)$') {
            $result.Add($Matches[1])
        }
        elseif ($line -match '^\s*\d+\xE2\x86\x92(.*)$') {
            # UTF-8 arrow character →
            $result.Add($Matches[1])
        }
        elseif ($line -eq '') {
            # skip trailing empty lines
        }
        else {
            # Could be continuation or non-numbered content
            $result.Add($line)
        }
    }
    return ($result -join "`n")
}

# ── Process each JSONL file ─────────────────────────────────────────────────
$fileNum = 0
foreach ($jf in $jsonlFiles) {
    $fileNum++
    $fname = [System.IO.Path]::GetFileName($jf)
    $sizeMB = [math]::Round((Get-Item $jf).Length / 1MB, 1)
    Write-Host "[$fileNum/$($jsonlFiles.Count)] Processing $fname ($sizeMB MB)..."

    $reader = [System.IO.StreamReader]::new($jf, [System.Text.Encoding]::UTF8)
    $lineNum = 0
    try {
        while ($null -ne ($line = $reader.ReadLine())) {
            $lineNum++
            $totalLines++
            if ($line.Length -lt 20) { continue }

            # Quick pre-filter: only parse lines that mention relevant tool names
            $hasWrite = $line.Contains('"Write"') -or $line.Contains('"write"')
            $hasRead  = $line.Contains('"Read"') -or $line.Contains('"read"')
            $hasEdit  = $line.Contains('"Edit"') -or $line.Contains('"edit"')
            $hasBash  = $line.Contains('"Bash"') -or $line.Contains('"Pwsh"')
            $hasFilePath = $line.Contains('file_path') -or $line.Contains('prtask.com')

            if (-not ($hasFilePath -or $hasWrite -or $hasRead -or $hasEdit)) { continue }

            try {
                $obj = $line | ConvertFrom-Json -Depth 20
            } catch {
                $parseErrors++
                continue
            }

            # ── Navigate the JSON structure to find tool uses ───────────
            # Claude logs can nest tool calls in various ways.
            # We search recursively for tool_use blocks.

            $toolUses = [System.Collections.Generic.List[psobject]]::new()
            $toolResults = [System.Collections.Generic.List[psobject]]::new()

            # Recursive extraction function
            function Extract-ToolCalls($node, [string]$path) {
                if ($null -eq $node) { return }
                if ($node -is [System.Collections.IList]) {
                    foreach ($item in $node) { Extract-ToolCalls $item "$path[]" }
                    return
                }
                if ($node -is [psobject] -or $node -is [System.Collections.IDictionary]) {
                    $type = $null
                    $name = $null
                    $input = $null
                    $content = $null

                    if ($node.PSObject.Properties['type']) { $type = $node.type }
                    if ($node.PSObject.Properties['name']) { $name = $node.name }
                    if ($node.PSObject.Properties['input']) { $input = $node.input }
                    if ($node.PSObject.Properties['content']) { $content = $node.content }

                    if ($type -eq 'tool_use' -and $name -and $input) {
                        $toolUses.Add($node)
                    }
                    if ($type -eq 'tool_result' -and $content) {
                        $toolResults.Add($node)
                    }

                    foreach ($prop in $node.PSObject.Properties) {
                        if ($prop.Value -is [psobject] -or $prop.Value -is [System.Collections.IList]) {
                            Extract-ToolCalls $prop.Value "$path.$($prop.Name)"
                        }
                    }
                }
            }

            Extract-ToolCalls $obj ''

            # Also check for a simpler structure: message.content[]
            if ($obj.PSObject.Properties['message']) {
                $msg = $obj.message
                if ($msg.PSObject.Properties['content'] -and $msg.content -is [System.Collections.IList]) {
                    foreach ($block in $msg.content) {
                        if ($block.PSObject.Properties['type'] -and $block.type -eq 'tool_use') {
                            if (-not $toolUses.Contains($block)) { $toolUses.Add($block) }
                        }
                    }
                }
            }

            # Process Write tool calls
            foreach ($tu in $toolUses) {
                if ($tu.name -ne 'Write') { continue }
                $inp = $tu.input
                if (-not $inp) { continue }
                $fp = $null; $ct = $null
                if ($inp.PSObject.Properties['file_path']) { $fp = $inp.file_path }
                if ($inp.PSObject.Properties['content'])   { $ct = $inp.content }
                if (-not $fp -or -not $ct) { continue }
                if (-not (Test-ValidPath $fp)) { continue }

                $seq++
                $rel = Normalize-Path $fp
                $recovered[$rel] = $ct
                $order[$rel] = $seq
                $writeHits++
            }

            # Process Edit tool calls
            foreach ($tu in $toolUses) {
                if ($tu.name -ne 'Edit') { continue }
                $inp = $tu.input
                if (-not $inp) { continue }
                $fp = $null; $old = $null; $new = $null; $replAll = $false
                if ($inp.PSObject.Properties['file_path'])   { $fp = $inp.file_path }
                if ($inp.PSObject.Properties['old_string'])   { $old = $inp.old_string }
                if ($inp.PSObject.Properties['new_string'])   { $new = $inp.new_string }
                if ($inp.PSObject.Properties['replace_all'])  { $replAll = $inp.replace_all }
                if (-not $fp -or $null -eq $old -or $null -eq $new) { continue }
                if (-not (Test-ValidPath $fp)) { continue }

                $seq++
                $rel = Normalize-Path $fp
                $edits.Add([pscustomobject]@{
                    RelPath    = $rel
                    OldString  = $old
                    NewString  = $new
                    ReplaceAll = $replAll
                    Seq        = $seq
                })
                $editHits++
            }

            # Process Read tool — we need to match tool_use (has file_path) with tool_result (has content)
            # In Claude logs, Read results appear as tool_result blocks with text content
            foreach ($tu in $toolUses) {
                if ($tu.name -ne 'Read') { continue }
                $inp = $tu.input
                if (-not $inp) { continue }
                $fp = $null
                if ($inp.PSObject.Properties['file_path']) { $fp = $inp.file_path }
                if (-not $fp) { continue }
                if (-not (Test-ValidPath $fp)) { continue }

                $rel = Normalize-Path $fp
                $tuId = $null
                if ($tu.PSObject.Properties['id']) { $tuId = $tu.id }

                # Find matching tool_result by tool_use_id
                foreach ($tr in $toolResults) {
                    $trTuId = $null
                    if ($tr.PSObject.Properties['tool_use_id']) { $trTuId = $tr.tool_use_id }
                    if ($tuId -and $trTuId -and $tuId -eq $trTuId) {
                        $resultText = ''
                        if ($tr.content -is [string]) {
                            $resultText = $tr.content
                        }
                        elseif ($tr.content -is [System.Collections.IList]) {
                            foreach ($cb in $tr.content) {
                                if ($cb.PSObject.Properties['text']) {
                                    $resultText = $cb.text
                                    break
                                }
                            }
                        }
                        if ($resultText -and $resultText.Length -gt 5) {
                            $stripped = Strip-ReadPrefix $resultText
                            if ($stripped.Length -gt 0) {
                                $seq++
                                # Only store Read result if we don't already have a Write for this file
                                # (Write is authoritative, Read may be partial)
                                if (-not $recovered.ContainsKey($rel) -or $order[$rel] -lt $seq) {
                                    # For Read results, only keep if file doesn't exist from Write
                                    # or if this Read is newer
                                    if (-not $recovered.ContainsKey($rel)) {
                                        $recovered[$rel] = $stripped
                                        $order[$rel] = $seq
                                        $readHits++
                                    }
                                }
                            }
                        }
                    }
                }
            }

            # Also look for Read results that appear inline (different JSON structure)
            # Some logs have the result directly in a content block with tool_use_id referencing a Read
        }
    }
    finally {
        $reader.Close()
        $reader.Dispose()
    }
    Write-Host "  Lines: $lineNum | Recovered so far: $($recovered.Count) files"
}

# ── Second pass: look for Read tool results in a different format ──────────
# Some JSONL files store tool results separately from tool calls
Write-Host "`n=== Second pass: scanning for standalone Read results ==="

foreach ($jf in $jsonlFiles) {
    $fileNum++
    $reader = [System.IO.StreamReader]::new($jf, [System.Text.Encoding]::UTF8)
    try {
        while ($null -ne ($line = $reader.ReadLine())) {
            if ($line.Length -lt 50) { continue }
            if (-not $line.Contains('prtask.com')) { continue }

            # Look for patterns like: "file_path": "C:/work/prtask.com/..." followed by numbered content
            # This handles cases where Read results are in content arrays

            try {
                $obj = $line | ConvertFrom-Json -Depth 15
            } catch { continue }

            # Check for tool_result type with content that looks like Read output
            if ($obj.PSObject.Properties['type'] -and $obj.type -eq 'tool_result') {
                # Skip — already handled above
                continue
            }

            # Check for content blocks that contain Read results
            if ($obj.PSObject.Properties['content'] -and $obj.content -is [System.Collections.IList]) {
                foreach ($block in $obj.content) {
                    if ($block.PSObject.Properties['type'] -and $block.type -eq 'tool_result') {
                        if ($block.PSObject.Properties['tool_use_id']) {
                            # This is a result block — check if it contains numbered lines
                            $resultText = ''
                            if ($block.PSObject.Properties['content']) {
                                if ($block.content -is [string]) {
                                    $resultText = $block.content
                                }
                                elseif ($block.content -is [System.Collections.IList]) {
                                    foreach ($cb in $block.content) {
                                        if ($cb.PSObject.Properties['text']) {
                                            $resultText += $cb.text
                                        }
                                    }
                                }
                            }
                            # Check if it looks like Read output (has numbered lines)
                            if ($resultText -match '^\s*1\t') {
                                # We need to find the matching tool_use to get the file_path
                                # Look in the same line's content for a tool_use with matching id
                                $tuId = $block.tool_use_id
                                foreach ($otherBlock in $obj.content) {
                                    if ($otherBlock.PSObject.Properties['type'] -and $otherBlock.type -eq 'tool_use' -and
                                        $otherBlock.PSObject.Properties['name'] -and $otherBlock.name -eq 'Read' -and
                                        $otherBlock.PSObject.Properties['id'] -and $otherBlock.id -eq $tuId) {
                                        $fp = $otherBlock.input.file_path
                                        if ($fp -and (Test-ValidPath $fp)) {
                                            $rel = Normalize-Path $fp
                                            if (-not $recovered.ContainsKey($rel)) {
                                                $stripped = Strip-ReadPrefix $resultText
                                                if ($stripped.Length -gt 0) {
                                                    $seq++
                                                    $recovered[$rel] = $stripped
                                                    $order[$rel] = $seq
                                                    $readHits++
                                                }
                                            }
                                        }
                                    }
                                }
                            }
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

# ── Apply edits in order ────────────────────────────────────────────────────
Write-Host "`n=== Applying $($edits.Count) edits... ==="
$editsApplied = 0
$editsFailed = 0

# Sort edits by sequence number
$sortedEdits = $edits | Sort-Object Seq

foreach ($edit in $sortedEdits) {
    $rel = $edit.RelPath
    if (-not $recovered.ContainsKey($rel)) {
        $editsFailed++
        continue
    }
    $content = $recovered[$rel]
    if ($edit.ReplaceAll) {
        $newContent = $content.Replace($edit.OldString, $edit.NewString)
    } else {
        # Replace first occurrence only
        $idx = $content.IndexOf($edit.OldString)
        if ($idx -ge 0) {
            $newContent = $content.Substring(0, $idx) + $edit.NewString + $content.Substring($idx + $edit.OldString.Length)
        } else {
            $editsFailed++
            continue
        }
    }
    if ($newContent -ne $content) {
        $recovered[$rel] = $newContent
        $editsApplied++
    } else {
        $editsFailed++
    }
}

Write-Host "Edits applied: $editsApplied, failed: $editsFailed"

# ── Write recovered files ──────────────────────────────────────────────────
Write-Host "`n=== Writing $($recovered.Count) recovered files... ==="
$written = 0
$skipped = 0

foreach ($kv in $recovered.GetEnumerator()) {
    $rel = $kv.Key
    $content = $kv.Value

    # Skip non-source files (build outputs, node_modules, bin, obj, etc.)
    if ($rel -match '^(publish-output/|publish/|deploy/|deploy-public/|output/|build-output|build_output|node_modules/|\.vs/)') {
        $skipped++
        continue
    }
    # Skip binary/image files that would be corrupted
    if ($rel -match '\.(png|jpg|jpeg|gif|ico|woff|woff2|ttf|eot|dll|exe|pdb|nupkg|snk|pfx|p12|wasm)$') {
        $skipped++
        continue
    }

    $fullPath = Join-Path $outRoot $rel
    $dir = [System.IO.Path]::GetDirectoryName($fullPath)
    if (-not (Test-Path $dir)) {
        New-Item -ItemType Directory -Path $dir -Force | Out-Null
    }

    # Write with UTF8 no BOM
    [System.IO.File]::WriteAllText($fullPath, $content, [System.Text.UTF8Encoding]::new($false))
    $written++
}

# ── Generate report ─────────────────────────────────────────────────────────
Write-Host "`n=== Generating report... ==="

$allFiles = Get-ChildItem $outRoot -Recurse -File |
            Where-Object { $_.FullName -notmatch '\\(publish-output|publish|deploy|deploy-public|output|\.vs|node_modules|bin|obj)\\' }

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
$mdFiles      = @($allFiles | Where-Object { $_.Extension -eq '.md' })
$ps1Files     = @($allFiles | Where-Object { $_.Extension -eq '.ps1' })

$report = @"
================================================================
   RECOVERY REPORT  —  $(Get-Date -Format 'yyyy-MM-dd HH:mm:ss')
================================================================

INPUT:
  JSONL files scanned : $($jsonlFiles.Count)
  Total lines parsed  : $totalLines
  Parse errors (skipped): $parseErrors

TOOL HITS:
  Write tool extractions : $writeHits
  Read  tool extractions : $readHits
  Edit  tool calls       : $editHits  (applied: $editsApplied, failed: $editsFailed)

OUTPUT:
  Files recovered (source) : $written
  Files skipped (build/bin) : $skipped
  Total unique paths found  : $($recovered.Count)

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
  .md files      : $($mdFiles.Count)
  .ps1 files     : $($ps1Files.Count)

ALL RECOVERED FILES:
$($allFiles | ForEach-Object { "  $($_.FullName.Replace($outRoot + '\',''))" } | Sort-Object | Out-String)
"@

$report | Out-File $reportPath -Encoding utf8
Write-Host $report
Write-Host "`nReport saved to: $reportPath"
