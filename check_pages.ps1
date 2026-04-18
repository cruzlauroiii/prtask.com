foreach ($Page in @('index','Tasks','Login','Dashboard','Pricing','About','HowItWorks','Leaderboard')) {
    $File = "C:\work\prtask.com\publish\web\wwwroot\$Page.html"
    if (Test-Path $File) {
        $Content = Get-Content $File -Raw
        $HeroMatch = [regex]::Match($Content, 'class="hero"')
        $H1Matches = [regex]::Matches($Content, '<h1[^>]*>([^<]+)</h1>')
        $H1Values = ($H1Matches | ForEach-Object { $_.Groups[1].Value }) -join ' | '
        Write-Output "$Page`: hero=$($HeroMatch.Success), h1=[$H1Values]"
    } else {
        Write-Output "$Page`: NOT FOUND"
    }
}
