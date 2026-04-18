$OutputFile = 'C:\Users\user\AppData\Local\Temp\claude\C--work-prtask-com\0da18213-ce9a-4401-913a-b80e756fa71d\tasks\ab5b0f7fdcd58e3a1.output'
$ResxPath = 'C:\work\prtask.com\src\PrTask.SharedUI\Resources\SharedResource.zh.resx'
$PatchScript = 'C:\work\prtask.com\scripts\patch-zh-translations.ps1'

$RawLines = [System.IO.File]::ReadAllLines($OutputFile, [System.Text.Encoding]::UTF8)
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

if (-not $Text) { Write-Error 'No text found'; exit 1 }

$Updates = [ordered]@{}
foreach ($TLine in ($Text -split "`n")) {
    if ($TLine -match "^'([^']+)'\s*=\s*'(.*)'$") {
        $Updates[$Matches[1]] = $Matches[2]
    }
}

Write-Host "Found $($Updates.Count) translations"

$JsonPath = [System.IO.Path]::GetTempFileName() + '.json'
$Updates | ConvertTo-Json -Depth 2 | Set-Content $JsonPath -Encoding UTF8
& $PatchScript -ResxPath $ResxPath -JsonPath $JsonPath
Remove-Item $JsonPath -Force
