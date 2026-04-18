function ConvertTo-Resx {
    param(
        [hashtable]$Data,
        [string]$OutputPath
    )
    $Sb = [System.Text.StringBuilder]::new()
    [void]$Sb.AppendLine('<?xml version="1.0" encoding="utf-8"?>')
    [void]$Sb.AppendLine('<root>')
    [void]$Sb.AppendLine('  <xsd:schema id="root" xmlns="" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:msdata="urn:schemas-microsoft-com:xml-msdata">')
    [void]$Sb.AppendLine('    <xsd:element name="root" msdata:IsDataSet="true">')
    [void]$Sb.AppendLine('      <xsd:complexType>')
    [void]$Sb.AppendLine('        <xsd:choice maxOccurs="unbounded">')
    [void]$Sb.AppendLine('          <xsd:element name="data">')
    [void]$Sb.AppendLine('            <xsd:complexType>')
    [void]$Sb.AppendLine('              <xsd:sequence>')
    [void]$Sb.AppendLine('                <xsd:element name="value" type="xsd:string" minOccurs="0" msdata:Ordinal="1" />')
    [void]$Sb.AppendLine('              </xsd:sequence>')
    [void]$Sb.AppendLine('              <xsd:attribute name="name" type="xsd:string" use="required" />')
    [void]$Sb.AppendLine('              <xsd:attribute name="type" type="xsd:string" />')
    [void]$Sb.AppendLine('              <xsd:attribute name="xml:space" type="xsd:string" />')
    [void]$Sb.AppendLine('            </xsd:complexType>')
    [void]$Sb.AppendLine('          </xsd:element>')
    [void]$Sb.AppendLine('        </xsd:choice>')
    [void]$Sb.AppendLine('      </xsd:complexType>')
    [void]$Sb.AppendLine('    </xsd:element>')
    [void]$Sb.AppendLine('  </xsd:schema>')
    [void]$Sb.AppendLine('  <resheader name="resmimetype"><value>text/microsoft-resx</value></resheader>')
    [void]$Sb.AppendLine('  <resheader name="version"><value>2.0</value></resheader>')
    [void]$Sb.AppendLine('  <resheader name="reader"><value>System.Resources.ResXResourceReader</value></resheader>')
    [void]$Sb.AppendLine('  <resheader name="writer"><value>System.Resources.ResXResourceWriter</value></resheader>')
    foreach ($Key in ($Data.Keys | Sort-Object)) {
        $Val = [System.Security.SecurityElement]::Escape($Data[$Key])
        [void]$Sb.AppendLine("  <data name=`"$Key`" xml:space=`"preserve`"><value>$Val</value></data>")
    }
    [void]$Sb.AppendLine('</root>')
    [System.IO.File]::WriteAllText($OutputPath, $Sb.ToString(), [System.Text.Encoding]::UTF8)
}

$ResDir = 'C:\work\prtask.com\src\PrTask.SharedUI\Resources'

# Read English JSON
$EnJson = Get-Content 'C:\work\prtask.com\src\PrTask.SharedUI\I18nText\Locales.en.json' -Raw | ConvertFrom-Json
$EnData = @{}
$EnJson.PSObject.Properties | ForEach-Object { $EnData[$_.Name] = $_.Value }

# Update language keys: remove Filipino, add Chinese/German/Hindi
$EnData.Remove('LanguageFilipino')
$EnData['LanguageChinese'] = 'Chinese'
$EnData['LanguageGerman'] = 'German'
$EnData['LanguageHindi'] = 'Hindi'

# Write English default .resx
ConvertTo-Resx -Data $EnData -OutputPath (Join-Path $ResDir 'SharedResource.resx')
Write-Host 'Created SharedResource.resx (English default)'

# Read Japanese JSON
$JaJson = Get-Content 'C:\work\prtask.com\src\PrTask.SharedUI\I18nText\Locales.ja.json' -Raw | ConvertFrom-Json
$JaData = @{}
$JaJson.PSObject.Properties | ForEach-Object { $JaData[$_.Name] = $_.Value }
$JaData.Remove('LanguageFilipino')
$JaData['LanguageChinese'] = "`u{4E2D}`u{56FD}`u{8A9E}"
$JaData['LanguageGerman'] = "`u{30C9}`u{30A4}`u{30C4}`u{8A9E}"
$JaData['LanguageHindi'] = "`u{30D2}`u{30F3}`u{30C7}`u{30A3}`u{30FC}`u{8A9E}"

ConvertTo-Resx -Data $JaData -OutputPath (Join-Path $ResDir 'SharedResource.ja.resx')
Write-Host 'Created SharedResource.ja.resx (Japanese)'

# Chinese placeholder (use English values with Chinese language names)
$ZhData = @{}
$EnData.Keys | ForEach-Object { $ZhData[$_] = $EnData[$_] }
$ZhData['LanguageEnglish'] = "`u{82F1}`u{8BED}"
$ZhData['LanguageChinese'] = "`u{4E2D}`u{6587}"
$ZhData['LanguageJapanese'] = "`u{65E5}`u{8BED}"
$ZhData['LanguageGerman'] = "`u{5FB7}`u{8BED}"
$ZhData['LanguageHindi'] = "`u{5370}`u{5730}`u{8BED}"
$ZhData['LanguageSelectorLabel'] = "`u{8BED}`u{8A00}"
ConvertTo-Resx -Data $ZhData -OutputPath (Join-Path $ResDir 'SharedResource.zh.resx')
Write-Host 'Created SharedResource.zh.resx (Chinese placeholder)'

# German placeholder
$DeData = @{}
$EnData.Keys | ForEach-Object { $DeData[$_] = $EnData[$_] }
$DeData['LanguageEnglish'] = 'Englisch'
$DeData['LanguageChinese'] = 'Chinesisch'
$DeData['LanguageJapanese'] = 'Japanisch'
$DeData['LanguageGerman'] = 'Deutsch'
$DeData['LanguageHindi'] = 'Hindi'
$DeData['LanguageSelectorLabel'] = 'Sprache'
ConvertTo-Resx -Data $DeData -OutputPath (Join-Path $ResDir 'SharedResource.de.resx')
Write-Host 'Created SharedResource.de.resx (German placeholder)'

# Hindi placeholder
$HiData = @{}
$EnData.Keys | ForEach-Object { $HiData[$_] = $EnData[$_] }
$HiData['LanguageEnglish'] = "`u{0905}`u{0902}`u{0917}`u{094D}`u{0930}`u{0947}`u{091C}`u{093C}`u{0940}"
$HiData['LanguageChinese'] = "`u{091A}`u{0940}`u{0928}`u{0940}"
$HiData['LanguageJapanese'] = "`u{091C}`u{093E}`u{092A}`u{093E}`u{0928}`u{0940}"
$HiData['LanguageGerman'] = "`u{091C}`u{0930}`u{094D}`u{092E}`u{0928}"
$HiData['LanguageHindi'] = "`u{0939}`u{093F}`u{0928}`u{094D}`u{0926}`u{0940}"
$HiData['LanguageSelectorLabel'] = "`u{092D}`u{093E}`u{0937}`u{093E}"
ConvertTo-Resx -Data $HiData -OutputPath (Join-Path $ResDir 'SharedResource.hi.resx')
Write-Host 'Created SharedResource.hi.resx (Hindi placeholder)'

Write-Host 'All .resx files generated successfully'
