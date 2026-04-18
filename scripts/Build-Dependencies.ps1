param(
    [switch]$DryRun,
    [switch]$SkipPull
)
$ErrorActionPreference = 'Stop'

function Write-Step($Message) {
    Write-Host "[$((Get-Date).ToString('HH:mm:ss'))] $Message" -ForegroundColor Cyan
}

function Write-Ok($Message) {
    Write-Host "[$((Get-Date).ToString('HH:mm:ss'))] $Message" -ForegroundColor Green
}

function Write-Err($Message) {
    Write-Host "[$((Get-Date).ToString('HH:mm:ss'))] $Message" -ForegroundColor Red
}

$PrTaskRoot = 'C:\work\prtask.com'
$Dependencies = @(
    @{ Name = 'PrTask.Automerge';  RepoDir = 'C:\work\automerge' },
    @{ Name = 'PrTask.Cdp';        RepoDir = 'C:\work\cdp' },
    @{ Name = 'PrTask.Git';        RepoDir = 'C:\work\git' },
    @{ Name = 'PrTask.GitNative';  RepoDir = 'C:\work\gitnative' },
    @{ Name = 'PrTask.Lighthouse'; RepoDir = 'C:\work\lighthouse' },
    @{ Name = 'PrTask.Llama';      RepoDir = 'C:\work\llama' },
    @{ Name = 'PrTask.LowDb';      RepoDir = 'C:\work\lowdb' },
    @{ Name = 'PrTask.Maui';       RepoDir = 'C:\work\maui' },
    @{ Name = 'PrTask.OpenClaw';   RepoDir = 'C:\work\openclaw' },
    @{ Name = 'PrTask.USearch';    RepoDir = 'C:\work\usearch' },
    @{ Name = 'PrTask.Whisper';    RepoDir = 'C:\work\whisper' }
)

$Results = @()
$Failed = @()

foreach ($Dep in $Dependencies) {
    $Name = $Dep.Name
    $Dir = $Dep.RepoDir

    Write-Step "Processing $Name at $Dir..."

    if (-not (Test-Path $Dir)) {
        Write-Err "$Name: directory not found at $Dir - skipping"
        $Failed += $Name
        continue
    }

    Push-Location $Dir
    try {
        if (-not $SkipPull) {
            Write-Step "$Name: pulling latest..."
            git pull --recurse-submodules 2>&1 | Out-Null
        }

        $CommitHash = git rev-parse --short HEAD
        $CommitFull = git rev-parse HEAD
        $Branch = git rev-parse --abbrev-ref HEAD
        Write-Step "$Name: branch=$Branch commit=$CommitHash"

        $CsProjFiles = Get-ChildItem -Path $Dir -Filter '*.csproj' -Recurse |
            Where-Object { $_.FullName -notlike '*\obj\*' -and $_.FullName -notlike '*\bin\*' }

        if ($CsProjFiles.Count -eq 0) {
            Write-Err "$Name: no .csproj files found"
            $Failed += $Name
            Pop-Location
            continue
        }

        foreach ($Proj in $CsProjFiles) {
            Write-Step "$Name: building $($Proj.Name)..."
            if (-not $DryRun) {
                $BuildResult = dotnet build $Proj.FullName -c Release 2>&1
                if ($LASTEXITCODE -ne 0) {
                    Write-Err "$Name: build failed for $($Proj.Name)"
                    Write-Err ($BuildResult | Out-String)
                    $Failed += "$Name/$($Proj.Name)"
                    continue
                }
            }
            Write-Ok "$Name: $($Proj.Name) built successfully"
        }

        $Results += [PSCustomObject]@{
            Name = $Name
            Branch = $Branch
            Commit = $CommitHash
            CommitFull = $CommitFull
            Path = $Dir
        }
    }
    catch {
        Write-Err "$Name: $_"
        $Failed += $Name
    }
    finally {
        Pop-Location
    }
}

Write-Step "`nBuild Summary:"
Write-Step "=============="
$Results | Format-Table -AutoSize

if ($Failed.Count -gt 0) {
    Write-Err "`nFailed: $($Failed -join ', ')"
    exit 1
}

Write-Ok "`nAll dependencies built successfully"

Write-Step "Verifying PrTask.com builds with updated dependencies..."
if (-not $DryRun) {
    Push-Location $PrTaskRoot
    try {
        dotnet build src/PrTask.Domain/PrTask.Domain.csproj -c Release 2>&1 | Out-Null
        if ($LASTEXITCODE -ne 0) {
            Write-Err "PrTask.Domain build failed after dependency update"
            exit 1
        }
        Write-Ok "PrTask.com builds successfully with updated dependencies"
    }
    finally {
        Pop-Location
    }
}
