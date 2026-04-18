$files = Get-ChildItem "C:\work\prtask.com\tests\PrTask.E2E\RulesTests.Task*.cs" | Sort-Object Name

# Parse covered rule numbers from filenames
$covered = New-Object System.Collections.Generic.HashSet[int]

foreach ($f in $files) {
    $name = $f.BaseName  # e.g. RulesTests.Task01to08
    if ($name -match 'Task(\d+)to(\d+)$') {
        $start = [int]$Matches[1]
        $end = [int]$Matches[2]
        for ($i = $start; $i -le $end; $i++) {
            [void]$covered.Add($i)
        }
    }
    elseif ($name -match 'Task(\d+)$') {
        [void]$covered.Add([int]$Matches[1])
    }
    elseif ($name -match 'TaskWorkflow') {
        # skip workflow files
    }
    else {
        Write-Output "UNRECOGNIZED: $name"
    }
}

# Find gaps in 1-620
$gaps = @()
$gapStart = -1
for ($i = 1; $i -le 620; $i++) {
    if (-not $covered.Contains($i)) {
        if ($gapStart -eq -1) { $gapStart = $i }
    } else {
        if ($gapStart -ne -1) {
            if ($gapStart -eq ($i - 1)) {
                $gaps += "$gapStart"
            } else {
                $gaps += "$gapStart-$($i-1)"
            }
            $gapStart = -1
        }
    }
}
if ($gapStart -ne -1) {
    if ($gapStart -eq 620) {
        $gaps += "620"
    } else {
        $gaps += "$gapStart-620"
    }
}

Write-Output "Covered rule count: $($covered.Count)"
Write-Output "Missing rule numbers (gaps in 1-620):"
foreach ($g in $gaps) {
    Write-Output "  $g"
}
Write-Output ""
Write-Output "Total gap ranges: $($gaps.Count)"
