$BaseDir = 'C:\Users\user\AppData\Local\Temp\claude\C--work-prtask-com\0da18213-ce9a-4401-913a-b80e756fa71d\tasks'
$PatchScript = 'C:\work\prtask.com\scripts\patch-zh-translations.ps1'
$ResxBase = 'C:\work\prtask.com\src\PrTask.SharedUI\Resources\SharedResource'

$Languages = @{
    'ar' = 'a7f477c98433e45bc.output'
    'hi' = 'afe0c3bc72e32e7ee.output'
    'ja' = 'a0f8b140b891cd67e.output'
    'ko' = 'aa9c2ed927961f993.output'
    'ru' = 'ab050374fad66b075.output'
}

foreach ($Lang in $Languages.Keys) {
    $OutputFile = Join-Path $BaseDir $Languages[$Lang]
    $ResxPath = "$ResxBase.$Lang.resx"
    $JsonPath = [System.IO.Path]::GetTempFileName() + '.json'

    if (-not (Test-Path $OutputFile)) { Write-Warning "Not found: $OutputFile"; continue }
    if (-not (Test-Path $ResxPath)) { Write-Warning "Not found: $ResxPath"; continue }

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

    if (-not $Text) { Write-Warning "No assistant text in $OutputFile"; continue }

    $Updates = [ordered]@{}
    $TextLines = $Text -split "`n"
    foreach ($TLine in $TextLines) {
        if ($TLine -match "^'([^']+)'\s*=\s*'(.*)'$") {
            $Key = $Matches[1]
            $Value = $Matches[2]
            $Updates[$Key] = $Value
        }
    }

    Write-Host "$Lang`: found $($Updates.Count) entries"

    if ($Updates.Count -eq 0) { continue }

    $Updates | ConvertTo-Json -Depth 2 | Set-Content $JsonPath -Encoding UTF8
    & $PatchScript -ResxPath $ResxPath -JsonPath $JsonPath
    Remove-Item $JsonPath -Force
}

Write-Host 'Done patching all languages.'
