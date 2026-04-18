# Find Java from .NET Android SDK
$Paths = @(
    'C:\work\dotnet',
    'C:\Program Files\Microsoft',
    'C:\Program Files\Android',
    'C:\Program Files\Java',
    'C:\Program Files\Eclipse Adoptium',
    "$env:LOCALAPPDATA\Android",
    "$env:USERPROFILE\.android"
)

foreach ($P in $Paths) {
    if (Test-Path $P) {
        $Found = Get-ChildItem -Path $P -Filter 'java.exe' -Recurse -ErrorAction SilentlyContinue | Select-Object -First 3
        foreach ($F in $Found) {
            Write-Output "JAVA: $($F.FullName)"
        }
    }
}

# Check .NET Android SDK packs for Java
$Packs = Get-ChildItem 'C:\work\dotnet\sdk\artifacts\bin\redist\Release\dotnet\packs' -Directory -ErrorAction SilentlyContinue
foreach ($Pack in $Packs) {
    $J = Get-ChildItem -Path $Pack.FullName -Filter 'java.exe' -Recurse -ErrorAction SilentlyContinue | Select-Object -First 1
    if ($J) { Write-Output "PACK JAVA: $($J.FullName)" }
}

# Check for d8, aapt2 in Android SDK tools
foreach ($P in $Paths) {
    if (Test-Path $P) {
        $Tools = Get-ChildItem -Path $P -Filter 'd8*' -Recurse -ErrorAction SilentlyContinue | Select-Object -First 2
        foreach ($T in $Tools) {
            Write-Output "D8: $($T.FullName)"
        }
        $Aapt = Get-ChildItem -Path $P -Filter 'aapt2*' -Recurse -ErrorAction SilentlyContinue | Select-Object -First 2
        foreach ($A in $Aapt) {
            Write-Output "AAPT2: $($A.FullName)"
        }
    }
}
