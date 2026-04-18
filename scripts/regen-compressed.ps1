param()

$wwwroot = 'C:\work\prtask.com\publish\web\wwwroot'

# Files we modified that need fresh .br and .gz
$modifiedFiles = @(
    "$wwwroot\index.html",
    "$wwwroot\service-worker.published.js",
    "$wwwroot\PrTask.Client.styles.css",
    "$wwwroot\_content\PrTask.SharedUI\css\app.min.css",
    "$wwwroot\_content\PrTask.SharedUI\PrTask.SharedUI.58anj8sw7j.bundle.scp.css"
)

foreach ($f in $modifiedFiles) {
    if (Test-Path $f) {
        $size = (Get-Item $f).Length
        Write-Host "Processing: $(Split-Path $f -Leaf) ($size bytes)"

        # Remove stale compressed files
        $brFile = "$f.br"
        $gzFile = "$f.gz"
        if (Test-Path $brFile) { Remove-Item $brFile -Force }
        if (Test-Path $gzFile) { Remove-Item $gzFile -Force }

        # Regenerate .gz
        $bytes = [System.IO.File]::ReadAllBytes($f)
        $gzStream = [System.IO.File]::Create($gzFile)
        $compressor = New-Object System.IO.Compression.GZipStream($gzStream, [System.IO.Compression.CompressionLevel]::Optimal)
        $compressor.Write($bytes, 0, $bytes.Length)
        $compressor.Close()
        $gzStream.Close()
        $gzSize = (Get-Item $gzFile).Length
        Write-Host "  .gz: $gzSize bytes"

        # Regenerate .br using brotli via .NET
        $brStream = [System.IO.File]::Create($brFile)
        $brCompressor = New-Object System.IO.Compression.BrotliStream($brStream, [System.IO.Compression.CompressionLevel]::Optimal)
        $brCompressor.Write($bytes, 0, $bytes.Length)
        $brCompressor.Close()
        $brStream.Close()
        $brSize = (Get-Item $brFile).Length
        Write-Host "  .br: $brSize bytes"
    }
}

Write-Host "`nDone regenerating compressed files."
