param(
    [string]$Repository = "cruzlauroiii/prtask.com",
    [switch]$SkipVerify
)

$ErrorActionPreference = "Stop"
$MaxPages = 50
$PageSize = 100
$Deleted = 0

function Invoke-GhApi([string]$Arguments, [int]$TimeoutMs = 30000) {
    $Psi = New-Object System.Diagnostics.ProcessStartInfo
    $Psi.FileName = "gh"
    $Psi.Arguments = "api $Arguments"
    $Psi.WorkingDirectory = $PSScriptRoot
    $Psi.RedirectStandardOutput = $true
    $Psi.RedirectStandardError = $true
    $Psi.UseShellExecute = $false
    $Psi.CreateNoWindow = $true

    $Proc = [System.Diagnostics.Process]::Start($Psi)
    $StdOut = $Proc.StandardOutput.ReadToEndAsync()
    $StdErr = $Proc.StandardError.ReadToEndAsync()
    if (-not $Proc.WaitForExit($TimeoutMs)) {
        try { $Proc.Kill($true) } catch {}
        throw "gh api timed out after ${TimeoutMs}ms: $Arguments"
    }
    [pscustomobject]@{
        ExitCode = $Proc.ExitCode
        Output = $StdOut.GetAwaiter().GetResult()
        Error = $StdErr.GetAwaiter().GetResult()
    }
}

Write-Host "=== Delete-GitHubActionsRuns ==="
Write-Host "Repository: $Repository"

for ($Page = 1; $Page -le $MaxPages; $Page++) {
    $Result = Invoke-GhApi "`"repos/$Repository/actions/runs?per_page=$PageSize&page=$Page`" --jq `".workflow_runs[].id`""
    if ($Result.ExitCode -ne 0 -or [string]::IsNullOrWhiteSpace($Result.Output)) {
        break
    }

    $RunIds = $Result.Output.Trim().Split("`n", [System.StringSplitOptions]::RemoveEmptyEntries)
    if ($RunIds.Length -eq 0) {
        break
    }

    foreach ($RunId in $RunIds) {
        $Id = $RunId.Trim()
        if ([string]::IsNullOrWhiteSpace($Id)) {
            continue
        }
        $Delete = Invoke-GhApi "-X DELETE `"repos/$Repository/actions/runs/$Id`""
        if ($Delete.ExitCode -ne 0) {
            throw "Failed to delete workflow run ${Id}: $($Delete.Error)"
        }
        $Deleted++
    }
}

if (-not $SkipVerify) {
    $Verify = Invoke-GhApi "`"repos/$Repository/actions/runs`" --jq .total_count"
    if ($Verify.ExitCode -eq 0) {
        $Remaining = $Verify.Output.Trim()
        if ($Remaining -ne "0") {
            throw "Expected 0 workflow runs remaining, got $Remaining (deleted $Deleted)"
        }
    }
}

Write-Host "Deleted $Deleted workflow run(s)"
Write-Host "=== Delete-GitHubActionsRuns complete ==="
