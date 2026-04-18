$ResxDir = "C:\work\prtask.com\src\PrTask.SharedUI\Resources"
$EnResx = [xml](Get-Content "$ResxDir\SharedResource.resx")
$MissingKeys = @(
    "AboutBadgesDescription","AboutBadgesHeading",
    "AboutCommunityDescription","AboutCommunityHeading",
    "AboutGetStartedDescription",
    "AboutLegalAcceptableUse","AboutLegalAccessibility","AboutLegalCookiePolicy","AboutLegalDmca",
    "AboutLegalHeading","AboutLegalLicenses","AboutLegalPrivacy","AboutLegalRefund","AboutLegalTerms",
    "AboutOpenSourceDescription","AboutOpenSourceHeading",
    "AboutPaymentsDescription","AboutPaymentsHeading",
    "AboutStatActiveDevelopers","AboutStatActiveDevelopersLabel",
    "AboutStatCountries","AboutStatCountriesLabel",
    "AboutStatPaidToDevelopers","AboutStatPaidToDevelopersLabel",
    "AboutStatTasksCompleted","AboutStatTasksCompletedLabel",
    "AboutStoryDescription","AboutStoryHeading",
    "AboutValueFairnessDescription","AboutValueFairnessHeading",
    "AboutValueOpenSourceDescription","AboutValueOpenSourceHeading",
    "AboutValueTransparencyDescription","AboutValueTransparencyHeading"
)

$DefaultTranslation = @{}
foreach ($Key in $MissingKeys) {
    $EnNode = $EnResx.root.data | Where-Object { $_.name -eq $Key }
    if ($EnNode) { $DefaultTranslation[$Key] = $EnNode.value }
}

$Locales = @("ar","de","es","fil","fr","hi","id","it","ja","ko","nl","pt","ru","tr","zh")
foreach ($Locale in $Locales) {
    $FilePath = "$ResxDir\SharedResource.$Locale.resx"
    $Xml = [xml](Get-Content $FilePath)
    $ExistingKeys = @($Xml.root.data | ForEach-Object { $_.name })
    $Added = 0
    foreach ($Key in $MissingKeys) {
        if ($Key -notin $ExistingKeys) {
            $NewNode = $Xml.CreateElement("data")
            $NewNode.SetAttribute("name", $Key)
            $NewNode.SetAttribute("xml:space", "preserve")
            $ValueNode = $Xml.CreateElement("value")
            if ($DefaultTranslation.ContainsKey($Key)) {
                $ValueNode.InnerText = $DefaultTranslation[$Key]
            }
            [void]$NewNode.AppendChild($ValueNode)
            [void]$Xml.root.AppendChild($NewNode)
            $Added++
        }
    }
    $Settings = New-Object System.Xml.XmlWriterSettings
    $Settings.Indent = $true
    $Settings.IndentChars = "  "
    $Settings.Encoding = New-Object System.Text.UTF8Encoding($false)
    $Writer = [System.Xml.XmlWriter]::Create($FilePath, $Settings)
    $Xml.Save($Writer)
    $Writer.Close()
    Write-Output "$Locale : added $Added keys"
}
