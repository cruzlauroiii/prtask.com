param(
    [string]$PublishDir = "C:\work\prtask.com\publish\web\wwwroot"
)

# Find the actual blazor.webassembly filename and rename if fingerprinted
$BlazorFile = Get-ChildItem "$PublishDir\_framework" -Filter 'blazor.webassembly*.js' | Where-Object { $_.Name -ne 'blazor.webassembly.js' } | Select-Object -First 1
if ($BlazorFile) {
    $BlazorJs = $BlazorFile.Name
    Write-Output "Blazor JS filename: $BlazorJs (fingerprinted, will rename)"
    # Rename fingerprinted file to plain name
    Rename-Item -Path $BlazorFile.FullName -NewName 'blazor.webassembly.js' -Force
    # Also rename .br and .gz variants if they exist
    $BrFile = Join-Path $BlazorFile.DirectoryName "$BlazorJs.br"
    $GzFile = Join-Path $BlazorFile.DirectoryName "$BlazorJs.gz"
    if (Test-Path $BrFile) { Rename-Item -Path $BrFile -NewName 'blazor.webassembly.js.br' -Force }
    if (Test-Path $GzFile) { Rename-Item -Path $GzFile -NewName 'blazor.webassembly.js.gz' -Force }
    Write-Output "  Renamed to blazor.webassembly.js"
} else {
    $BlazorJs = 'blazor.webassembly.js'
    Write-Output "Blazor JS filename: $BlazorJs (already plain)"
}

# Process all HTML files
$HtmlFiles = Get-ChildItem $PublishDir -Filter '*.html' -Recurse
foreach ($F in $HtmlFiles) {
    $C = [System.IO.File]::ReadAllText($F.FullName)
    $Changed = $false

    # 1. Fix blazor.webassembly script reference (fingerprint placeholder or fingerprinted name)
    if ($C -match 'blazor\.webassembly#\[\.{fingerprint}\]\.js') {
        $C = $C -replace 'blazor\.webassembly#\[\.{fingerprint}\]\.js', 'blazor.webassembly.js'
        $Changed = $true
    }
    if ($BlazorJs -ne 'blazor.webassembly.js' -and $C.Contains($BlazorJs)) {
        $C = $C.Replace($BlazorJs, 'blazor.webassembly.js')
        $Changed = $true
    }
    # Remove importmap script tags (fingerprint mappings no longer needed)
    if ($C -match '<script type="importmap">') {
        $C = $C -replace '(?s)<script type="importmap">.*?</script>', ''
        $Changed = $true
    }

    # 2. Fix canonical URLs from localhost to prtask.com
    if ($C -match 'http://127\.0\.0\.1:5050') {
        $C = $C -replace 'http://127\.0\.0\.1:5050', 'https://prtask.com'
        $Changed = $true
    }

    # 3. Extract pre-rendered content and replace Loading...
    $PrerenderBegin = '<!-- %%-PRERENDERING-BEGIN-%% -->'
    $PrerenderEnd = '<!-- %%-PRERENDERING-END-%% -->'
    $BeginIdx = $C.IndexOf($PrerenderBegin)
    $EndIdx = $C.IndexOf($PrerenderEnd)
    if ($BeginIdx -ge 0 -and $EndIdx -gt $BeginIdx) {
        $PreBlock = $C.Substring($BeginIdx, $EndIdx + $PrerenderEnd.Length - $BeginIdx)

        # Extract content from the hidden div (skip the wrapper div with opacity:0)
        $HiddenDivStart = '<div style="opacity: 0; position: fixed; z-index: -1; top: 0; left: 0; bottom: 0; right: 0;">'
        $InnerStartIdx = $PreBlock.IndexOf($HiddenDivStart)
        if ($InnerStartIdx -ge 0) {
            $ContentStart = $InnerStartIdx + $HiddenDivStart.Length
            # Find the closing </div> before PRERENDERING-END
            $ContentEndMarker = $PrerenderEnd
            $ContentEndIdx = $PreBlock.LastIndexOf('</div>', $PreBlock.IndexOf($ContentEndMarker))
            if ($ContentEndIdx -gt $ContentStart) {
                $PrerenderedHtml = $PreBlock.Substring($ContentStart, $ContentEndIdx - $ContentStart).Trim()

                # Extract the <main class="page-content"> content from pre-rendered HTML
                $MainRegex = [regex]::new('<main class="page-content">([\s\S]*?)</main>')
                $MainMatch = $MainRegex.Match($PrerenderedHtml)
                if ($MainMatch.Success) {
                    $MainContent = $MainMatch.Groups[1].Value
                    # Replace the Loading... or empty main in the app div
                    if ($C.Contains('<main class="page-content"><p>Loading...</p></main>')) {
                        $C = $C.Replace('<main class="page-content"><p>Loading...</p></main>', '<main class="page-content">' + $MainContent + '</main>')
                        $Changed = $true
                        Write-Output "  Replaced Loading... with real content in $($F.Name)"
                    } elseif ($C.Contains('<main class="page-content"></main>')) {
                        $C = $C.Replace('<main class="page-content"></main>', '<main class="page-content">' + $MainContent + '</main>')
                        $Changed = $true
                        Write-Output "  Replaced empty main with real content in $($F.Name)"
                    }
                }

                # Extract footer from pre-rendered content
                $FooterRegex = [regex]::new('<footer class="site-footer">([\s\S]*?)</footer>')
                $FooterMatch = $FooterRegex.Match($PrerenderedHtml)
                if ($FooterMatch.Success) {
                    $NewFooter = '<footer class="site-footer">' + $FooterMatch.Groups[1].Value + '</footer>'
                    # Replace the minimal footer
                    $OldFooterRegex = [regex]::new('<footer class="site-footer"><div class="footer-bottom"><p>[^<]*</p></div></footer>')
                    $C = $OldFooterRegex.Replace($C, $NewFooter, 1)
                    $Changed = $true
                }
            }
        }

        # Remove the hidden pre-rendered block entirely
        $C = $C.Replace($PreBlock, '')
        $Changed = $true
    }

    # 4. Remove __internal_preventDefault_onclick attributes
    if ($C.Contains('__internal_preventDefault_onclick')) {
        $C = $C.Replace(' __internal_preventDefault_onclick', '')
        $Changed = $true
    }

    # 5. Clean up PRERENDERING-HEADOUTLET markers (keep content between them)
    if ($C.Contains('%%-PRERENDERING-HEADOUTLET-')) {
        $C = $C -replace '<!-- %%-PRERENDERING-HEADOUTLET-BEGIN-%% -->\s*', ''
        $C = $C -replace '\s*<!-- %%-PRERENDERING-HEADOUTLET-END-%% -->', ''
        $Changed = $true
    }

    # 6. Remove duplicate <title> tags - keep the prerendered one (second occurrence)
    $TitleRegex = [regex]::new('<title>[^<]*</title>')
    $TitleMatches = $TitleRegex.Matches($C)
    if ($TitleMatches.Count -gt 1) {
        # Remove the first (original) title, keep the pre-rendered one
        $C = $C.Remove($TitleMatches[0].Index, $TitleMatches[0].Length)
        $Changed = $true
    }

    # 7. Remove duplicate meta description tags
    $DescRegex = [regex]::new('<meta name="description" content="[^"]*"\s*/?>')
    $DescMatches = $DescRegex.Matches($C)
    if ($DescMatches.Count -gt 1) {
        $C = $C.Remove($DescMatches[0].Index, $DescMatches[0].Length)
        $Changed = $true
    }

    # 8. Remove Blazor scoped CSS attributes (b-xxxxxxxx)
    $C = $C -replace ' b-[a-z0-9]{10}', ''

    if ($Changed) {
        [System.IO.File]::WriteAllText($F.FullName, $C)
        Write-Output "Fixed: $($F.Name)"
    }
}
Write-Output "`nDone processing all HTML files"
