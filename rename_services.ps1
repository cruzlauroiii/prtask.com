$BasePath = "C:\work\prtask.com\src\PrTask.Client\Services"
$Pairs = @{
    "LocalTaskService.cs" = "WssTaskService.cs"
    "LocalPullRequestService.cs" = "WssPullRequestService.cs"
    "LocalPaymentRecordService.cs" = "WssPaymentRecordService.cs"
    "LocalReviewCommentService.cs" = "WssReviewCommentService.cs"
    "LocalKycVerificationService.cs" = "WssKycVerificationService.cs"
    "LocalSourceCodeService.cs" = "WssSourceCodeService.cs"
    "LocalInferenceService.cs" = "WssInferenceService.cs"
    "LocalVectorSearchService.cs" = "WssVectorSearchService.cs"
    "LocalCloudflareD1Service.cs" = "WssCloudflareD1Service.cs"
    "LocalBoardService.cs" = "WssBoardService.cs"
    "LocalSprintService.cs" = "WssSprintService.cs"
    "LocalRepositoryService.cs" = "WssRepositoryService.cs"
    "LocalLeaderboardService.cs" = "WssLeaderboardService.cs"
    "LocalSubscriptionService.cs" = "WssSubscriptionService.cs"
    "LocalInvoiceService.cs" = "WssInvoiceService.cs"
    "LocalSnapshotService.cs" = "WssSnapshotService.cs"
}
foreach ($key in $Pairs.Keys) {
    $from = Join-Path $BasePath $key
    $to = Join-Path $BasePath $Pairs[$key]
    if (Test-Path $from) {
        Move-Item -Path $from -Destination $to -Force
        Write-Host "Renamed $key -> $($Pairs[$key])"
    } else {
        Write-Host "SKIP $key (not found)"
    }
}
