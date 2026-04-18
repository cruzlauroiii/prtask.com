$files = Get-ChildItem "C:\work\prtask.com\tests\PrTask.E2E\RulesTests.Task*.cs" | Sort-Object Name
$total = 0
foreach ($f in $files) {
    $count = (Select-String -Path $f.FullName -Pattern '\[TestMethod').Count
    $total += $count
    Write-Output ("{0}: {1} tests" -f $f.Name, $count)
}
Write-Output ""
Write-Output "Total files: $($files.Count)"
Write-Output "Total test methods: $total"
