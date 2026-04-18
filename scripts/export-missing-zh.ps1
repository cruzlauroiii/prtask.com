[xml]$En = Get-Content 'C:\work\prtask.com\src\PrTask.SharedUI\Resources\SharedResource.resx' -Encoding UTF8
[xml]$Zh = Get-Content 'C:\work\prtask.com\src\PrTask.SharedUI\Resources\SharedResource.zh.resx' -Encoding UTF8
$ZhKeys = @{}
foreach ($d in $Zh.root.data) { $ZhKeys[$d.name] = $true }
$Lines = [System.Collections.Generic.List[string]]::new()
foreach ($d in ($En.root.data | Sort-Object { $_.name })) {
    if (-not $ZhKeys.ContainsKey($d.name)) {
        $Lines.Add("$($d.name)|$($d.value)")
    }
}
$Utf8 = [System.Text.UTF8Encoding]::new($false)
[System.IO.File]::WriteAllLines('C:\work\prtask.com\missing-zh-keys.txt', $Lines, $Utf8)
Write-Host "Exported $($Lines.Count) missing keys"
