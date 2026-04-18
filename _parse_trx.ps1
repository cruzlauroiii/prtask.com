[xml]$trx = Get-Content "C:\work\prtask.com\tests\PrTask.E2E\TestResults\results.trx"
$ns = @{ t = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010" }

$results = Select-Xml -Xml $trx -XPath "//t:UnitTestResult" -Namespace $ns | Select-Object -ExpandProperty Node

$failed = $results | Where-Object { $_.outcome -eq "Failed" }

Write-Host "=== FAILED TESTS ($($failed.Count)) ==="
foreach ($f in $failed) {
    Write-Host ""
    Write-Host "TEST: $($f.testName)"
    if ($f.Output -and $f.Output.ErrorInfo) {
        $msg = $f.Output.ErrorInfo.Message
        if ($msg.Length -gt 300) { $msg = $msg.Substring(0, 300) + "..." }
        Write-Host "  ERROR: $msg"
    }
}

$counters = Select-Xml -Xml $trx -XPath "//t:ResultSummary/t:Counters" -Namespace $ns | Select-Object -ExpandProperty Node
Write-Host ""
Write-Host "=== SUMMARY ==="
Write-Host "Total:   $($counters.total)"
Write-Host "Passed:  $($counters.passed)"
Write-Host "Failed:  $($counters.failed)"
Write-Host "Skipped: $($counters.notExecuted)"
