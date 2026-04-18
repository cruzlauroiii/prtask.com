param([string]$ResxPath = 'C:\work\prtask.com\src\PrTask.SharedUI\Resources\SharedResource.zh.resx')

$OutputFiles = @(
    'C:\Users\user\AppData\Local\Temp\claude\C--work-prtask-com\0da18213-ce9a-4401-913a-b80e756fa71d\tasks\a48ad618fca15b9a0.output',
    'C:\Users\user\AppData\Local\Temp\claude\C--work-prtask-com\0da18213-ce9a-4401-913a-b80e756fa71d\tasks\a67c8793ba0e2eac0.output',
    'C:\Users\user\AppData\Local\Temp\claude\C--work-prtask-com\0da18213-ce9a-4401-913a-b80e756fa71d\tasks\aca960838b6a8daa8.output',
    'C:\Users\user\AppData\Local\Temp\claude\C--work-prtask-com\0da18213-ce9a-4401-913a-b80e756fa71d\tasks\a017a468809aece72.output',
    'C:\Users\user\AppData\Local\Temp\claude\C--work-prtask-com\0da18213-ce9a-4401-913a-b80e756fa71d\tasks\a3ad1f104e14086fd.output',
    'C:\Users\user\AppData\Local\Temp\claude\C--work-prtask-com\0da18213-ce9a-4401-913a-b80e756fa71d\tasks\a2ff741cfffeed062.output'
)

[xml]$Zh = Get-Content $ResxPath -Encoding UTF8
$ExistingKeys = @{}
foreach ($d in $Zh.root.data) { $ExistingKeys[$d.name] = $true }

$NewEntries = [System.Collections.Generic.List[object]]::new()

foreach ($File in $OutputFiles) {
    if (-not (Test-Path $File)) { Write-Warning "Not found: $File"; continue }
    $RawLines = [System.IO.File]::ReadAllLines($File, [System.Text.Encoding]::UTF8)
    # Find last assistant message in JSONL
    $Text = $null
    for ($i = $RawLines.Count - 1; $i -ge 0; $i--) {
        $Line = $RawLines[$i]
        if ($Line -match '"type":"assistant"') {
            $Json = $Line | ConvertFrom-Json
            foreach ($C in $Json.message.content) {
                if ($C.type -eq 'text') { $Text = $C.text; break }
            }
            if ($Text) { break }
        }
    }
    if (-not $Text) { Write-Warning "No assistant text in $File"; continue }

    $TextLines = $Text -split "`n"
    foreach ($TLine in $TextLines) {
        if ($TLine -match "^'([^']+)'\s*=\s*'(.*)'`$") {
            $Key = $Matches[1]
            $Value = $Matches[2]
            if (-not $ExistingKeys.ContainsKey($Key)) {
                $NewEntries.Add([PSCustomObject]@{ Key = $Key; Value = $Value })
                $ExistingKeys[$Key] = $true
            }
        }
    }
}

Write-Host "New entries to add: $($NewEntries.Count)"

foreach ($Entry in $NewEntries) {
    $DataNode = $Zh.CreateElement('data')
    $DataNode.SetAttribute('name', $Entry.Key)
    $DataNode.SetAttribute('xml:space', 'preserve')
    $ValueNode = $Zh.CreateElement('value')
    $ValueNode.InnerText = $Entry.Value
    $DataNode.AppendChild($ValueNode) | Out-Null
    $Zh.root.AppendChild($DataNode) | Out-Null
}

$Settings = [System.Xml.XmlWriterSettings]::new()
$Settings.Encoding = [System.Text.UTF8Encoding]::new($false)
$Settings.Indent = $true
$Settings.IndentChars = '  '
$Writer = [System.Xml.XmlWriter]::Create($ResxPath, $Settings)
$Zh.Save($Writer)
$Writer.Flush()
$Writer.Dispose()

Write-Host "Done. Total zh keys now:"
([xml](Get-Content $ResxPath -Encoding UTF8)).root.data.Count
