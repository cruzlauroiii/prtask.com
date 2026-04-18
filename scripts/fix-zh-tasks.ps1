$Path = "C:\work\prtask.com\src\PrTask.SharedUI\Resources\SharedResource.zh.resx"
[xml]$Resx = Get-Content $Path -Encoding UTF8

foreach ($d in $Resx.root.data) {
    if ($d.name -eq 'TaskListDescriptionParagraph1') {
        $d.value = $d.value -replace 'PrTask', '拉取请求任务'
    }
    if ($d.name -eq 'TaskListDescriptionParagraph3') {
        $d.value = ($d.value -replace 'PrTask', '拉取请求任务') -replace 'pull request', '拉取请求'
    }
}

$Settings = [System.Xml.XmlWriterSettings]::new()
$Settings.Encoding = [System.Text.UTF8Encoding]::new($false)
$Settings.Indent = $true
$Settings.IndentChars = '  '
$Writer = [System.Xml.XmlWriter]::Create($Path, $Settings)
$Resx.Save($Writer)
$Writer.Flush()
$Writer.Dispose()
Write-Host 'Done'
