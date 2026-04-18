$ResxDir = "C:\work\prtask.com\src\PrTask.SharedUI\Resources"
$EnXml  = [xml][System.IO.File]::ReadAllText("$ResxDir\SharedResource.resx", [System.Text.Encoding]::UTF8)
$ZhXml  = [xml][System.IO.File]::ReadAllText("$ResxDir\SharedResource.zh.resx", [System.Text.Encoding]::UTF8)
$EnMap = @{}; foreach ($d in $EnXml.root.data) { $EnMap[$d.name] = $d.value }
$ZhMap = @{}; foreach ($d in $ZhXml.root.data) { $ZhMap[$d.name] = $d.value }
$langs = @("ar","de","es","fil","fr","hi","id","it","ja","ko","nl","pt","ru","tr")

$LangMaps = @{}
foreach ($lang in $langs) {
    $lXml = [xml][System.IO.File]::ReadAllText("$ResxDir\SharedResource.$lang.resx", [System.Text.Encoding]::UTF8)
    $m = @{}; foreach ($d in $lXml.root.data) { $m[$d.name] = $d.value }
    $LangMaps[$lang] = $m
}

$results = @{}
foreach ($key in $ZhMap.Keys) {
    $zhVal = $ZhMap[$key]; $enVal = $EnMap[$key]
    if (-not $enVal -or $zhVal -eq $enVal) { continue }
    $missingLangs = @()
    foreach ($lang in $langs) {
        $lm = $LangMaps[$lang]
        if (-not $lm.ContainsKey($key) -or $lm[$key] -eq $enVal) {
            $missingLangs += $lang
        }
    }
    if ($missingLangs.Count -gt 0) {
        $results[$key] = $missingLangs
    }
}

Write-Host "Total keys needing translation in other langs: $($results.Count)"
$allMissing = $results.GetEnumerator() | Where-Object { $_.Value.Count -eq 14 } | Sort-Object Key
$partialMissing = $results.GetEnumerator() | Where-Object { $_.Value.Count -lt 14 } | Sort-Object Key
Write-Host "=== Missing in ALL 14 languages: $($allMissing.Count) keys ==="
$allMissing | ForEach-Object { Write-Host "  $($_.Key) | EN: $($EnMap[$_.Key])" }
Write-Host ""
Write-Host "=== Missing in SOME languages: $($partialMissing.Count) keys ==="
$partialMissing | ForEach-Object { Write-Host "  $($_.Key) [missing: $($_.Value -join ',')] | EN: $($EnMap[$_.Key])" }
