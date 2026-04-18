foreach ($Page in @('index','Tasks','Login','Dashboard','Pricing','About','HowItWorks','Leaderboard')) {
    $File = Join-Path 'C:\work\prtask.com\publish\web\wwwroot' ($Page + '.html')
    if (Test-Path $File) {
        $Content = Get-Content $File -Raw
        $H1 = [regex]::Match($Content, '<h1[^>]*>([^<]+)</h1>')
        $Titles = [regex]::Matches($Content, '<title>([^<]+)</title>')
        $LastTitle = if ($Titles.Count -gt 0) { $Titles[$Titles.Count-1].Groups[1].Value } else { 'N/A' }
        Write-Output ('{0}: title={1}, h1={2}' -f $Page, $LastTitle, $H1.Groups[1].Value)
    }
}
