$ResxDir = "C:\work\prtask.com\src\PrTask.SharedUI\Resources"
$EnXml  = [xml][System.IO.File]::ReadAllText("$ResxDir\SharedResource.resx", [System.Text.Encoding]::UTF8)
$ZhXml  = [xml][System.IO.File]::ReadAllText("$ResxDir\SharedResource.zh.resx", [System.Text.Encoding]::UTF8)
$EnMap = @{}; foreach ($d in $EnXml.root.data) { $EnMap[$d.name] = $d.value }
$ZhMap = @{}; foreach ($d in $ZhXml.root.data) { $ZhMap[$d.name] = $d.value }
$langs = @("ar","de","es","fil","fr","hi","id","it","ja","ko","nl","pt","ru","tr")

foreach ($lang in $langs) {
    $lXml = [xml][System.IO.File]::ReadAllText("$ResxDir\SharedResource.$lang.resx", [System.Text.Encoding]::UTF8)
    $lMap = @{}; foreach ($d in $lXml.root.data) { $lMap[$d.name] = $d.value }
    $count = 0
    foreach ($key in $ZhMap.Keys) {
        $zhVal = $ZhMap[$key]; $enVal = $EnMap[$key]
        if (-not $enVal -or $zhVal -eq $enVal) { continue }
        if (-not $lMap.ContainsKey($key) -or $lMap[$key] -eq $enVal) { $count++ }
    }
    Write-Host "$lang`: $count missing"
}
