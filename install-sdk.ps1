[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12
$ProgressPreference = 'SilentlyContinue'

Write-Host "=== Current SDK ==="
dotnet --version

Write-Host "`n=== Installed SDKs ==="
dotnet --list-sdks

Write-Host "`n=== Installed Runtimes ==="
dotnet --list-runtimes

Write-Host "`n=== .NET 10 Releases JSON ==="
try {
    $releasesJson = Invoke-RestMethod 'https://dotnetcli.azureedge.net/dotnet/release-metadata/10.0/releases.json' -ErrorAction Stop
    $latest = $releasesJson.releases[0]
    Write-Host "Latest release: $($latest.'release-version')"
    Write-Host "Release date: $($latest.'release-date')"
    Write-Host "SDK version: $($latest.sdk.version)"
    Write-Host "Runtime version: $($latest.runtime.version)"
    if ($latest.'cve-list') {
        Write-Host "`nCVEs in latest release:"
        foreach ($cve in $latest.'cve-list') {
            Write-Host "  $($cve.'cve-id') - $($cve.'cve-url')"
        }
    }

    # Show a few recent releases
    Write-Host "`nRecent releases:"
    foreach ($rel in $releasesJson.releases | Select-Object -First 5) {
        Write-Host "  $($rel.'release-version') (SDK: $($rel.sdk.version)) - $($rel.'release-date')"
    }
} catch {
    Write-Host "Error: $_"
}
