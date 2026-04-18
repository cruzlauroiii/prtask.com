$EnPath = "C:\work\prtask.com\src\PrTask.SharedUI\Resources\SharedResource.resx"
$ZhPath = "C:\work\prtask.com\src\PrTask.SharedUI\Resources\SharedResource.zh.resx"

[xml]$En = Get-Content $EnPath -Encoding UTF8
[xml]$Zh = Get-Content $ZhPath -Encoding UTF8

$EnMap = @{}
foreach ($d in $En.root.data) { $EnMap[$d.name] = $d.value }

$ZhMap = @{}
foreach ($d in $Zh.root.data) { $ZhMap[$d.name] = $d.value }

function Invoke-GoogleTranslate([string]$Text) {
    $Encoded = [System.Uri]::EscapeDataString($Text)
    $Uri = "https://translate.googleapis.com/translate_a/single?client=gtx&sl=en&tl=zh-CN&dt=t&q=$Encoded"
    try {
        $Response = Invoke-RestMethod -Uri $Uri -Method Get -ErrorAction Stop
        $Translated = ($Response[0] | ForEach-Object { $_[0] }) -join ''
        return $Translated
    } catch {
        Write-Host "  WARN: translation failed for '$Text': $($_.Exception.Message)"
        return $Text
    }
}

$Untranslated = [System.Collections.Generic.List[string]]::new()
foreach ($Key in $EnMap.Keys) {
    $EnVal = $EnMap[$Key]
    if (-not $ZhMap.ContainsKey($Key) -or $ZhMap[$Key] -eq $EnVal) {
        $Untranslated.Add($Key)
    }
}

if ($Untranslated.Count -eq 0) {
    Write-Host "Auto-Translate-ZhResx: all keys already translated"
    return
}

Write-Host "Auto-Translate-ZhResx: translating $($Untranslated.Count) key(s)..."

$Changed = 0
foreach ($d in $Zh.root.data) {
    if ($Untranslated.Contains($d.name)) {
        $EnVal = $EnMap[$d.name]
        Write-Host "  [$($d.name)] $EnVal"
        $Translated = Invoke-GoogleTranslate $EnVal
        Write-Host "    => $Translated"
        $d.value = $Translated
        $Untranslated.Remove($d.name) | Out-Null
        $Changed++
    }
}

foreach ($Key in $Untranslated) {
    $EnVal = $EnMap[$Key]
    Write-Host "  [$Key] $EnVal"
    $Translated = Invoke-GoogleTranslate $EnVal
    Write-Host "    => $Translated"
    $DataNode = $Zh.CreateElement('data')
    $DataNode.SetAttribute('name', $Key)
    $DataNode.SetAttribute('xml:space', 'preserve')
    $ValNode = $Zh.CreateElement('value')
    $ValNode.InnerText = $Translated
    $DataNode.AppendChild($ValNode) | Out-Null
    $Zh.root.AppendChild($DataNode) | Out-Null
    $Changed++
}

$Settings = [System.Xml.XmlWriterSettings]::new()
$Settings.Encoding = [System.Text.UTF8Encoding]::new($false)
$Settings.Indent = $true
$Settings.IndentChars = '  '
$Writer = [System.Xml.XmlWriter]::Create($ZhPath, $Settings)
$Zh.Save($Writer)
$Writer.Flush()
$Writer.Dispose()
Write-Host "Auto-Translate-ZhResx: $Changed key(s) translated and saved"
