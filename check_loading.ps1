foreach ($P in @('Tasks','Login','Pricing','About','Leaderboard')) {
    $F = Join-Path 'C:\work\prtask.com\publish\web\wwwroot' ($P + '.html')
    if (Test-Path $F) {
        $C = Get-Content $F -Raw
        $HasLoading = $C -match '<p>Loading'
        $H1 = [regex]::Match($C, '<h1[^>]*>([^<]+)</h1>').Groups[1].Value
        Write-Output ('{0}: Loading={1}, h1={2}' -f $P, $HasLoading, $H1)
    } else {
        Write-Output ('{0}: NOT FOUND' -f $P)
    }
}
