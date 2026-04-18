# PrTask Source Code Recovery Script
# Extracts file contents from Claude conversation JSONL logs
# Processes Write tool calls and Read tool results to recover source files

param(
    [string]$LogDir = "C:/Users/user/.claude/projects/C--work-prtask-com",
    [string]$OutputDir = "C:/work/prtask.com",
    [switch]$DryRun
)

$ErrorActionPreference = 'Continue'

# File extensions we want to recover
$WantedExtensions = @(
    '.cs', '.csproj', '.razor', '.html', '.js', '.json', '.css', '.scss',
    '.sln', '.props', '.targets', '.xaml', '.xml', '.resx',
    '.md', '.gitignore', '.editorconfig', '.config',
    '.ps1', '.sh', '.bat', '.cmd',
    '.ts', '.tsx', '.jsx', '.mjs',
    '.svg', '.ico', '.txt',
    '.lock', '.toml', '.yaml', '.yml',
    '.wasm', '.worker'
)

# Paths we want to recover (prefix match)
$WantedPrefixes = @(
    'C:\work\prtask.com\src\',
    'C:\work\prtask.com\tests\',
    'C:\work\prtask.com\infra\',
    'C:\work\prtask.com\scripts\',
    'C:/work/prtask.com/src/',
    'C:/work/prtask.com/tests/',
    'C:/work/prtask.com/infra/',
    'C:/work/prtask.com/scripts/'
)

# Root-level files we also want
$WantedRootFiles = @(
    'CLAUDE.md', 'RULES.md', '.gitignore', '.editorconfig', '.nojekyll',
    'RULES-00-quick-reference.md', 'RULES-01-architecture-core.md',
    'RULES-02-services-data.md', 'RULES-03-pages-constants.md',
    'RULES-04-infrastructure-platform.md', 'RULES-05-maui-desktop.md',
    'PrTask.sln', 'Directory.Build.props', 'Directory.Build.targets',
    'Directory.Packages.props', 'package.json', 'nuget.config',
    'global.json', '.eslintrc.json', '.stylelintrc.json',
    'eslint.config.mjs', 'eslint.config.js', '.stylelintrc.mjs'
)

function Test-WantedFile {
    param([string]$FilePath)

    # Normalize path
    $Normalized = $FilePath.Replace('\', '/')

    # Skip publish-output, deploy, output, node_modules, bin, obj, .claude
    if ($Normalized -match '/(publish-output|publish|deploy|output|node_modules|bin/|obj/|\.claude|\.vs|\.git/)') {
        return $false
    }

    # Check if it's a root-level wanted file
    foreach ($RootFile in $WantedRootFiles) {
        if ($Normalized -eq "C:/work/prtask.com/$RootFile") {
            return $true
        }
    }

    # Check prefix match
    $NormalizedLower = $Normalized.ToLower()
    foreach ($Prefix in $WantedPrefixes) {
        $PrefixNorm = $Prefix.Replace('\', '/').ToLower()
        if ($NormalizedLower.StartsWith($PrefixNorm)) {
            # Check extension
            $Ext = [System.IO.Path]::GetExtension($Normalized).ToLower()
            if ($Ext -in $WantedExtensions -or $Ext -eq '') {
                return $true
            }
        }
    }

    return $false
}

function Normalize-Path {
    param([string]$FilePath)
    return $FilePath.Replace('\', '/').Replace('//', '/')
}

# Dictionary to track latest version of each file
# Key: normalized path, Value: @{ Content; LineNumber; SourceFile; Timestamp }
$FileVersions = @{}

# Get all JSONL files sorted by modification time (oldest first so latest overwrites)
$JsonlFiles = Get-ChildItem $LogDir -Filter "*.jsonl" | Sort-Object LastWriteTime

Write-Host "Found $($JsonlFiles.Count) JSONL files to process"
Write-Host "Total size: $([math]::Round(($JsonlFiles | Measure-Object Length -Sum).Sum / 1MB, 1)) MB"
Write-Host ""

$TotalLines = 0
$TotalWrites = 0
$TotalReads = 0
$TotalEdits = 0

foreach ($JsonlFile in $JsonlFiles) {
    $FileName = $JsonlFile.Name
    $SizeMB = [math]::Round($JsonlFile.Length / 1MB, 1)
    Write-Host "Processing $FileName ($SizeMB MB)..." -NoNewline

    $Reader = [System.IO.StreamReader]::new($JsonlFile.FullName, [System.Text.Encoding]::UTF8)
    $LineNum = 0
    $FileWrites = 0
    $FileReads = 0
    $FileEdits = 0

    while ($null -ne ($Line = $Reader.ReadLine())) {
        $LineNum++

        # Quick string checks before expensive JSON parsing
        $HasWrite = $Line.Contains('"Write"') -and $Line.Contains('"file_path"') -and $Line.Contains('"content"')
        $HasRead = $Line.Contains('"toolUseResult"') -and $Line.Contains('"filePath"') -and $Line.Contains('"content"')
        $HasEdit = $Line.Contains('"Edit"') -and $Line.Contains('"file_path"') -and $Line.Contains('"old_string"') -and $Line.Contains('"new_string"')

        if (-not $HasWrite -and -not $HasRead -and -not $HasEdit) {
            continue
        }

        try {
            $Json = $Line | ConvertFrom-Json -Depth 20
        }
        catch {
            continue
        }

        # Extract timestamp for ordering
        $Timestamp = $null
        if ($Json.timestamp) {
            $Timestamp = $Json.timestamp
        }
        elseif ($Json.PSObject.Properties['message'] -and $Json.message.PSObject.Properties['timestamp']) {
            $Timestamp = $Json.message.timestamp
        }

        # Process Write tool calls
        if ($HasWrite) {
            # The content array in message.content has tool_use objects
            $ContentItems = $null
            if ($Json.message -and $Json.message.content) {
                $ContentItems = $Json.message.content
            }
            elseif ($Json.data -and $Json.data.message -and $Json.data.message.message -and $Json.data.message.message.content) {
                # progress type
                $ContentItems = $Json.data.message.message.content
            }

            if ($ContentItems) {
                foreach ($Item in $ContentItems) {
                    if ($Item.type -eq 'tool_use' -and $Item.name -eq 'Write' -and $Item.input) {
                        $FilePath = $Item.input.file_path
                        $Content = $Item.input.content

                        if ($FilePath -and $Content -and (Test-WantedFile $FilePath)) {
                            $NormPath = Normalize-Path $FilePath
                            $Key = $NormPath.ToLower()

                            $FileVersions[$Key] = @{
                                Path = $NormPath
                                Content = $Content
                                LineNumber = $LineNum
                                SourceFile = $FileName
                                Timestamp = $Timestamp
                                Type = 'Write'
                            }
                            $FileWrites++
                        }
                    }
                }
            }
        }

        # Process Read tool results
        if ($HasRead) {
            $ToolResult = $null
            if ($Json.toolUseResult -and $Json.toolUseResult.file) {
                $ToolResult = $Json.toolUseResult.file
            }

            if ($ToolResult -and $ToolResult.filePath -and $ToolResult.content) {
                $FilePath = $ToolResult.filePath
                $Content = $ToolResult.content
                $StartLine = if ($ToolResult.startLine) { $ToolResult.startLine } else { 1 }
                $TotalFileLines = if ($ToolResult.totalLines) { $ToolResult.totalLines } else { 0 }
                $NumLines = if ($ToolResult.numLines) { $ToolResult.numLines } else { 0 }

                # Only use Read results if they contain the FULL file (startLine=1 and numLines=totalLines)
                $IsFullFile = ($StartLine -eq 1) -and ($TotalFileLines -gt 0) -and ($NumLines -ge $TotalFileLines)

                if ($IsFullFile -and (Test-WantedFile $FilePath)) {
                    $NormPath = Normalize-Path $FilePath
                    $Key = $NormPath.ToLower()

                    # Only use Read if we don't already have a Write for this file from THIS or LATER file
                    if (-not $FileVersions.ContainsKey($Key) -or $FileVersions[$Key].Type -ne 'Write') {
                        $FileVersions[$Key] = @{
                            Path = $NormPath
                            Content = $Content
                            LineNumber = $LineNum
                            SourceFile = $FileName
                            Timestamp = $Timestamp
                            Type = 'Read'
                        }
                        $FileReads++
                    }
                }
            }
        }

        # Process Edit tool calls - apply old_string -> new_string replacement
        if ($HasEdit) {
            $ContentItems = $null
            if ($Json.message -and $Json.message.content) {
                $ContentItems = $Json.message.content
            }
            elseif ($Json.data -and $Json.data.message -and $Json.data.message.message -and $Json.data.message.message.content) {
                $ContentItems = $Json.data.message.message.content
            }

            if ($ContentItems) {
                foreach ($Item in $ContentItems) {
                    if ($Item.type -eq 'tool_use' -and $Item.name -eq 'Edit' -and $Item.input) {
                        $FilePath = $Item.input.file_path
                        $OldString = $Item.input.old_string
                        $NewString = $Item.input.new_string
                        $ReplaceAll = $false
                        if ($Item.input.PSObject.Properties['replace_all']) {
                            $ReplaceAll = $Item.input.replace_all
                        }

                        if ($FilePath -and (Test-WantedFile $FilePath)) {
                            $NormPath = Normalize-Path $FilePath
                            $Key = $NormPath.ToLower()

                            if ($FileVersions.ContainsKey($Key) -and $OldString -and $null -ne $NewString) {
                                $ExistingContent = $FileVersions[$Key].Content
                                if ($ExistingContent.Contains($OldString)) {
                                    if ($ReplaceAll) {
                                        $UpdatedContent = $ExistingContent.Replace($OldString, $NewString)
                                    }
                                    else {
                                        # Replace first occurrence only
                                        $Idx = $ExistingContent.IndexOf($OldString)
                                        if ($Idx -ge 0) {
                                            $UpdatedContent = $ExistingContent.Substring(0, $Idx) + $NewString + $ExistingContent.Substring($Idx + $OldString.Length)
                                        }
                                        else {
                                            $UpdatedContent = $ExistingContent
                                        }
                                    }
                                    $FileVersions[$Key].Content = $UpdatedContent
                                    $FileVersions[$Key].LineNumber = $LineNum
                                    $FileVersions[$Key].SourceFile = $FileName
                                    $FileVersions[$Key].Timestamp = $Timestamp
                                    $FileVersions[$Key].Type = 'Edit'
                                    $FileEdits++
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    $Reader.Close()
    $TotalLines += $LineNum
    $TotalWrites += $FileWrites
    $TotalReads += $FileReads
    $TotalEdits += $FileEdits
    Write-Host " $LineNum lines, $FileWrites writes, $FileReads reads, $FileEdits edits"
}

Write-Host ""
Write-Host "=== SUMMARY ==="
Write-Host "Total lines processed: $TotalLines"
Write-Host "Total Write extractions: $TotalWrites"
Write-Host "Total Read extractions: $TotalReads"
Write-Host "Total Edit applications: $TotalEdits"
Write-Host "Unique files to recover: $($FileVersions.Count)"
Write-Host ""

# Write files
$Written = 0
$Errors = 0

foreach ($Entry in $FileVersions.GetEnumerator()) {
    $Info = $Entry.Value
    $FilePath = $Info.Path

    # Convert to local Windows path
    $LocalPath = $FilePath
    if ($LocalPath.StartsWith('C:/')) {
        $LocalPath = $LocalPath.Replace('/', '\')
    }

    if ($DryRun) {
        Write-Host "[DRY RUN] Would write: $LocalPath (from $($Info.SourceFile) line $($Info.LineNumber), type=$($Info.Type))"
        $Written++
        continue
    }

    try {
        $Dir = [System.IO.Path]::GetDirectoryName($LocalPath)
        if (-not (Test-Path $Dir)) {
            New-Item -ItemType Directory -Path $Dir -Force | Out-Null
        }

        # Write with UTF-8 no BOM
        $Utf8NoBom = [System.Text.UTF8Encoding]::new($false)
        [System.IO.File]::WriteAllText($LocalPath, $Info.Content, $Utf8NoBom)
        $Written++
    }
    catch {
        Write-Host "ERROR writing $LocalPath : $_" -ForegroundColor Red
        $Errors++
    }
}

Write-Host ""
Write-Host "=== RESULT ==="
Write-Host "Files written: $Written"
Write-Host "Errors: $Errors"
Write-Host ""

# List recovered files grouped by directory
Write-Host "=== RECOVERED FILES ==="
$FileVersions.Values |
    Sort-Object { $_.Path } |
    ForEach-Object {
        $RelPath = $_.Path.Replace('C:/work/prtask.com/', '')
        Write-Host "  $RelPath ($($_.Type) from $($_.SourceFile))"
    }
